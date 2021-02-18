using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_DataGridView
{
	class Fahrzeug
	{
		// Eigenschaften (Codeausschnitt: prop)
		public string Bezeichnung { get; set; }
		public string Kennzeichen { get; set; }
		public int Geschwindigkeit { get; private set; }

		// Konstruktor (Codeausschnitt: ctor)
		public Fahrzeug(string bezeichnung, 
			string kennzeichen, int geschwindigkeit)
		{
			Bezeichnung = bezeichnung;
			Kennzeichen = kennzeichen;
			Geschwindigkeit = geschwindigkeit;
		}

		// Methode
		public void Beschleunigen(int wert) => Geschwindigkeit += wert;
	}
}
