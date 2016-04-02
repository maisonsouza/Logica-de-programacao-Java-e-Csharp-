class Piramide
{
    static void Main()
    {
		int basemaior=7; //descreve o tamanho máximo da base
		for(int espaco=1;espaco<=basemaior; espaco+= 2){ //incrementa o espaco em +2 a cada iteração
			int quantidade_espacos=(basemaior-espaco)/2; //determina aquantidade de espacos
		for(int desenhaespaco=0;desenhaespaco<quantidade_espacos;desenhaespaco++){ //desenha  quantidade de espacos
			System.Console.Write(" ");
		}
		for(int desenhaestrela=0;desenhaestrela<espaco;desenhaestrela++){//desenha as estrelas
				System.Console.Write("*");
		}
		System.Console.WriteLine(" ");	//pula uma linha
		}	
	}
}