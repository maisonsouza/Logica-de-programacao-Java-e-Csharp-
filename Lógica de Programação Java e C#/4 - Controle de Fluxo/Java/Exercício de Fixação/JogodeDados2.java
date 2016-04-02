class JogodeDados2{
	public static void main(String [] args){
		int pontos=0;
			for (int t=1;t<=4;t++){
				int dado = (int) (Math.random()*6 + 1);
					System.out.println("Lançamento = "+t+" valor do dado = "+dado);
				if(dado	% 2 == 0){
					continue;	
				}
					pontos+=dado;
						System.out.println("TOTAL DE PONTOS = "+pontos);
				if(pontos>9){
					System.out.println("Parábens você ganhou na "+t+" jogada");
				break;		
				}

			}
			
	}
		
}