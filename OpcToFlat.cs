using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.IO.Packaging;
using System.Xml;

namespace Dx
{
    static class OpcToFlat
    {
        static XElement GetContentsAsXml(PackagePart part)
        {
            XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

            if (part.ContentType.EndsWith("xml"))
            {
                using (Stream str1 = part.GetStream())
                using (StreamReader streamReader = new StreamReader(str1))
                using (XmlReader xr = XmlReader.Create(streamReader))
                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XElement(pkg + "xmlData",
                            XElement.Load(xr)
                        )
                    );
            }
            else
            {
                using (Stream str = part.GetStream())
                using (BinaryReader binaryReader = new BinaryReader(str))
                {
                    int len = (int)binaryReader.BaseStream.Length;
                    byte[] byteArray = binaryReader.ReadBytes(len);
                    // the following expression creates the base64String, then chunks
                    // it to lines of 76 characters long
                    string base64String = (System.Convert.ToBase64String(byteArray))
                        .Select
                        (
                            (c, i) => new
                            {
                                Character = c,
                                Chunk = i / 76
                            }
                        )
                        .GroupBy(c => c.Chunk)
                        .Aggregate(
                            new StringBuilder(),
                            (s, i) =>
                                s.Append(
                                    i.Aggregate(
                                        new StringBuilder(),
                                        (seed, it) => seed.Append(it.Character),
                                        sb => sb.ToString()
                                    )
                                )
                                .Append(Environment.NewLine),
                            s => s.ToString()
                        );
                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XAttribute(pkg + "compression", "store"),
                        new XElement(pkg + "binaryData", base64String)
                    );
                }
            }
        }

        public static XDocument ConvertOpcToFlat(string path)
        {
            using (Package package = Package.Open(path))
            {
                XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

                XDeclaration declaration = new XDeclaration("1.0", "UTF-8", "yes");

                XDocument doc = new XDocument(
                    declaration,
                    new XProcessingInstruction("mso-application", "progid=\"Word.Document\""),
                    new XElement(pkg + "package", new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                        package.GetParts().Select(part => GetContentsAsXml(part))
                    )
                );
                return doc;
            }
        }
        public static XDocument ConvertOpcToFlat(Stream myStream)
        {
            using (Package package = Package.Open(myStream))
            {
                XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";

                XDeclaration declaration = new XDeclaration("1.0", "UTF-8", "yes");

                XDocument doc = new XDocument(
                    declaration,
                    new XProcessingInstruction("mso-application", "progid=\"Word.Document\""),
                    new XElement(pkg + "package", new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                        package.GetParts().Select(part => GetContentsAsXml(part))
                    )
                );
                return doc;
            }
        }

    }
}