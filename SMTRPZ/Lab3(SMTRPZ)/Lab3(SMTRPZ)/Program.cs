using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SMTRPZ_
{
    class Program
    {
        static void Method1(int k)
        {
            k++;
        }

        static void Method2(ref int k)
        {
            k++;
        }
        static void Method3(out int k)
        {
            // k -> undefined
            k = 20;
        }
        static void Main(string[] args)
        {
            int l = 1;
            Console.WriteLine(l);
            Method1(l);
            Console.WriteLine(l);
            Method2(ref l);
            Console.WriteLine(l);
            Method3(out l);
            Console.WriteLine(l);
        }

    }

    class SomeClass
    {
        // Доступен отовсюду
        public void MethodA() { }

        // Доступен только из типов данных SomeClass
        private void MethodB() { }

        //Доступен только из SomeClass и из классов, производных от
        //него на любом нижестоящем уровне иерархии
        protected void MethodC() { }

        // Доступен только из той же самой сборки
        internal void MethodD() { }

        // Будет действовать как protected или internal
        protected internal void MethodE() { }

        // Будет считаться protected - по умолчанию
        void MethodO() { }
    }


}
