using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie13.Models
{
    public class Pracownik
    {
        [Key]
        public int IdPracown { get; set; }

        [Required]
        [MaxLength(50)]
        public String Imie { get; set; }

        [Required]
        [MaxLength(60)]
        public String Nazwisko { get; set; }

    }
}
