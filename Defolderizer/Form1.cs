using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Defolderizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_buttonSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = fbd.SelectedPath;            
        }

        private void m_buttonTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = fbd.SelectedPath;
        }

        private void m_buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                m_buttonSource_Click(this, new EventArgs());
                return;
            }
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                m_buttonTarget_Click(this, new EventArgs());
                return;
            }

            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                var fileNames = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);
                FCopy(fileNames, textBox2.Text);
            }
            else
            {
                string[] exts = textBox3.Text.Split(new string[]{"|"}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in exts)
                {
                    var fileNames = Directory.GetFiles(textBox1.Text, "*." + s.Trim().Replace(".",""), SearchOption.AllDirectories);
                    FCopy(fileNames, textBox2.Text);
                }
            }
        }

        private void FCopy(String[] fnames, string targetFolder)
        {
            foreach (string s in fnames)
            {
                if (File.Exists(s))
                {
                    String newFile = Path.Combine(targetFolder, Path.GetFileName(s));
                    if (!File.Exists(newFile))
                    {
                        File.Move(s, newFile);
                    }
                    else
                    {
                        File.Move(s, Path.Combine(targetFolder, Path.GetFileNameWithoutExtension(newFile) + DateTime.Now.Millisecond.ToString()));
                    }
                }
            }
        }
    }
}
