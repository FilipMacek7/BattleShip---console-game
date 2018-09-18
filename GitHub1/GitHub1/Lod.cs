using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub1
{
    class Lod
    {
        public string oznaceni;
        public string stav;
        private int velikost;
        List<Lod> lode = new List<Lod>();
        public Lod()
        {
            lode.Add(new Lod
            {
                oznaceni = "ponorka",
                velikost = 1,
                stav = String.Empty
            });
            lode.Add(new Lod
            {
                oznaceni = "torpédoborec",
                velikost = 2,
                stav = String.Empty
            });
            lode.Add(new Lod
            {
                oznaceni = "křižník",
                velikost = 3,
                stav = String.Empty
            });
            lode.Add(new Lod
            {
                oznaceni = "bitevní loď",
                velikost = 4,
                stav = String.Empty
            });
            lode.Add(new Lod
            {
                oznaceni = "letadlová loď",
                velikost = 5,
                stav = String.Empty
            });
        }
    }
}
