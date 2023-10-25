using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {
        public double[] numDouble;//Declaração de um vetor
        public int[] numInt;
        public int i;//Contador do vetor
        public int impares;
        private double soma;
        public Model()
        {
            numDouble = new double[50];
            numInt = new int[50];
            i = 0;
            impares = 0;
            ConsultarSoma = 0;
        }//Fim do Construtor

        public double ConsultarSoma
        {
            get { return soma; } 
            set { this.soma = value; }
        }
        //Guardar 10 notas de 10 alunos diferentes
        public double MediaNotas()
        {
            for(i = 0; i < 10; i++) 
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    numDouble[i] = Convert.ToDouble(Console.ReadLine());

                    if (numDouble[i] < 0 || numDouble[i] > 10)
                    {
                        Console.WriteLine("Informe uma nota de 0 a 10");
                    }
                } while (numDouble[i] < 0 || numDouble[i] > 10);
                ConsultarSoma = ConsultarSoma + numDouble[i];
            }//Fim do for

            return ConsultarSoma / i;
        }

        //Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for(i = 0; i < 5; i++) 
            {
                Console.Write(i + 1 + "ª Posição: ");
                numInt[i] = Convert.ToInt32((Console.ReadLine()));
            }//Fim do for
        }//Fim do método

        public void MostrarVetor()
        {
            for(i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + numInt[i]);
            }//Fim do for
        }//Fim do mostrar

        //Exercício 02
        public void ContagemDez()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numInt[i] = Convert.ToInt32((Console.ReadLine()));
            }
        }

        public void NumerosPares()
        {
            for (i = 0; i < 10; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("\nTodos os números pares digitados foram: ");
                }
                if (numInt[i] % 2 == 0)
                {
                    Console.WriteLine(numInt[i]);
                }
                else
                {
                    impares = impares + 1;
                }

                if (impares == 10)
                {
                    Console.WriteLine("Nenhum");
                }
            }
        }

        //Exercício 03
        public double ContagemVinte()
        {
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numInt[i] = Convert.ToInt32((Console.ReadLine()));
                ConsultarSoma = ConsultarSoma + numDouble[i];
            }
            return ConsultarSoma / i;
        }

        //Exercício 04
        public void ContagemQuinze()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numInt[i] = Convert.ToInt32((Console.ReadLine()));
            }
        }

        public void NumerosParesDois()
        {
            for (i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\nTodos os números pares digitados foram: ");
                }
                if (numInt[i] % 2 == 0)
                {
                    Console.WriteLine(numInt[i]);
                }
                else
                {
                    impares = impares + 1;
                }

                if (impares == 15)
                {
                    Console.WriteLine("Nenhum");
                }
            }
        }

        //Exercício 05
        public void ContadorVinteECinco()
        {
            for (i = 0; i < 25; i++)
            {
                if(i == 0)
                {
                    ConsultarSoma = ConsultarSoma + numInt[i];
                }
                else
                {
                    if (numInt[i] > ConsultarSoma)
                    {
                        ConsultarSoma = numInt[i];
                    }
                }
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numInt[i] = Convert.ToInt32((Console.ReadLine()));
            }
        }
    }//Fim da classe
}//Fim do projeto
