class CartoesEstacionamento{
	public static void main(String [] args){
		for (int numerodobloco=1;numerodobloco<=3;numerodobloco++){
			for(int andares=1;andares<=9;andares++){
				for(int apartamentos=1;apartamentos<=4;apartamentos++){
					System.out.println("Andar = "+andares+" apartamento = "+apartamentos);
				}
			}
		}
	}
}