using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneo_Briscola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvaSquadra_Click(object sender, EventArgs e)
        {
            string nomeGiocatore1, cognomeGiocatore1;
            string nomeGiocatore2, cognomeGiocatore2;
            string nomeSquadra;


            setAll();
            if(isAllSet())
            {
                //Assegnazioni
                nomeGiocatore1 = tbNomeGiocatore1.Text;
                cognomeGiocatore1 = tbCognomeGiocatore1.Text;
                nomeGiocatore2 = tbNomeGiocatore2.Text;
                cognomeGiocatore2 = tbCognomeGiocatore2.Text;
                nomeSquadra = tbNomeSquadra.Text;

                //Salvataggio su db

            }
        }

        //Controlla se tutti i campi della form sono compilati
        private bool isAllSet()
        {
            if (string.IsNullOrEmpty(tbNomeGiocatore1.Text) ||
                string.IsNullOrEmpty(tbNomeGiocatore2.Text) ||
                string.IsNullOrEmpty(tbCognomeGiocatore1.Text) ||
                string.IsNullOrEmpty(tbCognomeGiocatore2.Text) ||
                string.IsNullOrEmpty(tbNomeSquadra.Text)
               )
                return true;
            else
                return false;
            
        }

        //Funzione usata per velocizzare i test per i debug
        private void setAll()
        {
            tbNomeGiocatore1.Text = "Marco";
            tbNomeGiocatore2.Text = "Luca";
            tbCognomeGiocatore1.Text = "Rossi";
            tbCognomeGiocatore2.Text = "Giudilli";
            tbNomeSquadra.Text = "I 2 matti";
        }
    }
}
