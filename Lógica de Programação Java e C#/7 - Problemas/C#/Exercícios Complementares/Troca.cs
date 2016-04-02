class Troca{
	 static void Main(){
		int [] array = {2 , 5 , 7 , 10};
		exibeArray (array);
		System . Console. WriteLine ("\nTroca 0 e 2");
		 troca (array , 0, 2);
		 exibeArray ( array );

 		System .Console. WriteLine ("\nTroca 1 e 3");
 		troca (array , 1, 3);
 		exibeArray ( array );

	}
	static void exibeArray(int [] array){
		for(int a=0;a<array.Length;a++){
			System.Console.WriteLine(" "+array[a]);
		}
	}
	static void troca(int [] array,int i, int j){
		int auxiliar = array[i];
		array[i]=array[j];
		array[j]=auxiliar;
	}
	
}
	