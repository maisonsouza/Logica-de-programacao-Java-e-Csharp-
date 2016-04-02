class Tabuada{
	public static void main(String [] args){
		int[][] tabuada = new int [10][10];
		for(int a=1;a<tabuada.length;a++){
			System.out.println("");
			for(int b=1;b<tabuada.length;b++){
				tabuada[a][b]=a*b;
			System.out.println(a+" * "+b+" = "+tabuada[a][b]);
			}
		}
	}
}