using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMYSQL
{
	class Program
	{
		static void Main(string[] args)
		{			
			Console.WriteLine("Bienvenue sur mon tit test");
			Console.WriteLine("Veuiller suivre les instructions svp");
			Console.WriteLine("1. Pour vous enregistrer");
			Console.WriteLine("2. Pour vous suprimer");
			Console.WriteLine("3. Pour vous mettre a jour");
			Console.WriteLine("4. Pour quitter");
			Console.WriteLine(" Merci d'entrer votre nombre");
			int entrer = Convert.ToInt32( Console.ReadLine());
			OperationDB o = new OperationDB();
			switch (entrer)
			{
				case 1 :
					Console.WriteLine("Entre votre id");
					int id = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Entre votre nom ");
					string nom = Console.ReadLine();
					Console.WriteLine("Entre votre prenom ");
					string prenom = Console.ReadLine();
					User u = new User(id, nom, prenom); ;
					o.createUsers(u);
					break;
				case 2:
					Console.WriteLine("Entre votre id");
					int idN = Convert.ToInt32(Console.ReadLine());
					o.deleteUser(idN);
					break;
				case 3:
					Console.WriteLine("Entre votre id");
					int id1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Entre votre nom ");
					string nom1 = Console.ReadLine();
					Console.WriteLine("Entre votre prenom ");
					string prenom1 = Console.ReadLine();
					User u1 = new User(id1, nom1, prenom1); ;
					o.updateUser(u1);
					break;
					break;
				case 4:
					Environment.Exit(4);
					break;

			}
		}
	}
}
