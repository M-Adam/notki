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
    public partial class Nowa : Form
    {
        

        public Nowa()
        {
            InitializeComponent();
        }

        private void Nowa_Load(object sender, EventArgs e)
        {
            comboBoxPriorytet.DataSource = Enum.GetValues(typeof(Importancy));
            
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Importancy waznoscNowejNotatki;
            Enum.TryParse<Importancy>(comboBoxPriorytet.SelectedValue.ToString(), out waznoscNowejNotatki);
            MessageBox.Show("Dało radę!\n"+waznoscNowejNotatki.ToString());
        }

        
    }
}
