using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_DataGridView
{
	public partial class FormNeuesFahrzeug : Form
	{
		// Globale Eigenschaft mit der Sichtbarkeit public anlegen
		public Fahrzeug NeuesFahrzeug;

		public FormNeuesFahrzeug()
		{
			InitializeComponent();
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				// Eingaben prüfen
				// - Bezeichnung darf nicht leer sein

				// txtBezeichung => Steuerelement vom Typ TextBox mit dem Namen "txtBezeichnung"
				// . => Zugriff auf die Eigenschaften des Steuerelements
				// Text => Eigenschaft "Text" des Steuerelements (der in die TextBox eingegebene Text)
				// == => Operator, der linke und rechte Seite auf Gleichheit prüft
				//				- liefert true, wenn beides gleich ist
				//				- liefert false, bei Ungleichheit
				// "" => Leerer String (Eingabe ist leer)
				// throw : Löst eine Ausnahme aus
				// new ArgumentException: neues Objekt vom Typ ArgumentException wird erstellt
				//												=> Diese Ausnahme wird also ausgelöst
				// ("Bitte Bezeichnung eingeben.") => Meldungstext der Ausnahme
				if (txtBezeichnung.Text == "")
					throw new ArgumentException("Bitte Bezeichnung eingeben.");

				// - Kennzeichen darf nicht leer sein
				if (txtKennzeichen.Text == "")
					throw new ArgumentException("Bitte Kennzeichen eingeben.");

				// - Geschwindigkeit muss eine Zahl vom Typ int sein
				if (!int.TryParse(txtGeschwindigkeit.Text, out int geschwindigkeit))
					throw new ArgumentException("Bitte gültige Geschwindigkeit eingeben.");

				// Es soll ein neues Objekt vom Typ Fahrzeug angelegt werden
				// Bei der Konstruktion (Erstellung) des Objekts werden im 
				// Konstruktor die Eigenschaften passend gesetzt
				NeuesFahrzeug = new Fahrzeug(
					txtBezeichnung.Text,
					txtKennzeichen.Text,
					geschwindigkeit);

				// Überlegen: Wo kann dieses Objekt gespeichert werden?
				// => Es soll später in der Form1 ausgelesen 
				//		und der Datenquelle hinzugefügt werden

				// Rückgabe (DialogResult) passend setzen
				DialogResult = DialogResult.OK;

				// Formular schließen
				Close();
			}
			catch (Exception ex) 
			// Exception: Datentyp (ArgumentException ist eine Spezialform von Exception)
			// ex: ist die Variable, in der die Exception gespeichert wird
			{
				// => Fehlermeldung ausgeben
				// ex. => Auf gefangene Ausnahme zugreifen
				// Message => In dieser Eigenschaft der Ausnahme wird der Fehlertext gespeichert
				//						Dieser wurde oben in Klammern bei "new ArgumentException" vergeben
				MessageBox.Show(ex.Message);
			}
		}
	}
}
