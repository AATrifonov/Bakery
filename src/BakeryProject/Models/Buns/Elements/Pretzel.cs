using System;
using BakeryProject.Constants;

namespace BakeryProject.Models.Buns.Elements
{
    public class Pretzel : Bun
    {
        public Pretzel(string name, decimal price, DateTime timeCreate, int lifeTime, int limitation)
            : base(name, price, timeCreate, lifeTime, limitation)
        {

        }

        public override decimal? GetPriceCurrent()
        {
            if (DateTime.Now > TimeCreate.AddHours(LifeTime))
            {
                return null;
            }
            if (DateTime.Now < TimeCreate.AddHours(Limitation))
            {
                return Price;
            }
            return Price / BakeryConstants.countDivPretzel;
        }
    }
}
