using System;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subTotal = 30;

            Console.WriteLine("Descobrindo se 10 + 20 == 30");
            Console.WriteLine($"{(valorProduto1 + valorProduto2 == subTotal)}");//true

            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subTotal = 30.30;

            Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine($"{(valorProduto1 + valorProduto2 == subTotal)}");//FALSE - quando se compara o resultado para float ou double o resultado dessa soma é 30.2999997, 
            //pois internamente trabalhando ele guarda como bytes e isso gera esse erro

            Console.WriteLine(valorProduto1 + valorProduto2); // mas quando esse valor é convertido para depois imprimir esse erro não acontece, pois ele converte o resultado para
            //double que com isso arredonda para 30.3

            //uma variavel que esse erro não ocorre é o tipo decimal
            decimal materiaPrima = 10.1M;//a letra 'M' é um sulfixo para afirmar que aquele valor é do tipo decimal
            decimal maoDeObra = 20.2M;
            decimal custo = 30.3M;

            Console.WriteLine("Descobrindo se 10.1M + 20.2M == 30.3M");
            Console.WriteLine($"{(materiaPrima + maoDeObra == custo)}");//true

            //===================================================================================
            //=  C#             .NET                 FAIXA DE VALORES           PRECISÃO        =
            //===================================================================================
            //=  float          System.Single        -1.5e-45 à +3.4e38          7      dígitos =
            //=  double         System.Double        -5.0e324 à +1.7e308         15-16  dígitos =
            //=  decimal        System.Decimal       -7.9e28  à +7.9e28          28-29  dígitos = sempre que for somar valores decimais usar esse tipo
            //===================================================================================
        }
    }
}
