class SequenciaAleatoria{
	public static void main(String [] args){
		int [] vetor = new int [10];
			for(int a=0;a<vetor.length;a++){				
				vetor[a]=(int)(Math.random()*10);
				System.out.println(vetor[a]);
			}
	}
}
			