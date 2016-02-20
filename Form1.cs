using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Dx
{
    public partial class ClientForm : Form
    {
        #region fields
        String tempPath = System.IO.Path.GetTempPath();
        String resultFolder = string.Empty;
        String XsltPath = string.Empty;
        string PublishTo = string.Empty;
        XmlDocument dom = new XmlDocument();
        #endregion

        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonFindDocx_Click(object sender, EventArgs e)
        {
            string newFile = getFile("Select input document (Word docx file)", "Word docx (*.docx)|*.docx", "");
            if (newFile.Length > 0)
            {
                txtBoxDocx.Text = newFile;                
            }
        }

        private void buttonFindXslt_Click(object sender, EventArgs e)
        {
            string newFile = getFile("Select custom XSLT stylesheet", "XSLT stylesheet (*.xsl, *.xslt, *.crypt)|*.xsl;*.xslt;*.crypt", "");
            if (newFile.Length > 0)
            {
                txtBoxXslt.Text = newFile;
            }
        }

        private void btExtract_Click(object sender, EventArgs e)
        {
            try
            {
                #region validate string input
                if (ValidateInputFile(txtBoxDocx.Text, "DOCX") == false || ValidateInputFile(txtBoxXslt.Text, "XSLT") == false)
                {
                    return;
                }
                #endregion

                #region initialize
                buttonSaveResult.Enabled = false;
                Cursor = Cursors.WaitCursor;
                DisplayHtml(null);
                dom.RemoveAll();
                XmlDocument XInput = new XmlDocument();
                XmlReader xsltReader;
                XmlDocument xsltInput = new XmlDocument();
                XDocument myX = new XDocument();
                MemoryStream browserStream = new MemoryStream();
                #endregion

                #region prepare transform input
                XDocument Xopc = OpcToFlat.ConvertOpcToFlat(txtBoxDocx.Text);
                XInput = XmTools.ToXmlDocument(Xopc);

                if (txtBoxXslt.Text == string.Empty)
                {
                    xsltInput.LoadXml(Properties.Resources.DocxExtractor);
                    myX = XmTools.ToXDocument(xsltInput);
                    xsltReader = myX.CreateReader();                                                         
                }
                else
                {
                    xsltReader = XmlReader.Create(txtBoxXslt.Text);
                }
                #endregion

                #region call transform
                using (MemoryStream strm = XmTools.TransformXml(XInput.CreateNavigator(), xsltReader, null))
                {
                    dom.Load(strm);
                }
                #endregion

                #region present result
                if (dom.DocumentElement.LocalName == "DocxExtractor")
                {
                    //transform result to HTML
                    xsltInput.LoadXml(Properties.Resources.xDisplay);
                    myX = XmTools.ToXDocument(xsltInput);
                    xsltReader = myX.CreateReader();
                    browserStream = XmTools.TransformXml(dom.CreateNavigator(), xsltReader, null);
                    DisplayHtml(browserStream);
                }                
                #endregion
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message, "DocxExtractor: Extract Error");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DocxExtractor: Extract Error");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
          
        private bool ValidateInputFile(string FilePath, string FileType)
        {
            try
            {
                if (FileType == "XSLT" & FilePath == "")
                {
                    return true; //custom XSLT is optional
                }
                else if (FileType == "DOCX" & FilePath == "")
                {
                    MessageBox.Show("Please select a "+FileType+" input file and try again", "DocxExtractor: Validate input");
                    return false;
                }
                else if (FilePath.ToLower().EndsWith(FileType.ToLower()) == true)
                {
                    if (File.Exists(FilePath) == false)
                    {
                        MessageBox.Show("The " + FileType + " indicated was not found. Please correct and try again", "DocxExtractor: Validate input");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("The input file " + FilePath + " is not a " + FileType + " file. Please correct and try again", "DocxExtractor: Validate input");
                    return false;
                }  
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " " + e.StackTrace, "DocxExtractor: Validate input");
                return false;
            }
        }

        private void DisplayHtml(Stream html)
        {
            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Write(string.Empty);
            }
            webBrowser1.DocumentStream = html;
        }


        private string getFile(string dlgTitle, string dlgFilter, string initDir)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if ((initDir != "") && Directory.Exists(initDir))
                {
                    dialog.InitialDirectory = initDir;
                }
                dialog.Filter = dlgFilter;
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Multiselect = false;
                dialog.Title = dlgTitle;
                dialog.ShowDialog(this);
                return dialog.FileName;
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                String savePath = txtBoxDocx.Text + ".extract.xml";
                dom.Save(savePath);
                MessageBox.Show("Results saved as " + savePath, "DocxExtractor: Save Success");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DocxExtractor: Save Error");

            }
        }

        private void buttonShowOpenXml_Click(object sender, EventArgs e)
        {
            XmlDocument xsltInput = new XmlDocument();
            XDocument myX = new XDocument();
            XmlReader xsltReader;
            MemoryStream browserStream = new MemoryStream();

            try
            {
                #region initialize
                buttonSaveResult.Enabled = false;
                Cursor = Cursors.WaitCursor;
                DisplayHtml(null);
                dom.RemoveAll();
                #endregion

                #region create and show flat openxml            
                try
                {
                    dom = XmTools.ToXmlDocument(OpcToFlat.ConvertOpcToFlat(txtBoxDocx.Text));

                    #region present result                    
                        //transform result to HTML
                        xsltInput.LoadXml(Properties.Resources.xDisplay);
                        myX = XmTools.ToXDocument(xsltInput);
                        xsltReader = myX.CreateReader();
                        browserStream = XmTools.TransformXml(dom.CreateNavigator(), xsltReader, null);
                        DisplayHtml(browserStream);                    
                    #endregion

                }
                catch (XmlException xmlEx)
                {
                    MessageBox.Show(xmlEx.Message, "DocxExtractor: Show Flat OpenXML Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DocxExtractor: Show Flat OpenXML Error");
                }
                finally
                {
                    Cursor = Cursors.Default;
                    buttonSaveResult.Enabled = true;
                }
                #endregion
            }
            catch
            { }

        }
                
    }
}
