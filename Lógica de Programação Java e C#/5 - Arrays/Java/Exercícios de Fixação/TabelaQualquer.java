class TabelaQualquer{
	public static void main(String [] args){
		int [][] array = new int [3][3];
			array[0][0]= 19;
			array[0][1] = 22;
			array[0][2] = 31;
			array[1][0] = 2;
			array[1][1] = 51;
			array[1][2] = 12;
			array[2][0] = 65;
			array[2][1] = 40;
			array[2][2] = 43;
		
		for(int a=0;a<array.length;a++){
			for(int b=0;b<array[a].length;b++){
				System.out.println(array[a][b]);
			}
		}
	}
}
	