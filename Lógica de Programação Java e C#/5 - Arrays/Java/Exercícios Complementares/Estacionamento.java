class Estacionamento{
	public static void main(String [] args){
		boolean [][] vagas = new boolean [4][10];
			for(int a=0;a<vagas.length;a++){
				int cont=0;
			for(int b=0;b<vagas[a].length;b++){
				vagas[a][b]= Math.random() < 0.5;
				System.out.print(vagas[a][b] ? "-" : "X");		
			}
			System.out.println("");
				
			}

			for(int c=0;c<vagas.length;c++){
				int cont=0;
				for(int d=0;d<vagas[c].length;d++){
					if(vagas[c][d]==true){
						cont++;
					}	
				}
				System.out.println("Vagas disponíveis "+(c+1)+"º andar = "+cont);
			}
	}
}
					