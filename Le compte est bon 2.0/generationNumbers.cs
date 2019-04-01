using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_compte_est_bon_2._0
{
    class generationNumbers
    {
        protected int resultat; //Déclaration de la variable résultat

        protected int chiffre1, chiffre2, chiffre3, chiffre4, chiffre5, chiffre6; //Déclarations des variables, comportant les nombres necessaires aux calculs

        int r1, r2, r3, r4, r5; //Décaration des variables pour stockers si besoin les résultats

        Random rnd = new Random(); //Initialisation d'un nouvel objet Random

        int[] listeChiffre = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 25, 25, 50, 50, 75, 75, 100, 100 }; //Création d'un tableau comportant la liste des nombres disponible, lors de l'aléatoire

        List<int> stockageChiffre = new List<int>(); //Création de la liste

        //Création du constructeur
        public generationNumbers()
        {
            resultat = rnd.Next(100, 1000); //Création du nombre aléatoire que le résultat comportera, nombre situé entre 100 et 1000
            
            //Création d'un for, permettant de stocker des valeurs aléatoires necessaire dans une liste
            for(int i = 0; i < listeChiffre.Length; i++)
            {
                stockageChiffre.Add(listeChiffre[i]);
            }
            chiffre1 = pickNumber(); //Initiation d'une valeur d'un chiffre aléatoire dans la variable chiffre1
            chiffre2 = pickNumber(); //**
            chiffre3 = pickNumber(); //**
            chiffre4 = pickNumber(); //**
            chiffre5 = pickNumber(); //**
            chiffre6 = pickNumber(); //**

        }
        //Déclaration d'un deuxieme constructeur
        public generationNumbers(int numberFind)
        {
            resultat = numberFind; //Sauvegarde du résultat déjà généré lors du premier constructeur

            for (int i = 0; i < listeChiffre.Length; i++)
            {
                stockageChiffre.Add(listeChiffre[i]);
            }
            chiffre1 = pickNumber();
            chiffre2 = pickNumber();
            chiffre3 = pickNumber();
            chiffre4 = pickNumber();
            chiffre5 = pickNumber();
            chiffre6 = pickNumber();

        }

        //Fonction, permettant de sélectionner un nombre, et de le retourner 
        public int pickNumber()
        {
            int variable = rnd.Next(stockageChiffre.Count);
            int chiffre = stockageChiffre[variable];
            stockageChiffre.Remove(variable);
            return chiffre;
        }
        //Création d'une fonction renvoyant le résultat
        public int getResultat()
        {
            return resultat;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre1()
        {
            return chiffre1;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre2()
        {
            return chiffre2;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre3()
        {
            return chiffre3;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre4()
        {
            return chiffre4;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre5()
        {
            return chiffre5;
        }
        //Création d'une fonction renvoyant le chiffre
        public int getChiffre6()
        {
            return chiffre6;
        }

    }
}
