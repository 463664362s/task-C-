//Crie um programa que tenha uma variável double valorDaNotaFiscal e, de acordo com esse valor, o imposto deve ser calculado. As regras de cálculo são: 
//Se o valor for menor ou igual a 999, o imposto deve ser de 2% 
//Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5% 
//Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8% 
//Se for maior ou igual a 7000, o imposto deve ser de 3% 
//Imprima o imposto.

Console.Write("Digite o valor da nota fiscal: R$");

String nota = Console.ReadLine();
double valorNotaFiscal = Convert.ToDouble(nota);


if (valorNotaFiscal <= 999) {
    Console.WriteLine($"Imposto sera de 2% = {valorNotaFiscal * 0.02}");
} else if (valorNotaFiscal >= 1000 && valorNotaFiscal <= 2999) {
    Console.WriteLine($"Imposto sera de 2.5% = {valorNotaFiscal * 0.025}");
} else if (valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999) {
    Console.WriteLine($"Imposto sera de 2.8% = {valorNotaFiscal * 0.028}");
}  else {
        Console.WriteLine($"Imposto sera de 3% = {valorNotaFiscal * 0.03}");
}