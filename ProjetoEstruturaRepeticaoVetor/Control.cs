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
                             "6. Número maior e sua posição de 25 elementos");
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
                        Console.WriteLine(modelo.ContagemVinte());
                        break;
                    case 5:
                        modelo.ContagemQuinze();
                        modelo.NumerosParesDois();
                        break;
                    default:
                        Console.WriteLine("Erro, escolha uma opção válida!");
                        break;
                }//Fim do switch
            }while(ConsultarOpcao != 0);
        }//Fim do método Operacao
    }//Fim da classe
}//Fim do projeto
