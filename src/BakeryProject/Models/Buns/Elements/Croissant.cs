using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryProject.Models.Buns.Elements
{
    public class Croissant : Bun
    {
        public Croissant(string name, decimal price, DateTime timeCreate, int lifeTime, int limitation)
            : base(name, price, timeCreate, lifeTime, limitation)
        {
            
        }
    }
}
