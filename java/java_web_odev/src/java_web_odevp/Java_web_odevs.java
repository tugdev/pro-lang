package java_web_odevp;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/Java_web_odevs")
public class Java_web_odevs extends HttpServlet {
	private static final long serialVersionUID = 1L;


	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {

		response.setCharacterEncoding("UTF-8");
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html>\n"
				+ "<html>\n"
				+ "<head><title>Kisiler</title></head>\n"
				+ "<body style = \" background-color:#996699\">\n"
				+ "<div style=\" width: 500px; margin: 100px auto; padding: 10px 30px; border: 1px solid #e1e1e1; background: white;\""
				+ "</head></body>");

		Ogrenci tugdev = new Ogrenci();
		tugdev.OgrenciBilgisi(10060276, "Bilgisayar Muhendisligi", 3);
		out.println("ogrenci Numaram : " + tugdev.getOgrenciNosu());
		out.println("<br>Bolumum : " + tugdev.getBolum());
		out.println("<br>Sinifim : " + tugdev.getsinif());
		out.println("<br>dersteyim " + tugdev.derse_gir());
		out.println("<br>kantindeyim " + tugdev.kantine_git());

		// *******************
		out.println("<br><br><br>");
		// *******************

		Hoca hoca1 = new Hoca();
		hoca1.HocaBilgisi(12345, "Bilgisayar Muhendisligi");
		out.println("hocanin sicil numarasi : " + hoca1.getSicilNo());
		out.println("<br>Bolumu : " + hoca1.getBolum());
		out.println("<br>Dersteyim " + hoca1.ders_yap());
		out.println("<br>Sinav yapiyorum " + hoca1.Sinav_yap());

		// *******************
		out.println("<br><br><br>");
		// *******************

		
		Memur memur1 = new Memur();
		memur1.MemurBilgisi(12345, "Muhendislik dekanligi");
		out.println("memurun sicil numarasi : " + memur1.getMSicilNo());
		out.println("<br>birimi : " + memur1.getBirim());
		out.println("<br>Rektorlukten " + memur1.Evrak_getir());
		out.println("<br>Fakulteden " + memur1.Evrak_gotur());

	}

}
