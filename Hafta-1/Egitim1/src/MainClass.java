
public class MainClass {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Araba arb = new Araba("Dizel");
		arb.Agirlik = 121.1;
		arb.Hacim = 11.7;
		arb.Marka = "Auid";
		arb.Model = "A5";
		arb.setTekerSayisi(4);
		System.out.println(arb.Goster()); 
		
		System.out.println( "Araban�n Teker Sayisi: " + arb.getTekerSayisi() + " Arabanin a��rl��� " + arb.Agirlik + " Arabanin Hacmi" + arb.Hacim
				+ " Araban�n Markasi " + arb.Marka + " Arabanin Modeli: " + arb.Model );
		
		System.out.println(arb.Calis());
		System.out.println(arb.HareketEt()); 
		System.out.println(arb.Dur());
		
		

	}

}
