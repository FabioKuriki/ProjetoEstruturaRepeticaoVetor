using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {
        public double[] numDouble;
        public double[] numDouble2;//Declaração de um vetor
        public int[] numInt;
        public int posicao;
        public int i;//Contador do vetor
        public int i2;//2° Contador
        public double maior;
        public Boolean validacao;
        public double segundoMaior;
        private double soma;
        public double produtoEscalar;
        public Model()
        {
            numDouble = new double[50];
            numDouble2 = new double[50];
            numInt = new int[50];
            i = 0;
            i2 = 0;
            soma = 0;
            validacao = false;
            maior = 0;
            segundoMaior = 0;
            posicao = 0;
            ConsultarSoma = 0;
            produtoEscalar = 0;
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
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
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
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
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
                if (numDouble[i] % 2 == 0)
                {
                    Console.WriteLine(numDouble[i]);
                }
            }
        }

        //Exercício 03
        public void ContagemVinte()
        {
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double Media()
        {
            for (i = 0; i < 20; i++)
            {
                ConsultarSoma += numDouble[i];
            }
            return ConsultarSoma / i;
        }

        //Exercício 04
        public void ContagemQuinze()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
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
                if (numDouble[i] % 2 == 0)
                {
                    Console.WriteLine(numDouble[i]);
                }
            }
        }

        //Exercício 05
        public void ContagemVinteECinco()
        {
            for (i = 0; i < 25; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public void NumMaior()
        {
            for(i = 0; i < 25; i++)
            {
                if(i == 0)
                {
                    maior = numDouble[i];
                    posicao = i + 1;
                }
                else
                {
                    if (numDouble[i] > maior)
                    {
                        maior = numDouble[i];
                        posicao = i + 1;
                    }
                }
            }
            Console.WriteLine("\nO maior número é " + maior + ", e sua posição é " + posicao);
        }

        //Exercício 06
        public void ContagemTrinta()
        {
            for (i = 0; i < 30; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public void NumMenor()
        {
            for (i = 0; i < 30; i++)
            {
                if (i == 0)
                {
                    maior = numDouble[i];
                    posicao = i + 1;
                }
                else
                {
                    if (numDouble[i] < maior)
                    {
                        maior = numDouble[i];
                        posicao = i + 1;
                    }
                }
            }
            Console.WriteLine("\nO menor número é " + maior + ", e sua posição é " + posicao);
        }

        //Exercicio 07
        public void ContagemCinquenta()
        {
            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double SegundoMaior()
        {
            for (i = 0; i < 50; i++)
            {
                if(i == 0)
                {
                    maior = numDouble[i];
                    segundoMaior = numDouble[i];
                }
                else
                {
                    if (numDouble[i] > maior)
                    {
                        segundoMaior = maior;
                        maior = numDouble[i];
                    }
                }
            }
            return segundoMaior;
        }

        //Exercício 08
        public double Soma()
        {
            for(i = 0; i < 10; i++)
            {
                soma = soma + numDouble[i];
            }
            return soma;
        }

        //Exercício 09
        public double MediaNumPar()
        {
            for (i = 0; i < 15; i++)
            {
                if (numDouble[i] % 2 == 0)
                {
                    soma = soma + numDouble[i];
                    posicao = posicao + 1;
                }
            }
            return soma / posicao;
        }

        //Exercício 10
        public double MediaNumImpar()
        {
            for (i = 0; i < 20; i++)
            {
                if (numDouble[i] % 2 != 0)
                {
                    soma = soma + numDouble[i];
                    posicao = posicao + 1;
                }
            }
            return soma / posicao;
        }

        //Exercício 11
        public int PrimeiroNumImpar()
        {
            for(i = 0; i < 10; i++)
            {
                if (numDouble[i] % 2 != 0 && validacao == false)
                {
                    posicao = i + 1;
                    validacao = true;
                }
            }
            return posicao;
        }

        //Exercício 12
        public int UltimoNumPar()
        {
            for (i = 0; i < 10; i++)
            {
                if (numDouble[i] % 2 == 0)
                {
                    posicao = i + 1;
                }
            }
            return posicao;
        }

        //Exercício 13
        public int NumEntreDezECinquenta()
        {
            for(i = 0; i < 10; i++)
            {
                if (numDouble[i] > 10 && numDouble[i] < 50)
                {
                    posicao = posicao + 1;
                }
            }
            return posicao;
        }

        //Exercício 14
        public void ContagemDoze()
        {
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double SomaIndicePar()
        {
            for(i = 0; i < 12; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    soma = soma + numDouble[i];
                }
            }
            return soma;
        }

        //Exercício 15
        public double SomaIndiceImpar()
        {
            for(i = 0; i < 10; i ++)
            {
                if ((i + 1) % 2 != 0)
                {
                    soma = soma + numDouble[i];
                }
            }
            return soma;
        }

        //Exercício 16
        public void MostrarVetor2()
        {
            for (i = 9; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + numDouble[i]);
            }
        }

        //Exercício 17
        public void PreencherVetor2()
        {
            for (i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + "ª Posição: ");
                numDouble2[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double SomaDoisVetores()
        {
            for(i = 0; i < 5; i++)
            {
                soma = soma + numDouble[i];
            }

            for (i = 0; i < 5; i++)
            {
                soma = soma + numDouble2[i];
            }
            return soma;
        }

        //Exercício 18
        public void ContagemOito()
        {
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }
        public void ContagemOitoDois()
        {
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble2[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double ProdutoEscalar()
        {
            for (i = 0; i < 8; i++)
            {
                produtoEscalar = produtoEscalar + (numDouble[i] * numDouble2[i]);
            }
            return produtoEscalar;
        }

        //Exercício 19
        public void ContagemSeis()
        {
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }
        public void ContagemSeisDois()
        {
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                numDouble2[i] = Convert.ToDouble((Console.ReadLine()));
            }
        }

        public double ProdutoVetorial()
        {
            for (i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    produtoEscalar = numDouble[i];//Usado a mesma variável para outro calculo
                }
                else
                {
                    produtoEscalar = produtoEscalar * numDouble[i];
                }
            }
            return produtoEscalar;
        }

        public double ProdutoVetorialDois()
        {
            for (i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    produtoEscalar = numDouble2[i];//Usado a mesma variável para outro calculo
                }
                else
                {
                    produtoEscalar = produtoEscalar * numDouble2[i];
                }
            }
            return produtoEscalar;
        }

        //Exercício 20
        public void VetorPar()
        {
            for (i = 0; i < 10; i++)
            {
                if (numDouble[i] % 2 == 0)
                {
                    numDouble2[i2] = numDouble[i];
                    Console.WriteLine((i2 + 1) + "° Posição: " + numDouble2[i2]);
                    i2 = i2 + 1;
                }
            }
        }

        //Método para validar que o vetor recebeu em cada posição um número par
        public void ValidacaoVetorPar()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "° Posição: " + numDouble2[i]);
            }
        }
    }//Fim da classe
}//Fim do projeto
