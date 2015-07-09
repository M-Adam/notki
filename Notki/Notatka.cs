using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notki
{
    [Serializable]
    class Notatka:IComparable<Notatka>
    {
        public string Tytul { get; set; }
        public string Wiadomosc { get; set; }
        public byte Waznosc { get; set; }
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

        public static bool UtworzNowyPlikSerializuj(Notatka nowaNotatka, string sciezka)
        {
            IFormatter formatter = new BinaryFormatter();

            string nazwaPliku = nowaNotatka.Tytul + ".dat";
            MessageBox.Show(sciezka + "\\" + nazwaPliku);
            if (File.Exists(sciezka+"\\"+nazwaPliku))
                return false;

            try
            {
                using (Stream strim = File.Create(sciezka + "\\" + nazwaPliku))
                    formatter.Serialize(strim, nowaNotatka);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie udało się utworzyć pliku.\n" + e.Message, "Błąd!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static Notatka WczytajNotatke(string notatkaDoWczytania_sciezka)
        {
            Notatka przywroconaNotatka;
            IFormatter formatter = new BinaryFormatter();

            try
            {
                using (Stream strim = File.OpenRead(notatkaDoWczytania_sciezka))
                {
                    przywroconaNotatka = (Notatka) formatter.Deserialize(strim);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy ładowaniu notatki.\n" + e.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

            return przywroconaNotatka;
        }

        public static bool ZapiszZmiany(string notatkaDoZapisania_sciezka, Notatka notatkaDoZapisania)
        {
            
        }

       }
}
