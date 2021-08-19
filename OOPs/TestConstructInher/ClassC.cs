using System;

namespace TestConstructInher
{
    class ClassC : ClassB
    {

        public ClassC()//In this case, the constructors from the ClassB and ClassA will be called automatically,
        /// since they don't have the parameters in signature 
        {
            Console.WriteLine("Constructor of the class C is called");
        }

    }

}