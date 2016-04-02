class Pascoa {
	public static void main ( String [] args ) {
		String s = pascoa (2000) ;
		System.out.println("Páscoa "+s);
		s = pascoa (2012);
		System.out.println("Páscoa "+s);
		s = pascoa (2025) ;
		System . out. println (" Páscoa " + s);
		s = pascoa (2015) ;
		System . out. println (" Páscoa " + s);
	}

	static String pascoa(int ano){
		String data;
		int a = ano % 19;
		int b = ano / 100;
 		int c = ano % 100;
		int d = b / 4;
 		int e = b % 4;
 		int f = (b + 8) / 25;
 		int g = (b - f + 1) / 3;
 		int h = (19 * a + b -d - g + 15) % 30;
 		int i = c / 4;
 		int k = c % 4;
 		int l = (32 + 2 * e + 2 * i - h - k) % 7;
		int m = (a + 11 * h + 22 * l) / 451;
 		int mes = (h + 1 - 7 * m + 114) / 31;
 		int dia = ((h + 1 - 7 * m + 114) % 31) + 1;
		data = dia+"/"+mes;
		return data;
	}
}