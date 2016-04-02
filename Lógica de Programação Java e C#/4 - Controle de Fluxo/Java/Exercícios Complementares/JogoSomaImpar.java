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
				System.out.println("Você ganhou a soma é ímpar "+soma);	
			}
			if(soma%2==0 && contador<2){
				System.out.println("Você perdeu!! A Soma é par "+soma);
			}if(contador>=2){
				System.out.println("Você perdeu!! o número 6 aparece duas vezes");
			}
	}
}

		