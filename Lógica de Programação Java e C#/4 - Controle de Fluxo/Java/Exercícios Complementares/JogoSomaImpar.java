class JogoSomaImpar{
	public static void main(String [] args){
		int soma=0,contador=0;
			for(int jogada=1;jogada<=10;jogada++){
				int dado = (int)(Math.random() * 6 + 1);
				System.out.println(dado);
					if(dado!=1){
						soma +=dado;
					}	
					if(dado == 6){
						contador++;
						if(contador>=2){
							break;
						}
					}	
			}
			
			if(soma%2!=0 && contador < 2){
				System.out.println("Voc� ganhou a soma � �mpar "+soma);	
			}
			if(soma%2==0 && contador<2){
				System.out.println("Voc� perdeu!! A Soma � par "+soma);
			}if(contador>=2){
				System.out.println("Voc� perdeu!! o n�mero 6 aparece duas vezes");
			}
	}
}

		