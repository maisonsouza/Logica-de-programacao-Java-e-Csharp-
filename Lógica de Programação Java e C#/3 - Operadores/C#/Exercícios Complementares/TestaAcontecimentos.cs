class TestaAcontecimentos{
	static void Main(){
		System.DateTime df = new System.DateTime (2011, 11, 11);
		System.Console.WriteLine(df.ToString("dd/MM/yyyy"));
		df = df.AddDays(19/5);
		System.Console.WriteLine(df.ToString("dd/MM/yyyy"));
		System.DateTime df2 = new System.DateTime(2009, 06, 25);
		System.Console.WriteLine(df2.ToString("dd/MM/yyyy"));
		df2 = df2.AddDays(129/4);
		System.Console.WriteLine(df2.ToString("dd/MM/yyyy"));
	}
}