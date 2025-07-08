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
            m_labelOutput.Text = "<>";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                m_textBoxSource.Text = fbd.SelectedPath;            
        }

        private void m_buttonTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                m_textBoxTarget.Text = fbd.SelectedPath;
        }

        private void m_buttonStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                if (String.IsNullOrWhiteSpace(m_textBoxSource.Text))
                {
                    m_labelOutput.Text = "Select a Source";
                    m_buttonSource_Click(this, new EventArgs());
                    return;
                }
                if (String.IsNullOrWhiteSpace(m_textBoxTarget.Text))
                {
                    m_labelOutput.Text = "Select a Target";
                    m_buttonTarget_Click(this, new EventArgs());
                    return;
                }

                if (String.IsNullOrWhiteSpace(m_textBoxFilter.Text))
                {
                    var fileNames = Directory.GetFiles(m_textBoxSource.Text, "*.*", SearchOption.AllDirectories);
                    FCopy(fileNames, m_textBoxTarget.Text);
                    i = fileNames.Length;
                }
                else
                {
                    string[] exts = m_textBoxFilter.Text.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in exts)
                    {
                        var fileNames = Directory.GetFiles(m_textBoxSource.Text, "*." + s.Trim().Replace(".", ""), SearchOption.AllDirectories);
                        FCopy(fileNames, m_textBoxTarget.Text);
                        i += fileNames.Length;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                m_labelOutput.Text = "An error happened whilst defolderizing";
            }

            m_labelOutput.Text = "Defolderized " + i.ToString() + " files";
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

        private void m_buttonCopyStoT_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(m_textBoxSource.Text))
            {
                m_textBoxTarget.Text = m_textBoxSource.Text;
            }
        }
    }
}
