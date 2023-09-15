

using OlaMundo;

Console.WriteLine("Hello, World!");
float res = 0;00
res = 4.2f + 9.1f;
Console.WriteLine("A soma vale: " + res);

Trabalhador tr1 = new Trabalhador("Ana Lopes", 5600);
Trabalhador tr2 = new Trabalhador("Manuel Ledón", 15000);
Console.WriteLine(tr1.toString());
Console.WriteLine(tr2.toString());

//vamos alterar o salário de um trabalhador:
tr1.Salario = 8500;
Console.WriteLine("Ana, com salário alterado:\n" + tr1.toString());
