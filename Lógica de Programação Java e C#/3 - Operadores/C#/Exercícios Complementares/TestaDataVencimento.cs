class TestaDataVencimento{
	static void Main(){
		System.DateTime dt = new System.DateTime(2015,7,15);	
		System.Console.WriteLine(dt.ToString("dd/MM/yyyy"));
		dt = dt.AddDays(30);
		System.Console.WriteLine(dt.ToString("dd/MM/yyyy"));
		dt = dt.AddDays(30);
		System.Console.WriteLine(dt.ToString("dd/MM/yyyy"));
		dt = dt.AddDays(30);
		System.Console.WriteLine(dt.ToString("dd/MM/yyyy"));

		
	
}
}