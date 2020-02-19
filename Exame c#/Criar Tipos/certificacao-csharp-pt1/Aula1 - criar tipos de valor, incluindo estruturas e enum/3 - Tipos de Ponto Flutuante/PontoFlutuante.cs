using System;

namespace certificacao_csharp_roteiro.antes
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f; // coloca-se o "f" depois do número para indicar que o número é um tipo flutuante

            //int massa = 6_000_000_000_000_000_000_000_000; erro número muito grande
            //long massa = 6e24; erro ao converter double em long !!! OBS - ao colocar 'e10' por exemplo o c# entende que tem 10 zeros a direita

            float massaDaTerra = 5.9736e24f; // System.Single
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            //float numeroMuitoMaior = 6e100f; o tipo float não consegue suportar um valor desse tamanho
            double numeroMuitoMaior = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine($"O resultado é do tipo: {resultado1.GetType()}"); // o resultado de uma soma de variaveis de tipos diferentes o c# sempre cria a nova variavel com o tipo de maior capacidade

            float z = 4.5f; // System.Single

            var resultado2 = (x * y) / z;
            Console.WriteLine("(x * y) / z = {0}", resultado2);
            Console.WriteLine($"O resultado é do tipo: {resultado2.GetType()}"); // o resultado de uma soma de variaveis de tipos diferentes o c# sempre cria a nova variavel com o tipo de maior capacidade

            //===================================================================================
            //=  C#             .NET                 FAIXA DE VALORES           PRECISÃO        =
            //===================================================================================
            //=  float          System.Single        -1.5e-45 à 3.4e38           7      dígitos =
            //=  double         System.Double        -5.0e324 à 1.7e308          15-16  dígitos =
            //=  decimal        System.Decimal       -7.9e28  à 7.9e28           28-29  dígitos = sempre que for somar valores decimais usar esse tipo
            //===================================================================================
        }
    }
}
