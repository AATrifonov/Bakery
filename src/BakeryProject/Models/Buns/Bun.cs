using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryProject.Constants;

namespace BakeryProject.Models.Buns
{
    public class Bun
    {
        /// <summary>
        /// Наименование булки
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Цена
        /// </summary>
        private decimal _price;
        /// <summary>
        /// Время создания
        /// </summary>
        public readonly DateTime TimeCreate;
        /// <summary>
        /// Часы жизни
        /// </summary>
        public readonly int LifeTime;
        /// <summary>
        /// Контрольный срок
        /// </summary>
        private int _limitation;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > BakeryConstants.maxPrice)
                {
                    throw new ArgumentException($"Цена не должна превышать {BakeryConstants.maxPrice} рублей");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public int Limitation
        {
            get { return _limitation; }
            set
            {
                if (value > LifeTime)
                {
                    throw new ArgumentException("Контрольный срок не должна превышать срока годности");
                }
                else
                {
                    _limitation = value;
                }
            }
        }

        public Bun(string name, decimal price, DateTime timeCreate, int lifeTime, int limitation)
        {
            Name = name;
            Price = price;
            TimeCreate = timeCreate;
            LifeTime = lifeTime;
            Limitation = limitation;
        }

        public virtual decimal? GetPriceCurrent()
        {
            if (DateTime.Now > TimeCreate.AddHours(LifeTime))
            {
                return null;
            }
            if (DateTime.Now < TimeCreate.AddHours(Limitation))
            {
                return Price;
            }
            return Price - (Price * (decimal)(BakeryConstants.procent / 100.0) * DateTime.Now.Subtract(TimeCreate.AddHours(Limitation)).Hours);
        }

        //public virtual int? getPeriod()
        //{
        //    if (DateTime.Now > TimeCreate.AddHours(LifeTime))
        //    {
        //        return null;
        //    }
        //    if (DateTime.Now < TimeCreate.AddHours(Limitation))
        //    {
        //        return Price;
        //    }
        //    return Price - (Price * (decimal)(BakeryConstants.procent / 100.0) * DateTime.Now.Subtract(TimeCreate.AddHours(Limitation)).Hours);
        //}
    }
}
