class CorretorProvas{
	public static void main(String [] args){
		int [] gabarito = new int [10];
				for(int a=0; a<gabarito.length; a++){
					gabarito[a]=(int)(Math.random() * 3 + 1);	
					System.out.print("  "+gabarito[a]);
				}
					System.out.println("");					
					int[][] respostas = new int [10][];
					
					for(int a=0;a<respostas.length;a++){
						respostas[a] = new int [10];
						System.out.println("Aluno "+(a+1));
							for(int b=0;b<respostas[a].length;b++){
								respostas[a][b]=(int)(Math.random()*3 + 1);	
								System.out.print("  "+respostas[a][b]);
							}
								System.out.println("");
					}
			for(int a=0;a<respostas.length;a++){
				int acertos=0;
				for(int b=0;b<respostas[a].length;b++){
					if(gabarito[b]==respostas[a][b]){
						acertos++;
						
					}
						
				}
				System.out.println("Aluno = "+(a+1)+" Acertos = "+acertos);
			}			
	}
}
				
			
					