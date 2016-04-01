class TestaTelefone{
	static void Main(){
		string telefone="2387-3791";
		System.Console.WriteLine(telefone);
		string a = (telefone.Substring(0,2));
		int primeiro = System.Convert.ToInt32(a);
		System.Console.WriteLine(primeiro);
		primeiro++;
		System.Console.WriteLine(primeiro);
		a = (telefone.Substring(2,2));
		int segundo = System.Convert.ToInt32(a);
		System.Console.WriteLine(segundo);
		segundo--;
		System.Console.WriteLine(segundo);	
	}
}
	