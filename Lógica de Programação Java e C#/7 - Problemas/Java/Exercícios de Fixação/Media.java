class Media{
	public static void main(String [] args){
		int [] array = {10, 25, 15, 30, 40};
		double media = media(array);
		System.out.println("A m�dia dos elementos do array � = "+ media);
	}
	static int media(int [] array){
		int soma=0;
		int media=0;
			for(int a=0;a<array.length;a++){
				soma+=array[a];
			}
		media = soma/array.length;
		return media;
	}
}