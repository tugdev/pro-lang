package cookie;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/Cookies")
public class Cookies extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public Cookies() {
		super();

	}

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		boolean cook = true;
		Cookie[] cookies = request.getCookies();

		if (cookies != null) {
			for (Cookie c : cookies) {
				if ((c.getName().equals("visitor"))
						&& c.getValue().equals("yes")) {
					cook = false;
					break;
				}
			}
		}

		String mesaj;
		if (cook) {
			Cookie rvc = new Cookie("visitor", "yes");
			rvc.setMaxAge(60 * 60 * 24 * 365);
			response.addCookie(rvc);
			mesaj = "Merhaba misafir";
		} else

			mesaj = "Taniniyorsun :)";

		PrintWriter out = response.getWriter();
		request.setCharacterEncoding("UTF-8");
		out.println("<!DOCTYPE html>\n"
				+ "<html>\n"
				+ "<head><title>Cookies</title></head>\n"
				+ "<body style = \" margin-top:50px;margin-left: 3.5in\">\n"
				+ "<link href='http://twitter.github.com/bootstrap/assets/css/bootstrap.css' rel='stylesheet'>"
				+ "<div class = hero-unit style = width:600px;height:200px;margin-left:1in;margin-top:1in>"
				+ "<h1 style = \"color:#FF6666;\">" + mesaj + "</h1><br>");

	}

}