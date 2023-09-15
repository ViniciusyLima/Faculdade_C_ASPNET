Console.WriteLine("Qual o valor da compra:");
String valor = Console.ReadLine();
Console.WriteLine("Qual a quantidade de parcelas:");
String parcela = Console.ReadLine();

float v = float.Parse(valor);
float p = int.Parse(parcela);
float r;

if (p <= 1)
{
    v = Convert.ToSingle(v + (v * 0.1));
    r = v;
    Console.WriteLine("Valor da parcela: " + r +
        "\nValor Total da compra: " + v);
}
else if (p <= 5)
{
    r = v / p;
    Console.WriteLine("Valor da parcela: " + r +
        "\nValor Total da compra: " + v);
}
else
{
    v += Convert.ToSingle(v * 0.07);
    r = v / p;
    Console.WriteLine("Valor da parcela: " + r +
        "\nValor Total da compra: " + v);
}
