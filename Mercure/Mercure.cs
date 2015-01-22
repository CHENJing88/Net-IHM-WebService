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
    /// Permet la manipulation des données <b>Mercure</b>.
    /// </summary>
    public partial class Mercure : Form
    {
        private int childFormNumber = 0;
        /// <summary>
        /// Constructeur
        /// </summary>
        public Mercure()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            MessageBox.Show("Bonjour!\nQue la gestion de < Article > , < Marque > et <A propos> fonctionnent !\n"+
                "Merci de votre compréhension !\nBon Noël!", "Bonnes Vacances!");
        }

        //*****************************************************************************************
        #region // Section des fonctions: Configuration Url, Gestion Article, Gestion Marque
        //--------------------------------------------------------------------------------------
        /// <summary>
        /// lancer la Configuration le lien de serveur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurationURLServiceWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigUrlService ConfigUrlService = new ConfigUrlService();
            ConfigUrlService.MdiParent = this;
            ConfigUrlService.StartPosition = FormStartPosition.CenterParent;
            ConfigUrlService.Show();


        }
        /// <summary>
        /// Lancer la fenêtre d'afficher la table de Article qui permet de manipuler de la table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check si la fenêtre est ouverte
            foreach (Form childrenForm in this.MdiChildren)
            {
                //check le nom de form 
                if (childrenForm.Name == "GestionArticle")
                {
                    //affichage la fenêtre 
                    childrenForm.Visible = true;
                    //activer form 
                    childrenForm.Activate();
                    return;
                }
            }
            //générer une nouvelle fenêtre
            GestionTable GestionArticle = new GestionTable("Article");
            GestionArticle.MdiParent = this;
            childFormNumber++;
            GestionArticle.Show();
        }

        /// <summary>
        /// Lancer la fenêtre d'afficher la table de Article qui permet de manipuler de la table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check si la fenêtre est ouverte
            foreach (Form childrenForm in this.MdiChildren)
            {
                //check le nom de form 
                if (childrenForm.Name == "GestionMarque")
                {
                    //affichage la fenêtre 
                    childrenForm.Visible = true;
                    //activer form 
                    childrenForm.Activate();
                    return;
                }
            }
            //générer une nouvelle fenêtre
            GestionTable GestionMarque = new GestionTable("Marque");
            GestionMarque.MdiParent = this;
            childFormNumber++;
            GestionMarque.Show();
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************

        /// <summary>
        /// Affichage des informations de ce logiciel: auteur, copyright, date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auteur : CHEN Jing\ncopyright \u00A9 Polytech'Tours Bright Mind\nDate : 20/12/2014", "Mercure");
        }
        

        //*****************************************************************************************
        #region // Section des ToolStripMenuItems générés automatiquement
        //---------------------------------------------------------------------------------------
        private void ShowNewForm(object sender, EventArgs e)
        {
            
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }
        /// <summary>
        /// fermer tous les fils fenêtre de MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        //---------------------------------------------------------------------------------------
        #endregion
        //*****************************************************************************************
        
    }
}
