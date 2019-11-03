using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_3_02
{
    //тип делегата
    public delegate void MyDelegate();
    class Program
    {
        private static void MethodOne()
        {
            Console.WriteLine("Method1");
        }
        private static void MethodTwo()
        {
            Console.WriteLine("Method2");
        }
        private static void MethodThree()
        {
            Console.WriteLine("Method3");
        }
        private static void MethodFour()
        {
            Console.WriteLine("Method4");
        }
        static void Main(string[] args)
        {
            //  Экземпляр делегата в к-ром будем комбинировать делегаты
            MyDelegate mD = null;
       
            MyDelegate mD1 = new MyDelegate(MethodOne);
            MyDelegate mD2 = new MyDelegate(MethodTwo);
            MyDelegate mD3 = new MyDelegate(MethodThree);
            MyDelegate mD4 = new MyDelegate(MethodFour);

           

            mD = mD1 + mD2 + mD3;
            int test = Convert.ToInt32(Console.ReadLine());


            switch (test)
            {
                case 1:
                    mD();
                    break;
                case 2:
                    mD -= mD2;
                    mD();
                    break;
                case 3:
                    mD = mD4;
                    mD();
                    break;
                case 4:
                    mD -= mD4;
                    mD();
                    break;

            }
            Console.ReadKey();
        }
    }
}
