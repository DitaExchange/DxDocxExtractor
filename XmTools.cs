using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Reflection;
using System.Windows.Forms;

namespace Dx
{
    public static class XmTools
    {
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }
            return xmlDocument;
        }

        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }

        public static MemoryStream TransformXml(XPathNavigator navInputXml, XmlReader xsltReader, XsltArgumentList args)
        {
            try
            {
                var myTransformer = new XslCompiledTransform();
                myTransformer.Load(xsltReader);

                var transformedStream = new MemoryStream();
                using (var myWriter = XmlWriter.Create(transformedStream))
                {
                    myTransformer.Transform(navInputXml, args, myWriter);
                    myWriter.Flush();
                    transformedStream.Position = 0;
                }
                return transformedStream;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, "DocxExtractor: TransformXml");
                return null;
            }
        }
    }
}
