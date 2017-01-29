using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Word_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            int intCount = 0;
            string strPath;
            //Open the file
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                //Get path of the file and counts the words per line
                strPath = theDialog.FileName;
                string[] filelines = File.ReadAllLines(strPath);

                foreach (string line in filelines)
                {
                    intCount += line.Split(' ').Length;
                }
                string strFileName = Path.GetFileName(strPath);
                lblFileName.Text = strFileName;
                lblCount.Text = intCount.ToString();
            }
            else
            {
                lblFileName.Text = "Error";
            }

        }
    }
}
