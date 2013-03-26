package java_web_odevp;

//import Kisi.Ogrenci;

class Hoca extends Ogrenci {
	private int Sicil_No;
	String Bolum;

	public void HocaBilgisi(int Sicil_No, String Bolum) {
		this.Sicil_No = Sicil_No;
		this.Bolum = Bolum;
		//System.out.println("SicilNo = "+ this.Sicil_No +" Bolum = "+ this.Bolum );
	}
	public int getSicilNo() {
		return Sicil_No;
	}
	public String getBolum() {
		return Bolum;
	}
	
	public String ders_yap() {
		return " rahatsiz etmeyin";
	}

	public String Sinav_yap() {
		return " rahatsiz etmeyin";
	}

}