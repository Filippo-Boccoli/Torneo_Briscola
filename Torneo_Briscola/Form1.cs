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

            //setAll(); //Momentanea

            if (isAllSet())
            {
                //Assegnazioni
                nomeGiocatore1 = tbNomeGiocatore1.Text;
                cognomeGiocatore1 = tbCognomeGiocatore1.Text;
                nomeGiocatore2 = tbNomeGiocatore2.Text;
                cognomeGiocatore2 = tbCognomeGiocatore2.Text;
                nomeSquadra = tbNomeSquadra.Text;

                //Aggiungere alla Lista del program
                Program.Squadra squadra;
                Program.Giocatore giocatore1, giocatore2;
                giocatore1.Nome = nomeGiocatore1;
                giocatore1.Cognome = cognomeGiocatore1;
                giocatore2.Nome = nomeGiocatore2;
                giocatore2.Cognome = cognomeGiocatore2;
                squadra.Nome = nomeSquadra;
                squadra.Giocatore1 = giocatore1;
                squadra.Giocatore2 = giocatore2;


                //Salvataggio su db
                if(Program.inserisciSquadra(squadra))
                {
                    unSetAll();
                    Program.squadre = Program.caricaSquadre();
                }

                //Visualizza nella ListView
                popolaListView();


            }
            else
            {
                MessageBox.Show("Assicurati di aver inserito tutti i campi", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        //Controlla se tutti i campi della form sono compilati
        private bool isAllSet()
        {
            if (string.IsNullOrEmpty(tbNomeGiocatore1.Text) ||
                string.IsNullOrEmpty(tbNomeGiocatore2.Text) ||
                string.IsNullOrEmpty(tbCognomeGiocatore1.Text) ||
                string.IsNullOrEmpty(tbCognomeGiocatore2.Text)
               )
                return false;
            else
                return true;
            
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

        private void unSetAll()
        {
            tbNomeGiocatore1.Text = "";
            tbNomeGiocatore2.Text = "";
            tbCognomeGiocatore1.Text = "";
            tbCognomeGiocatore2.Text = "";
            tbNomeSquadra.Text = "";
        }

        private void popolaListView()
        {
            lviSquadre.Items.Clear();
            ListViewItem lvi = new ListViewItem();
            foreach (Program.Squadra squadra in Program.squadre)
            {
                lvi = new ListViewItem(squadra.Nome);
                lvi.SubItems.Add(squadra.Giocatore1.Cognome);
                lvi.SubItems.Add(squadra.Giocatore2.Cognome);
                lviSquadre.Items.Add(lvi);            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popolaListView();
        }
    }
}
