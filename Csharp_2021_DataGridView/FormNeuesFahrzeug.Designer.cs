
namespace Csharp_2021_DataGridView
{
	partial class FormNeuesFahrzeug
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBezeichnung = new System.Windows.Forms.TextBox();
			this.txtKennzeichen = new System.Windows.Forms.TextBox();
			this.txtGeschwindigkeit = new System.Windows.Forms.TextBox();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.btnAbbrechen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bezeichnung:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kennzeichen:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Geschwindigkeit:";
			// 
			// txtBezeichnung
			// 
			this.txtBezeichnung.Location = new System.Drawing.Point(130, 10);
			this.txtBezeichnung.Name = "txtBezeichnung";
			this.txtBezeichnung.Size = new System.Drawing.Size(100, 20);
			this.txtBezeichnung.TabIndex = 3;
			// 
			// txtKennzeichen
			// 
			this.txtKennzeichen.Location = new System.Drawing.Point(130, 34);
			this.txtKennzeichen.Name = "txtKennzeichen";
			this.txtKennzeichen.Size = new System.Drawing.Size(100, 20);
			this.txtKennzeichen.TabIndex = 4;
			// 
			// txtGeschwindigkeit
			// 
			this.txtGeschwindigkeit.Location = new System.Drawing.Point(130, 58);
			this.txtGeschwindigkeit.Name = "txtGeschwindigkeit";
			this.txtGeschwindigkeit.Size = new System.Drawing.Size(100, 20);
			this.txtGeschwindigkeit.TabIndex = 5;
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(16, 97);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 6;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			// 
			// btnAbbrechen
			// 
			this.btnAbbrechen.Location = new System.Drawing.Point(155, 97);
			this.btnAbbrechen.Name = "btnAbbrechen";
			this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
			this.btnAbbrechen.TabIndex = 7;
			this.btnAbbrechen.Text = "Abbrechen";
			this.btnAbbrechen.UseVisualStyleBackColor = true;
			// 
			// FormNeuesFahrzeug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 137);
			this.Controls.Add(this.btnAbbrechen);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.txtGeschwindigkeit);
			this.Controls.Add(this.txtKennzeichen);
			this.Controls.Add(this.txtBezeichnung);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormNeuesFahrzeug";
			this.Text = "Neues Fahrzeug hinzufügen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBezeichnung;
		private System.Windows.Forms.TextBox txtKennzeichen;
		private System.Windows.Forms.TextBox txtGeschwindigkeit;
		private System.Windows.Forms.Button btnSpeichern;
		private System.Windows.Forms.Button btnAbbrechen;
	}
}