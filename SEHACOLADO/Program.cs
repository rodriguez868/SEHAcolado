using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * La tienda de mi barrio vende a los mejores precios y calidad de la zona, 
 * por lo que siempre está llena de gente. Joselito, el dueño, 
 * hace tiempo que decidió colocar un expendedor de números para poder atender a los clientes ordenadamente
 * y sin que las discusiones entre ellos perturbasen su quehacer diario. Como no tenía suficiente dinero, 
 * no ha podido comprar un contador digital, así que confía en que los propios 
 * clientes formen una cola respetando la numeración y no suele pedir el número cuando les atiende; 
 * circunstancia que algunos han aprovechado para colarse en numerosas ocasiones.

De este modo, le ha pedido a su hija Claudia que haga una inspección sorpresa diaria. 
En el momento de la inspección, Claudia les pide a todos los que están en ese momento
en la cola que enseñen su número y a los que está segura de que se han colado los expulsa
de la tienda. Luego, cuando cierran la tienda, le cuenta a su padre a cuántos ha expulsado ese día.

Entrada
La primera línea contiene un número que indica el número de casos de prueba que aparecen a continuación.

Cada caso de prueba se compone de dos líneas. En la primera aparece un único entero con el
número de personas que están en la cola cuando Claudia hace la inspección (entre 1 y 500.000).
En la segunda aparecen los números que tienen cada una de esas personas según están en la cola,
números entre 1 y 10⁶, todos distintos (nadie ha llegado aún hasta el extremo de falsificar los números).
Eso sí, pueden faltar números, porque hay personas que ya han sido atendidas o personas que se cansaron
de esperar y se marcharon.

Salida
Para cada caso de prueba, el programa escribirá el número de personas que Claudia ha expulsado.
 */


namespace SEHACOLADO
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES-------------------------
            int fila = 0;
            int c = 0;

            Console.WriteLine("CONTROLADOR DE PERSONAS");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");

            //--------DATO INGRESADO POR EL USUARIO ---------
            Console.WriteLine("CUANTAS PERSONAS TENEMOS EN LA FILA");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");

            Console.WriteLine(" TENEMOS  "  + fila + "  PERSONAS  EN LA FILA EN ESTOS MOMENTOS");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");

            //------ EL QUE ME CUENTAS CUANTAS PERSONAS TENGO-------------
            for (c = 1; c <= fila; c++)
            {
                Console.WriteLine(" ESTA ES LA PERSONA " + c);
            }

            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");
            Console.WriteLine("0-----0  0----------0  0--------0  0------0  0-----0 ");

            // ---------LAS  PERSONAS  QUE SE COLA ----------------
            Random colados = new Random();
            int numero = colados.Next(1, 5);
            Console.WriteLine("CUANTAS PERSONAS HAN EXPULSADO CLAUDIA...  " + numero);
 
            Console.ReadKey();

        }
    }
}
