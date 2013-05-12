<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>
<TITLE>Baked Bean Values: session-based Sharing</TITLE>
<LINK REL=STYLESHEET HREF="JSP-Styles.css" TYPE="text/css">
</HEAD>
<BODY>
	<H1>Baked Bean session</H1>
	<jsp:useBean id="sessionBean" class="beans.BakedBean" scope="session" />
	<jsp:setProperty name="sessionBean" property="*" />
	<H2>
		Sehir:
		<jsp:getProperty name="sessionBean" property="city" /></H2>
	<H2>
		Universite:
		<jsp:getProperty name="sessionBean" property="university" /></H2>
</BODY>
</HTML>