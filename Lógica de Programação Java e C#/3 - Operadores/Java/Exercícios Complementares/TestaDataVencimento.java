class TestaDataVencimento{
	public static void main(String [] args){
		java.util.Calendar primeira = new java.util.GregorianCalendar(2015,7,15);
		java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("dd/MM/yyyy");		
		String primeiraformatada = sdf.format(primeira.getTime());
		System.out.println(primeiraformatada);

		primeira.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(primeira.getTime()));

		primeira.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(primeira.getTime()));
		
		primeira.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(primeira.getTime()));
		
	
}
}