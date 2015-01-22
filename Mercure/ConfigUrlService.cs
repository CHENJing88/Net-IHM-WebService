using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    /// <summary>
    /// Permet la configuration la lien(Url) de Serveur <b>Mercure</b>.
    /// </summary>
    public partial class ConfigUrlService : Form
    {
       
        public ConfigUrlService()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Accepter la configuration de l'Url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ConfURL_Valider_Click(object sender, EventArgs e)
        { 
            Global.ServiceUrl=this.textbox_UrlServiceWeb.Text;
            MessageBox.Show("Save URL:"+this.textbox_UrlServiceWeb.Text,
            "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Quiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ConfURL_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
