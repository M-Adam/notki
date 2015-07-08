using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notki
{
    public enum Importancy
    {
        BWazne = 5,
        Wazne = 4,
        SWazne = 3,
        MWazne = 2,
        NWazne = 1
    }

    class Notatka:IComparable<Notatka>
    {
        public string Tytul { get; set; }
        public string Wiadomosc
        {
            get { return this.Wiadomosc; }
            set
            {
                if (value.Length > 1000)
                {
                    MessageBox.Show("Maksymalna długość wiadomości to 1000 znaków");
                    throw new Exception("Przekroczono maksymalną długość wiadomości.");
                }
            } 
        }
        public Importancy Waznosc { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime? DataModyfikacji { get; set; }

        public int CompareTo(Notatka innaNotatka)
        {
            if (this.DataUtworzenia > innaNotatka.DataUtworzenia) return 1;
            if (this.DataUtworzenia == innaNotatka.DataUtworzenia) return 0;
            else return -1;
        }

        public override string ToString()
        {
            return this.Tytul;
        }

        
    }
}
