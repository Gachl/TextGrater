using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGrater
{
    [Serializable]
    public struct RegexTemplate
    {
        public string Name;
        public RegexOptions Options;
        public String[] Search;
        public String[] Replace;

        public override string ToString()
        {
            return this.Name;
        }
    }

    public partial class TextGrater : Form
    {
        private DateTime lastChange = DateTime.Now;
        List<RegularExpressionEditor> regexEditors = new List<RegularExpressionEditor>();
        public BindingList<RegexTemplate> regexTemplates = new BindingList<RegexTemplate>();

        public TextGrater()
        {
            InitializeComponent();

            FileStream templates = File.OpenRead("./templates.bin");
            this.regexTemplates = new BindingList<RegexTemplate>(new BinaryFormatter().Deserialize(templates) as List<RegexTemplate>);
            templates.Close();

            lbTemplates.DataSource = this.regexTemplates;

            for (int i = 0; i < 3; i++)
                this.createEditor();

            scContext.BeginUndoAction();
        }

        private RegularExpressionEditor createEditor()
        {
            int i = this.regexEditors.Count;
            RegularExpressionEditor rexedit = new RegularExpressionEditor();
            rexedit.Location = new Point(3, 3 + i * 28);
            rexedit.Size = new Size(splitContainer3.Panel1.ClientSize.Width - 31, 22);
            rexedit.Index = i + 1;
            splitContainer3.Panel1.Controls.Add(rexedit);
            regexEditors.Add(rexedit);
            return rexedit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.scContext.EndUndoAction();
            this.scContext.BeginUndoAction();
            RegexOptions options = this.regexOptions();

            string text = scContext.Text.Replace("\r", "");
            foreach (RegularExpressionEditor rexedit in this.regexEditors.OrderBy(x => x.Index))
                if (rexedit.UserEnabled)
                {
                    try
                    {
                        text = new Regex(rexedit.Expression, options).Replace(text, Regex.Unescape(rexedit.Replacement));
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            scContext.Text = text.Replace("\n", Environment.NewLine);

            this.scContext.EndUndoAction();
        }

        private RegexOptions regexOptions()
        {
            RegexOptions options = RegexOptions.None;
            if (cbRxOCultureInvariant.Checked)
                options |= RegexOptions.CultureInvariant;
            if (cbRxOECMAScript.Checked)
                options |= RegexOptions.ECMAScript;
            if (cbRxOExplicitCapture.Checked)
                options |= RegexOptions.ExplicitCapture;
            if (cbRxOIgnoreCase.Checked)
                options |= RegexOptions.IgnoreCase;
            if (cbRxOIgnorePatternWhitespace.Checked)
                options |= RegexOptions.IgnorePatternWhitespace;
            if (cbRxORightToLeft.Checked)
                options |= RegexOptions.RightToLeft;
            if (rbRxOLSingleline.Checked)
                options |= RegexOptions.Singleline;
            else
                options |= RegexOptions.Multiline;

            return options;
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            if (scContext.Text.EndsWith(Environment.NewLine)
                || (DateTime.Now - this.lastChange).TotalSeconds > 3)
            {
                scContext.EndUndoAction();
                scContext.BeginUndoAction();
            }
            this.lastChange = DateTime.Now;
        }

        private void btnAddRegexEditor_Click(object sender, EventArgs e)
        {
            this.createEditor();
        }

        private void btnRemoveRegexEditor_Click(object sender, EventArgs e)
        {
            this.removeEditor();
        }

        private void removeEditor()
        {
            RegularExpressionEditor toRemove = this.regexEditors.OrderBy(x => x.Index).Last();
            this.splitContainer3.Panel1.Controls.Remove(toRemove);
            this.regexEditors.Remove(toRemove);
            toRemove.Dispose();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            SaveAs save = new SaveAs();
            if (save.ShowDialog() == DialogResult.Cancel || String.IsNullOrEmpty(save.TemplateName.Trim()))
                return;
            string templateName = save.TemplateName.Trim();
            RegexTemplate dupe = this.regexTemplates.Where(t => t.Name.ToLower().Trim() == templateName.ToLower()).FirstOrDefault();
            if (!String.IsNullOrEmpty(dupe.Name))
            {
                if (MessageBox.Show($"A template with the name \"{save.TemplateName}\" already exists.{Environment.NewLine}Do you really want to override the existing template?", "Overwrite template", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                this.regexTemplates.Remove(dupe);
            }

            List<RegularExpressionEditor> toSave = this.regexEditors.OrderBy(x => x.Index).Where(x => x.UserEnabled).ToList();
            this.regexTemplates.Add(new RegexTemplate()
            {
                Name = templateName,
                Options = this.regexOptions(),
                Search = toSave.Select(x => x.Expression).ToArray(),
                Replace = toSave.Select(x => x.Replacement).ToArray()
            });

            this.serializeTemplates();
        }

        private void serializeTemplates()
        {
            // Keep one backup
            if (File.Exists("./templates.bin.1"))
                File.Delete("./templates.bin.1");
            if (File.Exists("./templates.bin"))
                File.Move("./templates.bin", "./templates.bin.1");
            FileStream templateFileStream = File.OpenWrite("./templates.bin");
            new BinaryFormatter().Serialize(templateFileStream, this.regexTemplates.ToList());
            templateFileStream.Close();
        }

        private void lbTemplates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTemplates.SelectedItem == null)
                return;

            RegexTemplate template = (RegexTemplate)lbTemplates.SelectedItem;
            while (template.Search.Length - this.regexEditors.Count > 0)
                this.createEditor();
            while (this.regexEditors.Count > template.Search.Length)
                this.removeEditor();

            RegularExpressionEditor[] orderedEditors = this.regexEditors.OrderBy(x => x.Index).ToArray();
            for (int i = 0; i < template.Search.Length; i++)
            {
                orderedEditors[i].Expression = template.Search[i];
                orderedEditors[i].Replacement = template.Replace[i];
                orderedEditors[i].UserEnabled = true;
            }

            cbRxOCultureInvariant.Checked = ((template.Options & RegexOptions.CultureInvariant) != 0);
            cbRxOECMAScript.Checked = ((template.Options & RegexOptions.ECMAScript) != 0);
            cbRxOExplicitCapture.Checked = ((template.Options & RegexOptions.ExplicitCapture) != 0);
            cbRxOIgnoreCase.Checked = ((template.Options & RegexOptions.IgnoreCase) != 0);
            cbRxOIgnorePatternWhitespace.Checked = ((template.Options & RegexOptions.IgnorePatternWhitespace) != 0);
            cbRxORightToLeft.Checked = ((template.Options & RegexOptions.RightToLeft) != 0);
            if ((template.Options & RegexOptions.Singleline) != 0)
                rbRxOLSingleline.Checked = true;
            else
                rbRxOLMultiline.Checked = true;
        }

        private void btnRemoveTemplate_Click(object sender, EventArgs e)
        {
            if (lbTemplates.SelectedItem == null)
                return;

            this.regexTemplates.Remove((RegexTemplate)this.lbTemplates.SelectedItem);
            this.serializeTemplates();
        }

        private void TextGrater_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                new About().ShowDialog();
        }
    }
}
