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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Excel_File_Rename
{
    public partial class Form1 : Form
    {

        string path;
        string profile;
        int x = 0;
        
        public Form1()
        {
            InitializeComponent();

            //Get user profile information
            profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
        }

        private void fileDropListBox_DragDrop(object sender, DragEventArgs e)
        {
            try { 
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                progressBar1.Maximum = files.Length;
            foreach (string file in files)
            {
                fileDropListBox.Items.Add(file);

                // File gets dropped and edited 
                
                path = file;
                    //MessageBox.Show(path);
                    if (statusLabel.Text == "Files have been renamed and saved into the correct folder.")
                    {
                        statusLabel.Text = "Additional files are being proccessed. Please stand by.";
                    }
                    statusLabel.Visible = true;
                Application excel = new Application();
                Workbook wb = excel.Workbooks.Open(path);
                Worksheet excelSheet = wb.ActiveSheet;


                    // [Row, Column] 
                string test = excelSheet.Cells[10, 3].value.ToString();
                
                // This is the file path the document will be saved at as. 
                wb.SaveCopyAs(profile +"/desktop/" + "Info from cell" + test + ".xlsx");
                
                
                
                wb.Close();
                    x = x + 1;
                    progressBar1.Value = x;
            }
                statusLabel.Text = x + " File's have been renamed and saved on your desktop.";
                //statusLabel.Visible = true;
            }
            catch
            {
                MessageBox.Show("There was an error. Please check the following Items:" +
                    "1. That the document was closed." +
                    "2. The document is an excel file.");
            }
        }

        private void fileDropListBox_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)== true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void fileDropListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    


}
