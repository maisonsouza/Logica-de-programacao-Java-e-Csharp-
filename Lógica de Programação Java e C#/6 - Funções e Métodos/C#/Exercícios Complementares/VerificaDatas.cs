public class VerificaDatas
{
    public static void Main(){
		bool data = verificaData(31,6,2000);
		System.Console.WriteLine(data);
	}
    static void mostraData(int dia, int mes, int ano){
        System.Console.WriteLine(dia + "/" + mes + "/" + ano);
		}
    static bool bissexto(int ano){
			if(ano%400==0 || (ano%4==0 && ano%100!=0)){
				System.Console.WriteLine("Ano bissexto");
				return true;		
			}else{
                System.Console.WriteLine("Ano bissexto");
			return false;
			}
		}
    static bool verificaData(int dia, int mes, int ano){
			bool eBissexto = bissexto(ano);
				if(eBissexto==true && mes==2 && dia<=29){
					mostraData(dia,mes,ano);
					System.Console.WriteLine("Data V�lida");
					return true;
				}
				if(eBissexto==false && mes==2 && dia<=28){
					mostraData(dia,mes,ano);
					System.Console.WriteLine("Ano Normal - Fevereiro - Data V�lida");
					return true;
				}
				if(eBissexto==true && mes==2 && dia>29){
					mostraData(dia,mes,ano);
					System.Console.WriteLine("Data inv�lida, dias de Fevereiro em anos bissextos s�o at� 29. Dia informado"+dia);
						return false;
				}
						if(mes==1 || mes==3 || mes==5 || mes==7 || mes==8 || mes==10 || mes==12){
							if(mes<=12 && dia<=31){
								mostraData(dia,mes,ano);
								System.Console.WriteLine("Data V�lida");	
								return true;
							}else{
								mostraData(dia,mes,ano);
								System.Console.WriteLine("M�s ou dia inv�lidos");
								return false;
							}
						}
					
					if(mes==4 || mes==6 ||mes==9 || mes==11){
						if(mes<=12 && dia<=30){
							mostraData(dia,mes,ano);
							System.Console.WriteLine("M�s v�lido e dia v�lido"+dia);
								return true;
						}else{
							mostraData(dia,mes,ano);
                            System.Console.WriteLine("M�s ou dia inv�lidos dia= " + dia + " em m�s at� 30");
							return false;
						}
							
					}
				return false;
			
		}
}
