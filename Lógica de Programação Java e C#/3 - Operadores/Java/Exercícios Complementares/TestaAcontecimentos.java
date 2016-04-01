class TestaAcontecimentos{
	public static void main(String []args){
		String data1formatada,data2formatada;
		java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat ("dd/MM/ yyyy HH:mm:ss");
		java.util.Calendar data1 = new java.util.GregorianCalendar(2011, 10, 11) ;
		
		data1.add(java.util.Calendar.DAY_OF_MONTH ,19/5);
		data1formatada = sdf.format(data1.getTime());
		java.util.Calendar data2 = new java.util.GregorianCalendar(2009, 05, 25); 
		data1.add(java.util.Calendar.DAY_OF_MONTH ,129/4);
		data2formatada = sdf.format(data1.getTime());
		System.out.println(data1formatada);
		System.out.println(data2formatada);
		System.out.println (data1.after(data2));
	}
}