using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Configuration;

namespace Torneo_Briscola
{
    static class Program
    {
        static string connStr = "Server=127.0.0.1;Port=3306;User=root;Database=torneo_briscola;Password=root;SslMode=None;";


        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            squadre = caricaSquadre();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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

        //Metodi BL per il DataBase
        public static bool inserisciSquadra(Squadra squadra)
        {
            int idGiocatore1, idGiocatore2;

            idGiocatore1 = inserisciGiocatore(squadra.Giocatore1);
            idGiocatore2 = inserisciGiocatore(squadra.Giocatore2);

            string query_name = "INSERT INTO squadre (nome, giocatore1_id, giocatore2_id) VALUES (@nome, @giocatore1_id, @giocatore2_id);";

            string query_empty_name = "INSERT INTO squadre (nome, giocatore1_id, giocatore2_id) VALUES (@nome, @giocatore1_id, @giocatore2_id); " +
                                      "UPDATE squadre " +
                                      "SET nome = CONCAT('squadra_', id) " +
                                      "WHERE id = LAST_INSERT_ID();";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    //rendo la query dinamica così che accetti sia il nome di una squadra sia nessun nome

                    string query = "";
                    if (!string.IsNullOrEmpty(squadra.Nome))
                    {
                        query = query_name;
                        
                    }
                    else
                    {
                        query = query_empty_name;
                        squadra.Nome = "temp";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", squadra.Nome);
                    cmd.Parameters.AddWithValue("@giocatore1_id", idGiocatore1);
                    cmd.Parameters.AddWithValue("@giocatore2_id", idGiocatore2);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore: " + ex.Message);
                }

                return true;
            }            
        }

        private static int inserisciGiocatore(Giocatore giocatore)
        {
            int ID_giocatore = -1;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO giocatori (nome, cognome) VALUES (@nome, @cognome)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", giocatore.Nome);
                    cmd.Parameters.AddWithValue("@cognome", giocatore.Cognome);

                    cmd.ExecuteNonQuery();

                    ID_giocatore = (int)cmd.LastInsertedId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore: " + ex.Message);
                }

                return ID_giocatore;
            }
        }

        //Carica tutte le squadre dal database 
        public static List<Squadra> caricaSquadre()
        {
            List<Squadra> squadre = new List<Squadra>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT squadre.nome AS nome_squadra, g1.nome AS nome_g1, g1.cognome AS cognome_g1, g2.nome AS nome_g2, g2.cognome AS cognome_g2 " +
                                   "FROM squadre " +
                                   "JOIN giocatori AS g1 ON squadre.giocatore1_id = g1.id " +
                                   "JOIN giocatori AS g2 ON squadre.giocatore2_id = g2.id;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Giocatore giocatore1 = new Giocatore { Nome = (string)reader["nome_g1"], Cognome = (string)reader["cognome_g1"] };
                            Giocatore giocatore2 = new Giocatore { Nome = (string)reader["nome_g2"], Cognome = (string)reader["cognome_g2"] };
                            Squadra squadra = new Squadra { Nome = (string)reader["nome_squadra"], Giocatore1 = giocatore1, Giocatore2 = giocatore2 };
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
