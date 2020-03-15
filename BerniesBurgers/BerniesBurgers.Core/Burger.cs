using System;

namespace BerniesBurgers.Core
{
    public class Burger
    {
      
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Toppings Toppings { get; set; }
    }
}