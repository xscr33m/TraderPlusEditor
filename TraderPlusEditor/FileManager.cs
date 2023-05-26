using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TraderPlusEditor
{
    public static class FileHelper
    {
        public static JsonData LoadFile(string filePath)
        {
            // JSON-Datei lesen und deserialisieren
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<JsonData>(json);
        }

        public static void ExportFile(string filePath, JsonData jsonData, ListView productsListView, string editorFolderPath)
        {
            // Übertrage die Änderungen aus den ListViews zurück in die jsonData-Instanz

            // Kategorien aktualisieren
            jsonData.TraderCategories.Clear();
            foreach (ListViewGroup group in productsListView.Groups)
            {
                string categoryName = group.Header;
                List<string> products = new List<string>();

                // Produkte für die Kategorie sammeln
                foreach (ListViewItem item in group.Items)
                {
                    string productName = item.SubItems[0].Text;
                    string productCoefficient = item.SubItems[1].Text;
                    string maxStock = item.SubItems[2].Text;
                    string tradeQuantity = item.SubItems[3].Text;
                    string buyPrice = item.SubItems[4].Text;
                    string sellPrice = item.SubItems[5].Text;
                    string destockCoefficient = string.Empty;

                    if (item.SubItems.Count >= 7)
                    {
                        destockCoefficient = item.SubItems[6].Text;
                    }

                    string productData;

                    if (!string.IsNullOrEmpty(destockCoefficient))
                    {
                        productData = $"{productName},{productCoefficient},{maxStock},{tradeQuantity},{buyPrice},{sellPrice},{destockCoefficient}";
                    }
                    else
                    {
                        productData = $"{productName},{productCoefficient},{maxStock},{tradeQuantity},{buyPrice},{sellPrice}";
                    }

                    products.Add(productData);
                }

                Category category = new Category
                {
                    CategoryName = categoryName,
                    Products = products
                };

                jsonData.TraderCategories.Add(category);
            }

            // Geladene Daten in eine neue JSON-Datei serialisieren und speichern
            string serializedJson = JsonConvert.SerializeObject(jsonData, Formatting.Indented);

            // Neuen Dateinamen erstellen
            string newFileName = Path.GetFileName(filePath);
            string newFilePath = Path.Combine(editorFolderPath, newFileName);

            // Existierende Datei archivieren, falls vorhanden
            if (File.Exists(newFilePath))
            {
                int counter = 1;
                string oldFilePath = Path.Combine(editorFolderPath, $"{newFileName}.old{counter}");

                while (File.Exists(oldFilePath))
                {
                    counter++;
                    oldFilePath = Path.Combine(editorFolderPath, $"{newFileName}.old{counter}");
                }

                File.Move(newFilePath, oldFilePath);
            }

            File.WriteAllText(newFilePath, serializedJson);
        }
    }
}