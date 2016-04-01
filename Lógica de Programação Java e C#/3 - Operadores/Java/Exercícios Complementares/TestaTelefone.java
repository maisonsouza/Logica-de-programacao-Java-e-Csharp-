class TestaTelefone{
	public static void main(String [] args){
	String telefone="2387-3791";
	System.out.println(telefone);
	String a = (telefone.substring(0,2));
	int primeiro = Integer.parseInt(a);
	System.out.println(primeiro);
	primeiro++;
	System.out.println(primeiro);
	a = (telefone.substring(2,4));
	int segundo = Integer.parseInt(a);
	System.out.println(segundo);
	segundo--;
	System.out.println(segundo);


	
}
}
	