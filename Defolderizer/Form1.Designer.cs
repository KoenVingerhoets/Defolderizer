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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.m_buttonTarget = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_buttonSource
            // 
            this.m_buttonSource.Location = new System.Drawing.Point(13, 13);
            this.m_buttonSource.Name = "m_buttonSource";
            this.m_buttonSource.Size = new System.Drawing.Size(75, 23);
            this.m_buttonSource.TabIndex = 0;
            this.m_buttonSource.Text = "Source";
            this.m_buttonSource.UseVisualStyleBackColor = true;
            this.m_buttonSource.Click += new System.EventHandler(this.m_buttonSource_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 20);
            this.textBox2.TabIndex = 3;
            // 
            // m_buttonTarget
            // 
            this.m_buttonTarget.Location = new System.Drawing.Point(12, 42);
            this.m_buttonTarget.Name = "m_buttonTarget";
            this.m_buttonTarget.Size = new System.Drawing.Size(75, 23);
            this.m_buttonTarget.TabIndex = 2;
            this.m_buttonTarget.Text = "Target";
            this.m_buttonTarget.UseVisualStyleBackColor = true;
            this.m_buttonTarget.Click += new System.EventHandler(this.m_buttonTarget_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(344, 20);
            this.textBox3.TabIndex = 5;
            // 
            // m_buttonStart
            // 
            this.m_buttonStart.Location = new System.Drawing.Point(12, 71);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_buttonStart.Size = new System.Drawing.Size(75, 23);
            this.m_buttonStart.TabIndex = 4;
            this.m_buttonStart.Text = "Start";
            this.m_buttonStart.UseVisualStyleBackColor = true;
            this.m_buttonStart.Click += new System.EventHandler(this.m_buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter above a list of extensions separated by |\r\nIf there is nothing, all files w" +
    "ill be copied.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.m_buttonTarget);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_buttonSource);
            this.Name = "Form1";
            this.Text = "Defolderizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_buttonSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button m_buttonTarget;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Label label1;
    }
}

