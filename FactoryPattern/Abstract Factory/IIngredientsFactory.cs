using System.Collections.Generic;

namespace FactoryPattern
{
    internal interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}
