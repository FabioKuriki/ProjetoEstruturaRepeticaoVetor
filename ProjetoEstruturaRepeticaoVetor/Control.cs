using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Control
    {
        Model modelo;
        private int opcao;

        public Control()
        {
            this.modelo = new Model();//Criando uma chave
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao;}
            set { this.opcao = value; }
        }//Fim do método

        public void Menu()
        {
            Console.WriteLine("\nEscolha uma das opções abaixo: \n\n" +
                             "0.Sair\n" +
                             "1. Média de notas 10 alunos\n" +
                             "2. Vetor Inverso de 5 elementos\n" +
                             "3. Números pares de 10 elementos\n" +
                             "4. Média de valores de 20 elementos\n" +
                             "5. Números pares de 15 elementos\n" +
                             "6. Número maior e sua posição de 25 elementos\n" +
                             "7. Número menor e sua posição de 30 elementos\n" +
                             "8. Segundo maior valor de 50 elementos\n" +
                             "9. Soma dos valores de 10 elementos\n" +
                             "10. Média dos valores pares de 15 elementos\n" +
                             "11. Média dos valores impares de 20 elementos\n" +
                             "12. Posição do primeiro número impar de 10 elementos\n" + 
                             "13. Posição do último número par de 10 elementos\n" +
                             "14. Quantidade de números entre 10 e 50\n" +
                             "15. Soma dos valores nos índices pares de 12 elementos\n" +
                             "16. Soma dos valores nos índices ímpares de 10 elementos\n" +
                             "17. Vetor Inverso de 10 elementos\n" +
                             "18. Soma dos elementos de 2 vetores com 5 elementos cada\n" +
                             "19. ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());

        }//Fim do menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        Console.WriteLine("A médias das notas será: " + this.modelo.MediaNotas());
                        break;
                    case 2:
                        this.modelo.PreencherVetor();
                        Console.WriteLine("\n");
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        modelo.ContagemDez();
                        modelo.NumerosPares();
                        break;
                    case 4:
                        modelo.ContagemVinte();
                        Console.WriteLine("\n" + modelo.Media());
                        break;
                    case 5:
                        modelo.ContagemQuinze();
                        modelo.NumerosParesDois();
                        break;
                    case 6:
                        modelo.ContagemVinteECinco();
                        modelo.NumMaior();
                        break;
                    case 7:
                        modelo.ContagemTrinta();
                        modelo.NumMenor();
                        break;
                    case 8:
                        modelo.ContagemCinquenta();
                        Console.WriteLine("\nO segundo maior número é: " + modelo.SegundoMaior());
                        break;
                    case 9:
                        modelo.ContagemDez();
                        Console.WriteLine("\nA soma dos valores será: " + modelo.Soma());
                        break;
                    case 10:
                        modelo.ContagemQuinze();
                        Console.WriteLine("\nA média dos valores pares é: " + modelo.MediaNumPar());
                        break;
                    case 11:
                        modelo.ContagemVinte();
                        Console.WriteLine("\nA média dos valores impares é: " + modelo.MediaNumImpar());
                        break;
                    case 12:
                        modelo.ContagemDez();
                        Console.WriteLine("\nA posição do primeiro número impar é: " + modelo.PrimeiroNumImpar());
                        break;
                    case 13:
                        modelo.ContagemDez();
                        Console.WriteLine("\nA posição do último número par é: " + modelo.UltimoNumPar());
                        break;
                    case 14:
                        modelo.ContagemDez();
                        Console.WriteLine("\nHá " + modelo.NumEntreDezECinquenta() + " número(os) entre 10 e 50");
                        break;
                    case 15:
                        modelo.ContagemDoze();
                        Console.WriteLine("\nA soma dos índices pares é: " + modelo.SomaIndicePar());
                        break;
                    case 16:
                        modelo.ContagemDez();
                        Console.WriteLine("\nA soma dos índices pares é: " + modelo.SomaIndiceImpar());
                        break;
                    case 17:
                        modelo.ContagemDez();
                        Console.WriteLine("\n");
                        modelo.MostrarVetor2();
                        break;
                    case 18:
                        Console.WriteLine("1° Vetor:");
                        modelo.PreencherVetor();
                        Console.WriteLine("\n2º Vetor:");
                        modelo.PreencherVetor2();
                        Console.WriteLine("A soma dos dois vetores será: " + modelo.SomaDoisVetores());
                        break;
                    case 19:
                        break;
                    default:
                        Console.WriteLine("Erro, escolha uma opção válida!");
                        break;
                }//Fim do switch
            }while(ConsultarOpcao != 0);
        }//Fim do método Operacao
    }//Fim da classe
}//Fim do projeto
