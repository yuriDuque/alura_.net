using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            short passageirosVoo = -230; // System.Int16 - aceita negativo
            ushort passageirosNavio = 230; // System.UInt16 - não aceita negativo

            int idade = -15; // System.Int32 - aceita negativo
            uint estoque = 15; // System.UInt32 - não aceita negativo

            long populacaoDoBrasil = -207_660_920; // System.Int64 - aceita negativo
            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64 - aceita negativo

            char resposta = 'S'; // System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal - não aceita negativo
            sbyte nivelDeBrilho = -127; // System.SByte - aceita negativo

            Console.WriteLine($"short: {passageirosVoo}");
            Console.WriteLine($"ushort: {passageirosNavio}");

            Console.WriteLine($"int: {idade}");
            Console.WriteLine($"uint: {estoque}");

            Console.WriteLine($"long: {populacaoDoBrasil}");
            Console.WriteLine($"ulong: {populacaoDoMundo}");

            Console.WriteLine($"char: {resposta}");

            Console.WriteLine($"byte: {nivelDeAzul}");
            Console.WriteLine($"sbyte: {nivelDeBrilho}");

            // TIPOS INTEGRAIS

            // TIPO          BYTE          ACEITA NEGATIVO?
            // char          1             N
            // byte          1             N
            // sbyte         1             S
            // short         2             S
            // ushort        2             N
            // int           4             S
            // uint          4             N
            // long          8             S
            // ulong         8             N



            // TIPOS DE VALOR 

            // TIPO          CATEGORIA
            // char          número inteiro
            // byte          número inteiro
            // sbyte         número inteiro
            // short         número inteiro
            // ushort        número inteiro
            // int           número inteiro
            // uint          número inteiro
            // long          número inteiro
            // ulong         número inteiro
            // bool          booleano
            // decimal       número decimal
            // double        número ponto flutuante
            // float         número ponto flutuante
            // enum          enumeracao
            // struct        estrutura
        }
    }
}
