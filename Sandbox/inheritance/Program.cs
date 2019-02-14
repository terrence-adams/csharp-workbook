using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stringtransform sF = new Stringtransform();
            TransformUpper tfU = new TransformUpper();
            TransformLower tLw = new TransformLower ();
            Console.WriteLine( sF.Transform("Wording"));
            sF.TransformStringArray("Wording!");
            Console.WriteLine(tfU.Transform("Wording!"));
            Stringtransform []  transformArray = new Stringtransform []
            {
                sF,
                tfU,
                tLw


            };



            foreach(var item in transformArray )
            {
                var result = item.Transform("Hello World");
                Console.WriteLine(result);



            }


        }
    }
}
