class EscolheRoupa{
	public static void main(String [] args){
		double valor = Math.random();
	if(valor<0.5){
	System.out.println("Camiseta Preta");
	}else{
	System.out.println("Camiseta vermelha");
	}
	valor=Math.random();
	if(valor<0.5){
	System.out.println("Calça Jeans");
	}else{
	System.out.println("bermuda");
	}
	valor=Math.random();
	if (valor<0.5){
	System.out.println("Tênis");
	}else{
	System.out.println("Sapato");
	}
	valor= Math.random();
	if (valor <0.5){
	System.out.println("Boné");
	}else{
	System.out.println("óculos");
	}
}
}