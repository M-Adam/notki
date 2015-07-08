using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notki
{
    public partial class Form1 : Form
    {
        //List<Notatka> lista = new List<Notatka>()
        //    {
        //        new Notatka()
        //        {
        //            DataUtworzenia = new DateTime(2015, 07, 08), 
        //            Waznosc = Importancy.BWazne, 
        //            Wiadomosc = "cokolwiek",
        //            Tytul = "pierwsza"
        //        },
        //        new Notatka()
        //        {
        //            DataUtworzenia = new DateTime(1900, 07, 08),
        //            Waznosc = Importancy.MWazne,
        //            Wiadomosc = "cokolwiek v2",
        //            Tytul = "druga"
        //        },
        //        new Notatka()
        //        {
        //            DataUtworzenia = new DateTime(2000, 07, 08),
        //            Waznosc = Importancy.SWazne,
        //            Wiadomosc = "cokolwiek v3",
        //            Tytul = "trzecia"
        //        }
        //    };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            new Nowa().Show();
        }

        
    }
}
