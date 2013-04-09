package encodingpacket;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class EncodingOrnek
 */
@WebServlet("/EncodingOrnek")
public class EncodingOrnek extends HttpServlet {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		PrintWriter out;
		if (GzipUtilities.isGzipSupported(request) && !GzipUtilities.isGzipDisabled(request)) {
			out = GzipUtilities.getGzipWriter(response);
			response.setHeader("Content-Encoding", "gzip");
		} 
		else {
			out = response.getWriter();
		}
		
		out.println("<HTML>\n" + "<HEAD><TITLE></TITLE></HEAD>\n" +
		"<BODY BGCOLOR=\"#9999FF\">\n" + "<H1 ALIGN=\"CENTER\">Encoding Örneði</H1>\n");
		
		String line = " tugdev ";
		for(int i=0; i<105; i++) {
		out.println(line);
		}
		out.println("</BODY></HTML>");
		out.close();
		
	}
}

	


