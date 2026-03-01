# SaxonXsltProcessor

Sample project that demonstrates transforming an XML user data file into different output formats using XSLT.

This repository contains a small console app (`SaxonXsltProcessor`) and a library (`Saxon.XML`) that perform XSLT-based transforms. By default the project uses .NET's `XslCompiledTransform` to produce HTML and CSV output from an input XML file using provided XSL stylesheets.

## Features

- Transform `XML/users.xml` into `HTML` (`html.xsl`) and `CSV` (`csv.xsl`).
- Simple console runner that resolves files relative to the project root and writes outputs to the `XML` folder.

## Prerequisites

- .NET 10 SDK
- (Optional) If you want to use Saxon-CS instead of the built-in .NET XSLT engine, follow Saxonica's documentation and provide a valid `saxon-license.lic` for licensed features.

## Build and run

From the repository root you can build and run the console app:

```
dotnet build
dotnet run --project SaxonXsltProcessor/SaxonXsltProcessor.csproj
```

The app expects the sample input and XSL files to be located in the `XML` folder next to the project root:

```
XML/
  users.xml      # input data
  html.xsl       # stylesheet -> HTML
  csv.xsl        # stylesheet -> CSV
```

Output files are written to the same `XML` folder (e.g. `output.html`, `output.csv`).

## Notes

- The project originally experimented with Saxon-CS; that may require a license file. The current implementation uses `XslCompiledTransform` (XSLT 1.0) which does not require external licensing. If your stylesheets rely on XSLT 2.0/3.0 features you will need to switch to Saxon and provide a license or use a Saxon-licensed runtime.
- To add JSON output or additional transforms, add another XSL stylesheet and call the transformer from `Program.cs`.

## License

This sample is provided as-is for demonstration purposes.

