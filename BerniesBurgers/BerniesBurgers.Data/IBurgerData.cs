using System.Collections.Generic;
using System.Linq;
using BerniesBurgers.Core;

namespace BerniesBurgers.Data
{
    public interface IBurgerData
    {
        IEnumerable<Burger> GetBurgersByName(string name);
        Burger GetById(int id);

        public class InMemoryBurgerData : IBurgerData
        {
            private List<Burger> burgers;
            
            
            public InMemoryBurgerData()
            {
                burgers = new List<Burger>()
                {
                    new Burger() {Id = 1, Name = "Gut Buster", Toppings = Toppings.ExtraMeat, Price = 15},
                    new Burger() {Id = 2, Name = "Bernie Special", Toppings = Toppings.Cheese, Price = 13},
                    new Burger() {Id = 3, Name = "BLT", Toppings = Toppings.Bacon, Price = 12}
                };

            }

            public Burger GetById(int id)
            {
                return burgers.SingleOrDefault(b => b.Id == id);
            }
            
            public IEnumerable<Burger> GetBurgersByName(string name = null)
            {
                return from b in burgers
                    where string.IsNullOrEmpty(name) || b.Name.StartsWith(name)
                    orderby b.Name
                    select b;
            }
        }
    }
}