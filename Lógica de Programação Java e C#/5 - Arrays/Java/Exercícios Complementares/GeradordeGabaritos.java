class GeradordeGabaritos{
	public static void main(String [] args){
		int [] questoes = new int [10];
		   for(int a=0;a<questoes.length; a++){
			questoes[a] = (int)(Math.random() * 3 + 1);
			}
			System.out.println("Gabarito");
			for(int a=0;a<questoes.length; a++){
				System.out.print(questoes[a]);
			}		
		}
}
			
			