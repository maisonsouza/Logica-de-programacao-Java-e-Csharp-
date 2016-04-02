class Media{
	 static void Main(){
		int [] array = {10, 25, 15, 30, 40};
		double media = calculaMedia(array);
		System.Console.WriteLine("A média dos elementos do array é = "+ media);
	}
	static int calculaMedia(int [] array){
		int soma=0;
		int media=0;
			for(int a=0;a<array.Length;a++){
				soma+=array[a];
			}
		media = soma/array.Length;
		return media;
	}
}