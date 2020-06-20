using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie13.Models;

namespace Zadanie13.Services
{
    public interface IZamowienieService
    {
        public List<Zamowienie> WszystkieZamowienia(Klient klient);

        public List<Zamowienie> WszystkieZamowienia();
    }
}
