using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryProject.Models.ViewModels
{
    public class BunViewModel
    {
        public int Number { get; set; }
        /// <summary>
        /// Наименование булки
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цена начальная
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Цена текущая
        /// </summary>
        public decimal? PriceCurrent { get; set; }
        /// <summary>
        /// Цена прогноз
        /// </summary>
        public decimal PriceForecast { get; set; }
        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime TimeCreate { get; set; }
        /// <summary>
        /// через сколько поменяется цена
        /// </summary>
        public int Period { get; set; }

    }
}
