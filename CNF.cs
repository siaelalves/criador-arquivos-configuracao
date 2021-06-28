using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNF
{
    public partial class CNF : Form
    {
        public CNF()
        {
            InitializeComponent();
        }
        string File { get; set; }

        SettingReader.Configurações set =
            new SettingReader.Configurações();

        private void mnAA_Click(object sender, EventArgs e)
        {
            dlgAb.ShowDialog();
            //
            lstCb.Items.Clear();
            File = dlgAb.FileName;
            foreach (string h in set.ListarCabeçalhos(File))
            {
                if (h != "")
                {
                    lstCb.Items.Add(h);
                }
            }
        }

        private void lstCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEn.Items.Clear();
            foreach (string h in set.ListarEntradas(File,
                lstCb.Items[lstCb.SelectedIndex].ToString()))
            {
                if (h != "")
                {
                    lstEn.Items.Add(h);
                }
            }    
        }

        private void lstEn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVl.Text = set.LerConfigurações(File,
                lstCb.Items[lstCb.SelectedIndex].ToString(),
                lstEn.Items[lstEn.SelectedIndex].ToString());
        }

        private void cmdSv_Click(object sender, EventArgs e)
        {
            set.ModificarConfiguração(File,
                lstCb.Items[lstCb.SelectedIndex].ToString(),
                lstEn.Items[lstEn.SelectedIndex].ToString(),
                txtVl.Text);
        }

        private void cmdAd_Click(object sender, EventArgs e)
        {
            set.AdicionarEntrada(File, txtNCb.Text, txtNEn.Text, txtNVl.Text);
            return;
            set.AdicionarConfiguração(File, txtNCb.Text, txtNEn.Text, txtNVl.Text);
            //
            lstCb.Items.Clear();
            lstEn.Items.Clear();
            txtVl.Text = "";
            foreach (string h in set.ListarCabeçalhos(File))
            {
                if (h != "")
                {
                    lstCb.Items.Add(h);
                }
            }            
        }
    }
}
