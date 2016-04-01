class OperacoesString
{
    static void Main()
    {
        string nome = "   Maison Mar cel  ";
        System.Console.WriteLine(nome[7]);
        System.Console.WriteLine(nome.Contains("Mar"));
        System.Console.WriteLine(nome.EndsWith("el"));
        System.Console.WriteLine(nome.StartsWith("Mai"));
        nome = nome.Replace("Mais", "+");
        System.Console.WriteLine(nome);
        System.Console.WriteLine(nome.Substring(0, 3));
        System.Console.WriteLine(nome.ToUpper());
        System.Console.WriteLine(nome.ToLower());
        System.Console.WriteLine(nome.Trim());
    }
}