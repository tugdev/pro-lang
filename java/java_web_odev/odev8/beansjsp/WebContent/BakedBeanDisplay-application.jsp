<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>
<TITLE>Baked Bean Values: application-based Sharing</TITLE>
<LINK REL=STYLESHEET HREF="JSP-Styles.css" TYPE="text/css">
</HEAD>
<BODY>
	<H1>Baked Bean application</H1>
	<jsp:useBean id="applicationBean" class="beans.BakedBean"
		scope="application" />
	<jsp:setProperty name="applicationBean" property="*" />
	<H2>
		Sehir:
		<jsp:getProperty name="applicationBean" property="city" /></H2>
	<H2>
		Universite:
		<jsp:getProperty name="applicationBean" property="university" /></H2>
</BODY>
</HTML>