using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie13.Models;

namespace Zadanie13.Services
{
    public class ZamowienieService

    {
        private readonly CukierniaContext _context;

        public ZamowienieService(CukierniaContext context)
        {
            _context = context;
        }

        public List<Zamowienie> WszystkieZamowienia(Klient klient)
        {
            return _context.Zamowienie.Where(z => z.Klient == klient).ToList();
        }

        public List<Zamowienie> WszystkieZamowienia()
        {

            var a = _context.Zamowienie.ToList();

            return a;
        }
    }
}
