//Davyd Roscowski - 2463577

//Título e pula linha
Console.WriteLine("| EQUAÇÃO do 2 GRAU |");
Console.WriteLine();

//Entrada do valor A
Console.Write("Digite o valor de A: ");
var a = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de A = " + a);

//Entrada do valor B
Console.Write("Digite o valor de B: ");
var b = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de B = " + b);

//Entrada do valor C
Console.Write("Digite o valor de C: ");
var c = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de C = " + c);

if (a != 0) //Verifica se o valor de A é diferente de 0 para prosseguir
{
    //Calcula o valor de Delta
    float delta = ((b) * (b)) - (4 * (a) * (c));
    Console.WriteLine("Delta = " + delta);
    //Só pra pular linha
    Console.WriteLine();

    if (delta > 0) //Verifica se o valor de delta é maior que 0 para prosseguir
    {
        //Calcula o valor de X1
        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("X1 = " + x1);

        //Calcula o valor de X2
        var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("X2 = " + x2);

        //Apresenta a solução
        Console.WriteLine("A solução é: " + x1 + ", " + x2);
    }
    else //Se delta for menor que 0...
    {
        //Mostra mensagem de erro
        Console.WriteLine("Impossível continuar! Valor de Delta é menor que 0 (zero).");
    }
}
else //Se A for igual que 0...
{
    Console.WriteLine("Impossível calcular! Valor de A é igual a 0 (zero).");
}