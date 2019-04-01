using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_compte_est_bon_2._0
{
    class checker
    {
        public checker()
        {
            
            
        }
        //Création d'une fonction, permettant de vérifier, quel calcul lancer
        public int checkCalculPossible(int a, int b, string ope)
        {
            calcul calcul = new calcul();//Initialisation d'un nouvel objet calcul
            
                switch (ope)//Création d'un switch, permettant de voir quel signe sera utilisé
                {
                    case "+":
                    return calcul.addition(a, b); //Donne le résultat de l'addition entre a et b
                    case "-":
                        return calcul.substract(a, b); //Donne le résultat de la soustraction entre a et b
                case "X":
                        return calcul.multiplication(a, b); //Donne le résultat de la multiplication entre a et b
                case "/":
                       return calcul.division(a, b); //Donne le résultat de la division entre a et b
                default:
                        return 0;
                }             
        }


    }
}
