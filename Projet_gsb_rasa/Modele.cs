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
        private static string specialite;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new GSB_Anjaka_SamuelEntities();
        }
        public static Visiteur GetUtilisateurConnecte()
        {
            return utilisateurConnecte;
        }

        public static string GetMd5Hash(string PasswdSaisi)
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
        public static bool VerificationID(string id)
        {
            bool vretour = false;
            List<Visiteur> lesVisiteurs = Modele.listeLesVisiteurs();
            foreach (Visiteur unVisteur in lesVisiteurs)
            {
                if (unVisteur.identifiant == id)
                {
                    vretour = true;
                    utilisateurConnecte = unVisteur;
                    break;
                }
            }
            return vretour;
        }
        public static bool VerificationMDP(string id, string mdp)
        {
            bool vretour = false;
            Visiteur visiteurs = getVisiteur(id);
            if (visiteurs.password.Substring(2).Equals(mdp) )
            {
                vretour = true;
            }
            return vretour;
        }

       public static Object RegionParSecteur(int idSecteur)
        {
            var LQuery = maConnexion.Secteur.ToList()
                      // .Join maConnexion.

                           .Where(x => x.idSecteur  == idSecteur )
                           .Select(x => new { x.idVisiteur, x.Visiteur.nom, x.Visiteur.rue, x.Visiteur.cp, x.Visiteur.ville })
                        
                          // .Select(x => new { x.Visiteur.nom, x.Visiteur.prenom, x.Visiteur.rue, x.Visiteur.cp, x.Visiteur.ville, x.Visiteur.dateEmbauche, x.Visiteur.identifiant, x.Visiteur.password })
                           .OrderBy(x => x.idVisiteur);
            return LQuery.ToList();

        }

      //  public static Object ResponsableParRegion()
    

        public static List<Secteur>ListSecteur()
        {
            return maConnexion.Secteur.ToList();
        }

        public static List<Region> ListeRegion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Visiteur> Listvisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

        /* public static List<>Travailler> ListRegion()
         {
             return maConnexion.Travailler.ToList();
         }
         */
        public static List<Visiteur> listeLesVisiteurs()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static Visiteur getVisiteur(string id)
        {
            
            var LQuery =  maConnexion.Visiteur.ToList()
                              .Where(x => x.identifiant == id);

            return ((Visiteur) LQuery.ToList()[0]);
        }
        public static Object getLibFraisForfait()
        {
            
            var LQuery = maConnexion.FraisForfait.ToList()
                              .Where(x => x.typeFrais.Contains("FF"));

            return LQuery.ToList();
        }


    }
}
