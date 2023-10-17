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
                               "7. Exercício 07\n" +
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


                    case 5:

                        double totalE;
                        double valido;
                        double branco;
                        double nulo;
                        do
                        { 
                            //Coletando e validando o total de elitores
                            do
                            {
                                Console.WriteLine("Informe o total de eleitores");
                                totalE= Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativos(totalE) == true)
                                {
                                    Console.WriteLine("O número digitado não é válido!!!");
                                }
                            } while(exercicio.ValidarNegativos(totalE) == true);

                            //Validando votos validos
                            do
                            {
                                Console.WriteLine("Informe a quantidade de votos válidos");
                                valido = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativos(valido) == true)
                                {
                                    Console.WriteLine("O número digitado não é válido!!!");
                                }

                            } while (exercicio.ValidarNegativos(valido) == true);

                            //Validando votos brancos
                            do
                            {
                                Console.WriteLine("Informe a quantidade de votos brancos");
                                branco = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativos(branco) == true)
                                {
                                    Console.WriteLine("O número digitado não é válido!!!");
                                }

                            } while (exercicio.ValidarNegativos(branco) == true);

                            //Validando votos nulos
                            do
                            {
                                Console.WriteLine("Infore a quantidade de votos nulos");
                                nulo = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativos(nulo) == true) 
                                {
                                    Console.WriteLine("O número digitado não é válido!!!");
                                }

                            } while (exercicio.ValidarNegativos(nulo) == true);

                            Console.Clear();//Limpa a tela
                            if (exercicio.validarTotalE(totalE, branco, nulo, valido) == true)

                            {
                                Console.WriteLine("A quantidade de votos é diferente do total de eeitores");
                            }                            
                        } while (exercicio.validarTotalE(totalE, branco, nulo, valido) == true);

                            //Mostrar os percentuais em tela
                            Console.WriteLine("O percentual de votos válidos é: " + exercicio.PValidos(totalE, valido) + "%");
                            Console.WriteLine("O percentual de votos brancos é: " + exercicio.PBrancos(totalE, branco) + "%");                         
                            Console.WriteLine("O percentual de votos nulos é: " + exercicio.PNulos(totalE, nulo) + "%");
                        break;
                    case 6:
                        double salario6;
                        double reajuste6;

                        do
                        {
                            Console.WriteLine("Informe o valor do salário do funcionário");
                            salario6 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(salario6) == true)
                            {
                                Console.WriteLine("O número digitado não é valido");
                            }

                        } while (exercicio.ValidarNegativos(salario6) == true);
                        //Fim da validação do salario

                        do
                        {
                            Console.WriteLine("Informe o valor do salário do funcionário");
                            reajuste6 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(reajuste6) == true)
                            {
                                Console.WriteLine("O número digitado não é valido");
                            }

                        } while (exercicio.ValidarNegativos(reajuste6) == true);
                        //Mostrando em tela o resultado
                            Console.Write("O novo salário do funcionário é: " + exercicio.PFuncionario(reajuste6, salario6));
                        break;
                    case 7:
                        double percentualImpostos;
                        double percentualDistribuidor;
                        double custoFabrica;

                        do
                        {
                            Console.WriteLine("Informe o percentual de impostos");
                            percentualImpostos = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(percentualImpostos) == true)
                            {
                                Console.WriteLine("O valor digitado não é válido");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativos(percentualImpostos) == true);

                        do
                        {
                            Console.WriteLine("Informe o percentual de distribuidor");
                            percentualDistribuidor = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(percentualDistribuidor) == true)
                            {
                                Console.WriteLine("O valor digitado não é válido");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativos(percentualDistribuidor) == true);


                        do
                        {
                            Console.WriteLine("Informe o custo de fábrica");
                            custoFabrica = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativos(custoFabrica) == true)
                            {
                                Console.WriteLine("O valor digitado não é válido");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativos(custoFabrica) == true);
                        //Mostrar em tela o custo final
                        Console.WriteLine("O custo final é R$ " + exercicio.CustoFinalCarro(percentualImpostos, percentualDistribuidor,custoFabrica));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;


                }//Fim do escolha
            } while (ConsultarOpcao != 0);//Fim do while
        }//Fim do método

    }//Fim da classe
}//Fim do projeto
