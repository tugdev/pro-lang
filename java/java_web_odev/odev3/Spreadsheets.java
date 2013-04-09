package spreadsheets;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/Spreadsheets")
public class Spreadsheets extends HttpServlet {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	//	PrintWriter out = response.getWriter();
		response.setContentType("application/msword");
		PrintWriter out = response.getWriter();
		out.println("\tQ1\tQ2\tQ3\tQ4\tTotal");
		out.println
		("Apples\t78\t87\t92\t29\t=SUM(B2:E2)");
		out.println
		("Oranges\t77\t86\t93\t30\t=SUM(B3:E3)");
	}
}
