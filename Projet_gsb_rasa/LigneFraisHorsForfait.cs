//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_gsb_rasa
{
    using System;
    using System.Collections.Generic;
    
    public partial class LigneFraisHorsForfait
    {
        public int id { get; set; }
        public string idVisiteur { get; set; }
        public string mois { get; set; }
        public string libelle { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> montant { get; set; }
    
        public virtual fichefrais fichefrais { get; set; }
    }
}
