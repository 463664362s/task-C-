// Escreva um programa em C# que some todos os números de 1 a 100, pulando os múltiplos de 3. 
//O programa deve imprimir o resultado final em um MessageBox.



int variavel = 0;

for (int contador = 1; contador < 101; contador++) { 
    if (contador % 3 != 0){
        variavel = contador + variavel;
    }
}

Console.Write($"A soma de todos os números de 1 a 100, pulando os múltiplos de é {variavel}"); 
