using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Partial_Classes
{
    class Program
    {
        static void Run()
        {
            /*=============================================================*/
            /* ······ TASK 1 ······ */
            /*=============================================================*/
            //var point  = new Point (596, 782);
            //point .Show();

            /*=============================================================*/
            /* ······ TASK 2 ······ */
            /*=============================================================*/

            //try                       // minimumun maksimumdan boyuk olub olmadiqini yoxlayir
            //{
            //    var counter = new Counter(200, 100);
            //}
            //catch (Exception content)
            //{
            //    Console.WriteLine(content);
            //    Console.WriteLine();
            //}

            //var counterSecond = new Counter(0, 100);

            //for (double i = 0; i < 150; i++)
            //{       
            //    if ( i == 100)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(counterSecond.Increment() + " ");
            //}
            //Console.WriteLine();

            /*=============================================================*/
            /* ······ TASK 3 ······ */
            /*=============================================================*/

            var first = new Fraction(2.5, 1);
            var second = new Fraction(0.5, 1);
            first.Show();
            second.Show();
            Console.WriteLine(first / second);
            Console.WriteLine(first * second);
            Console.WriteLine(first + second);
            Console.WriteLine(first - second);
            Console.WriteLine();

            /*=============================================================*/
            /* ······ TASK 4 ······ */
            /*=============================================================*/

            //var car = new Car(1, "Jeep", "AMERICAN ENGINE COMPANY", "WRANGLER", new DateTime(2020, 01, 01));
            //car.Show();
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
