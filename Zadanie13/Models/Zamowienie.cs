
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie13.Models
{
    public class Zamowienie
    {
        [Key]
        public int IdZamowienia { get; set; }

        [Required]
        public DateTime DataPrzyjecia { get; set; }
        public DateTime DataRealizacji {get; set; }

        [MaxLength(300)]
        public String Uwagi { get; set; }

        [ForeignKey("Klient")]
        [Required]
        public int IdKlient { get; set; }
        public Klient Klient { get; set; }

        [Required]
        [ForeignKey("Pracownik")]
        public int IdPracownik { get; set; }
        public Pracownik Pracownik { get; set; }

        public List<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobCukierniczies { get; set; }



    }
}
