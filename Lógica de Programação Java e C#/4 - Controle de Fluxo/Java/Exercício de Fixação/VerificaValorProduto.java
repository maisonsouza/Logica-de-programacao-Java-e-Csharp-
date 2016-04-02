class VerificaValorProduto{
	public static void main(String [] args){
		double precodoProduto1 = Math.random()*3;
		double precodoProduto2 = Math.random()*3;
	System.out.println("O preço do Produto 1 = "+precodoProduto1);
	System.out.println("O preço do Produto 2 = "+precodoProduto2);
		if(precodoProduto1<precodoProduto2){
	System.out.println("O preço do produto 1 é mais barato");
	}else if(precodoProduto2<precodoProduto1){
	System.out.println("O preço do produto 2 é mais barato");
	}else{
	System.out.println("Os preços dos produtos são iguais");
}
}
}

	