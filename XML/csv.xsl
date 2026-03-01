<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="3.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    
    <xsl:output method="text" encoding="UTF-8"/>

    <xsl:template match="/">
        <xsl:text>Name,Email,Phone&#10;</xsl:text>

        <xsl:for-each select="UserList/User">
            <xsl:value-of select="Name"/>
            <xsl:text>,</xsl:text>

            <xsl:value-of select="Email"/>
            <xsl:text>,</xsl:text>

            <xsl:value-of select="Phone"/>
            <xsl:text>&#10;</xsl:text>
        </xsl:for-each>
    </xsl:template>

</xsl:stylesheet>