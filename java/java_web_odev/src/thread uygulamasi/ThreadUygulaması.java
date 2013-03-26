
public class ThreadUygulaması {

	
	
	public static void main(String[] args)
	{
		Thread thread1=new threadOrnek("1.thread");
		Thread thread2=new threadOrnek("2.thread");
		thread2.stop();
		Thread thread3=new threadOrnek("3.thread");
		Thread thread4=new threadOrnek("4.thread");
		//2. nesneyi durdur
	}
}
class threadOrnek extends Thread{
	threadOrnek(String isim)
	{
		super(isim);
		start();
		//baslat
	}public void run(){
		System.out.println(Thread.currentThread().getName());
		//calısır olanı ekrana yaz
	}
	
}