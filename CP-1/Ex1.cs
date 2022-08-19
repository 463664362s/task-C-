//Crie um programa com três variáveis inteiras, a, b, c, com quaisquer valores. 
//Depois crie 3 variáveis double, delta, a1, a2, com a fórmula anterior. 
//Imprima a1 e a2. Dica: Para calcular raiz quadrada, use Math.Sqrt(variável). 
//Não se esqueça que não podemos calcular a raiz quadrada de números negativos.




Console.WriteLine("Digite os valores de a, b e c: ");

 
String Ia = Console.ReadLine();
String Ib = Console.ReadLine();
String Ic = Console.ReadLine();

int a = Convert.ToInt32(Ia);
int b = Convert.ToInt32(Ib);
int c = Convert.ToInt32(Ic);

double delta = b*b - 4*a*c,
a1 = (-b + Math.Sqrt(delta)) / (2 * a), 
a2 = (-b - Math.Sqrt(delta)) / (2 * a); 

if(delta <= 0) {
    Console.WriteLine("ERRO. Delta não pode ser negativo");
}else {
Console.WriteLine($"O valor de x1 é {a1} e o valor de x2 é {a2}");

}
