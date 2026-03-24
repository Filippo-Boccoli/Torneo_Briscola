using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Torneo_Briscola
{
    static class Program
    {
        static string connStr = "server=localhost;user=root;database=torneo_briscola;port=3306;password=root;";

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            squadre = caricaSquadre();
        }

        #region STRUTTURE DATI
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
        #endregion 


        //Variabili per tutto il programma
        public static List<Squadra> squadre = new List<Squadra>();

        public static bool inserisciSquadra(Squadra squadra)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO squadre (nome) VALUES (@nome)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", squadra.Nome);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore: " + ex.Message);
                }

                return false;
            }            
        }

        private static bool inserisciGiocatore(Giocatore giocatore, int IDsquadra)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO giocatori (nome, cognome, squadra) VALUES (@nome, @cognome, @squadra)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", giocatore.Nome);
                    cmd.Parameters.AddWithValue("@cognome", giocatore.Cognome);
                    cmd.Parameters.AddWithValue("@squadra", IDsquadra);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore: " + ex.Message);
                }

                return false;
            }
        }

        //Carica le squadre dal database
        private static List<Squadra> caricaSquadre()
        {
            List<Squadra> squadre = new List<Squadra>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT q.id, q.nome, q.cognome, s.nome " +
                                   "FROM giocatori AS g " +
                                   "JOIN squadre AS s ON g.squadra=s.ID;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Giocatore giocatore1 = new Giocatore { Nome = (string)reader["nome"], Cognome = (string)reader["cognome"] };
                            Giocatore giocatore2 = new Giocatore { Nome = (string)reader["nome"], Cognome = (string)reader["cognome"] };
                            Squadra squadra = new Squadra { Giocatore1 = giocatore1, Giocatore2 = giocatore2 };
                            squadre.Add(squadra);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore: " + ex.Message);
                }
            }

            return squadre;
        }
    }
}
