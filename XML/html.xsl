<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="3.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes" html-version="5.0"/>

    <xsl:template match="/">
        <html>
            <head>
                <title>User Report</title>
                <style>
                    body { font-family: sans-serif; margin: 40px; }
                    table { width: 100%; border-collapse: collapse; }
                    th, td { border: 1px solid #ccc; padding: 10px; text-align: left; }
                    th { background: #f4f4f4; }
                </style>
            </head>
            <body>
                <h1>User Directory</h1>
                <table>
                    <tr><th>Name</th><th>Email</th><th>Phone</th></tr>
                    <xsl:for-each select="UserList/User">
                        <tr>
                            <td><xsl:value-of select="Name"/></td>
                            <td><xsl:value-of select="Email"/></td>
                            <td><xsl:value-of select="Phone"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>