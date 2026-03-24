namespace Torneo_Briscola
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvaSquadra = new System.Windows.Forms.Button();
            this.tbNomeGiocatore1 = new System.Windows.Forms.TextBox();
            this.tbCognomeGiocatore1 = new System.Windows.Forms.TextBox();
            this.tbNomeGiocatore2 = new System.Windows.Forms.TextBox();
            this.tbCognomeGiocatore2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lviSquadre = new System.Windows.Forms.ListView();
            this.cdSquadra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cdGiocatore1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cdGiocatore2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomeSquadra = new System.Windows.Forms.TextBox();
            this.btCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSalvaSquadra
            // 
            this.btSalvaSquadra.Location = new System.Drawing.Point(513, 187);
            this.btSalvaSquadra.Name = "btSalvaSquadra";
            this.btSalvaSquadra.Size = new System.Drawing.Size(105, 50);
            this.btSalvaSquadra.TabIndex = 0;
            this.btSalvaSquadra.Text = "Salva";
            this.btSalvaSquadra.UseVisualStyleBackColor = true;
            this.btSalvaSquadra.Click += new System.EventHandler(this.btSalvaSquadra_Click);
            // 
            // tbNomeGiocatore1
            // 
            this.tbNomeGiocatore1.Location = new System.Drawing.Point(159, 45);
            this.tbNomeGiocatore1.Name = "tbNomeGiocatore1";
            this.tbNomeGiocatore1.Size = new System.Drawing.Size(100, 22);
            this.tbNomeGiocatore1.TabIndex = 1;
            // 
            // tbCognomeGiocatore1
            // 
            this.tbCognomeGiocatore1.Location = new System.Drawing.Point(297, 45);
            this.tbCognomeGiocatore1.Name = "tbCognomeGiocatore1";
            this.tbCognomeGiocatore1.Size = new System.Drawing.Size(100, 22);
            this.tbCognomeGiocatore1.TabIndex = 2;
            // 
            // tbNomeGiocatore2
            // 
            this.tbNomeGiocatore2.Location = new System.Drawing.Point(159, 85);
            this.tbNomeGiocatore2.Name = "tbNomeGiocatore2";
            this.tbNomeGiocatore2.Size = new System.Drawing.Size(100, 22);
            this.tbNomeGiocatore2.TabIndex = 3;
            // 
            // tbCognomeGiocatore2
            // 
            this.tbCognomeGiocatore2.Location = new System.Drawing.Point(297, 85);
            this.tbCognomeGiocatore2.Name = "tbCognomeGiocatore2";
            this.tbCognomeGiocatore2.Size = new System.Drawing.Size(100, 22);
            this.tbCognomeGiocatore2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giocatore1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giocatore2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cognome";
            // 
            // lviSquadre
            // 
            this.lviSquadre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cdSquadra,
            this.cdGiocatore1,
            this.cdGiocatore2});
            this.lviSquadre.HideSelection = false;
            this.lviSquadre.Location = new System.Drawing.Point(36, 187);
            this.lviSquadre.Name = "lviSquadre";
            this.lviSquadre.Size = new System.Drawing.Size(446, 251);
            this.lviSquadre.TabIndex = 9;
            this.lviSquadre.UseCompatibleStateImageBehavior = false;
            this.lviSquadre.View = System.Windows.Forms.View.Details;
            // 
            // cdSquadra
            // 
            this.cdSquadra.Text = "Squadra";
            this.cdSquadra.Width = 80;
            // 
            // cdGiocatore1
            // 
            this.cdGiocatore1.Text = "Giocatore1";
            this.cdGiocatore1.Width = 93;
            // 
            // cdGiocatore2
            // 
            this.cdGiocatore2.Text = "Giocatore2";
            this.cdGiocatore2.Width = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome squadra:";
            // 
            // tbNomeSquadra
            // 
            this.tbNomeSquadra.Location = new System.Drawing.Point(159, 146);
            this.tbNomeSquadra.Name = "tbNomeSquadra";
            this.tbNomeSquadra.Size = new System.Drawing.Size(238, 22);
            this.tbNomeSquadra.TabIndex = 10;
            // 
            // btCalcola
            // 
            this.btCalcola.Location = new System.Drawing.Point(513, 308);
            this.btCalcola.Name = "btCalcola";
            this.btCalcola.Size = new System.Drawing.Size(105, 50);
            this.btCalcola.TabIndex = 12;
            this.btCalcola.Text = "Calcola";
            this.btCalcola.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCalcola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNomeSquadra);
            this.Controls.Add(this.lviSquadre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCognomeGiocatore2);
            this.Controls.Add(this.tbNomeGiocatore2);
            this.Controls.Add(this.tbCognomeGiocatore1);
            this.Controls.Add(this.tbNomeGiocatore1);
            this.Controls.Add(this.btSalvaSquadra);
            this.Name = "Form1";
            this.Text = "Torneo di briscola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvaSquadra;
        private System.Windows.Forms.TextBox tbNomeGiocatore1;
        private System.Windows.Forms.TextBox tbCognomeGiocatore1;
        private System.Windows.Forms.TextBox tbNomeGiocatore2;
        private System.Windows.Forms.TextBox tbCognomeGiocatore2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lviSquadre;
        private System.Windows.Forms.ColumnHeader cdSquadra;
        private System.Windows.Forms.ColumnHeader cdGiocatore1;
        private System.Windows.Forms.ColumnHeader cdGiocatore2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeSquadra;
        private System.Windows.Forms.Button btCalcola;
    }
}

