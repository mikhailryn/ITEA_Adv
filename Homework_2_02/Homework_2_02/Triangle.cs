using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_02
{
  class Triangle<T,R>
        where T : struct
        where R : Shape
    {
        Shape shape;
        private T id;

        public (T, Shape) ShapeMethod()  
        {
            return (id, shape);
        }

    }
}
