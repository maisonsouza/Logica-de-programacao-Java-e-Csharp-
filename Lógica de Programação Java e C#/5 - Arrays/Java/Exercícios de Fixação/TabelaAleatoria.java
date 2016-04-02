class TabelaAleatoria{
	public static void main(String [] args){
		int [][] matriz = new int [3][3];
			for(int a=0; a<matriz.length; a++){
				for(int b=0; b<matriz.length; b++){
					matriz[a][b] = (int)(Math.random()*100);
					System.out.println(matriz[a][b]);
				}
			}
	}
}
		