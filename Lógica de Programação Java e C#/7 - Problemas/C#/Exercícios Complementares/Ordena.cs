class Ordena {
	 static void Main () {
 		System . Console. WriteLine (" Original ");
 			int [] array = { -10 , 37, 101 , 28, -4};
			 exibeArray ( array );

			System . Console. WriteLine ("\nOrdenando ... ");
 			ordena ( array );
 			exibeArray ( array );
 	}

 	public static void ordena ( int [] array ) {
 		for ( int i = 0; i < array . Length ; i ++) {
			int menor = verMenor (array , i);
		 	troca (array , i, menor );		
		}
	 }
	public static int verMenor ( int [] array , int inicio ) {
 		int menor = inicio ;
 			for ( int i = inicio + 1; i < array . Length ; i ++) {	
				if( array [ menor ] > array [i]) {
 					menor = i;
 				}
 			}
 				return menor ;	
	}

 		public static void troca ( int [] array , int i, int j) {
 			int auxiliar = array [i];	
			array [i] = array [j];
 			array [j] = auxiliar ;
 		}
		 public static void exibeArray ( int [] array ) {
			 System . Console. Write ("{");
				for ( int i = 0; i < array . Length - 1; i ++) {
 					System . Console. Write ( array [i] + ", ");	
				}

			 System . Console. WriteLine ( array [ array . Length - 1] + "}");	
		}
}