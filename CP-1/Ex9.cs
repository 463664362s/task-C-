Console.WriteLine("UTILIZE A VIRGULA PARA OS DECIMAIS");
Console.Write("Digite o preço do etanol: R$");
String etanol = Console.ReadLine();

Console.Write("Digite o preço da gasolina: R$");
String gasolina = Console.ReadLine();

double gasolinaA = Convert.ToDouble(gasolina);
double etanolA = Convert.ToDouble(etanol);

if(etanolA * 1.3 > gasolinaA){
    Console.WriteLine($"A Gasolina no preço de R${gasolinaA} possui o melhor custo benefício.");
} else {
    Console.WriteLine($"O Etanol no preço de R${etanolA} possui o melhor custo benefício.");
}



