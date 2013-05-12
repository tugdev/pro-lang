<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
<HEAD>
<TITLE>Baked Bean Values: request-based Sharing</TITLE>
<LINK REL=STYLESHEET HREF="JSP-Styles.css" TYPE="text/css">
</HEAD>
<BODY>
	<H1>Baked Bean request</H1>
	<jsp:useBean id="requestBean" class="beans.BakedBean" scope="request" />
	<jsp:setProperty name="requestBean" property="*" />
	<H2>
		Sehir:
		<jsp:getProperty name="requestBean" property="city" /></H2>
	<H2>
		Universite:
		<jsp:getProperty name="requestBean" property="university" /></H2>
	<%-- <jsp:include page="/WEB-INF/includes/BakedBeanDisplay-snippet.jsp" /> --%>
</BODY>
</HTML>