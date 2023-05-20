using System.Threading.Tasks;

namespace TraderPlusEditor._Core._Language
{
    internal class LanguageCore
    {
        public static async Task GetnSetLanguage()
        {
            // suche systemsprache des benutzers und setze den Wert in einen String
            string currentSystemLanguage = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            // Wenn in den Settings die Variable language den Wert initial enthält
            if (Properties.Settings.Default.LanguageKey == "init")
            {
                //Wenn die Systemsprache de ist
                if (currentSystemLanguage == "de")
                {
                    // Setze den Wert für die variable language auf de und speichere diese
                    Properties.Settings.Default.LanguageKey = "de";
                    Properties.Settings.Default.Save();
                }
                else if (currentSystemLanguage == "fr")
                {
                    // Setze den Wert für die variable language auf fra und speichere diese
                    Properties.Settings.Default.LanguageKey = "fr";
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // ist die systemsprache nicht de, setze den Wert eng für die variable language
                    Properties.Settings.Default.LanguageKey = "en";
                    Properties.Settings.Default.Save();
                }
                await Task.Delay(10);
            }
        }
    }
}
