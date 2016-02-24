<?xml version="1.0" encoding="UTF-8"?>
<!--
	Copyright DITA Exchange ApS 2016. Visit us at
	http://www.ditaexchange.com
	
	This stylesheet only performs the very basic extraction.
	For advanced use, you wil have to 
	
	Freely available under the GNU GPL v. 3, see
	http://www.gnu.org/licenses/gpl.txt
	
	Revisions:
	2016-02-18/srf: Initial version
-->

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:dxext="urn:dxext:xslt:ext" extension-element-prefixes="dxext"
	xmlns:ve="http://schemas.openxmlformats.org/markup-compatibility/2006"
	xmlns:o="urn:schemas-microsoft-com:office:office"
	xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
	xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math"
	xmlns:v="urn:schemas-microsoft-com:vml"
	xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"
	xmlns:w10="urn:schemas-microsoft-com:office:word"
	xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main"
	xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml"
	xmlns:pkg="http://schemas.microsoft.com/office/2006/xmlPackage"
	xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	xmlns:wp14="http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing"
	xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml"
	xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup"
	xmlns:wpi="http://schemas.microsoft.com/office/word/2010/wordprocessingInk"
	xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape"
	xmlns:a="http://schemas.openxmlformats.org/drawingml/2006/main"
	xmlns:pic="http://schemas.openxmlformats.org/drawingml/2006/picture"
	xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas"
	xmlns:ct="http://schemas.microsoft.com/2006/09/sip/commontypes"
	xmlns:ma="http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes"
	xmlns:ds="http://www.w3.org/2000/09/xmldsig#"
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
	xmlns:w15="http://schemas.microsoft.com/office/word/2012/wordml"
	xmlns:ns1="http://schemas.microsoft.com/sharepoint/v3"
	xmlns:ns2="e20d0584-76bd-4ce1-8e5a-f12f0528cb34"
	xmlns:ns4="c241e890-5fd2-4858-97dd-cd37f176e2d6"
	exclude-result-prefixes="ve o r m v wp w10 w wne pkg mc wp14 w14 w15 wpg wpi wps ct ma ds xsi ns1 ns2 ns4">
	<xsl:output method="xml" encoding="UTF-8" indent="yes"/>

	<xsl:template match="/">
		<xsl:element name="DocxExtractor">
			<xsl:apply-templates/>
		</xsl:element>
	</xsl:template>
	
	<xsl:template match="w:sdt">
		<xsl:variable name="tagalias"><xsl:value-of select="descendant::w:alias[1]/@w:val"/></xsl:variable>
		<xsl:variable name="tag"><xsl:value-of select="descendant::w:tag[1]/@w:val"/></xsl:variable>
		<xsl:variable name="taginnertext"><xsl:value-of select="normalize-space(string(.))"/></xsl:variable>
		<xsl:element name="DocxTag">
			<xsl:attribute name="alias"><xsl:value-of select="$tagalias"/></xsl:attribute>
			<xsl:attribute name="tag"><xsl:value-of select="$tag"/></xsl:attribute>
			<xsl:value-of select="$taginnertext"/>		
			<xsl:apply-templates/>
		</xsl:element>
	</xsl:template>
	
	<xsl:template match="text() | @*">
		<!--do nothing-->
	</xsl:template>
	
	<xsl:template match="*">
		<xsl:apply-templates/>
	</xsl:template>

</xsl:stylesheet>
