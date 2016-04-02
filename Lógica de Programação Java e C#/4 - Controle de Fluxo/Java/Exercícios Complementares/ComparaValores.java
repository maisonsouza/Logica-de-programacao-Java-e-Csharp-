class ComparaValores{
	public static void main(String [] args){
		double valor1 = Math.random();
			System.out.println(valor1);
		double valor2 = Math.random();
			System.out.println(valor2);	
	if(valor1 < valor2)
		System.out.println("Segundo > Primeiro");
	if(valor1 > valor2)
		System.out.println("Primeiro > Segundo");
	if(valor1 == valor2)
		System.out.println("Primeiro = Segundo");
		}
}