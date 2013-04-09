package java_web_odevp;

//import Kisi.Kisi;

public class Ogrenci extends Kisi {
	int OgrenciNo;
	String Bolum;
	int Sinifi;

	public void OgrenciBilgisi(int OgrenciNo, String Bolum, int Sinifi) {
		this.OgrenciNo = OgrenciNo;
		this.Bolum = Bolum;
		this.Sinifi = Sinifi;
		//System.out.println("OgrenciNo = "+ this.OgrenciNo +" Bolum = "+ this.Bolum +" Sinifi  = "+ this.Sinifi   );
	}
	
	
	public int getOgrenciNosu() {
		return OgrenciNo;
	}
	public String getBolum() {
		return Bolum;
	}
	public int getsinif() {
		return Sinifi;
	}

	public String  derse_gir() {
		return "rahatsiz etmeyin";
	}

	public String kantine_git() {
		return " cay iciyorum";
	}

}