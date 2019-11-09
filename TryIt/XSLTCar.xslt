<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <xsl:template match="/">
      <html>
        <head>
          <title>Cars</title>
        </head>
        <body>
          <table border="1">
              <tr>
                <td><b>Color</b></td>
                <td><b>Brand</b></td>
                <td><b>Model</b></td>
                <td><b>Year</b></td>
                <td><b>Vin</b></td>
                <td><b>Gas Type</b></td>
                <td><b>Engine Size</b></td>
                <td><b>Engine Valves</b></td>
                <td><b>Cylinders</b></td>
                <td><b>Owners</b></td>
              </tr>
            <xsl:for-each select="Cars/Car">
              <tr style="font-size: 10pt; font-family: verdana">
              <td><xsl:value-of select="@Color"></xsl:value-of></td>
              <td><xsl:value-of select="Brand"></xsl:value-of></td>
              <td><xsl:value-of select="Model"></xsl:value-of></td>
              <td><xsl:value-of select="Year"></xsl:value-of></td>
              <td><xsl:value-of select="Vin"></xsl:value-of></td>
              <td><xsl:value-of select="Engine/Fuel/Type"></xsl:value-of></td>
              <td><xsl:value-of select="Engine/Size"></xsl:value-of></td>
              <td><xsl:value-of select="Engine/@Valves"></xsl:value-of></td>
              <td><xsl:value-of select="Engine/Cylinders"></xsl:value-of></td>
              <td>
                <xsl:for-each select="Owner">
                  <p>
                    <xsl:value-of select="First"></xsl:value-of>
                    <xsl:value-of select="Last"></xsl:value-of>
                  </p>
                </xsl:for-each>
              </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
