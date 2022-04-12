<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

<xsl:template match="/">
  <html>
  <body>
    <h2>Orari</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th>Emri</th>
        <th>NrViti</th>
      </tr>
      <xsl:for-each select="Orari/row">
        <tr>
          <td><xsl:value-of select="Emri"/></td>
          <td><xsl:value-of select="NrViti"/></td>
        </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>
