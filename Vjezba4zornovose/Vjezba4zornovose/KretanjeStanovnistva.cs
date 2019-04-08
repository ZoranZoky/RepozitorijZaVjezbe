using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba4zornovose
{
    public class KretanjeStanovnistva
    {
        public int PocetnoStanje { get; set; }
        public int BrojRodenih { get; set; }
        public int BrojPreminulih { get; set; }
        public int BrojIseljenih { get; set; }
        public int BrojUseljenih { get; set; }
        public int PromjenaPoGodini { get; set; }
        public static BindingList<Godina> ListaPoGodini = new BindingList<Godina>();

        public KretanjeStanovnistva()
        {

        }

        public void IzracunajKretanje()
        {
            PromjenaPoGodini = ((BrojRodenih * 12) - (BrojPreminulih * 12) - (BrojIseljenih * 4 * 12) + (BrojUseljenih * 4 * 12));
            int trenutnoStanje = PocetnoStanje;
            int brojac = 0;
            ListaPoGodini.Clear();
            while(trenutnoStanje > 0)
            {
                brojac++;
                trenutnoStanje += PromjenaPoGodini;
                Godina nova = new Godina(brojac, trenutnoStanje);
                ListaPoGodini.Add(nova);
            }
            
        }
    }
}
