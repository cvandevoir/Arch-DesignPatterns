using System;

namespace Ducks
{
    internal class QuackNormal : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }      
    }
}
