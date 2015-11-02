using System;
using System.Windows.Forms;

namespace Notki
{
    public partial class NewNote : Form
    {
        private byte setPriority = 5;
        private bool isTextChanged = false;
        private readonly string pathToNotes;

        public NewNote(string documents)
        {
            InitializeComponent();
            this.pathToNotes = documents;
        }

        private bool isFilled()
        {
            if ((textBoxTitle.Text == "") || (textBoxText.Text == ""))
            {
                MessageBox.Show("Nie wszystkie pola zostały wypełnione!", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void getPriority(object sender, EventArgs e)
        {
            if (!(sender is RadioButton)) return;

            if ((sender as RadioButton).Checked)
                setPriority = Convert.ToByte((sender as RadioButton).Text);
            else
                setPriority = (byte)5;
        }
   
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!isFilled()) return;
            
            Note newNote = new Note()
            {
                DateOfCreation = DateTime.Now,
                Priority = setPriority,
                Title = textBoxTitle.Text,
                Text = textBoxText.Text
            };

            bool isSuccess = Note.CreateNewAndSerialize(newNote, pathToNotes);

            if (isSuccess)
            {
                MessageBox.Show("Notatka stworzona.","Sukces",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Istnieje już notatka o takiej samej nazwie!", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxTitle.Focus();
            }
        }

        private void textBoxTitle_textChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
        }

        private void buttonAbort_click(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult decision = MessageBox.Show("Czy na pewno chcesz anulować?", 
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (decision == DialogResult.Yes) Close();
            }
            else Close();
        }
    }
}