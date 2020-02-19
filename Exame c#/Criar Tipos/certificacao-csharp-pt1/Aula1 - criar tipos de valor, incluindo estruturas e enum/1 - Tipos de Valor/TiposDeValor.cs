using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);

            int copiaIdade = idade;
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Copia idade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Copia idade: {copiaIdade}");

            int? idadeNula = null;
        }
    }
}
