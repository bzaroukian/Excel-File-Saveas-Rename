﻿
namespace Excel_File_Rename
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileDropListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop Files Here:";
            // 
            // fileDropListBox
            // 
            this.fileDropListBox.AllowDrop = true;
            this.fileDropListBox.FormattingEnabled = true;
            this.fileDropListBox.ItemHeight = 16;
            this.fileDropListBox.Location = new System.Drawing.Point(21, 48);
            this.fileDropListBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileDropListBox.Name = "fileDropListBox";
            this.fileDropListBox.Size = new System.Drawing.Size(749, 324);
            this.fileDropListBox.TabIndex = 1;
            this.fileDropListBox.SelectedIndexChanged += new System.EventHandler(this.fileDropListBox_SelectedIndexChanged);
            this.fileDropListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileDropListBox_DragDrop);
            this.fileDropListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileDropListBox_DragEnter);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(21, 416);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1005, 129);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Files are being renamed and saved into the correct folder. Please standby.";
            this.statusLabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(792, 182);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 86);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.fileDropListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Friday Load Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileDropListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

