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
    /// Gestion la base de données d'un table: affichage, ajout, modification, suppression, actualisation
    /// </summary>
    public partial class GestionTable : Form
    {
        public MercureService Service { get; set; }

        //le nom de la table que on manipuler
        private string Table { get; set; }

        //*****************************************************************************************
        #region // Section des Constructeurs
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// constructor avec le nom de la table
        /// </summary>
        /// <param name="TableName">le nom de la table</param>
        public GestionTable(string TableName)
        {
            InitializeComponent();

            //configurer le nom de form
            this.Name = "Gestion" + TableName;
            this.labelTableCatalog.Text = "Catalogage " + TableName;

            //configuration de serveur
            Service = new MercureService();
            Service.Url = Global.ServiceUrl;

            //load Articles dans le ListView
            Table = TableName;
            Load_ListView(TableName);
        }
        /// <summary>
        /// constructor avec le nom de la table et l'Url de serveur
        /// </summary>
        /// <param name="UrlService">Url de serveur</param>
        /// <param name="TableName">le nom de la table</param>
         public GestionTable(string UrlService,string TableName)
        {
            InitializeComponent();

            //configurer le nom de form
            this.Name = "Gestion" + TableName;
            this.labelTableCatalog.Text = "Catalogage " + TableName;

            //configuration de serveur
            Service = new MercureService();
            Service.Url = UrlService;
            Global.ServiceUrl = UrlService;

            //load Articles dans le ListView
            Table = TableName;
            Load_ListView(TableName);
        }
         //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

        //*****************************************************************************************
         #region // Section des fonctionnalités internes
         //---------------------------------------------------------------------------------------
        /// <summary>
        /// charger des données d'une table
        /// </summary>
         /// <param name="TableName">le nom de la table</param>
        private void Load_ListView(string TableName)
        {
            //configuration de listView
            this.listView.Items.Clear();
            this.listView.Columns.Clear();
            this.listView.GridLines = true;
            this.listView.View = View.Details;
            this.listView.FullRowSelect = true;

            //ajouter les titres de colonnes
            string[] TitreArticle ={"RefArticle","Description","RefFamille","NomFamille","RefSousFamille"
                               ,"NomSousFamille", "RefMarque", "NomMarque", "PrixHT"};
            string[] TitreMarque = { "RefMarque", "NomMarque" };

            //set le nom de table et obtenir des données de la table pour remplir le ListView
            string[] Titres=null;
            List<string[]> ListViewItems = null;
            switch(TableName)
            {
                case "Article":
                    Titres = TitreArticle;
                    ListViewItems = Service.GetArticles();
                    break;
                case "Marque":
                    Titres = TitreMarque;
                    ListViewItems = Service.GetMarques();
                    break;
            }
            
            //remplir le Header de ListView
            foreach (string Titre in Titres)
            {
                this.listView.Columns.Add(Titre);
            }

            //remplir le List de ListView
            foreach (string[] Datas in ListViewItems)
            {
                ListViewItem ListItem = new ListViewItem(Datas);
                
                this.listView.Items.Add(ListItem);
            }
            this.listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        /// <summary>
        /// Pour modifier le record d'article dans une fenêtre
        /// </summary>
        private void ModifArticle()
        {
            AjouterArticles FormAjoutArticle = new AjouterArticles();

            //extraire des données dans le ListView
            string RefActricle = this.listView.SelectedItems[0].SubItems[0].Text;
            string Description = this.listView.SelectedItems[0].SubItems[1].Text;
            int RefSsFamil = int.Parse(this.listView.SelectedItems[0].SubItems[4].Text);
            int RefMarque = int.Parse(this.listView.SelectedItems[0].SubItems[6].Text);
            float PrixHT = float.Parse(this.listView.SelectedItems[0].SubItems[8].Text.Replace('.', ','));

            try
            {
                //remplir des données dans la fenêtre 
                FormAjoutArticle.ModifActicle(RefActricle, Description, RefSsFamil, RefMarque, PrixHT);
            }
            catch (Exception Err)
            {
                Console.Out.WriteLine(Err.Message);
            }

            FormAjoutArticle.Show();
        }
        /// <summary>
        /// Pour modifier le record de Marque dans une fenêtre
        /// </summary>
        private void ModifMarque()
        {
            AjouterMarques FormAjoutMarque = new AjouterMarques();

            //extraire des données dans le ListView
            string RefMarque = this.listView.SelectedItems[0].SubItems[0].Text;
            string NomMarque = this.listView.SelectedItems[0].SubItems[1].Text;

            try
            {
                //récupérer des données dans la fenêtre
                FormAjoutMarque.ModifMarque(RefMarque, NomMarque);
            }
            catch (Exception Err)
            {
                Console.Out.WriteLine(Err.Message);
            }

            FormAjoutMarque.Show();
        }
        //---------------------------------------------------------------------------------------
         #endregion
        //*****************************************************************************************

        //*****************************************************************************************
        #region // Section des Buttons
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Ajouter un record et lancer la fenêtre correspondante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            //choisir une table et affichage la fenêtre d'ajout
            switch (Table)
            {
                case "Article":
                    AjouterArticles FormAjoutArticle = new AjouterArticles();
                    FormAjoutArticle.Show();
                    break;
                case "Marque":
                    AjouterMarques FormAjoutMarque=new AjouterMarques();
                    FormAjoutMarque.Show();
                    break;

            }
        }
        /// <summary>
        /// Modifier un record et lancer la fenêtre correspondante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModif_Click(object sender, EventArgs e)
        {
            //check si un record est choisi
            if (this.listView.SelectedItems.Count > 0)
            {
                //choisir une table et affichage la fenêtre de la modification
                switch (Table)
                {
                    case "Article":
                        ModifArticle();
                        break;
                    case "Marque":
                        ModifMarque();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Cloisissez un Record, si vous plaît !", "Warning");
                return;
            }
        }
        /// <summary>
        /// Supprimer un record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupp_Click(object sender, EventArgs e)
        {
            //check si un record est choisi
            if (this.listView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce Record ?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // delete item dans le serveur
                    switch (Table)
                    {
                        case "Article":
                            Service.DeleteArticle(this.listView.SelectedItems[0].SubItems[0].Text);
                            break;
                    }
                    

                    //remove le item dans le listView
                    this.listView.SelectedItems[0].Remove();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Cloisissez un Record, si vous plaît !", "Warning");
                return;
            }
        }
        /// <summary>
        /// Rechager le ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Load_ListView(Table);
        }
        /// <summary>
        /// Quiter la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnul_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.Dispose();
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************
        
    }
}
