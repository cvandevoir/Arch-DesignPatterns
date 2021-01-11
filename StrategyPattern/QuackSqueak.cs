using System;

namespace Ducks
{
    internal class QuackSqueak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeeeak");
        }
    }
}
