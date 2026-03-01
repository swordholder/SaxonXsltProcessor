<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="3.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    
    <xsl:output method="text" encoding="UTF-8"/>

    <xsl:template match="/">
        <xsl:text>[</xsl:text>
        <xsl:for-each select="UserList/User">
            <xsl:text>&#10;  {</xsl:text>
            <xsl:text>&#10;    "name": "</xsl:text><xsl:value-of select="Name"/><xsl:text>",</xsl:text>
            <xsl:text>&#10;    "email": "</xsl:text><xsl:value-of select="Email"/><xsl:text>",</xsl:text>
            <xsl:text>&#10;    "phone": "</xsl:text><xsl:value-of select="Phone"/><xsl:text>"</xsl:text>
            <xsl:text>&#10;  }</xsl:text>
            <xsl:if test="position() != last()">
                <xsl:text>,</xsl:text>
            </xsl:if>
        </xsl:for-each>
        <xsl:text>&#10;]</xsl:text>
    </xsl:template>

</xsl:stylesheet>