class Soma{
	public static void main(String [] args){
		double [] array = {-10.7, 12.4, 23.8, 68.4, 31.5};
		double soma = soma(array);
		System.out.println("A soma dos elementos é = "+soma);
	}
	static double soma(double [] array){	
		double soma = 0;
			for (int a=1;a<array.length;a++){
				soma += array[a];		
			}
			return soma;
	}
}