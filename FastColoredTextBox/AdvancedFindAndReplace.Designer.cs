
namespace FastColoredTextBoxNS
{
    partial class AdvancedFindAndReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedFindAndReplace));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcFindAndReplace = new System.Windows.Forms.TabControl();
            this.tpFindAndReplace = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.cbReplace = new System.Windows.Forms.CheckBox();
            this.cbWholeWord = new System.Windows.Forms.CheckBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.btFindNext = new System.Windows.Forms.Button();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.tpFindInFiles = new System.Windows.Forms.TabPage();
            this.cbSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.btFindInFiles = new System.Windows.Forms.Button();
            this.tbFindInFilesDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFindInFiles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSwitchFindAndReplace = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tcFindAndReplace.SuspendLayout();
            this.tpFindAndReplace.SuspendLayout();
            this.tpFindInFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusUpdateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusUpdateLabel
            // 
            this.tsStatusUpdateLabel.Name = "tsStatusUpdateLabel";
            this.tsStatusUpdateLabel.Size = new System.Drawing.Size(114, 17);
            this.tsStatusUpdateLabel.Text = "tsStatusUpdateLabel";
            // 
            // tcFindAndReplace
            // 
            this.tcFindAndReplace.Controls.Add(this.tpFindAndReplace);
            this.tcFindAndReplace.Controls.Add(this.tpFindInFiles);
            this.tcFindAndReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFindAndReplace.Location = new System.Drawing.Point(0, 0);
            this.tcFindAndReplace.Name = "tcFindAndReplace";
            this.tcFindAndReplace.SelectedIndex = 0;
            this.tcFindAndReplace.Size = new System.Drawing.Size(451, 219);
            this.tcFindAndReplace.TabIndex = 1;
            // 
            // tpFindAndReplace
            // 
            this.tpFindAndReplace.Controls.Add(this.btSwitchFindAndReplace);
            this.tpFindAndReplace.Controls.Add(this.label2);
            this.tpFindAndReplace.Controls.Add(this.tbReplace);
            this.tpFindAndReplace.Controls.Add(this.btReplaceAll);
            this.tpFindAndReplace.Controls.Add(this.btReplace);
            this.tpFindAndReplace.Controls.Add(this.cbReplace);
            this.tpFindAndReplace.Controls.Add(this.cbWholeWord);
            this.tpFindAndReplace.Controls.Add(this.tbFind);
            this.tpFindAndReplace.Controls.Add(this.label1);
            this.tpFindAndReplace.Controls.Add(this.btClose);
            this.tpFindAndReplace.Controls.Add(this.cbMatchCase);
            this.tpFindAndReplace.Controls.Add(this.btFindNext);
            this.tpFindAndReplace.Controls.Add(this.cbRegex);
            this.tpFindAndReplace.Location = new System.Drawing.Point(4, 22);
            this.tpFindAndReplace.Name = "tpFindAndReplace";
            this.tpFindAndReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tpFindAndReplace.Size = new System.Drawing.Size(443, 193);
            this.tpFindAndReplace.TabIndex = 0;
            this.tpFindAndReplace.Text = "Find and Replace";
            this.tpFindAndReplace.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Replace with";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(90, 157);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(305, 20);
            this.tbReplace.TabIndex = 37;
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Location = new System.Drawing.Point(239, 98);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btReplaceAll.TabIndex = 39;
            this.btReplaceAll.Text = "Replace all";
            this.btReplaceAll.UseVisualStyleBackColor = true;
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(158, 98);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 38;
            this.btReplace.Text = "Replace";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // cbReplace
            // 
            this.cbReplace.AutoSize = true;
            this.cbReplace.Location = new System.Drawing.Point(359, 43);
            this.cbReplace.Name = "cbReplace";
            this.cbReplace.Size = new System.Drawing.Size(72, 17);
            this.cbReplace.TabIndex = 36;
            this.cbReplace.Text = "Replace?";
            this.cbReplace.UseVisualStyleBackColor = true;
            this.cbReplace.Click += new System.EventHandler(this.cbReplace_CheckedChanged);
            // 
            // cbWholeWord
            // 
            this.cbWholeWord.AutoSize = true;
            this.cbWholeWord.Location = new System.Drawing.Point(177, 43);
            this.cbWholeWord.Name = "cbWholeWord";
            this.cbWholeWord.Size = new System.Drawing.Size(113, 17);
            this.cbWholeWord.TabIndex = 31;
            this.cbWholeWord.Text = "Match whole word";
            this.cbWholeWord.UseVisualStyleBackColor = true;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(90, 17);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(305, 20);
            this.tbFind.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Find";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(320, 98);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 35;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(90, 43);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(82, 17);
            this.cbMatchCase.TabIndex = 30;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // btFindNext
            // 
            this.btFindNext.Location = new System.Drawing.Point(77, 98);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Size = new System.Drawing.Size(75, 23);
            this.btFindNext.TabIndex = 33;
            this.btFindNext.Text = "Find next";
            this.btFindNext.UseVisualStyleBackColor = true;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Location = new System.Drawing.Point(296, 43);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(57, 17);
            this.cbRegex.TabIndex = 32;
            this.cbRegex.Text = "Regex";
            this.cbRegex.UseVisualStyleBackColor = true;
            // 
            // tpFindInFiles
            // 
            this.tpFindInFiles.Controls.Add(this.cbSearchSubFolders);
            this.tpFindInFiles.Controls.Add(this.btFindInFiles);
            this.tpFindInFiles.Controls.Add(this.tbFindInFilesDirectory);
            this.tpFindInFiles.Controls.Add(this.label4);
            this.tpFindInFiles.Controls.Add(this.tbFindInFiles);
            this.tpFindInFiles.Controls.Add(this.label3);
            this.tpFindInFiles.Location = new System.Drawing.Point(4, 22);
            this.tpFindInFiles.Name = "tpFindInFiles";
            this.tpFindInFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpFindInFiles.Size = new System.Drawing.Size(443, 193);
            this.tpFindInFiles.TabIndex = 1;
            this.tpFindInFiles.Text = "Find in Files";
            this.tpFindInFiles.UseVisualStyleBackColor = true;
            // 
            // cbSearchSubFolders
            // 
            this.cbSearchSubFolders.AutoSize = true;
            this.cbSearchSubFolders.Location = new System.Drawing.Point(48, 97);
            this.cbSearchSubFolders.Name = "cbSearchSubFolders";
            this.cbSearchSubFolders.Size = new System.Drawing.Size(119, 17);
            this.cbSearchSubFolders.TabIndex = 23;
            this.cbSearchSubFolders.Text = "Search Sub Folders";
            this.cbSearchSubFolders.UseVisualStyleBackColor = true;
            // 
            // btFindInFiles
            // 
            this.btFindInFiles.Location = new System.Drawing.Point(308, 120);
            this.btFindInFiles.Name = "btFindInFiles";
            this.btFindInFiles.Size = new System.Drawing.Size(75, 23);
            this.btFindInFiles.TabIndex = 22;
            this.btFindInFiles.Text = "Find";
            this.btFindInFiles.UseVisualStyleBackColor = true;
            this.btFindInFiles.Click += new System.EventHandler(this.btFindInFiles_Click);
            // 
            // tbFindInFilesDirectory
            // 
            this.tbFindInFilesDirectory.Location = new System.Drawing.Point(111, 67);
            this.tbFindInFilesDirectory.Name = "tbFindInFilesDirectory";
            this.tbFindInFilesDirectory.Size = new System.Drawing.Size(272, 20);
            this.tbFindInFilesDirectory.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Directory";
            // 
            // tbFindInFiles
            // 
            this.tbFindInFiles.Location = new System.Drawing.Point(111, 41);
            this.tbFindInFiles.Name = "tbFindInFiles";
            this.tbFindInFiles.Size = new System.Drawing.Size(272, 20);
            this.tbFindInFiles.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Find";
            // 
            // btSwitchFindAndReplace
            // 
            this.btSwitchFindAndReplace.Image = ((System.Drawing.Image)(resources.GetObject("btSwitchFindAndReplace.Image")));
            this.btSwitchFindAndReplace.Location = new System.Drawing.Point(32, 90);
            this.btSwitchFindAndReplace.Name = "btSwitchFindAndReplace";
            this.btSwitchFindAndReplace.Size = new System.Drawing.Size(39, 38);
            this.btSwitchFindAndReplace.TabIndex = 41;
            this.btSwitchFindAndReplace.UseVisualStyleBackColor = true;
            this.btSwitchFindAndReplace.Click += new System.EventHandler(this.btSwitchFindAndReplace_Click);
            // 
            // AdvancedFindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.ControlBox = false;
            this.Controls.Add(this.tcFindAndReplace);
            this.Controls.Add(this.statusStrip1);
            this.HelpButton = true;
            this.Name = "AdvancedFindAndReplace";
            this.Text = "Find And Replace";
            this.Load += new System.EventHandler(this.AdvancedFindAndReplace_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcFindAndReplace.ResumeLayout(false);
            this.tpFindAndReplace.ResumeLayout(false);
            this.tpFindAndReplace.PerformLayout();
            this.tpFindInFiles.ResumeLayout(false);
            this.tpFindInFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusUpdateLabel;
        private System.Windows.Forms.TabControl tcFindAndReplace;
        private System.Windows.Forms.TabPage tpFindAndReplace;
        private System.Windows.Forms.TabPage tpFindInFiles;
        private System.Windows.Forms.Button btSwitchFindAndReplace;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btReplaceAll;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.CheckBox cbReplace;
        private System.Windows.Forms.CheckBox cbWholeWord;
        public System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.Button btFindNext;
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.CheckBox cbSearchSubFolders;
        private System.Windows.Forms.Button btFindInFiles;
        public System.Windows.Forms.TextBox tbFindInFilesDirectory;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbFindInFiles;
        private System.Windows.Forms.Label label3;
    }
}