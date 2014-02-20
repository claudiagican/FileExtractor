using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExtractor
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void browseSrc_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folderPathSrc.Text = folderBrowserDialog.SelectedPath;
        }

        private void browseRes_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folderPathDest.Text = folderBrowserDialog.SelectedPath;

            checkBoxResAsSrc.Checked = false;
        }

        private void checkBoxResAsSrc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxResAsSrc.Checked)
                folderPathDest.Text = folderPathSrc.Text;
            
            folderPathDest.Enabled = !checkBoxResAsSrc.Checked;
        }

        private void extract_Click(object sender, EventArgs e)
        {
            Program.ProcessFiles(folderPathSrc.Text, folderPathDest.Text);
        }
    }
}
