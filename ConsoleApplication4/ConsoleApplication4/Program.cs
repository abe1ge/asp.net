using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    
    class animel
    {
       

        public virtual void bark()
        {
            Console.WriteLine("BARK1");
        }

       
    }

    class dog : animel
    {
      
        public override void bark()
        {
            Console.WriteLine("BARK2");
            base.bark();
        }
    }

    class bull : dog
    {
        public override void bark()
        {
            Console.WriteLine("BARK3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dog x = new dog(5);
            Console.WriteLine(x.sum);

            new bull().bark();




        }
    }
}
