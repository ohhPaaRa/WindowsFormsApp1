using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Utilisateur
    {
        public string Pseudo { get; set; }
        public string MotDePasse { get; set; }

        public Utilisateur()
        {

        }

        public Utilisateur(string pseudo, string mdp)
        {
            Pseudo = pseudo;
            MotDePasse = mdp;
        }
    }
}
