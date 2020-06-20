using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie13.Models
{
    public class Zamowienie_WyrobCukierniczy
    {
        [ForeignKey("WyrobCukierniczy")]
        public int IdWyrobuCukierniczego { get; set; }

        [ForeignKey("Zamowienie")]
        public int IdZamowienia { get; set; }

        [Required]
        public int Ilosc { get; set; }

        [MaxLength(300)]
        public String Uwagi { get; set; }

        public Zamowienie Zamowienie { get; set; }
        public WyrobCukierniczy WyrobCukierniczy { get; set; }

    }
}
