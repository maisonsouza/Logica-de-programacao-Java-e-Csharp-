class SequenciaDecrescente{
	public static void main(String [] args){
		int [] vetor = new int [10];
			for(int a=0;a<vetor.length;a++){
				vetor[a]= vetor.length-a;
					System.out.println(vetor[a]);
			}
	}
}