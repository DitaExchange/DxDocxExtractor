using System.Reflection;
namespace Dx
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.buttonPublish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFindDocx = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFindXslt = new System.Windows.Forms.Button();
            this.tabPublish = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShowOpenXml = new System.Windows.Forms.Button();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.txtBoxDocx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxXslt = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPublish.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(642, 68);
            this.buttonPublish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(96, 31);
            this.buttonPublish.TabIndex = 0;
            this.buttonPublish.Text = "Extract Tags";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.btExtract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input docx file";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 92);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(336, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Extract structured, tagged content from any docx file\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(772, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Provided to IRISS by";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dx.Properties.Resources.tag_64;
            this.pictureBox2.Location = new System.Drawing.Point(17, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(81, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 54);
            this.label9.TabIndex = 1;
            this.label9.Text = "Docx Extractor™";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dx.Properties.Resources.Dx3;
            this.pictureBox1.Location = new System.Drawing.Point(909, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFindDocx
            // 
            this.buttonFindDocx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindDocx.Location = new System.Drawing.Point(959, 32);
            this.buttonFindDocx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindDocx.Name = "buttonFindDocx";
            this.buttonFindDocx.Size = new System.Drawing.Size(47, 26);
            this.buttonFindDocx.TabIndex = 9;
            this.buttonFindDocx.Text = "...";
            this.buttonFindDocx.UseVisualStyleBackColor = true;
            this.buttonFindDocx.Click += new System.EventHandler(this.buttonFindDocx_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extraction Results:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 662);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(806, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyright © 2016, DITA Exchange ApS. Provided under GNU General Public License, p" +
    "lease see the \"Licensing\" tab for terms.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Custom stylesheet";
            // 
            // buttonFindXslt
            // 
            this.buttonFindXslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindXslt.Location = new System.Drawing.Point(961, 23);
            this.buttonFindXslt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindXslt.Name = "buttonFindXslt";
            this.buttonFindXslt.Size = new System.Drawing.Size(47, 27);
            this.buttonFindXslt.TabIndex = 23;
            this.buttonFindXslt.Text = "...";
            this.buttonFindXslt.UseVisualStyleBackColor = true;
            this.buttonFindXslt.Click += new System.EventHandler(this.buttonFindXslt_Click);
            // 
            // tabPublish
            // 
            this.tabPublish.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPublish.Controls.Add(this.tabPage1);
            this.tabPublish.Controls.Add(this.tabPage2);
            this.tabPublish.Controls.Add(this.tabPage4);
            this.tabPublish.Controls.Add(this.tabPage3);
            this.tabPublish.Location = new System.Drawing.Point(12, 112);
            this.tabPublish.Margin = new System.Windows.Forms.Padding(0);
            this.tabPublish.Multiline = true;
            this.tabPublish.Name = "tabPublish";
            this.tabPublish.Padding = new System.Drawing.Point(0, 0);
            this.tabPublish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPublish.SelectedIndex = 0;
            this.tabPublish.Size = new System.Drawing.Size(1021, 549);
            this.tabPublish.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1013, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extraction";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 119);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(17, 17);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1008, 397);
            this.webBrowser1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowOpenXml);
            this.groupBox3.Controls.Add(this.buttonSaveResult);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonFindDocx);
            this.groupBox3.Controls.Add(this.txtBoxDocx);
            this.groupBox3.Controls.Add(this.buttonPublish);
            this.groupBox3.Location = new System.Drawing.Point(-2, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1012, 107);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Please select the docx file and click the \"Extract\" button";
            // 
            // buttonShowOpenXml
            // 
            this.buttonShowOpenXml.Location = new System.Drawing.Point(744, 68);
            this.buttonShowOpenXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowOpenXml.Name = "buttonShowOpenXml";
            this.buttonShowOpenXml.Size = new System.Drawing.Size(147, 31);
            this.buttonShowOpenXml.TabIndex = 11;
            this.buttonShowOpenXml.Text = "Show Flat OpenXML";
            this.buttonShowOpenXml.UseVisualStyleBackColor = true;
            this.buttonShowOpenXml.Click += new System.EventHandler(this.buttonShowOpenXml_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Enabled = false;
            this.buttonSaveResult.Location = new System.Drawing.Point(896, 68);
            this.buttonSaveResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(110, 31);
            this.buttonSaveResult.TabIndex = 10;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // txtBoxDocx
            // 
            this.txtBoxDocx.AllowDrop = true;
            this.txtBoxDocx.Location = new System.Drawing.Point(101, 33);
            this.txtBoxDocx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDocx.Name = "txtBoxDocx";
            this.txtBoxDocx.Size = new System.Drawing.Size(852, 22);
            this.txtBoxDocx.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1013, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1015, 128);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guidance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(859, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxXslt);
            this.groupBox2.Controls.Add(this.buttonFindXslt);
            this.groupBox2.Location = new System.Drawing.Point(0, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1011, 59);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use the following custom XSLT for the extraction";
            // 
            // txtBoxXslt
            // 
            this.txtBoxXslt.Location = new System.Drawing.Point(130, 24);
            this.txtBoxXslt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxXslt.Name = "txtBoxXslt";
            this.txtBoxXslt.Size = new System.Drawing.Size(825, 22);
            this.txtBoxXslt.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1013, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Licensing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1009, 246);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1013, 517);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Guidelines";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(2, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1010, 517);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 681);
            this.Controls.Add(this.tabPublish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 644);
            this.Name = "ClientForm";
            this.Text = "DocxExtractor™";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPublish.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxDocx;
        private System.Windows.Forms.Button buttonFindDocx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxXslt;
        private System.Windows.Forms.Button buttonFindXslt;
        private System.Windows.Forms.TabControl tabPublish;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.Button buttonShowOpenXml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

