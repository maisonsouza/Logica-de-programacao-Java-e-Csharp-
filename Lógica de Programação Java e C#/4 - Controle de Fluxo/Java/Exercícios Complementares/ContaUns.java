class ContaUns {
	public static void main ( String [] args ) {
		double numero = Math . random ();
		System.out.println(numero);
		String valor = "" + numero ;
 		int resposta = 0;
		 for ( int i = 0; i < valor.length(); i++) {
 			if(valor.charAt(i)=='1'){
 				resposta ++;
 			}
 		}
		 System . out. println (resposta);
 	}
 }