
namespace Csharp_2021_DataGridView
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grdFahrzeuge = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKennzeichen = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBeschreibung = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGeschwindigkeit = new System.Windows.Forms.TextBox();
			this.btnFahrzeugAusgeben = new System.Windows.Forms.Button();
			this.txtBeschleunigen = new System.Windows.Forms.TextBox();
			this.btnBeschleunigen = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fahrzeugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdFahrzeuge)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBeschleunigen);
			this.groupBox1.Controls.Add(this.txtBeschleunigen);
			this.groupBox1.Controls.Add(this.btnFahrzeugAusgeben);
			this.groupBox1.Controls.Add(this.txtGeschwindigkeit);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtBeschreibung);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtKennzeichen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.grdFahrzeuge);
			this.groupBox1.Location = new System.Drawing.Point(12, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(591, 342);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fahrzeuge";
			// 
			// grdFahrzeuge
			// 
			this.grdFahrzeuge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdFahrzeuge.Location = new System.Drawing.Point(6, 19);
			this.grdFahrzeuge.Name = "grdFahrzeuge";
			this.grdFahrzeuge.Size = new System.Drawing.Size(579, 207);
			this.grdFahrzeuge.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ausgewähltes Fahrzeug:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 263);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kennzeichen:";
			// 
			// txtKennzeichen
			// 
			this.txtKennzeichen.Location = new System.Drawing.Point(87, 260);
			this.txtKennzeichen.Name = "txtKennzeichen";
			this.txtKennzeichen.Size = new System.Drawing.Size(100, 20);
			this.txtKennzeichen.TabIndex = 3;
			this.txtKennzeichen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateOnEnter);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(210, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Beschreibung:";
			// 
			// txtBeschreibung
			// 
			this.txtBeschreibung.Location = new System.Drawing.Point(292, 260);
			this.txtBeschreibung.Name = "txtBeschreibung";
			this.txtBeschreibung.Size = new System.Drawing.Size(100, 20);
			this.txtBeschreibung.TabIndex = 5;
			this.txtBeschreibung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateOnEnter);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(407, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Geschwindigkeit:";
			// 
			// txtGeschwindigkeit
			// 
			this.txtGeschwindigkeit.Enabled = false;
			this.txtGeschwindigkeit.Location = new System.Drawing.Point(501, 260);
			this.txtGeschwindigkeit.Name = "txtGeschwindigkeit";
			this.txtGeschwindigkeit.Size = new System.Drawing.Size(69, 20);
			this.txtGeschwindigkeit.TabIndex = 7;
			// 
			// btnFahrzeugAusgeben
			// 
			this.btnFahrzeugAusgeben.Location = new System.Drawing.Point(9, 313);
			this.btnFahrzeugAusgeben.Name = "btnFahrzeugAusgeben";
			this.btnFahrzeugAusgeben.Size = new System.Drawing.Size(292, 23);
			this.btnFahrzeugAusgeben.TabIndex = 1;
			this.btnFahrzeugAusgeben.Text = "Ausgewähltes Fahrzeug in der Konsole ausgeben";
			this.btnFahrzeugAusgeben.UseVisualStyleBackColor = true;
			this.btnFahrzeugAusgeben.Click += new System.EventHandler(this.btnFahrzeugAusgeben_Click);
			// 
			// txtBeschleunigen
			// 
			this.txtBeschleunigen.Location = new System.Drawing.Point(501, 287);
			this.txtBeschleunigen.Name = "txtBeschleunigen";
			this.txtBeschleunigen.Size = new System.Drawing.Size(69, 20);
			this.txtBeschleunigen.TabIndex = 8;
			// 
			// btnBeschleunigen
			// 
			this.btnBeschleunigen.Location = new System.Drawing.Point(401, 285);
			this.btnBeschleunigen.Name = "btnBeschleunigen";
			this.btnBeschleunigen.Size = new System.Drawing.Size(94, 23);
			this.btnBeschleunigen.TabIndex = 9;
			this.btnBeschleunigen.Text = "Beschleunigen";
			this.btnBeschleunigen.UseVisualStyleBackColor = true;
			this.btnBeschleunigen.Click += new System.EventHandler(this.btnBeschleunigen_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fahrzeugToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fahrzeugToolStripMenuItem
			// 
			this.fahrzeugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem});
			this.fahrzeugToolStripMenuItem.Name = "fahrzeugToolStripMenuItem";
			this.fahrzeugToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.fahrzeugToolStripMenuItem.Text = "Fahrzeug";
			// 
			// hinzufügenToolStripMenuItem
			// 
			this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
			this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
			this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Fahrzeugverwaltung";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdFahrzeuge)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grdFahrzeuge;
		private System.Windows.Forms.TextBox txtGeschwindigkeit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBeschreibung;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtKennzeichen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFahrzeugAusgeben;
		private System.Windows.Forms.Button btnBeschleunigen;
		private System.Windows.Forms.TextBox txtBeschleunigen;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fahrzeugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
	}
}

