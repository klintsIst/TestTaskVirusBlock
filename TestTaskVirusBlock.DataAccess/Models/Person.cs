using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskVirusBlock.DataAccess.Models
{
    /// <summary>
    /// Модель для человека
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string LastName { get; set; }
    }
}
