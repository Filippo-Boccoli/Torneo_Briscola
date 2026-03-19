using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneo_Briscola
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //Strutture dati
        public struct Giocatore
        {
            public string Nome;
            public string Cognome;
        }

        public struct Squadra
        {
            public string Nome;
            public Giocatore Giocatore1;
            public Giocatore Giocatore2;
        }

        //Variabili per tutto il programma
        public static List<Squadra> squadre = new List<Squadra>();

    }
}
