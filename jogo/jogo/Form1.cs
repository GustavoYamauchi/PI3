using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string ret = Jogo.ListarPartidas("T");

            ret = ret.Replace("\r", "");

            string[] partidas = ret.Split('\n');

            string[] itens = partidas[0].Split(',');

            foreach (string partida in partidas)
            {
                cboPartidas.Items.Add(partida);
            }

            txtPartidas.Text = itens[1];
        }

        private void txtPartidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string partida = cboPartidas.SelectedItem.ToString();

            string[] itens = partida.Split(',');
            
            txtIdPartida.Text = itens[0];
            txtNomePartida.Text = itens[1];
        }
    }
}
