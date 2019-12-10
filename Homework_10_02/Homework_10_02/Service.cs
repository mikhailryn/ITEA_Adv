using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_02
{
   public static class Service<T>
    {
        public static void ShowMethodsAttributes(T some)
        {
            var methods = some.GetType().GetMethods();

            foreach(var method in methods)
                foreach(var attributeData in method.CustomAttributes)
                    Console.WriteLine(attributeData);
        }
    }
}
