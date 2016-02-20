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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.SuspendLayout();
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(771, 82);
            this.buttonPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(115, 37);
            this.buttonPublish.TabIndex = 0;
            this.buttonPublish.Text = "Extract Tags";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.btExtract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 110);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Extract structured, tagged content from any docx file\r\n";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(926, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Provided to IRISS by";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dx.Properties.Resources.tag_64;
            this.pictureBox2.Location = new System.Drawing.Point(21, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(97, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 65);
            this.label9.TabIndex = 1;
            this.label9.Text = "Docx Extractor™";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dx.Properties.Resources.Dx3;
            this.pictureBox1.Location = new System.Drawing.Point(1091, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFindDocx
            // 
            this.buttonFindDocx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindDocx.Location = new System.Drawing.Point(1151, 38);
            this.buttonFindDocx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFindDocx.Name = "buttonFindDocx";
            this.buttonFindDocx.Size = new System.Drawing.Size(56, 31);
            this.buttonFindDocx.TabIndex = 9;
            this.buttonFindDocx.Text = "...";
            this.buttonFindDocx.UseVisualStyleBackColor = true;
            this.buttonFindDocx.Click += new System.EventHandler(this.buttonFindDocx_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extraction Results:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 794);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(899, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyright © 2016, DITA Exchange ApS. Provided under GNU General Public License, p" +
    "lease see the \"Licensing\" tab for terms.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Custom stylesheet";
            // 
            // buttonFindXslt
            // 
            this.buttonFindXslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindXslt.Location = new System.Drawing.Point(1153, 28);
            this.buttonFindXslt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFindXslt.Name = "buttonFindXslt";
            this.buttonFindXslt.Size = new System.Drawing.Size(56, 32);
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
            this.tabPublish.Controls.Add(this.tabPage3);
            this.tabPublish.Location = new System.Drawing.Point(14, 135);
            this.tabPublish.Margin = new System.Windows.Forms.Padding(0);
            this.tabPublish.Multiline = true;
            this.tabPublish.Name = "tabPublish";
            this.tabPublish.Padding = new System.Drawing.Point(0, 0);
            this.tabPublish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPublish.SelectedIndex = 0;
            this.tabPublish.Size = new System.Drawing.Size(1225, 659);
            this.tabPublish.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1217, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extraction";
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
            this.groupBox3.Location = new System.Drawing.Point(-2, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1215, 129);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Please select the docx file and click the \"Extract\" button";
            // 
            // buttonShowOpenXml
            // 
            this.buttonShowOpenXml.Location = new System.Drawing.Point(893, 82);
            this.buttonShowOpenXml.Name = "buttonShowOpenXml";
            this.buttonShowOpenXml.Size = new System.Drawing.Size(176, 37);
            this.buttonShowOpenXml.TabIndex = 11;
            this.buttonShowOpenXml.Text = "Show Flat OpenXML";
            this.buttonShowOpenXml.UseVisualStyleBackColor = true;
            this.buttonShowOpenXml.Click += new System.EventHandler(this.buttonShowOpenXml_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Enabled = false;
            this.buttonSaveResult.Location = new System.Drawing.Point(1075, 82);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(132, 37);
            this.buttonSaveResult.TabIndex = 10;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // txtBoxDocx
            // 
            this.txtBoxDocx.AllowDrop = true;
            this.txtBoxDocx.Location = new System.Drawing.Point(121, 40);
            this.txtBoxDocx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDocx.Name = "txtBoxDocx";
            this.txtBoxDocx.Size = new System.Drawing.Size(1022, 26);
            this.txtBoxDocx.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1217, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 154);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guidance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(957, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxXslt);
            this.groupBox2.Controls.Add(this.buttonFindXslt);
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1213, 71);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use the following custom XSLT for the extraction";
            // 
            // txtBoxXslt
            // 
            this.txtBoxXslt.Location = new System.Drawing.Point(156, 29);
            this.txtBoxXslt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxXslt.Name = "txtBoxXslt";
            this.txtBoxXslt.Size = new System.Drawing.Size(989, 26);
            this.txtBoxXslt.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1217, 623);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Licensing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1210, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(4, 143);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1210, 477);
            this.webBrowser1.TabIndex = 16;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1248, 817);
            this.Controls.Add(this.tabPublish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 764);
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
    }
}

