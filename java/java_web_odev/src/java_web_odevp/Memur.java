package java_web_odevp;

//import Kisi.Hoca;

public class Memur extends Hoca {
	private int MemurSicilNo;
	String Birim;
	public void MemurBilgisi(int M_SicilNo, String Birim){
		this.MemurSicilNo = M_SicilNo;
		this.Birim = Birim;
		System.out.println("Memur SicilNumarasý = "+ this.MemurSicilNo +" Birim = "+ this.Birim );
	}
	
	public int getMSicilNo() {
		return MemurSicilNo;
	}
	public String getBirim() {
		return Birim;
	}
	
	public String Evrak_getir(){
		return "Evrak getiriyorum";
	}
	public String Evrak_gotur(){
		return "Evrak goturuyorum";
	}


}