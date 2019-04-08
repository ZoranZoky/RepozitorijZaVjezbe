using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba4zornovose
{
    public class Godina
    {
        public int Brojac { get; set; }
        public int Vrijednost { get; set; }
        public Godina(int brojac, int vrijednost)
        {
            this.Brojac = brojac;
            this.Vrijednost = vrijednost;
        }

        public override string ToString()
        {
            return "Godina: " + Brojac.ToString() + " Broj stanovnika: " + Vrijednost.ToString();
        }
    }
}
