using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie13.Models
{
    public class WyrobCukierniczy
    {
        [Key]
        public int IdWyrobuCukierniczego { get; set; }
        [Required]
        [MaxLength(200)]
        public String Nazwa { get; set; }
        
        [Required]
        public float CenaZaSzt { get; set; }

        [Required]
        [MaxLength(40)]
        public String Typ { get; set; }

        public List<Zamowienie_WyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }
    }
}
