//*************************************************************************************************
// DEBUT DU FICHIER
//*************************************************************************************************

//-------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------
using System;
using System.Web.Services;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Web.Services.Protocols;
using System.Web.Services.Description;
//-------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------

//*************************************************************************************************
// Début du bloc "Mercure"
//*************************************************************************************************
namespace Mercure
	{
    //  #   #  #####  ####    ###   #   #  ####   #####   ####  #####  ####   #   #  #   ### 
    //  ## ##  #      #   #  #   #  #   #  #   #  #      #      #      #   #  #   #  #  #   #
    //  # # #  ###    ####   #      #   #  ####   ###     ###   ###    ####   #   #  #  #    
    //  #   #  #      #   #  #   #  #   #  #   #  #          #  #      #   #   # #   #  #   #
    //  #   #  #####  #   #   ###    ###   #   #  #####  ####   #####  #   #    #    #   ###   ##

	//*********************************************************************************************
	// Classe MercureService
	//*********************************************************************************************
	/// <summary>
	/// Permet la synchronisation et la manipulation des données <b>Mercure</b>.
	/// </summary>
	//---------------------------------------------------------------------------------------------
	[GeneratedCodeAttribute    ("wsdl", "2.0.50727.42")]
	[DesignerCategoryAttribute ("code")]
	[WebServiceBindingAttribute(Name="MercureService",Namespace="http://Mercure.org/")]
	//---------------------------------------------------------------------------------------------
	public class MercureService : SoapHttpClientProtocol
		{
		//*****************************************************************************************
		#region // Section des Articles
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute un article.
		/// </summary>
		/// <param name="RefArticle">Référence de l'article.</param>
		/// <param name="Description">Description de l'article.</param>
		/// <param name="RefSousFamille">Référence de la sous-famille.</param>
		/// <param name="RefMarque">Référence de la marque.</param>
		/// <param name="PrixHT">Prix Hors Taxes de l'article.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddArticle", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddArticle ( string RefArticle, string Description, int RefSousFamille, 
		                                                             int RefMarque , float PrixHT )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddArticle", new object [] 
				                  { RefArticle, Description, RefSousFamille, RefMarque, PrixHT } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime un article.
		/// </summary>
		/// <param name="RefArticle">Référence de l'article.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteArticle", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteArticle ( string RefArticle )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteArticle", new object [] { RefArticle } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des articles.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefArticle', 
		/// 'Description', 'RefFamille', 'NomFamille', 'RefSousFamille', 'NomSousFamille', 
		/// 'RefMarque', 'NomMarque', 'PrixHT'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetArticles", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetArticles ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetArticles", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Modifie un article.
		/// </summary>
		/// <param name="RefArticle">Référence de l'article.</param>
		/// <param name="Description">Description de l'article.</param>
		/// <param name="RefSousFamille">Référence de la sous-famille.</param>
		/// <param name="RefMarque">Référence de la marque.</param>
		/// <param name="PrixHT">Prix Hors Taxes de l'article.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/UpdateArticle", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void UpdateArticle ( string RefArticle, string Description, int RefSousFamille, 
		                                                             int RefMarque , float PrixHT )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "UpdateArticle", new object [] 
				                  { RefArticle, Description, RefSousFamille, RefMarque, PrixHT } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Marques
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute une marque.
		/// </summary>
		/// <param name="Marque">Nom de la marque.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddMarque", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddMarque ( string Marque )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddMarque", new object [] { Marque } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime une marque.
		/// </summary>
		/// <param name="RefMarque">Référence de la marque.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteMarque", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteMarque ( int RefMarque )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteMarque", new object [] { RefMarque } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des marques.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefMarque', 
		/// 'NomMarque'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetMarques", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetMarques ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetMarques", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Modifie une marque.
		/// </summary>
		/// <param name="RefMarque">Référence de la marque.</param>
		/// <param name="Marque">Nom de la marque.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/UpdateMarque", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void UpdateMarque ( int RefMarque, string Marque )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "UpdateMarque", new object [] { RefMarque, Marque } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Familles
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute une famille.
		/// </summary>
		/// <param name="Famille">Nom de la famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddFamille ( string Famille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddFamille", new object [] { Famille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime une famille.
		/// </summary>
		/// <param name="RefFamille">Référence de la famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteFamille ( int RefFamille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteFamille", new object [] { RefFamille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des familles.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefFamille', 
		/// 'NomFamille'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetFamilles", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetFamilles ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetFamilles", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Modifie une familles.
		/// </summary>
		/// <param name="RefFamille">Référence de la famille.</param>
		/// <param name="Famille">Nom de la famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/UpdateFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void UpdateFamille ( int RefFamille, string Famille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "UpdateFamille", new object [] { RefFamille, Famille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Sous-Familles
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute une sous-famille.
		/// </summary>
		/// <param name="RefFamille">Référence de la famille.</param>
		/// <param name="SousFamille">Nom de la sous-famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddSousFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddSousFamille ( int RefFamille, string SousFamille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddSousFamille", new object [] { RefFamille, SousFamille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime une sous-famille.
		/// </summary>
		/// <param name="RefSousFamille">Référence de la sous-famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteSousFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteSousFamille ( int RefSousFamille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteSousFamille", new object [] { RefSousFamille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des sous-familles.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 
		/// 'RefSousFamille', 'RefFamille', 'NomSousFamille'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetSousFamilles", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetSousFamilles ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetSousFamilles", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Modifie une sous-familles.
		/// </summary>
		/// <param name="RefSousFamille">Référence de la sous-famille.</param>
		/// <param name="RefFamille">Référence de la famille.</param>
		/// <param name="SousFamille">Nom de la sous-famille.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/UpdateSousFamille", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void UpdateSousFamille ( int RefSousFamille, int RefFamille, string SousFamille )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "UpdateSousFamille", new object [] 
				                                     { RefSousFamille, RefFamille, SousFamille } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Clients
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute un client.
		/// </summary>
		/// <param name="RaisonSocial">Raison sociale du client.</param>
		/// <param name="Nom">Nom du client.</param>
		/// <param name="Prenom">Prénom du client.</param>
		/// <param name="Adresse">Adresse du client.</param>
		/// <param name="CodePostal">Code postal du client.</param>
		/// <param name="Ville">Ville du client.</param>
		/// <param name="Pays">Pays du client.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddClient", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddClient ( string RaisonSocial, string Nom, string Prenom, string Adresse, 
		                                             string CodePostal, string Ville, string Pays )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddClient", new object [] 
				                 { RaisonSocial, Nom, Prenom, Adresse, CodePostal, Ville, Pays } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime un client.
		/// </summary>
		/// <param name="RefClient">Référence du client.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteClient", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteClient ( int RefClient )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteClient", new object [] { RefClient } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des clients.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefClient', 
		/// 'RaisonSocial', 'Nom', 'Prenom', 'Adresse', 'CodePostal', 'Ville', 'Pays'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetClients", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetClients ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetClients", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Modifie un client.
		/// </summary>
		/// <param name="RefClient">Référence du client.</param>
		/// <param name="RaisonSocial">Raison sociale du client.</param>
		/// <param name="Nom">Nom du client.</param>
		/// <param name="Prenom">Prénom du client.</param>
		/// <param name="Adresse">Adresse du client.</param>
		/// <param name="CodePostal">Code postal du client.</param>
		/// <param name="Ville">Ville du client.</param>
		/// <param name="Pays">Pays du client.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/UpdateClient", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void UpdateClient ( int RefClient, string RaisonSocial, string Nom, 
		              string Prenom, string Adresse, string CodePostal, string Ville, string Pays )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "UpdateClient", new object [] 
				      { RefClient, RaisonSocial, Nom, Prenom, Adresse, CodePostal, Ville, Pays } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Entêtes de Factures
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute une entête de facture.
		/// </summary>
		/// <param name="RefFacture">Référence de la facture.</param>
		/// <param name="RefClient">Référence du client.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddFacture", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddFacture ( string RefFacture, int RefClient )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddFacture", new object [] { RefFacture, RefClient } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime une facture.
		/// </summary>
		/// <param name="RefFacture">Référence de la facture.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteFacture", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteFacture ( string RefFacture )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteFacture", new object [] { RefFacture } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des entêtes factures.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefFacture', 
		/// 'RefClient', 'RaisonSocial', 'Nom', 'Prenom', 'Adresse', 'CodePostal', 'Ville', 
		/// 'Pays', 'CreateDate'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetFactures", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetFactures ()
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetFactures", new object [0] )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************

		//*****************************************************************************************
		#region // Section des Articles d'une Facture
		//-----------------------------------------------------------------------------------------

		//*****************************************************************************************
		/// <summary>
		/// Ajoute un article à une facture.
		/// </summary>
		/// <param name="RefFacture">Référence de la facture.</param>
		/// <param name="RefArticle">Référence de l'article.</param>
		/// <param name="Quantity">Quantité d'articles.</param>
		/// <param name="PrixHT">Prix Hors Taxes de l'article.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/AddFactureArticle", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void AddFactureArticle ( string RefFacture, string RefArticle, int Quantity, 
		                                                                             float PrixHT )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "AddFactureArticle", new object [] 
				                                    { RefFacture, RefArticle, Quantity, PrixHT } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Supprime un article d'une facture.
		/// </summary>
		/// <param name="RefFacture">Référence de la facture.</param>
		/// <param name="RefArticle">Référence de l'article.</param>
		/// <remarks>Une exception est générée s'il y a un problème.</remarks>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/DeleteFactureArticle", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public void DeleteFactureArticle ( string RefFacture, string RefArticle )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				this.Invoke ( "DeleteFactureArticle", new object [] { RefFacture, RefArticle } );
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//*****************************************************************************************
		/// <summary>
		/// Obtiens la liste des articles d'une facture.
		/// </summary>
		/// <returns>
		/// Tableau de tableau de chaines. Les champs retournés sont dans l'ordre : 'RefFacture', 
		/// 'RefArticle', 'Description', 'RefFamille', 'NomFamille', 'RefSousFamille', 
		/// 'NomSousFamille', 'RefMarque', 'NomMarque', 'PrixHT'.
		/// </returns>
		//-----------------------------------------------------------------------------------------
		[SoapDocumentMethodAttribute (
			Action           ="http://Mercure.org/GetFactureArticles", 
			RequestNamespace ="http://Mercure.org/", 
			ResponseNamespace="http://Mercure.org/", 
			Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
		//-----------------------------------------------------------------------------------------
		public List<string[]> GetFactureArticles ( string RefFacture )
			{
			//-------------------------------------------------------------------------------------
			try
				{
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				return (List<string[]>)this.Invoke ( "GetFactureArticles", new object [] 
				                                                               { RefFacture } )[0];
				//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
				}
			//-------------------------------------------------------------------------------------
			catch { return null; }
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************

		//-----------------------------------------------------------------------------------------
		#endregion
		//*****************************************************************************************
		}
	//*********************************************************************************************

	} // Fin du namespace "Mercure"
//*************************************************************************************************

//*************************************************************************************************
// FIN DU FICHIER
//*************************************************************************************************
