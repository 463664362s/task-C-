//Faça um programa que imprima a seguinte tabela, usando for s encadeados:  
//1 
//2 4 
//3 6 9 
//4 8 12 16 
//n n*2 n*3 .... n*n

Console.Write("Digite o numero de linhas: ");

String linhas = Console.ReadLine();

int numLinhas = Int32.Parse(linhas);

for(int i = 1; i <= numLinhas; i++){
    for(int n = 1; n <= i; n++){
        Console.Write(n*i + " ");
    }
Console.WriteLine(); //Pular linha    
}


