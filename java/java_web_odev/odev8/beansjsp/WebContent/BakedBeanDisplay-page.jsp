<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>
<TITLE>Baked Bean Values: page-based Sharing</TITLE>
<LINK REL=STYLESHEET HREF="JSP-Styles.css" TYPE="text/css">
</HEAD>
<BODY>
	<H1>Baked Bean page</H1>
	<jsp:useBean id="pageBean" class="beans.BakedBean" />
	<jsp:setProperty name="pageBean" property="*" />
	<H2>
		Sehir:
		<jsp:getProperty name="pageBean" property="city" /></H2>
	<H2>
		Universite:
		<jsp:getProperty name="pageBean" property="university" /></H2>
</BODY>
</HTML>