class DataeHora{
	public static void main(String [] args){
		java.util.Calendar horaatual = java.util.Calendar.getInstance();
		java.util.Calendar horadada = new java.util.GregorianCalendar(2010,07,27,10,32,15);
		java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("dd/MM/yyyy HH:mm:ss");		
		String horadadaformatada = sdf.format(horadada.getTime());
		String horaatualformatada = sdf.format(horaatual.getTime());
        System.out.println("PRIMEIRO = "+horaatual);
		System.out.println("SEGUNDO = "+horadada);
		System.out.println("Formatando...");
		System.out.println("Quarto = "+horaatualformatada);
		System.out.println("TERCEIRO = "+horadadaformatada);
		
}
}