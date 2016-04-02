class ArvoreNatal
{
    static void Main()
    {
 		int baseMaior = 15;
		for ( int m = 7; m <= 15; m += 4) {
 			for (int i = m - 6; i <= m; i += 2) {
 				int espacos = ( baseMaior - i) / 2;
 				System.Console.WriteLine(" ");
					for (int j = 0; j < espacos ; j ++) {
 						System.Console.Write(" ");
 					}
 			for (int k = 0; k < i; k++) {
 				System.Console.Write("*");
 			}
		 		System.Console.WriteLine (" ");
 			}
		}
 	}
 }