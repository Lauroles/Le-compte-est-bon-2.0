using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_compte_est_bon_2._0
{
    class calcul
    {
        checker calculCheck = new checker(); //Initialisation de l'objet checker

        //Fonction permettant de faire une addition
        public int addition(int a, int b) 
        {
            return a+b;
        }

        //Fonction permettant de faire une soustraction
        public int substract(int a, int b)
        {
            if(a-b < 0) //Vérification que la soustraction de renvoi pas un nombre négatif
            {
                return 0;
            }

            return a-b;
        }

        //Fonction permettant de faire une multiplication
        public int multiplication(int a, int b)
        {
            return a*b;
        }

        //Fonction permettant de faire une division
        public int division(int a, int b)
        {
            int z = a % b;
            if (z > 0) //Vérification du modulo, pour ne pas retourner de résultat à virgule
            {
                return 0;
            }

            return a/b;
        }
    }
}
