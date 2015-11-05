using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartijeCas
{
    public enum TipPartije
    {
        Tekuci_racun,
        Dinarska_stednja,
        Devizna_stednja,
        Kreditna_stednja
    }

    class Partija
    {
        private int[] promene = new int[10];
  

        private  int _balans = 0;
        private Vlasnik _vlasnikPartije;
        private string _brojPartije;
        TipPartije _tipPartije;

        public int[] Promene { get; set; }
       

        public int Balans { get; set; }
        public string BrojPartije { get; set; }
        public Vlasnik VlasnikPartije { get; set; }
        public TipPartije TipPartije { get; set; }

    }
}
