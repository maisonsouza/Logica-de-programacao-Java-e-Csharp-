class JogodeDado{
	public static void main(String [] args){
		int pontos = 0;
			for(int t=1;t<=5;t++){
		int dado = (int) (Math.random()*6 + 1);
		System.out.println("Lan�amento "+t+ " = " + dado);
		pontos += dado;
		System.out.println("Total de Pontos = "+pontos);
			if(pontos>7){
		System.out.println("Par�bens voc� ganhou com "+t+" jogadas");
		break;
		}
		}	
		System.out.println("Jogue Novamente");
	}
}
	
		