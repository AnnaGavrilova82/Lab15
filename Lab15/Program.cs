using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение ");
            int x = Convert.ToInt32(Console.ReadLine());
            ISeries ia = new ArithProgression();
            ISeries ig = new GeomProgression();
            ia.setStart(x);
            ig.setStart(x);
            Console.WriteLine(ia.getNext());
            Console.WriteLine(ig.getNext());

            Console.ReadKey();

        }

        interface ISeries
        {
            int start {
                get;
                set;
            }

            int next {
                get;
                set;
            }

            void setStart(int x);

            int getNext();

            void reset();

        }

        class ArithProgression : ISeries
        {
            public int start { get; set; }
            public int next { get; set; }

            public void setStart(int x)
            {
                start = x;
                next = x;
            }

            public int getNext()
            {
                next = next + 1;
                return next;
            }

            public void reset()
            {
                next = start;
                
            }

        }

        class GeomProgression : ISeries
        {
            public int start { get; set; }
            public int next { get; set; }
            public int getNext()
            {
                next = next * 2;
                return next;
            }

            public void reset()
            {
                next = start;
            }

            public void setStart(int x)
            {
                start = x;
                next = x;
            }
        }
    }
}
