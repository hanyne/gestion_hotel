using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_hotel
{
    internal class Cls_connexion
    {
        public bool ConnexionValide(DbHotel db, string Nom, string Mot_de_passe)
        {
            Utilisateur_ U = new Utilisateur_();
            U.NomUtilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if (db.Utilisateur_.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_De_Passe == Mot_de_passe) != null)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
