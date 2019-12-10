using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMYSQL
{
	class OperationDB
	{
		MySqlConnection con;
		MySqlCommand mc;
		string param= "Server=localhost;Database=crud;Uid=root;Password=root;";

		public void initConnection(){
			this.con = new MySqlConnection(param);
			this.mc = this.con.CreateCommand();

		}
		public OperationDB(){
			this.initConnection();
		}

		/**
		 * @creatUsers : methode permettant de creer des users
		 */
		public void createUsers(User u)
		{
			try {
				Console.WriteLine("bien");
				this.con.Open();
				//mc.CommandText = "Insert into users(nom,prenom,numero,adresse,statut,profession) values('" + u.getNom + "','" + u.getPrenom + "','" + u.getNumero + "','" + u.getAdresse + "','" + u.getStatut + "','" + u.getProfession + "')";
				this.mc.CommandText = "Insert into users(id,nom,prenom) values('"+u.getId()+"','" + u.getNom()+ "','" + u.getPrenom()+ "')";
				//this.mc.CommandText = "Insert into users(id,nom,prenom) values(@nom,@prenom)";			
				this.mc.ExecuteNonQuery();
				this.con.Close();
				Console.WriteLine("Super");
				MessageBox.Show("created successuf", "INFORMATION");
			}
			catch (Exception e) {
				MessageBox.Show("created echec :" + e.Message, "ERREUR");
			}
		}

		/**
		 * @deleteUsers : supprimer un users
		 */
		public void deleteUser(int id)
		{
			try {
				this.con.Open();
				this.mc.CommandText = "Delete from users where id = @id";
				this.mc.Parameters.AddWithValue("@id",id);
				this.mc.ExecuteNonQuery();
				this.con.Close();
				MessageBox.Show("Supression succes", "INFORMATON");
			} catch (Exception e) {
				MessageBox.Show("Supression echec : "+e.Message,"ERREUR");
			}

		}

		/**
		 * @updateUser : mise a jour des donnee
		 */
		public void updateUser(User u)
		{
			try
			{
				this.con.Open();
				//this.mc.CommandText = "update users set nom = @nom , prenom = @prenom, numero =@numero , adresse = @adresse, statut = @statut, profession=@prefession where id = @id";
				//mc.Parameters.AddWithValue("@id",);
				//mc.Parameters.AddWithValue("@nom",);
				this.mc.CommandText = "update  users set nom ='" + u.getNom() + "',prenom ='" + u.getPrenom() + "' where id ="+u.getId();
				this.mc.ExecuteNonQuery();
				this.con.Close();
				MessageBox.Show("Updated suceessuf", "INFORMATIONS");
			}
			catch (Exception e)
			{
				MessageBox.Show("Updated echec : "+e.Message, "ERREUR");
			}
		}
	}
}
