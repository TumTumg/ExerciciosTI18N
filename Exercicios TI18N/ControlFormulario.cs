using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI18N
{
    class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;
        
        public ControlFormulario()
        {
            exercicio = new ModelExercicio();//Conecta a classe model e a control
            ConsultarOpcao = -1;
        }//Fim do método construtor

        //Métodos modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do método
        

        public void Menu()
        {
            Console.WriteLine("\n\n ---- Menu ---- \n\n" +
                               "0. Sair\n"         +
                               "1. Exercicio 01\n" +
                               "2. Exercício 02\n" +
                               "3. Exercício 03\n" +
                               "4. Exercício 04\n" +
                               "5. Exercício 05\n" +
                               "6. Exercício 06\n" +
                               "Escolha uma das opções acima: " );
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Mostrar menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpa tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1 = 0;//Declarei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 a 10");
                            }

                        } while (exercicio.ValidarNotas(nota1) == true);

                        double nota2 = 0;//Declarei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 a 10");
                            }

                        } while (exercicio.ValidarNotas(nota2) == true);


                        //Chamar Método média que está na classe model
                        Console.WriteLine("A média das duas notas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;

                    case 2:
                        Console.WriteLine("Informe um número");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Informe um número");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O antecessor é: " + exercicio.Antecesor(num));
                        break;
                   case 4:
                        double numA;//Validei fora
                        double numB;

                        do
                        {
                            Console.WriteLine("Informe a base");
                            numA = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(numA) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }

                        } while (exercicio.ValidarNegativos(numA) == true);


                        do
                        {
                            Console.WriteLine("Informe a altura");
                            numB = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(numB) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }

                        } while (exercicio.ValidarNegativos(numB) == true);

                        //Mostrando a área
                        Console.WriteLine("O valor da área é: " + exercicio.CalcArea(numA, numB));

                        break;

                        //Mostrando a área
                        Console.WriteLine("O valor da área é: " + exercicio.CalcArea(numA, numB));



                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                   



                }//Fim do escolha
            } while (ConsultarOpcao != 0);//Fim do while
        }//Fim do método

    }//Fim da classe
}//Fim do projeto
