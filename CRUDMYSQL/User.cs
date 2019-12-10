using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMYSQL
{
	class User
	{
		private string nom;
		private string prenom;
		private int numero;
		private string adresse;
		private string statut;
		private string profession;
		int id;

		/*public User(string nom, string prenom, int numero, string adresse, string statut, string profession)
		{
			this.nom = nom;
			this.prenom = prenom;
			this.numero = numero;
			this.adresse = adresse;
			this.statut = statut;
			this.profession = profession;
		}*/
		public User(int id,string nom, string prenom)
		{
			this.id = id;
			this.nom = nom;
			this.prenom = prenom;			
		}

		public int getId()
		{
			return this.id;
		}
		public string getNom()
		{
			return this.nom;
		}

		public void setNom(string nom)
		{
			 this.nom = nom;
		}

		public string getPrenom()
		{
			return this.prenom;
		}
		public void setPrenom(string prenom)
		{
			this.prenom = prenom;
		}

		public int getNumero()
		{
			return this.numero;
		}
		public void setNumero(int numero)
		{
			this.numero = numero;
		}

		public string getAdresse()
		{
			return this.nom;
		}
		public void setAdresse(string adresse)
		{
			 this.adresse = adresse;
		}

		public string getStatut()
		{
			return this.statut;
		}
		public void setStatut(string statut)
		{
			 this.statut = statut;
		}

		public string getProfession()
		{
			return this.profession;
		}
		public void setProfession(string profession)
		{
			 this.profession = profession;
		}

	}
}
