// App de Console para somar dois valores digitados pelo usuário

Console.WriteLine("Digite o primeiro valor:");
string str1 = Console.ReadLine();
Console.WriteLine("Digite o segundo valor:");
string str2 = Console.ReadLine();

float v1 = float.Parse(str1);
float v2 = Convert.ToSingle(str2);
float res = v1 + v2;

Console.WriteLine("A soma dos valores digitados é " + res);


