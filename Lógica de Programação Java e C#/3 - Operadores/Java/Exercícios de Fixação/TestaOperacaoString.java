class TestaOperacaoString {
 	public static void main(String [] args){
	String nome = "Maison Galv�o";
	System.out.println(nome.charAt(4));
	System.out.println(nome.contains("Daniel"));
	System.out.println(nome.contains("Maison"));
	System.out.println(nome.contains("Maiso"));
	System.out.println(nome.contains("Maisona"));
	System.out.println(nome.endsWith("Galvo"));
	System.out.println(nome.endsWith("Galv�o"));

	System.out.println(nome.startsWith("Maison"));
	System.out.println(nome.startsWith("Galv�o"));
	System.out.println(nome.replaceAll("Maison","Gilberto"));
	System.out.println(nome);
	System.out.println(nome.substring(0,6));
	System.out.println(nome.toUpperCase());
	System.out.println(nome.toLowerCase());
	System.out.println(nome.trim());
	

}
}
	