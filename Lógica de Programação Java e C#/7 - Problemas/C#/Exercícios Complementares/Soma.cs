class Soma{
	 static void Main(){
		double [] array = {-10.7, 12.4, 23.8, 68.4, 31.5};
		double soma = calculaSoma(array);
		System.Console.WriteLine("A soma dos elementos é = "+soma);
	}
	static double calculaSoma(double [] array){	
		double soma = 0;
			for (int a=1;a<array.Length;a++){
				soma += array[a];		
			}
			return soma;
	}
}