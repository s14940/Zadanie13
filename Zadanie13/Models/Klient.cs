
using System;
using System.ComponentModel.DataAnnotations;

namespace Zadanie13.Models
{
    public class Klient
    {
        [Key]
        public int IdKlient { get; set; }

        [Required]
        [MaxLength(50)]
        public String Imie { get; set; }

        [Required]
        [MaxLength(60)]
        public String Nazwisko { get; set; }
    }
}
