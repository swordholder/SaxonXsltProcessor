using System.Xml;
using System.Xml.Xsl;

namespace Saxon.XML
{
    public class XmlTransformer
    {
        /// <summary>
        /// Reads users from XML and transforms it according to given XSL file.
        /// </summary>
        /// <param name="xmlFilePath"></param>
        public void TransformXml(string xmlFilePath, string xslFilePath, string outputFilePath)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath)) throw new ArgumentException("xmlFilePath is required", nameof(xmlFilePath));
            if (string.IsNullOrWhiteSpace(xslFilePath)) throw new ArgumentException("xslFilePath is required", nameof(xslFilePath));
            if (string.IsNullOrWhiteSpace(outputFilePath)) throw new ArgumentException("outputFilePath is required", nameof(outputFilePath));

            if (!File.Exists(xmlFilePath)) throw new FileNotFoundException("XML input file not found", xmlFilePath);
            if (!File.Exists(xslFilePath)) throw new FileNotFoundException("XSLT file not found", xslFilePath);

            var xslt = new XslCompiledTransform();
            var settings = new XsltSettings(enableDocumentFunction: false, enableScript: false);
            xslt.Load(xslFilePath, settings, new XmlUrlResolver());

            using var reader = XmlReader.Create(xmlFilePath);
            using var writer = XmlWriter.Create(outputFilePath, xslt.OutputSettings);
            xslt.Transform(reader, writer);
        }       
    }
}
