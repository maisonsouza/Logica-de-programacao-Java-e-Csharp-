class GeradorRespostasAleatorias{
	public static void main(String [] args){
		int [] gabarito = new int [10];
		int [][] respostas = new int [5][10];
			System.out.println("Gabarito");
			for(int a=0;a<gabarito.length;a++){
				gabarito[a]=(int)(Math.random() * 3 + 1);
				System.out.print(gabarito[a]);
			}
				System.out.println("");
			for(int a=0;a<respostas.length;a++){
				System.out.println("Resposta "+(a+1));	
				for(int b=0;b<respostas[a].length;b++){
					respostas[a][b]=(int)(Math.random() * 3 + 1);
					System.out.print(respostas[a][b]);
				}
				System.out.println("");
			}
	}
}
					