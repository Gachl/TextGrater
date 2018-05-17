namespace TextGrater
{
    partial class TextGrater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextGrater));
            this.scContext = new ScintillaNET.Scintilla();
            this.btnApply = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbContext = new System.Windows.Forms.GroupBox();
            this.gbTemplates = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.btnRemoveTemplate = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.gbRxOptions = new System.Windows.Forms.GroupBox();
            this.gbRxOLineMode = new System.Windows.Forms.GroupBox();
            this.rbRxOLMultiline = new System.Windows.Forms.RadioButton();
            this.rbRxOLSingleline = new System.Windows.Forms.RadioButton();
            this.cbRxOCultureInvariant = new System.Windows.Forms.CheckBox();
            this.cbRxOECMAScript = new System.Windows.Forms.CheckBox();
            this.cbRxORightToLeft = new System.Windows.Forms.CheckBox();
            this.cbRxOIgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
            this.cbRxOExplicitCapture = new System.Windows.Forms.CheckBox();
            this.cbRxOIgnoreCase = new System.Windows.Forms.CheckBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnRemoveRegexEditor = new System.Windows.Forms.Button();
            this.btnAddRegexEditor = new System.Windows.Forms.Button();
            this.ttRxOptions = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbContext.SuspendLayout();
            this.gbTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbRxOptions.SuspendLayout();
            this.gbRxOLineMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // scContext
            // 
            this.scContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContext.Location = new System.Drawing.Point(3, 16);
            this.scContext.MultipleSelection = true;
            this.scContext.Name = "scContext";
            this.scContext.Size = new System.Drawing.Size(703, 495);
            this.scContext.TabIndex = 1;
            this.scContext.UseTabs = true;
            this.scContext.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(3, 60);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(63, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(872, 606);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbContext);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbTemplates);
            this.splitContainer2.Panel2.Controls.Add(this.gbRxOptions);
            this.splitContainer2.Size = new System.Drawing.Size(872, 514);
            this.splitContainer2.SplitterDistance = 709;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // gbContext
            // 
            this.gbContext.Controls.Add(this.scContext);
            this.gbContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContext.Location = new System.Drawing.Point(0, 0);
            this.gbContext.Name = "gbContext";
            this.gbContext.Size = new System.Drawing.Size(709, 514);
            this.gbContext.TabIndex = 0;
            this.gbContext.TabStop = false;
            this.gbContext.Text = "Con&text";
            // 
            // gbTemplates
            // 
            this.gbTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTemplates.Controls.Add(this.splitContainer4);
            this.gbTemplates.Location = new System.Drawing.Point(0, 229);
            this.gbTemplates.Name = "gbTemplates";
            this.gbTemplates.Size = new System.Drawing.Size(159, 282);
            this.gbTemplates.TabIndex = 0;
            this.gbTemplates.TabStop = false;
            this.gbTemplates.Text = "Temp&lates";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(3, 16);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lbTemplates);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnRemoveTemplate);
            this.splitContainer4.Panel2.Controls.Add(this.btnSaveTemplate);
            this.splitContainer4.Size = new System.Drawing.Size(153, 263);
            this.splitContainer4.SplitterDistance = 237;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 0;
            // 
            // lbTemplates
            // 
            this.lbTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.Location = new System.Drawing.Point(0, 0);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(153, 237);
            this.lbTemplates.TabIndex = 9;
            this.lbTemplates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTemplates_MouseDoubleClick);
            // 
            // btnRemoveTemplate
            // 
            this.btnRemoveTemplate.Location = new System.Drawing.Point(75, 2);
            this.btnRemoveTemplate.Name = "btnRemoveTemplate";
            this.btnRemoveTemplate.Size = new System.Drawing.Size(77, 23);
            this.btnRemoveTemplate.TabIndex = 11;
            this.btnRemoveTemplate.Text = "Remove";
            this.btnRemoveTemplate.UseVisualStyleBackColor = true;
            this.btnRemoveTemplate.Click += new System.EventHandler(this.btnRemoveTemplate_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(2, 2);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(67, 23);
            this.btnSaveTemplate.TabIndex = 10;
            this.btnSaveTemplate.Text = "Save";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // gbRxOptions
            // 
            this.gbRxOptions.Controls.Add(this.gbRxOLineMode);
            this.gbRxOptions.Controls.Add(this.cbRxOCultureInvariant);
            this.gbRxOptions.Controls.Add(this.cbRxOECMAScript);
            this.gbRxOptions.Controls.Add(this.cbRxORightToLeft);
            this.gbRxOptions.Controls.Add(this.cbRxOIgnorePatternWhitespace);
            this.gbRxOptions.Controls.Add(this.cbRxOExplicitCapture);
            this.gbRxOptions.Controls.Add(this.cbRxOIgnoreCase);
            this.gbRxOptions.Location = new System.Drawing.Point(0, 0);
            this.gbRxOptions.Name = "gbRxOptions";
            this.gbRxOptions.Size = new System.Drawing.Size(159, 225);
            this.gbRxOptions.TabIndex = 0;
            this.gbRxOptions.TabStop = false;
            this.gbRxOptions.Text = "Rx &options";
            // 
            // gbRxOLineMode
            // 
            this.gbRxOLineMode.Controls.Add(this.rbRxOLMultiline);
            this.gbRxOLineMode.Controls.Add(this.rbRxOLSingleline);
            this.gbRxOLineMode.Location = new System.Drawing.Point(3, 157);
            this.gbRxOLineMode.Name = "gbRxOLineMode";
            this.gbRxOLineMode.Size = new System.Drawing.Size(150, 66);
            this.gbRxOLineMode.TabIndex = 0;
            this.gbRxOLineMode.TabStop = false;
            this.gbRxOLineMode.Text = "Line mode";
            // 
            // rbRxOLMultiline
            // 
            this.rbRxOLMultiline.AutoSize = true;
            this.rbRxOLMultiline.Location = new System.Drawing.Point(6, 42);
            this.rbRxOLMultiline.Name = "rbRxOLMultiline";
            this.rbRxOLMultiline.Size = new System.Drawing.Size(63, 17);
            this.rbRxOLMultiline.TabIndex = 0;
            this.rbRxOLMultiline.Text = "&Multiline";
            this.ttRxOptions.SetToolTip(this.rbRxOLMultiline, "Multiline mode. Changes the meaning of ^ and $ so they match at the beginning\r\nan" +
        "d end, respectively, of any line, and not just the beginning and end of the\r\nent" +
        "ire string.");
            this.rbRxOLMultiline.UseVisualStyleBackColor = true;
            // 
            // rbRxOLSingleline
            // 
            this.rbRxOLSingleline.AutoSize = true;
            this.rbRxOLSingleline.Checked = true;
            this.rbRxOLSingleline.Location = new System.Drawing.Point(6, 19);
            this.rbRxOLSingleline.Name = "rbRxOLSingleline";
            this.rbRxOLSingleline.Size = new System.Drawing.Size(70, 17);
            this.rbRxOLSingleline.TabIndex = 8;
            this.rbRxOLSingleline.TabStop = true;
            this.rbRxOLSingleline.Text = "&Singleline";
            this.ttRxOptions.SetToolTip(this.rbRxOLSingleline, "Specifies single-line mode. Changes the meaning of the dot (.) so it matches\r\neve" +
        "ry character (instead of every character except \\n).");
            this.rbRxOLSingleline.UseVisualStyleBackColor = true;
            // 
            // cbRxOCultureInvariant
            // 
            this.cbRxOCultureInvariant.AutoSize = true;
            this.cbRxOCultureInvariant.Location = new System.Drawing.Point(6, 134);
            this.cbRxOCultureInvariant.Name = "cbRxOCultureInvariant";
            this.cbRxOCultureInvariant.Size = new System.Drawing.Size(102, 17);
            this.cbRxOCultureInvariant.TabIndex = 7;
            this.cbRxOCultureInvariant.Text = "&Culture invariant";
            this.ttRxOptions.SetToolTip(this.cbRxOCultureInvariant, "Specifies that cultural differences in language is ignored.");
            this.cbRxOCultureInvariant.UseVisualStyleBackColor = true;
            // 
            // cbRxOECMAScript
            // 
            this.cbRxOECMAScript.AutoSize = true;
            this.cbRxOECMAScript.Location = new System.Drawing.Point(6, 111);
            this.cbRxOECMAScript.Name = "cbRxOECMAScript";
            this.cbRxOECMAScript.Size = new System.Drawing.Size(86, 17);
            this.cbRxOECMAScript.TabIndex = 6;
            this.cbRxOECMAScript.Text = "&ECMA Script";
            this.ttRxOptions.SetToolTip(this.cbRxOECMAScript, resources.GetString("cbRxOECMAScript.ToolTip"));
            this.cbRxOECMAScript.UseVisualStyleBackColor = true;
            // 
            // cbRxORightToLeft
            // 
            this.cbRxORightToLeft.AutoSize = true;
            this.cbRxORightToLeft.Location = new System.Drawing.Point(6, 88);
            this.cbRxORightToLeft.Name = "cbRxORightToLeft";
            this.cbRxORightToLeft.Size = new System.Drawing.Size(80, 17);
            this.cbRxORightToLeft.TabIndex = 5;
            this.cbRxORightToLeft.Text = "&Right to left";
            this.ttRxOptions.SetToolTip(this.cbRxORightToLeft, "Specifies that the search will be from right to left instead of from left to righ" +
        "t.");
            this.cbRxORightToLeft.UseVisualStyleBackColor = true;
            // 
            // cbRxOIgnorePatternWhitespace
            // 
            this.cbRxOIgnorePatternWhitespace.AutoSize = true;
            this.cbRxOIgnorePatternWhitespace.Location = new System.Drawing.Point(6, 65);
            this.cbRxOIgnorePatternWhitespace.Name = "cbRxOIgnorePatternWhitespace";
            this.cbRxOIgnorePatternWhitespace.Size = new System.Drawing.Size(149, 17);
            this.cbRxOIgnorePatternWhitespace.TabIndex = 4;
            this.cbRxOIgnorePatternWhitespace.Text = "Ignore &pattern whitespace";
            this.ttRxOptions.SetToolTip(this.cbRxOIgnorePatternWhitespace, resources.GetString("cbRxOIgnorePatternWhitespace.ToolTip"));
            this.cbRxOIgnorePatternWhitespace.UseVisualStyleBackColor = true;
            // 
            // cbRxOExplicitCapture
            // 
            this.cbRxOExplicitCapture.AutoSize = true;
            this.cbRxOExplicitCapture.Location = new System.Drawing.Point(6, 42);
            this.cbRxOExplicitCapture.Name = "cbRxOExplicitCapture";
            this.cbRxOExplicitCapture.Size = new System.Drawing.Size(98, 17);
            this.cbRxOExplicitCapture.TabIndex = 3;
            this.cbRxOExplicitCapture.Text = "E&xplicit capture";
            this.ttRxOptions.SetToolTip(this.cbRxOExplicitCapture, resources.GetString("cbRxOExplicitCapture.ToolTip"));
            this.cbRxOExplicitCapture.UseVisualStyleBackColor = true;
            // 
            // cbRxOIgnoreCase
            // 
            this.cbRxOIgnoreCase.AutoSize = true;
            this.cbRxOIgnoreCase.Location = new System.Drawing.Point(6, 19);
            this.cbRxOIgnoreCase.Name = "cbRxOIgnoreCase";
            this.cbRxOIgnoreCase.Size = new System.Drawing.Size(82, 17);
            this.cbRxOIgnoreCase.TabIndex = 2;
            this.cbRxOIgnoreCase.Text = "&Ignore case";
            this.ttRxOptions.SetToolTip(this.cbRxOIgnoreCase, "Specifies case-insensitive matching.");
            this.cbRxOIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnRemoveRegexEditor);
            this.splitContainer3.Panel2.Controls.Add(this.btnAddRegexEditor);
            this.splitContainer3.Panel2.Controls.Add(this.btnApply);
            this.splitContainer3.Size = new System.Drawing.Size(872, 88);
            this.splitContainer3.SplitterDistance = 798;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // btnRemoveRegexEditor
            // 
            this.btnRemoveRegexEditor.Location = new System.Drawing.Point(3, 31);
            this.btnRemoveRegexEditor.Name = "btnRemoveRegexEditor";
            this.btnRemoveRegexEditor.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveRegexEditor.TabIndex = 13;
            this.btnRemoveRegexEditor.Text = "Remove";
            this.btnRemoveRegexEditor.UseVisualStyleBackColor = true;
            this.btnRemoveRegexEditor.Click += new System.EventHandler(this.btnRemoveRegexEditor_Click);
            // 
            // btnAddRegexEditor
            // 
            this.btnAddRegexEditor.Location = new System.Drawing.Point(3, 2);
            this.btnAddRegexEditor.Name = "btnAddRegexEditor";
            this.btnAddRegexEditor.Size = new System.Drawing.Size(63, 23);
            this.btnAddRegexEditor.TabIndex = 12;
            this.btnAddRegexEditor.Text = "Add";
            this.btnAddRegexEditor.UseVisualStyleBackColor = true;
            this.btnAddRegexEditor.Click += new System.EventHandler(this.btnAddRegexEditor_Click);
            // 
            // TextGrater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 606);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TextGrater";
            this.Text = "Text Grater";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextGrater_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbContext.ResumeLayout(false);
            this.gbTemplates.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.gbRxOptions.ResumeLayout(false);
            this.gbRxOptions.PerformLayout();
            this.gbRxOLineMode.ResumeLayout(false);
            this.gbRxOLineMode.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scContext;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox cbRxOIgnoreCase;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbContext;
        private System.Windows.Forms.GroupBox gbRxOptions;
        private System.Windows.Forms.GroupBox gbRxOLineMode;
        private System.Windows.Forms.RadioButton rbRxOLMultiline;
        private System.Windows.Forms.ToolTip ttRxOptions;
        private System.Windows.Forms.RadioButton rbRxOLSingleline;
        private System.Windows.Forms.CheckBox cbRxOCultureInvariant;
        private System.Windows.Forms.CheckBox cbRxOECMAScript;
        private System.Windows.Forms.CheckBox cbRxORightToLeft;
        private System.Windows.Forms.CheckBox cbRxOIgnorePatternWhitespace;
        private System.Windows.Forms.CheckBox cbRxOExplicitCapture;
        private System.Windows.Forms.GroupBox gbTemplates;
        private System.Windows.Forms.Button btnRemoveRegexEditor;
        private System.Windows.Forms.Button btnAddRegexEditor;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnRemoveTemplate;
    }
}

