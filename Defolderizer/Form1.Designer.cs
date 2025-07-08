namespace Defolderizer
{
    partial class Form1
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
            this.m_buttonSource = new System.Windows.Forms.Button();
            this.m_textBoxSource = new System.Windows.Forms.TextBox();
            this.m_textBoxTarget = new System.Windows.Forms.TextBox();
            this.m_buttonTarget = new System.Windows.Forms.Button();
            this.m_textBoxFilter = new System.Windows.Forms.TextBox();
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_labelFilter = new System.Windows.Forms.Label();
            this.m_buttonCopyStoT = new System.Windows.Forms.Button();
            this.m_helpProvider = new System.Windows.Forms.HelpProvider();
            this.m_labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_buttonSource
            // 
            this.m_helpProvider.SetHelpKeyword(this.m_buttonSource, "Source");
            this.m_helpProvider.SetHelpString(this.m_buttonSource, "Click to set the source folder, all subfolders will be crawled for files.");
            this.m_buttonSource.Location = new System.Drawing.Point(13, 13);
            this.m_buttonSource.Name = "m_buttonSource";
            this.m_helpProvider.SetShowHelp(this.m_buttonSource, true);
            this.m_buttonSource.Size = new System.Drawing.Size(75, 23);
            this.m_buttonSource.TabIndex = 0;
            this.m_buttonSource.Text = "Source";
            this.m_buttonSource.UseVisualStyleBackColor = true;
            this.m_buttonSource.Click += new System.EventHandler(this.m_buttonSource_Click);
            // 
            // m_textBoxSource
            // 
            this.m_textBoxSource.Location = new System.Drawing.Point(94, 15);
            this.m_textBoxSource.Name = "m_textBoxSource";
            this.m_textBoxSource.Size = new System.Drawing.Size(344, 20);
            this.m_textBoxSource.TabIndex = 1;
            // 
            // m_textBoxTarget
            // 
            this.m_textBoxTarget.Location = new System.Drawing.Point(94, 70);
            this.m_textBoxTarget.Name = "m_textBoxTarget";
            this.m_textBoxTarget.Size = new System.Drawing.Size(344, 20);
            this.m_textBoxTarget.TabIndex = 3;
            // 
            // m_buttonTarget
            // 
            this.m_helpProvider.SetHelpKeyword(this.m_buttonTarget, "Target");
            this.m_helpProvider.SetHelpString(this.m_buttonTarget, "Folder where all the found files will be copied to.");
            this.m_buttonTarget.Location = new System.Drawing.Point(13, 68);
            this.m_buttonTarget.Name = "m_buttonTarget";
            this.m_helpProvider.SetShowHelp(this.m_buttonTarget, true);
            this.m_buttonTarget.Size = new System.Drawing.Size(75, 23);
            this.m_buttonTarget.TabIndex = 2;
            this.m_buttonTarget.Text = "Target";
            this.m_buttonTarget.UseVisualStyleBackColor = true;
            this.m_buttonTarget.Click += new System.EventHandler(this.m_buttonTarget_Click);
            // 
            // m_textBoxFilter
            // 
            this.m_textBoxFilter.Location = new System.Drawing.Point(94, 96);
            this.m_textBoxFilter.Name = "m_textBoxFilter";
            this.m_textBoxFilter.Size = new System.Drawing.Size(344, 20);
            this.m_textBoxFilter.TabIndex = 5;
            // 
            // m_buttonStart
            // 
            this.m_helpProvider.SetHelpKeyword(this.m_buttonStart, "Start");
            this.m_helpProvider.SetHelpString(this.m_buttonStart, "Click to Start defolderizing.");
            this.m_buttonStart.Location = new System.Drawing.Point(13, 186);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_helpProvider.SetShowHelp(this.m_buttonStart, true);
            this.m_buttonStart.Size = new System.Drawing.Size(75, 23);
            this.m_buttonStart.TabIndex = 4;
            this.m_buttonStart.Text = "Start";
            this.m_buttonStart.UseVisualStyleBackColor = true;
            this.m_buttonStart.Click += new System.EventHandler(this.m_buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter above a list of extensions separated by | (the pipe, vertical bar)\r\nIf ther" +
    "e is nothing, all files will be copied.";
            // 
            // m_labelFilter
            // 
            this.m_labelFilter.AutoSize = true;
            this.m_helpProvider.SetHelpKeyword(this.m_labelFilter, "Filer");
            this.m_helpProvider.SetHelpString(this.m_labelFilter, "Keep blank to copy all files, add extensions (pdf, doc, jpg,...) sperated by the " +
        "pipe to filter. Ex: pdf|docx|jpg");
            this.m_labelFilter.Location = new System.Drawing.Point(59, 99);
            this.m_labelFilter.Name = "m_labelFilter";
            this.m_helpProvider.SetShowHelp(this.m_labelFilter, true);
            this.m_labelFilter.Size = new System.Drawing.Size(29, 13);
            this.m_labelFilter.TabIndex = 7;
            this.m_labelFilter.Text = "Filter";
            // 
            // m_buttonCopyStoT
            // 
            this.m_helpProvider.SetHelpKeyword(this.m_buttonCopyStoT, "Copy");
            this.m_helpProvider.SetHelpString(this.m_buttonCopyStoT, "Click to set the Source folder as Target folder.");
            this.m_buttonCopyStoT.Location = new System.Drawing.Point(13, 41);
            this.m_buttonCopyStoT.Name = "m_buttonCopyStoT";
            this.m_helpProvider.SetShowHelp(this.m_buttonCopyStoT, true);
            this.m_buttonCopyStoT.Size = new System.Drawing.Size(105, 23);
            this.m_buttonCopyStoT.TabIndex = 8;
            this.m_buttonCopyStoT.Text = "Source = Target";
            this.m_buttonCopyStoT.UseVisualStyleBackColor = true;
            this.m_buttonCopyStoT.Click += new System.EventHandler(this.m_buttonCopyStoT_Click);
            // 
            // m_labelOutput
            // 
            this.m_labelOutput.AutoSize = true;
            this.m_labelOutput.Location = new System.Drawing.Point(94, 191);
            this.m_labelOutput.Name = "m_labelOutput";
            this.m_labelOutput.Size = new System.Drawing.Size(19, 13);
            this.m_labelOutput.TabIndex = 9;
            this.m_labelOutput.Text = "<>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 221);
            this.Controls.Add(this.m_labelOutput);
            this.Controls.Add(this.m_buttonCopyStoT);
            this.Controls.Add(this.m_labelFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_textBoxFilter);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.m_textBoxTarget);
            this.Controls.Add(this.m_buttonTarget);
            this.Controls.Add(this.m_textBoxSource);
            this.Controls.Add(this.m_buttonSource);
            this.Name = "Form1";
            this.Text = "Defolderizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_buttonSource;
        private System.Windows.Forms.TextBox m_textBoxSource;
        private System.Windows.Forms.TextBox m_textBoxTarget;
        private System.Windows.Forms.Button m_buttonTarget;
        private System.Windows.Forms.TextBox m_textBoxFilter;
        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_labelFilter;
        private System.Windows.Forms.Button m_buttonCopyStoT;
        private System.Windows.Forms.HelpProvider m_helpProvider;
        private System.Windows.Forms.Label m_labelOutput;
    }
}

