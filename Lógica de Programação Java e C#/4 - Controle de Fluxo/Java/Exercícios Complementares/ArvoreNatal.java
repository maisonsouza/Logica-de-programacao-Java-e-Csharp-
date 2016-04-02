class ArvoreNatal{
	public static void main(String [] args){
 		int baseMaior = 15;
		for ( int m = 7; m <= 15; m += 4) {
 			for (int i = m - 6; i <= m; i += 2) {
 				int espacos = ( baseMaior - i) / 2;
 				System.out.println("");
					for (int j = 0; j < espacos ; j ++) {
 						System.out.print(" ");
 					}
 			for (int k = 0; k < i; k++) {
 				System.out.print("*");
 			}
		 		System .out . println ("");
 			}
		}
 	}
 }
