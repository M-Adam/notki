using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Notki
{
    
    public partial class Nowa : Form
    {
        private byte ustawionaWaznosc = 5;
        private bool czyTextZmieniony = false;
        private readonly string sciezkaDoNotatek;
        

        public Nowa(string dokumenty)
        {
            InitializeComponent();
            sciezkaDoNotatek = dokumenty;
        }

        private bool czyWypelnione()
        {
            if ((textBoxTytul.Text == "") || (textBoxTresc.Text == ""))
            {
                MessageBox.Show("Nie wszystkie pola zostały wypełnione!", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }

        private void pobierzPriorytet(object sender, EventArgs e)
        {
            ustawionaWaznosc = ((RadioButton) sender).Checked ? Convert.ToByte(((RadioButton) sender).Text) : (byte)5;
        }
   
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!czyWypelnione()) return;
            
            Notatka nowaNotatka = new Notatka()
            {
                DataUtworzenia = DateTime.Now,
                Waznosc = ustawionaWaznosc,
                Tytul = textBoxTytul.Text,
                Wiadomosc = textBoxTresc.Text
            };
            bool czySieUdaloutworzyc = Notatka.UtworzNowyPlikSerializuj(nowaNotatka, sciezkaDoNotatek);
            if (czySieUdaloutworzyc)
            {
                MessageBox.Show("Notatka stworzona.","Sukces",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Istnieje już notatka o takiej samej nazwie!", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxTytul.Focus();
            }
        }

        private void textBoxTytul_TextChanged(object sender, EventArgs e)
        {
            czyTextZmieniony = true;
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            if (czyTextZmieniony)
            {
                DialogResult pytanie = MessageBox.Show("Czy na pewno chcesz anulować?", this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (pytanie == DialogResult.Yes) Close();

            }
            else Close();
        }
    }
}
