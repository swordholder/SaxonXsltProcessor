namespace XsltProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string baseDir = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                if (baseDir == null || !Directory.Exists(baseDir))
                {
                    throw new Exception($"Path {baseDir} not found.");
                }

                //input xml file
                var xmlPath = Path.GetFullPath(Path.Combine(baseDir, "XML", "users.xml"));

                //XSL and output paths for HTML
                var htmlXslPath = Path.GetFullPath(Path.Combine(baseDir, "XML", "html.xsl"));                
                var outputPathHtml = Path.GetFullPath(Path.Combine(baseDir, "XML", "output.html"));

                //XSL and output paths for CSV
                var csvXslPath = Path.GetFullPath(Path.Combine(baseDir, "XML", "csv.xsl"));
                var outputPathCsv = Path.GetFullPath(Path.Combine(baseDir, "XML", "output.csv"));

                //XSL and output paths for JSON
                var jsonXslPath = Path.GetFullPath(Path.Combine(baseDir, "XML", "json.xsl"));
                var outputPathJson = Path.GetFullPath(Path.Combine(baseDir, "XML", "output.json"));

                var reader = new Saxon.XML.XmlTransformer();

                reader.TransformXml(xmlPath, htmlXslPath, outputPathHtml);
                reader.TransformXml(xmlPath, csvXslPath, outputPathCsv);
                reader.TransformXml(xmlPath, jsonXslPath, outputPathJson);

                Console.WriteLine("Transformation completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
