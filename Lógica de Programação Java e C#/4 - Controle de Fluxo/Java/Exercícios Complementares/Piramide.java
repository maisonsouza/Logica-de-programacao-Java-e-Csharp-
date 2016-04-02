class Piramide{
	public static void main(String [] args){
		int basemaior=7;
		for(int espaco=1;espaco<=basemaior; espaco+= 2){
			int quantidade_espacos=(basemaior-espaco)/2;
		for(int desenhaespaco=0;desenhaespaco<quantidade_espacos;desenhaespaco++){
			System.out.print(" ");
		}
		for(int desenhaestrela=0;desenhaestrela<espaco;desenhaestrela++){
				System.out.print("*");
	
		}
		System.out.println("");	
		}	
	}
}