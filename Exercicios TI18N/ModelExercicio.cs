using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI18N
{
    class ModelExercicio
    {
        public ModelExercicio()
        {

        }//Fim do construtor 

        //Exercicio 01 - A média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }//Fim do método média


        //Método de validação
        public Boolean ValidarNotas(double nota)
        {
            if ((nota < 0) || (nota > 10))

            {
                return true;
            }
            else
            {
                return false;
            }
                   
        }//Fim do método 

        //Método de validação de negativos
        public Boolean ValidarNegativos(double num)
        {
            if(num <= 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Exercício 02
        public int Comparar(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//Fim do comparar

        //Exercício 03 - Mostrar o antecesor
        public int Antecesor(int num)
        {
            return num - 1;
        }//Fim do antecessor

        //Exercicio 04
        public double CalcArea(double numA, double numB)
        {
            return numA * numB;
        }//Fim da calcArea

         



    }//Fim da classe
}//Fim do projeto
