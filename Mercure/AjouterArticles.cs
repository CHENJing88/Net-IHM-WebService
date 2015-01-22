using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure
{
    /// <summary>
    /// Ajouter ou Modifier un Article
    /// </summary>
    public partial class AjouterArticles : Form
    {
        public MercureService Service { get; set; }

        //Sauvegarde le pair (Id,Nom) de SousFamille pour remplir le ComboBox
        private Hashtable SousFamilles { get; set; }

        //Sauvegarde le pair (Id,Nom) de Marques pour remplir le ComboBox
        private Hashtable Marques { get; set; }

        //check si la class est construit pour la modification
        private bool IsModif = false;

        //*****************************************************************************************
        #region // Section des Initialisations
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Constructeur
        /// </summary>
        public AjouterArticles()
        {
            InitializeComponent();
            Service = new MercureService();
            Service.Url = Global.ServiceUrl;
            Remplir_SousFamille();
            Remplir_Marque();
        }
        /// <summary>
        /// Remplir le ComboBox de la liste de SousFamille
        /// </summary>
        public void Remplir_SousFamille()
        {
            List<string[]> SousFamilleList = Service.GetSousFamilles();
            SousFamilles = new Hashtable();
            foreach (string[] SsFamille in SousFamilleList)
            {
                SousFamilles.Add(SsFamille[0], SsFamille[2]);
            }

            this.comboBoxSsFamil.DataSource = SousFamilles.Values.Cast<string>().ToList();
            this.comboBoxSsFamil.SelectionChangeCommitted += ComboBoxSsFamil_SelectionChanged;
            this.comboBoxSsFamil.DropDownStyle = ComboBoxStyle.DropDownList;
            this.textBoxRefSsF.ReadOnly = true;
        }
        /// <summary>
        /// Interaction de ComboBox de la liste de SousFamille
        /// Si la selection de comboBox change, le textBox de Ref SousFamille change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSsFamil_SelectionChanged(object sender, EventArgs e)
        {
            string NameValue=this.comboBoxSsFamil.SelectedValue.ToString();
            string Ref = GetIdByName(SousFamilles, NameValue);
            this.textBoxRefSsF.Text = Ref;
        }

        /// <summary>
        /// Remplir le ComboBox de la liste de Marque
        /// </summary>
        public void Remplir_Marque()
        {
            List<string[]> MarqueList = Service.GetMarques();
            Marques = new Hashtable();
            foreach (string[] Marque in MarqueList)
            {
                Marques.Add(Marque[0], Marque[1]);
            }
            this.comboBoxRefMarque.DataSource = Marques.Values.Cast<string>().ToList();
            this.comboBoxRefMarque.SelectionChangeCommitted += ComboBoxRefMarque_SelectionChanged;
            this.comboBoxRefMarque.DropDownStyle = ComboBoxStyle.DropDownList;
            this.textBoxRefMq.ReadOnly = true;
        }
        /// <summary>
        /// Interaction de ComboBox de la liste de Marque
        /// Si la selection de comboBox de Marque change, le textBox de Ref Marque change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxRefMarque_SelectionChanged(object sender, EventArgs e)
        {
            string NameValue = this.comboBoxRefMarque.SelectedValue.ToString();
            string Ref = GetIdByName(Marques, NameValue);
            this.textBoxRefMq.Text = Ref;
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

        //*****************************************************************************************
        #region // Section des fonctionnalités internes
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// La modification de Article
        /// </summary>
        /// <param name="RefArticle">Ref Article</param>
        /// <param name="Description">Description</param>
        /// <param name="RefSsFamil">Ref SousFamil</param>
        /// <param name="RefMarque">Ref Marque</param>
        /// <param name="PrixHT">PrixHT</param>
        public void ModifActicle(string RefArticle, string Description, int RefSsFamil, int RefMarque, float PrixHT)
        {
            IsModif = true;
            this.labelAjoutArticle.Text = "Modification Acticle";
            this.Text = "Modification Acticle";
            if (string.IsNullOrEmpty(RefArticle))
                throw new ArgumentException("RefArticle est vide");
            else
                this.textBoxRefArticle.Text = RefArticle;

            if (string.IsNullOrEmpty(Description))
                throw new ArgumentException("Description est vide");
            else
                this.textBoxDescription.Text = Description;

            if (string.IsNullOrEmpty(RefSsFamil.ToString()))
                throw new ArgumentException("RefSsFamil est vide");
            else
            {
                this.textBoxRefSsF.Text = RefSsFamil.ToString();
                this.comboBoxSsFamil.SelectedText = GetNameById(SousFamilles, RefSsFamil.ToString());
            }

            if (string.IsNullOrEmpty(RefMarque.ToString()))
                throw new ArgumentException("RefMarque est vide");
            else
            {
                this.textBoxRefMq.Text = RefMarque.ToString();
                this.comboBoxRefMarque.SelectedText = GetNameById(Marques, RefMarque.ToString());
            }

            if (string.IsNullOrEmpty(PrixHT.ToString()))
                throw new ArgumentException("PrixHT est vide");
            else
                this.textBoxPrixHT.Text = PrixHT.ToString();


        }
        /// <summary>
        /// obtenir le Key valeur(Id) par le nom
        /// </summary>
        /// <param name="Table">Hashtable</param>
        /// <param name="Value">Nom</param>
        /// <returns></returns>
        private string GetIdByName(Hashtable Table, string Value)
        {
            foreach (DictionaryEntry Paire in Table)
            {
                if (Paire.Value.ToString() == Value)
                    return Paire.Key.ToString();
            }
            return null;
        }
        /// <summary>
        /// obtenir le Value valeur(nom) par Id
        /// </summary>
        /// <param name="Table">Hashtable </param>
        /// <param name="Key">Id</param>
        /// <returns></returns>
        private string GetNameById(Hashtable Table, string Key)
        {
            foreach (DictionaryEntry Paire in Table)
            {
                if (Paire.Key.ToString() == Key)
                    return Paire.Value.ToString();
            }
            return null;
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

        //*****************************************************************************************
        #region // Section des Buttons
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Valider de Ajouter ou Update de Article
        /// récupérer des données dans la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.textBoxRefArticle.Text) || string.IsNullOrEmpty(this.textBoxDescription.Text) || 
                string.IsNullOrEmpty(this.textBoxPrixHT.Text))
            {
                if (this.textBoxRefArticle.Text == null)
                    this.labelRefArticle.ForeColor = Color.Red;
                if (this.textBoxDescription.Text == null)
                    this.labelDescription.ForeColor = Color.Red;
                if (this.textBoxPrixHT.Text == null)
                    this.labelPrixHT.ForeColor = Color.Red;
                MessageBox.Show("Remplir tous les champs, si vous plaît!", "Warning");
                return;
            }
            Regex RegRefArt = new Regex(@"^\d{8}$");
            if (!RegRefArt.IsMatch(this.textBoxRefArticle.Text))
            {

                MessageBox.Show("La forme de Ref Article n'est pas correct !", "Warning");
                return;
            }
            
            Regex Prix = new Regex("^[0-9]*[.|,][0-9]*$");
            if (!Prix.IsMatch(this.textBoxPrixHT.Text))
            {
                MessageBox.Show("La forme de PrixHT n'est pas correct !", "Warning");
                return;
            }

            string RefArticle = this.textBoxRefArticle.Text;
            string Description = this.textBoxDescription.Text;
            int RefSsFamil = int.Parse(this.textBoxRefSsF.Text);
            int RefMarque = int.Parse(this.textBoxRefMq.Text);
            float PrixHT = float.Parse(this.textBoxPrixHT.Text.Replace('.', ','));
            if (!IsModif)
            {
                Service.AddArticle(RefArticle, Description, RefSsFamil, RefMarque, PrixHT);
                MessageBox.Show("Ajout Article est réussi !");
                ClearData();
            }
            else
            {
                Service.UpdateArticle(RefArticle, Description, RefSsFamil, RefMarque, PrixHT);
                MessageBox.Show("Article est Update !");
            }
        }
        /// <summary>
        /// Fermer la fenêtre ou élimier des contenus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnl_Click(object sender, EventArgs e)
        {
            //pour ajouter, élimier des données dans la fenêtre
            if (!IsModif)
                ClearData();
            else
            {
                //pour modifier, quiter la fenêtre
                this.Close(); 
                this.Dispose();
            }
        }
        /// <summary>
        /// élimier des données dans la fenêtre
        /// </summary>
        private void ClearData()
        {
            this.textBoxRefArticle.Clear();
            this.textBoxDescription.Clear();
            this.textBoxPrixHT.Clear();
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************
        
    }
}
