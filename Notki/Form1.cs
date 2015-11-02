using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Notki
{
    public partial class Form1 : Form
    {
        private string pathToNotes;
        private Note loadedNote;
        private List<string> names;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathToNotes = myDocumentsPath + "\\Notatki.net";

            if (Directory.Exists(pathToNotes))
            {
                reloadControls();
            }
            else
            {
                Directory.CreateDirectory(pathToNotes);
                MessageBox.Show("Nie znaleziono folderu z notatkami, utworzono nowy:\n" + pathToNotes,
                    "Nowy folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reloadControls()
        {
            List<string> paths = Directory.GetFiles(pathToNotes, "*.dat").ToList();
            names = new List<string>();
            names.Clear();

            foreach (var sciezka in paths)
                names.Add(Path.GetFileNameWithoutExtension(sciezka));

            listBox1.DataSource = names;
            toolStripStatusLabel1.Text = "Notatek: " + listBox1.Items.Count;
            checkQuantityOfListboxItems();
        }

        private void checkQuantityOfListboxItems()
        {
            if (listBox1.Items.Count != 0) return;

            buttonSaveChanges.Enabled = false;
            buttonUsunNotatke.Enabled = false;
            textBoxTitle.Text = "";
            textBoxText.Text = "";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            new NewNote(pathToNotes).Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            reloadControls();
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTytul_TextChanged(object sender, EventArgs e)
        {
            buttonSaveChanges.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUsunNotatke.Enabled = true;

            loadedNote = Note.LoadNote(pathToNotes+"\\"+listBox1.SelectedItem.ToString()+".dat");
            textBoxTitle.Text = loadedNote.Title;
            textBoxText.Text = loadedNote.Text;
            switch (loadedNote.Priority)
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
            buttonSaveChanges.Enabled = false;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string noteToSave=pathToNotes+"\\"+listBox1.SelectedItem+".dat";

            Note newNote = new Note()
            {
                DateOfCreation = loadedNote.DateOfCreation,
                Priority = getPriority(),
                Text = textBoxText.Text,
                Title = textBoxTitle.Text,
                DateOfModification = DateTime.Now
            };

            if (!Note.SaveChanges(noteToSave, pathToNotes, newNote))
                return;

            buttonSaveChanges.Enabled = false;

            reloadControls();
        }

        private byte getPriority()
        {
            if (radioButton1.Checked) return 1;
            if (radioButton2.Checked) return 2;
            if (radioButton3.Checked) return 3;
            if (radioButton4.Checked) return 4;
            return 5;
        }

        private void OpenInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathToNotes);
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Czy na pewno?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(decision==DialogResult.No) return;
            
            string noteToDelete = pathToNotes + "\\" + listBox1.SelectedItem + ".dat";

            if (!Note.DeleteNote(noteToDelete))
                return;

            reloadControls();
        }
    }
}