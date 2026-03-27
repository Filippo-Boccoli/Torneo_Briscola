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
    public partial class FrmTorneo : Form
    {
        public FrmTorneo()
        {
            InitializeComponent();
        }
        List<Program.Squadra> squadreMischiate;
        private void FrmTorneo_Load(object sender, EventArgs e)
        {
            squadreMischiate=MischiaSquadre();
            CaricaSquadreIniziali();



            //CaricaAltreSquadre(16);//ottavi di finale
            //CaricaAltreSquadre(8);//quarti di finale
            //CaricaAltreSquadre(4);//semifinali
            //CaricaAltreSquadre(2);//finale
        }

        private List<Program.Squadra> MischiaSquadre()
        {
            List<Program.Squadra> lista = new List<Program.Squadra>(Program.squadre);
            Random rnd = new Random();

            for (int i = lista.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                Program.Squadra temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
            return lista;
        }
        //carico nelle combo box iniziali tutte le squadre in base alla lista delle squadre mischiate 
        private void CaricaSquadreIniziali()
        {
            for (int i = 0; i < 32; i++)
            {
                ComboBox cbSquadra = (ComboBox)this.Controls["cbSquadra" + (i + 1)];
                for (int j = 0; j < squadreMischiate.Count; j++)
                {
                    cbSquadra.Items.Add(squadreMischiate[j].Giocatore1.Cognome + "-" + squadreMischiate[j].Giocatore2.Cognome);
                }
                if(squadreMischiate.Count > i)
                    cbSquadra.SelectedIndex = i;
                else
                    cbSquadra.SelectedIndex = -1;
            }
        }
        //quando si seleziona due vincitori mi si caricano le squadre nella combox per il turno successivo
        private void AggiornaProssimoCb(ComboBox cb1, ComboBox cb2, ComboBox cbProx)
        {
            cbProx.Items.Clear();
            if (cb1.SelectedItem != null)
                cbProx.Items.Add(cb1.SelectedItem);
            if (cb2.SelectedItem != null)
                cbProx.Items.Add(cb2.SelectedItem);
            cbProx.SelectedIndex = -1;
        }

        #region ottavi_finale
        private void cbSquadra1_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_1, cbSquadra1_2, cbSquadra2_1);
        }

        private void cbSquadra1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_1, cbSquadra1_2, cbSquadra2_1);
        }

        private void cbSquadra1_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_3, cbSquadra1_4, cbSquadra2_2);
        }

        private void cbSquadra1_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_3, cbSquadra1_4, cbSquadra2_2);
        }

        private void cbSquadra1_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_5, cbSquadra1_6, cbSquadra2_3);
        }

        private void cbSquadra1_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_5, cbSquadra1_6, cbSquadra2_3);
        }

        private void cbSquadra1_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_7, cbSquadra1_8, cbSquadra2_4);
        }

        private void cbSquadra1_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_7, cbSquadra1_8, cbSquadra2_4);
        }

        private void cbSquadra1_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_9, cbSquadra1_10, cbSquadra2_5);
        }

        private void cbSquadra1_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_9, cbSquadra1_10, cbSquadra2_5);
        }

        private void cbSquadra1_11_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_11, cbSquadra1_12, cbSquadra2_6);
        }

        private void cbSquadra1_12_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_11, cbSquadra1_12, cbSquadra2_6);
        }

        private void cbSquadra1_13_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_13, cbSquadra1_14, cbSquadra2_7);
        }

        private void cbSquadra1_14_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_13, cbSquadra1_14, cbSquadra2_7);
        }

        private void cbSquadra1_15_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_15, cbSquadra1_16, cbSquadra2_8);
        }

        private void cbSquadra1_16_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra1_15, cbSquadra1_16, cbSquadra2_8);
        }
        #endregion

        #region quarti_finale
        private void cbSquadra2_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_1, cbSquadra2_2, cbSquadra3_1);
        }

        private void cbSquadra2_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_1, cbSquadra2_2, cbSquadra3_1);
        }

        private void cbSquadra2_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_3, cbSquadra2_4, cbSquadra3_2);
        }

        private void cbSquadra2_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_3, cbSquadra2_4, cbSquadra3_2);
        }

        private void cbSquadra2_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_5, cbSquadra2_6, cbSquadra3_3);
        }

        private void cbSquadra2_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_5, cbSquadra2_6, cbSquadra3_3);
        }

        private void cbSquadra2_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_7, cbSquadra2_8, cbSquadra3_4);
        }

        private void cbSquadra2_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra2_7, cbSquadra2_8, cbSquadra3_4);
        }
        #endregion

        #region semifinali
        private void cbSquadra3_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra3_1, cbSquadra3_2, cbSquadra4_1);
        }

        private void cbSquadra3_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra3_1, cbSquadra3_2, cbSquadra4_1);
        }

        private void cbSquadra3_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra3_3, cbSquadra3_4, cbSquadra4_2);
        }

        private void cbSquadra3_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra3_3, cbSquadra3_4, cbSquadra4_2);
        }
        #endregion

        #region finali
        private void cbSquadra4_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra4_1, cbSquadra4_2, cbVincitore);
        }

        private void cbSquadra4_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaProssimoCb(cbSquadra4_1, cbSquadra4_2, cbVincitore);
        }
        #endregion

        private void cbVincitore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pbVittoria.Location=new Point(0, 0);
            ////pbVittoria.Visible = true;
            //lblSquadraVincente.Text = cbVincitore.Text + "Ha vinto questo torneo di merda";
            //lblSquadraVincente.Visible = true;
            //tmrVittoria.Start();
        }

        private void cbSquadra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int numCb = Convert.ToInt32(cb.Name.Replace("cbSquadra", ""));
            if (numCb % 2 == 0)
            {
                ComboBox cbSquadraAvversaria = (ComboBox)this.Controls["cbSquadra" + (numCb - 1)];

                ComboBox cbSquadraSuccessiva = (ComboBox)this.Controls["cbSquadra1_" + (numCb / 2)];
                cbSquadraSuccessiva.Items.Clear();
                cbSquadraSuccessiva.Items.Add(cb.Text);
                cbSquadraSuccessiva.Items.Add(cbSquadraAvversaria.Text);

            }
        }
    }
}
