using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notki
{
    public partial class Form1 : Form
    {
        private string sciezkaDoNotatek;
        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string mojeDokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sciezkaDoNotatek = mojeDokumenty + "\\Notatki.net";
            if (Directory.Exists(sciezkaDoNotatek))
            {
               // listBox1.DataSource = Directory.GetFiles(sciezkaDoNotatek, "*.dat");
                var listaSciezek = Directory.GetFiles(sciezkaDoNotatek, "*.dat").ToList();
                List<string> listaNazw = new List<string>();
                foreach (var sciezka in listaSciezek)
                    listaNazw.Add(Path.GetFileNameWithoutExtension(sciezka));
                listBox1.DataSource = listaNazw;

            }
            else
            {
                Directory.CreateDirectory(sciezkaDoNotatek);
                MessageBox.Show("Nie znaleziono folderu z notatkami, utworzono nowy:\n" + sciezkaDoNotatek,
                    "Nowy folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void buttonNew_Click(object sender, EventArgs e)
        {
            new Nowa(sciezkaDoNotatek).Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            listBox1.Refresh();
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTytul_TextChanged(object sender, EventArgs e)
        {
            buttonZapiszZmiany.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wybrany_item = listBox1.SelectedItem;
           
            if (buttonZapiszZmiany.Enabled)
            {
                var decyzja = MessageBox.Show("Czy chcesz porzucić zmiany", "Zapis", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (decyzja == DialogResult.No)
                {
                    listBox1.SelectedItem = wybrany_item;
                    return;
                }
            }

            buttonUsunNotatke.Enabled = true;

            Notatka zaladowanaNotatka = Notatka.WczytajNotatke(sciezkaDoNotatek+"\\"+listBox1.SelectedItem.ToString()+".dat");
            textBoxTytul.Text = zaladowanaNotatka.Tytul;
            textBoxTresc.Text = zaladowanaNotatka.Wiadomosc;
            switch (zaladowanaNotatka.Waznosc)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
                case 5:
                    radioButton5.Checked = true;
                    break;
                default:
                    radioButton5.Checked = true;
                    break;
            }
            buttonZapiszZmiany.Enabled = false;


        }

        
    }
}
