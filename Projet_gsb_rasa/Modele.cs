using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projet_gsb_rasa
{
   

   public static class Modele
    {
        private static GSB_Anjaka_SamuelEntities maConnexion;
        private static Visiteur utilisateurConnecte;
        private static bool connexionValide;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new GSB_Anjaka_SamuelEntities();
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string validConnexion(string id, string mp)
        {
            string message = "";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via
            utilisateurConnecte.dateEmbauche.Substring(2).Equals(GetMd5Hash(mp));
            return message;
        }

       public static Object RegionParSecteur(int idSecteur)
        {
            var LQuery = maConnexion.Region.ToList()

                           .Where(x => x.idSecteur == idSecteur )
                           .Select(x => new { x.libRegion })
                        
                          // .Select(x => new { x.Visiteur.nom, x.Visiteur.prenom, x.Visiteur.rue, x.Visiteur.cp, x.Visiteur.ville, x.Visiteur.dateEmbauche, x.Visiteur.identifiant, x.Visiteur.password })
                           .OrderBy(x => x.libRegion);
            return LQuery.ToList();

        }

      //  public static Object ResponsableParRegion()
    

        public static List<Secteur>ListSecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        
    }
}
