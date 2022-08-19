//Faça um programa em C# que imprima os fatoriais de 1 a 10. O fatorial de um número n é n n-1 n-2 ... até n = 1. 
//O fatorial de 0 é 1 
//O fatorial de 1 é (0!) * 1 = 1 
//O fatorial de 2 é (1!) * 2 = 2 
//O fatorial de 3 é (2!) * 3 = 6 
//O fatorial de 4 é (3!) * 4 = 24 

int fatorial = 1;

for (int n = 1; n <= 10; n++) { 
    fatorial = fatorial * n;
    Console.WriteLine($"O fatorial de {n} é ({n-1}!) * {n} = {fatorial}" );
}
