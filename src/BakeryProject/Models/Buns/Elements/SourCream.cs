using System;
using BakeryProject.Constants;

namespace BakeryProject.Models.Buns.Elements
{
    public class SourCream : Bun
    {
        public SourCream(string name, decimal price, DateTime timeCreate, int lifeTime, int limitation)
            : base(name, price, timeCreate, lifeTime, limitation)
        {
        }
        public override decimal? getPriceCurrent()
        {

            if (DateTime.Now > TimeCreate.AddHours(LifeTime))
            {
                return null;
            }
            if (DateTime.Now < TimeCreate.AddHours(Limitation))
            {
                return Price;
            }
            return Price - (Price * (decimal)(BakeryConstants.procent * 2 / 100.0) * DateTime.Now.Subtract(TimeCreate.AddHours(Limitation)).Hours); ;
        }
    }
}
