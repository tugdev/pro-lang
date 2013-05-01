<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<!-- <link href="http://twitter.github.com/bootstrap/assets/css/bootstrap.css" rel="stylesheet"> -->
<link rel="stylesheet" href="css/bootstrap.css">
<link rel="stylesheet" href="css/bootstrap-responsive.css">
<link rel="stylesheet" href="css/docs.css">
<title>Request_Parameter_With_Jsp</title>
</head>
<body>

<div style = "margin-left:1in;margin-top: 1in">
<table class="table">
	<thead>
        <tr>
			<th>Parameter Name</th>
			<th>Parameter Value(s)</th>
	   </tr>
    </thead>
    
       <tbody>
                <tr class="success">
                  <td>ISIM</td>
                  <td><%=request.getParameter("isim") %></td>
                 
                </tr>
                
                <tr class="error">
                  <td>SOYISIM</td>
                  <td><%= request.getParameter("soyisim") %></td>
                  
                </tr>
                
                <tr class="warning">
                  <td>CINSIYET </td>
                  <td><%= request.getParameter("check") %></td>
                  
                </tr>
                
                <tr class="info">
                  <td>MESLEK</td>
                  <td><%= request.getParameter("meslek") %></td>
                 
                </tr>
                
                <tr class="success">
                  <td>MESAJ</td>
                  <td><%= request.getParameter("mesaj") %></td>
                </tr>
              </tbody>
            </table>
   

</div>
</body>
</html>