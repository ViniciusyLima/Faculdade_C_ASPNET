
Console.WriteLine("Digite o valor da compra:");
String valor = Console.ReadLine();
Console.WriteLine("Digite a quantidade de parcelas:");
String parcela = Console.ReadLine();
Console.WriteLine(" ");

float v = float.Parse(valor);
float p = int.Parse(parcela);
float res;

if (p <= 1)
{
    v -= Convert.ToSingle(v * 0.1);
    Console.WriteLine("Quantidade de parcelas: " + p + 
        "\nValor pago a vista: " + v);
}
else if (p <= 5)
{
    res = v / p;
    Console.WriteLine("Quantidade de parcelas: " + p + 
        "\nValor da parcela: " + res + 
        "\nValor Total da compra: " + v);
}
else
{
    v += Convert.ToSingle(v * 0.07);
    res = v / p;
    Console.WriteLine("Quantidade de parcelas: " + p + 
        "\nValor da parcela: " + res + 
        "\nValor Total da compra: " + v);
}
