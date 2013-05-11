<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<!-- 
Example of using jsp:plugin for an applet that uses Java 2 or later.
-->
<HTML>
<HEAD>
<TITLE>Using jsp:plugin</TITLE>
<LINK REL=STYLESHEET
      HREF="JSP-Styles.css"
      TYPE="text/css">
</HEAD>
<BODY>
<CENTER>
<TABLE BORDER=5>
  <TR><TH CLASS="TITLE">
      Using jsp:plugin</TABLE>
<P>
<jsp:plugin type="applet" 
            codebase="."
            code="PluginApplet.class"
            width="370" height="420">
</jsp:plugin>
</CENTER></BODY></HTML>