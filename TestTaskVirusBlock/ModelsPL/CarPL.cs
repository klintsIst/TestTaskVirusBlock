using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskVirusBlock.ModelsPL
{
    public class CarPL
    {
        /// <summary>
        /// Марка авто
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Модель авто
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Дата производства авто
        /// </summary>
        public DateTime YearCreation { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Автомат или ручная
        /// </summary>
        public bool IsAutomaticTransmission { get; set; }
    }
}
