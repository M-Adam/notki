using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Notki
{
    [Serializable]
    class Note:IComparable<Note>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Priority { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime? DateOfModification { get; set; }

        public int CompareTo(Note otherNote)
        {
            if (this.DateOfCreation > otherNote.DateOfCreation) return 1;
            if (this.DateOfCreation == otherNote.DateOfCreation) return 0;
            else return -1;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static bool CreateNewAndSerialize(Note newNote, string destPath)
        {
            IFormatter formatter = new BinaryFormatter();

            string fileName = newNote.Title + ".dat";
            
            if (File.Exists(destPath+"\\"+fileName))
                return false;

            try
            {
                using (Stream str = File.Create(destPath + "\\" + fileName))
                    formatter.Serialize(str, newNote);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie udało się utworzyć pliku.\n" + e.Message, "Błąd!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static Note LoadNote(string pathToNote)
        {
            Note loadedNote;
            IFormatter formatter = new BinaryFormatter();

            try
            {
                using (Stream str = File.OpenRead(pathToNote))
                {
                    loadedNote = (Note) formatter.Deserialize(str);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy ładowaniu notatki.\n" + e.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

            return loadedNote;
        }

        public static bool SaveChanges(string noteToOverwrite, string sciezkaDoFolderuZNotatkami, Note notatkaDoZapisania)
        {
            try
            {
                File.Delete(noteToOverwrite);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie udało się skasować poprzedniej wersji." + e.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (!Note.CreateNewAndSerialize(notatkaDoZapisania, sciezkaDoFolderuZNotatkami))
            {
                MessageBox.Show("Nie udało się zapisać zmian!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool DeleteNote(string noteToDelete)
        {
            try
            {
                File.Delete(noteToDelete);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie udało się skasować notatki." + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}