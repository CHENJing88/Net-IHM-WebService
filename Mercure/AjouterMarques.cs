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
    /// Ajouter ou Modifier un Marque
    /// </summary>
    public partial class AjouterMarques : Form
    {
        public MercureService Service { get; set; }

        //check si la class est construit pour la modification
        private bool IsModif = false;
        //le ref Marque de Marque à modifier
        private string RefMarque;

        /// <summary>
        /// Constructeur
        /// </summary>
        public AjouterMarques()
        {
            InitializeComponent();
            Service = new MercureService();
            Service.Url = Global.ServiceUrl;
        }

        //*****************************************************************************************
        #region // Section des Buttons
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Valider de Ajouter ou Update de Marque
        /// récupérer des données dans la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxNomMarq.Text) )
            {
                if (this.textBoxNomMarq.Text == null)
                    this.labelNameMarqu.ForeColor = Color.Red;
                MessageBox.Show("Remplir tous le Nom de Marque, si vous plaît!", "Warning");
                return;
            }
            string NomMarq = this.textBoxNomMarq.Text;
            
            if (!IsModif)
            {
                Service.AddMarque(NomMarq);
                MessageBox.Show("Ajout Marque est réussi !");
                ClearData();
            }
            else
            {
                Service.UpdateMarque(int.Parse(RefMarque), NomMarq);
                MessageBox.Show("Marque est Update !");
            }
        }
        /// <summary>
        /// Fermer la fenêtre ou élimier des contenus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnul_Click(object sender, EventArgs e)
        {
            if (!IsModif)
                ClearData();
            else
            {
                this.Close();
                this.Dispose();
            }
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

        //*****************************************************************************************
        #region // Section des fonctionnalités internes
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// La modification de Marque
        /// </summary>
        /// <param name="RefMarq">Ref Marque</param>
        /// <param name="NomMarq">Nom du Marque</param>
        public void ModifMarque(string RefMarq, string NomMarq)
        {
            IsModif = true;
            RefMarque = RefMarq;
            this.labelTitreAjoutMarq.Text = "Modification Marque";
            this.Text = "Modification Marque";
            if (string.IsNullOrEmpty(RefMarq))
                throw new ArgumentException("RefMarqe est vide");

            if (string.IsNullOrEmpty(NomMarq))
                throw new ArgumentException("NomMarq est vide");
            else
                this.textBoxNomMarq.Text = NomMarq;

        }

        /// <summary>
        /// élimier des contenus dans la fenêtre
        /// </summary>
        private void ClearData()
        {
            this.textBoxNomMarq.Clear();
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

    }
}
