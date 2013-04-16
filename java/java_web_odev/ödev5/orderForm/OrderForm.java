package orderForm;

import java.io.*;
import javax.servlet.*;
import javax.servlet.annotation.*;
import javax.servlet.http.*;
import java.util.*;



@WebServlet("/show-items")
public class OrderForm extends HttpServlet {
  /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

@Override
  public void doPost (HttpServletRequest request,
                      HttpServletResponse response)
      throws ServletException, IOException {
    HttpSession session = request.getSession();
    synchronized(session) {
      @SuppressWarnings("unchecked")
      List<String> previousItems =
        (List<String>)session.getAttribute("previousItems");
      if (previousItems == null) {
        previousItems = new ArrayList<String>();
      }
      String newItem = request.getParameter("newItem");
      if ((newItem != null) &&
          (!newItem.trim().equals(""))) {
        previousItems.add(newItem);
      }
      session.setAttribute("previousItems", previousItems);
      response.setContentType("text/html");
      PrintWriter out = response.getWriter();
      String title = "Alinan ürünler";
      String docType =
        "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 " +
        "Transitional//EN\">\n";
      out.println(docType +
                  "<HTML>\n" +
                  "<HEAD><TITLE>" + title + "</TITLE></HEAD>\n" +
                  "<BODY BGCOLOR=\"#FDF5E6\">\n" +
                  "<H1>" + title + "</H1>");
      if (previousItems.size() == 0) {
        out.println("<I>No items</I>");
      } else {
        out.println("<UL>");
        for(String item: previousItems) {
          out.println("  <LI>" + item);
        }
        out.println("</UL>");
      }
      out.println("</BODY></HTML>");
    }
  }
}
