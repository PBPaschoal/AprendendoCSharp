/* Atualmente trabalho com emprestimo consignado, atendimento ao corretor, dando suporte na parte operacional 
 * dos sistemas de bancos. Para praticar eu fiz a um tempo atras esse mesmo programa em C++ e Java, agora estou
 * fazendo em C# para praticar o básico como utilização de switch, if e else.
 * Futuramente farei uma nova versão desse programa, mais avançado.
 * Criado por: Paulo Bruno Paschoal
 * Atualizado dia 18-07-2020 às 20:24hrs, Rio de Janeiro. 
 */

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ConsigConsultaProgram
{
    class ConsigConsulta03
    {
        static void Main(string[] args)
        {
            int org, vall;
            double brut, comiss, sald, lib, parcl;
            string nom = null, cepf = null;

            Console.WriteLine("Escolha o órgão para cadastramento: ");
            Console.WriteLine("[1] = [INSS]: ");
            Console.WriteLine("[2] = [SIAPE]: ");
            Console.WriteLine("[3] = [EXERCITO]: ");
            org = int.Parse(Console.ReadLine()); 
            // Digite 1 ou 2 ou 3 para selecionar o órgão desejado. Para essa opção escolhi 
            //a variavel do tipo inteiro.
            
            switch (org)
            {
                case 1:
                    //switch sendo utilizado nesse caso não apenas para informar (repetir) o órgão que foi selecionado
                    //mas também para atribuir o valor da comissão para cada um deles.

                    Console.WriteLine("Você selecionou INSS");
                    comiss = 15;
                    break;
                case 2:
                    Console.WriteLine("Você selecionou SIAPE");
                    comiss = 18;
                    break;
                default:
                    Console.WriteLine("Você selecionou EXERCITO");
                    comiss = 20;
                    break;
            }
            Console.WriteLine("\nEscolha o tipo de operação para cadastramento: ");
            Console.WriteLine("[1] = [NOVO]: ");
            Console.WriteLine("[2] = [REFINANCIAMENTO]: ");
            vall = int.Parse(Console.ReadLine()); 
            //Mais uma vez com a variavel do tipo inteiro, digite 1 ou 2 para selecionar
            //dessa vez o tipo de operação desejavel.

            if (vall == 1) 
                //Digitou 1? Então será apresentado as mensagens abaixo para preencher os dados de uma operação NOVA.
            {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("CADASTRAMENTO DE OPERAÇÃO NOVA");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Informe o nome do cliente: ");
                nom = (Console.ReadLine());
                Console.WriteLine("Informe o CPF do cliente: ");
                cepf = (Console.ReadLine());
                Console.WriteLine("Informe o valor Bruto: "); 
                //Valor bruto no caso de operação NOVA é o liquido desejado 
                //para o cliente receber.

                brut = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor da parcela: ");
                parcl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o prazo: ");
                vall = int.Parse(Console.ReadLine());

                //Nessa nova versão é informado o valor minimo para cada órgão e cada operação.
                if (org == 1 && brut < 500.00) { 
                    //Como podemos notar, org informa a opção escolhida e brut compara 
                    //o valor digitado com o minimo para prosseguir. 
                    //Se o valor digitado for maior que R$ 500.00, ele irá prosseguir normalmente para o resultado da operação.
                    //Se for menor que R$ 500.00 a mensagem abaixo será apresentada:

                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO NOVA INSS]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 500,00 <<<\n");
                    //Se não liberar o valor minimo do órgão especifico, a simulação será interrompida pela mensagem 
                    //RESULTADO N E G A D O

                    Console.WriteLine("RESULTADO N E G A D O: \n");

                } else if (org == 2 && brut < 850.00) {
                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO NOVA SIAPE]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 850,00 <<<\n");
                    Console.WriteLine("RESULTADO N E G A D O: \n");
                } else if (org == 3 && brut < 1000.00) {
                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO NOVA EXERCITO]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 1000,00 <<<\n");
                    Console.WriteLine("RESULTADO N E G A D O: \n");
                }
                else {
                    //Como citado antes, liberou acima do valor minimo do órgão/valor especifico? 
                    //Então será apresentado conforme abaixo:

                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("***( RESULTADO DA PROPOSTA )***");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("CLIENTE: " + nom);
                    Console.WriteLine("CPF: " + cepf);
                    Console.WriteLine("Valor Bruto: " + brut.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcela: " + parcl.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Prazo: " + vall);
                    Console.WriteLine("Porcentagem da Comissao: " + comiss + "%"); 
                    // porcentagem da comissão

                    comiss = brut * comiss / 100;
                    Console.WriteLine("Valor da Comissao: " + comiss.ToString("F2", CultureInfo.InvariantCulture) + "\n\n"); 
                    // valor da comissão a receber
                }

            }
            else {
                //As mesmas informações serão repetidas abaixo, mas para refinanciamento:

                Console.WriteLine("\n------------------------------");
                Console.WriteLine("CADASTRAMENTO DE REFINANCIAMENTO");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Informe o nome do cliente: ");
                nom = (Console.ReadLine());
                Console.WriteLine("Informe o CPF do cliente: ");
                cepf = (Console.ReadLine());
                Console.WriteLine("Informe o valor Bruto: ");
                brut = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor do Saldo: ");
                sald = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor da parcela: ");
                parcl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o prazo: ");
                vall = int.Parse(Console.ReadLine());

                if (org == 1 && brut - sald < 300.00) {
                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO REFINANCIAMENTO INSS]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 300,00 <<<\n");
                    Console.WriteLine("RESULTADO N E G A D O: \n");
                }
                else if (org == 2 && brut - sald < 400.00) {
                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO REFINANCIAMENTO SIAPE]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 400,00 <<<\n");
                    Console.WriteLine("RESULTADO N E G A D O: \n");
                }
                else if (org == 3 && brut - sald < 500.00) {
                    Console.WriteLine("\n\n\n>>> [OPERAÇÃO REFINANCIAMENTO EXERCITO]: NÃO VIAVEL AO MINIMO PERMITIDO DE R$ 500,00 <<<\n");
                    Console.WriteLine("RESULTADO N E G A D O: \n");
                }
                else {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("***( RESULTADO DA PROPOSTA )***");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("CLIENTE: " + nom);
                    Console.WriteLine("CPF: " + cepf);
                    Console.WriteLine("Valor Bruto: " + brut.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor do Saldo: " + sald.ToString("F2", CultureInfo.InvariantCulture));
                    lib = brut - sald; //Diminuindo o valor bruto pelo valor do saldo descobrimos o valor liberado para o cliente.

                    Console.WriteLine("Prazo: " + vall);
                    Console.WriteLine("Valor Liberado: " + lib.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcela: " + parcl.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Prazo: " + vall);
                    Console.WriteLine("Porcentagem da Comissao: " + (comiss - 3) + "%");
                    comiss = (brut - sald) * (comiss - 3) / 100;
                    Console.WriteLine("Valor da Comissao: " + comiss.ToString("F2", CultureInfo.InvariantCulture) + "\n\n");
                }
            }
        }
    }
}