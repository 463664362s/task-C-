//Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira. 
//Crie um programa com duas variáveis, int idade, bool brasileira, e faça com que o programa diga se a pessoa está apta a votar ou não, 
//de acordo com os dados nas variáveis.

Console.Write("Digite sua idade: ");
String idade = Console.ReadLine();
int num_idade = Int32.Parse(idade);

Console.Write("Você é brasileiro? Digite s para sim e n para não: ");
String nacionalidade = Console.ReadLine();

if(num_idade > 16 && nacionalidade == "s") {
    Console.WriteLine("Essa pessoa pode votar");
} else {
    Console.WriteLine("Essa pessoa não pode votar");

}