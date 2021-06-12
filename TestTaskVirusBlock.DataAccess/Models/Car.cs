using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestTaskVirusBlock.DataAccess.Models
{
    /// <summary>
    /// Модель для авто
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Уникальный идентификатор авто
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Марка авто
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        /// <summary>
        /// Модель авто
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        /// <summary>
        /// Дата производства авто
        /// </summary>
        public DateTime YearCreation { get; set; }

        /// <summary>
        /// Цвет авто
        /// </summary>
        [MaxLength(100)]
        public string Color { get; set; }

        /// <summary>
        /// Автомат или ручная
        /// </summary>
        [Required]
        public bool IsAutomaticTransmission { get; set; }
    }
}
