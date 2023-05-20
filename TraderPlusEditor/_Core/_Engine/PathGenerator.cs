using System.IO;
using System.Threading.Tasks;
using System;

namespace TraderPlusEditor._Core._Engine
{
    internal class PathGenerator
    {
        static public string editorFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EXPORTS");
        static public string previewFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TraderPlusEditor", "PREVIEW");

        public static async Task GeneratePath()
        {
            if (!Directory.Exists(editorFolderPath))
            {
                Directory.CreateDirectory(editorFolderPath);
            }

            if (!Directory.Exists(previewFolderPath))
            {
                Directory.CreateDirectory(previewFolderPath);
            }
            await Task.Delay(200);
        }

        // --- Vorschau-Beispiel verschieben --- //
        public static async Task GeneratePreviewFolder()
        {
            string previewFolder = Path.Combine(System.Windows.Forms.Application.StartupPath, "DO_NOT_TOUCH");

            // Überprüfen, ob der PREVIEW-Ordner existiert
            if (Directory.Exists(previewFolder))
            {
                // Den Inhalt des PREVIEW-Ordners in den previewFolderPath verschieben
                foreach (string file in Directory.GetFiles(previewFolder))
                {
                    string fileName = Path.GetFileName(file);
                    string destinationPath = Path.Combine(previewFolderPath, fileName);

                    // Überprüfen, ob die Datei bereits im Zielordner existiert
                    if (!File.Exists(destinationPath))
                    {
                        // Datei in den Zielordner verschieben
                        File.Move(file, destinationPath);
                    }
                }

                // Den leeren PREVIEW-Ordner löschen
                Directory.Delete(previewFolder, recursive: true);
                await Task.Delay(200);
            }
        }
    }
}
