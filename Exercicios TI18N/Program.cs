using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_TI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a contrl com a program
            ControlFormulario control = new ControlFormulario();//Instanciando essa variável
            control.Operacao();

            //Fazer o ReadLine para manter aberto
            Console.ReadLine();
        }//Fim do metodo main
    }//Fim da classe program 
}//Fim do projeto
