class ControleVagas{
	public static void main(String [] args){
		boolean [][] vagas = new boolean [4][10];
			for(int a=0;a<vagas.length;a++){
				System.out.println("");
				for(int b=0; b<vagas[a].length;b++){
					vagas[a][b]=Math.random() < 0.5;
						System.out.print( vagas[a][b]?" - " : " X ");
				}
			}
	}
}