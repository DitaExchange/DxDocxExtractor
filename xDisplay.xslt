<!--
 | XSLT REC Compliant Version of IE5 Default Stylesheet
 |
 | Original version by Jonathan Marsh (jmarsh@xxxxxxxxxxxxx)
 | http://msdn.microsoft.com/xml/samples/defaultss/defaultss.xsl
 |
 | Conversion to XSLT 1.0 REC Syntax by Steve Muench (smuench@xxxxxxxxxx)
 | 
 | Multiple fixes, corrections and customizations by srf@ditaexchange.com
 |
 +-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output
        indent="no"
				method="html"
				doctype-public="-//W3C//DTD Xhtml 1.0 Transitional//EN"
				doctype-system="http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd" />

  <xsl:template match="/">
    <html>
      <head>
        <script type="text/javascript">
          <xsl:comment>
            <![CDATA[
                  function f(e){
                     if (e.className=="ci") {
                       if (e.children(0).innerText.indexOf("\n")>0) fix(e,"cb");
                     }
                     if (e.className=="di") {
                       if (e.children(0).innerText.indexOf("\n")>0) fix(e,"db");
                     } e.id="";
                  }
                  function fix(e,cl){
                    e.className=cl;
                    e.style.display="block";
                    j=e.parentElement.children(0);
                    j.className="c";
                    k=j.children(0);
                    k.style.visibility="visible";
                    k.href="#";
                  }
                  function ch(e) {
                    mark=e.children(0).children(0);
                    if (mark.innerText=="+") {
                      mark.innerText="-";
                      for (var i=1;i<e.children.length;i++) {
                        e.children(i).style.display="block";
                      }
                    }
                    else if (mark.innerText=="-") {
                      mark.innerText="+";
                      for (var i=1;i<e.children.length;i++) {
                        e.children(i).style.display="none";
                      }
                    }
                  }
                  function ch2(e) {
                    mark=e.children(0).children(0);
                    contents=e.children(1);
                    if (mark.innerText=="+") {
                      mark.innerText="-";
                      if (contents.className=="db"||contents.className=="cb") {
                        contents.style.display="block";
                      }
                      else {
                        contents.style.display="inline";
                      }
                    }
                    else if (mark.innerText=="-") {
                      mark.innerText="+";
                      contents.style.display="none";
                    }
                  }
                  function cl() {
                    e=window.event.srcElement;
                    if (e.className!="c") {
                      e=e.parentElement;
                      if (e.className!="c") {
                        return;
                      }
                    }
                    e=e.parentElement;
                    if (e.className=="e") {
                      ch(e);
                    }
                    if (e.className=="k") {
                      ch2(e);
                    }
                  }
                  function ex(){}
                  function h(){window.status=" ";}
                  
                  document.onclick=cl;
                    ]]>
          </xsl:comment>
        </script>
        <style type="text/css">
          body {font-family:'Segoe UI'; font-size:x-small; margin-right:1.5em; margin-top: 44px;}
          .c  {cursor:hand}
          .b  {color:#808080; font-family:'Segoe UI'; font-size:x-small; text-decoration:none}
          .e  {margin-left:1em; text-indent:-1em; margin-right:1em}
          .k  {margin-left:1em; text-indent:-1em; margin-right:1em}
          .t  {color:#808080}
          .xt {color:#808080}
          .ns {color:#808080}
          .dt {color:#808080}
          .m  {color:#808080}
          .tx {color:#000000; font-family:'Segoe UI'; font-size:x-small; text-decoration:none}
          .db {text-indent:0px; margin-left:1em; margin-top:0px; margin-bottom:0px; padding-left:.3em; border-left:1px solid #CCCCCC; font-family:'Segoe UI'; font-size:x-small}
          .di {font-family:'Segoe UI'; font-size:x-small}
          .d  {color:#808080}
          .pi {color:#808080}
          .cb {text-indent:0px; margin-left:1em; margin-top:0px; margin-bottom:0px;padding-left:.3em; font-family:'Segoe UI'; font-size:x-small; color:#888888}
          .ci {font-family:'Segoe UI'; font-size:x-small; color:#888888}
          pre {margin:0px; display:inline}
          .label {padding-left:20px; vertical-align: middle}
          .validation {color: white; padding: 3px; margin: 5px 5px 5px 5px; text-indent: 0}
          .summary {position: fixed; top: 0; left: 0; margin: 0px; padding-top: 10px; width: 100%; height: 32px; font-size: 12pt; vertical-align: middle;border-bottom: 2px solid black}
          .nav {float: right; padding-right:20px;}
          .failure {background: red;}
          .success {background: green;}
          .warning {background: yellow; color: black}
          .selected {text-indent: 1em}
        </style>
      </head>
      <body class="st">
        <xsl:apply-templates/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="processing-instruction()">
    <div class="e">
      <span class="b">
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">nbsp</xsl:with-param>
        </xsl:call-template>
      </span>
      <span class="m">
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">lt</xsl:with-param>
        </xsl:call-template>?
      </span>
      <span class="pi">
        <xsl:value-of select="name(.)"/>
      </span>
      <span>
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">nbsp</xsl:with-param>
        </xsl:call-template>
        <xsl:value-of select="."/>
      </span>
      <span class="m">
        <xsl:text>?></xsl:text>
      </span>
    </div>
  </xsl:template>
  <xsl:template match="processing-instruction('xml')">
    <div class="e">
      <span class="b">
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">nbsp</xsl:with-param>
        </xsl:call-template>
      </span>
      <span class="m">
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">lt</xsl:with-param>
        </xsl:call-template>?
      </span>
      <span class="pi">
        <xsl:text>xml </xsl:text>
        <xsl:for-each select="@*">
          <xsl:value-of select="name(.)"/>
          <xsl:text>="</xsl:text>
          <xsl:value-of select="."/>
          <xsl:text>" </xsl:text>
        </xsl:for-each>
      </span>
      <span class="m">
        <xsl:text>?></xsl:text>
      </span>
    </div>
  </xsl:template>
  <xsl:template match="@*">
    <span>
      <xsl:attribute name="class">
        <xsl:if test="xsl:*/@*">
          <xsl:text>x</xsl:text>
        </xsl:if>
        <xsl:text>t</xsl:text>
      </xsl:attribute>
      <xsl:call-template name="entity-ref">
        <xsl:with-param name="name">nbsp</xsl:with-param>
      </xsl:call-template>
      <xsl:value-of select="name(.)"/>
    </span>
    <span class="m">="</span>
    <span class="tx">
      <xsl:value-of select="."/>
    </span>
    <span class="m">"</span>
  </xsl:template>
  <xsl:template match="text()">
    <div class="e">
      <span class="b"> </span>
      <span class="tx">
        <xsl:value-of select="."/>
      </span>
    </div>
  </xsl:template>
  <xsl:template match="comment()">
    <div class="k">
      <span>
        <a STYLE="visibility:hidden" class="b" onclick="return false" onfocus="h()">-</a>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>!--
        </span>
      </span>
      <span class="ci" id="clean">
        <pre>
          <xsl:value-of select="."/>
        </pre>
      </span>
      <span class="b">
        <xsl:call-template name="entity-ref">
          <xsl:with-param name="name">nbsp</xsl:with-param>
        </xsl:call-template>
      </span>
      <span class="m">
        <xsl:text>--></xsl:text>
      </span>
      <script type="text/javascript">f(clean);</script>
    </div>
  </xsl:template>
  <xsl:template match="*">
    <div class="e">
      <div STYLE="margin-left:1em;text-indent:-2em">
        <span class="b">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">nbsp</xsl:with-param>
          </xsl:call-template>
        </span>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>
        </span>
        <span>
          <xsl:attribute name="class">
            <xsl:if test="xsl:*">
              <xsl:text>x</xsl:text>
            </xsl:if>
            <xsl:text>t</xsl:text>
          </xsl:attribute>
          <xsl:value-of select="name(.)"/>
          <xsl:if test="@*">
            <xsl:text> </xsl:text>
          </xsl:if>
        </span>
        <xsl:apply-templates select="@*"/>
        <span class="m">
          <xsl:text>/></xsl:text>
        </span>
      </div>
    </div>
  </xsl:template>
  <xsl:template match="*[node()]">
    <div class="e">
      <div class="c">
        <a class="b" href="#" onclick="return false" onfocus="h()">-</a>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>
        </span>
        <span>
          <xsl:attribute name="class">
            <xsl:if test="xsl:*">
              <xsl:text>x</xsl:text>
            </xsl:if>
            <xsl:text>t</xsl:text>
          </xsl:attribute>
          <xsl:value-of select="name(.)"/>
          <xsl:if test="@*">
            <xsl:text> </xsl:text>
          </xsl:if>
        </span>
        <xsl:apply-templates select="@*"/>
        <span class="m">
          <xsl:text>></xsl:text>
        </span>
      </div>
      <div>
        <xsl:apply-templates/>
        <div>
          <span class="b">
            <xsl:call-template name="entity-ref">
              <xsl:with-param name="name">nbsp</xsl:with-param>
            </xsl:call-template>
          </span>
          <span class="m">
            <xsl:call-template name="entity-ref">
              <xsl:with-param name="name">lt</xsl:with-param>
            </xsl:call-template>?/
          </span>
          <span>
            <xsl:attribute name="class">
              <xsl:if test="xsl:*">
                <xsl:text>x</xsl:text>
              </xsl:if>
              <xsl:text>t</xsl:text>
            </xsl:attribute>
            <xsl:value-of select="name(.)"/>
          </span>
          <span class="m">
            <xsl:text>></xsl:text>
          </span>
        </div>
      </div>
    </div>
  </xsl:template>
  <xsl:template match="*[text() and not (comment() or processing-instruction())]">
    <div class="e">
      <div STYLE="margin-left:1em;text-indent:-2em">
        <span class="b">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">nbsp</xsl:with-param>
          </xsl:call-template>
        </span>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>
        </span>
        <span>
          <xsl:attribute name="class">
            <xsl:if test="xsl:*">
              <xsl:text>x</xsl:text>
            </xsl:if>
            <xsl:text>t</xsl:text>
          </xsl:attribute>
          <xsl:value-of select="name(.)"/>
          <xsl:if test="@*">
            <xsl:text> </xsl:text>
          </xsl:if>
        </span>
        <xsl:apply-templates select="@*"/>
        <span class="m">
          <xsl:text>></xsl:text>
        </span>
        <span class="tx">
          <xsl:value-of select="."/>
        </span>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>/
        </span>
        <span>
          <xsl:attribute name="class">
            <xsl:if test="xsl:*">
              <xsl:text>x</xsl:text>
            </xsl:if>
            <xsl:text>t</xsl:text>
          </xsl:attribute>
          <xsl:value-of select="name(.)"/>
        </span>
        <span class="m">
          <xsl:text>></xsl:text>
        </span>
      </div>
    </div>
  </xsl:template>
  <xsl:template match="*[*]" priority="20">
    <div class="e">
      <div STYLE="margin-left:1em;text-indent:-2em" class="c">
        <a class="b" href="#" onclick="return false" onfocus="h()">-</a>
        <span class="m">
          <xsl:call-template name="entity-ref">
            <xsl:with-param name="name">lt</xsl:with-param>
          </xsl:call-template>
        </span>
        <span>
          <xsl:attribute name="class">
            <xsl:if test="xsl:*">
              <xsl:text>x</xsl:text>
            </xsl:if>
            <xsl:text>t</xsl:text>
          </xsl:attribute>
          <xsl:value-of select="name(.)"/>
          <xsl:if test="@*">
            <xsl:text> </xsl:text>
          </xsl:if>
        </span>
        <xsl:apply-templates select="@*"/>
        <span class="m">
          <xsl:text>></xsl:text>
        </span>
      </div>
      <div>
        <xsl:apply-templates/>
        <div>
          <span class="b">
            <xsl:call-template name="entity-ref">
              <xsl:with-param name="name">nbsp</xsl:with-param>
            </xsl:call-template>
          </span>
          <span class="m">
            <xsl:call-template name="entity-ref">
              <xsl:with-param name="name">lt</xsl:with-param>
            </xsl:call-template>/
          </span>
          <span>
            <xsl:attribute name="class">
              <xsl:if test="xsl:*">
                <xsl:text>x</xsl:text>
              </xsl:if>
              <xsl:text>t</xsl:text>
            </xsl:attribute>
            <xsl:value-of select="name(.)"/>
          </span>
          <span class="m">
            <xsl:text>></xsl:text>
          </span>
        </div>
      </div>
    </div>
  </xsl:template>

  <xsl:template name="entity-ref">
    <xsl:param name="name"/>
    <xsl:text disable-output-escaping="yes">&amp;</xsl:text>
    <xsl:value-of select="$name"/>
    <xsl:text>;</xsl:text>
  </xsl:template>
</xsl:stylesheet>
