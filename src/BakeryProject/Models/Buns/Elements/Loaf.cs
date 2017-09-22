using System;

namespace BakeryProject.Models.Buns.Elements
{
    public class Loaf : Bun
    {
        public Loaf(string name, decimal price, DateTime timeCreate, int lifeTime, int limitation)
            : base(name, price, timeCreate, lifeTime, limitation)
        {
            
        }
    }
}
