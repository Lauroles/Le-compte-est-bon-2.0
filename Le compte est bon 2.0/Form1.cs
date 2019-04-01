using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_compte_est_bon_2._0
{
    public partial class Form1 : Form
    {
        int i = 0; //Déclaration de la variable i 
        int j = 0; //Déclaration de la variable j 
        int k = 0; //Déclaration de la variable k 
        List<string> listeO = new List<string>(); // Création d'une liste
        checker calculCheck = new checker(); //Initialisation de l'objet checker
        generationNumbers nb; //Génération du résultat à trouver

        //Constructeur
        public Form1()
        {
            nb = new generationNumbers(); //Initialisation du résultat
            InitializeComponent(); //Initialisation
        }

        //2 ème constructeur, pour l'utilisation du bouton recommencer
        public Form1(int numberFind)
        {
            nb = new generationNumbers(numberFind); //Permet de sauvegarder le résultat, en appuyant sur le bouton recommencer
            InitializeComponent();
        }

        //Déclaration des 6 nombres aléatoires, utilisable
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.resultat.Text = nb.getResultat().ToString(); //Initialisation du résultat dans une variable
            this.chiffre1.Text = nb.getChiffre1().ToString(); //Initialisation d'un numéro aléatoire dans une variable
            this.chiffre2.Text = nb.getChiffre2().ToString(); // **
            this.chiffre3.Text = nb.getChiffre3().ToString(); // **
            this.chiffre4.Text = nb.getChiffre4().ToString(); // **
            this.chiffre5.Text = nb.getChiffre5().ToString(); // **
            this.chiffre6.Text = nb.getChiffre6().ToString(); // **
        }

        //Initialisation des valeurs, d'une liste dans les cases respectives
        public void giveValueO(List<string> listeO)
        {
            o1.Text = listeO[0];
            o2.Text = listeO[1];
            o3.Text = listeO[2];
            o4.Text = listeO[3];
            o5.Text = listeO[4];
            o6.Text = listeO[5];
        }
        
        //Fonction permettant de transférer la valeur de o (un des chiffres aléatoires) dans un des labels
        private void fonctionTransferValue(object sender, EventArgs e)
        {
            Control buttonPressed = (Control)sender;
            i++; // Incrémentation de i
            string nomControl = "o" + i.ToString(); //Incrémentation de la valeur o + i dans une variable, permettant d'incrémenter automatiquement une valeur dans un label
            Control nameLabel = this.Controls.Find(nomControl, true).FirstOrDefault() as Control;
            nameLabel.Text = buttonPressed.Text; //Met le nombre cliqué dans le prochain label o disponible
            nameLabel.Visible = true; //Rend le bouton visible
            buttonPressed.Enabled = false; //Désactive le bouton sur le clic
        }

        //Fonction permettant de pouvoir ajouter un signe d'opération directement dans un des labels s disponible
        private void fonctionTransferValueOperator(object sender, EventArgs e)
        {
            if (j < 5) //If permettant de ne pas dépasser le nombre de signe disponible à mettre, évitant ainsi un crash
            {
                Control buttonPressed = ((Control)sender);
                j++; //Incrémentation de j
                string nomControl = "s" + j.ToString(); //Incrémentation de la valeur o + j dans une variable, permettant d'incrémenter automatiquement une valeur dans un label
                Control nameLabel = this.Controls.Find(nomControl, true).FirstOrDefault() as Control;
                nameLabel.Text = buttonPressed.Text; //Met le nombre cliqué dans le prochain label s disponible
                nameLabel.Visible = true; //Rend le bouton visible          
            }
            
        }

        //Fonction permettant de lancer le calcul, necessaire, dès que les nombres necessaires sont rentrés, ainsi que les signes d'opérations aussi
        private void label_TextChanged(object sender, EventArgs e)
        {
            Control Operator;
            Control Num1;
            Control Num2;
            Control Result;

            Control labelChanged = (Control)sender;
            int number = Convert.ToInt32(labelChanged.Name.Substring(1)); 
            string letter = labelChanged.Name.Substring(0, 1); //Sépare la variable en 2, pour stocker dans letter, la lettre necessaire 
            if (letter == "o") //If permettant de vérifier que letter est bien = à o
            {
                Operator = this.Controls.Find("s" + (number / 2).ToString(), true).FirstOrDefault() as Control;
                Num1 = this.Controls.Find(letter + (number - 1).ToString(), true).FirstOrDefault() as Control;
                Num2 = labelChanged;
                Result = this.Controls.Find("r" + (number / 2).ToString(), true).FirstOrDefault() as Control;
            }
            else
            {
                
                Operator = this.Controls.Find("s" + (number).ToString(), true).FirstOrDefault() as Control;
                Num1 = this.Controls.Find('o' + ((number * 2) - 1).ToString(), true).FirstOrDefault() as Control;
                Num2 = this.Controls.Find('o' + (number * 2).ToString(), true).FirstOrDefault() as Control;
                Result = this.Controls.Find("r" + (number).ToString(), true).FirstOrDefault() as Control;
            }

            if (Num1.Text != "null" && Num2.Text != "null" && Operator.Text != "null")
            {
               Result.Text = calculCheck.checkCalculPossible(int.Parse(Num1.Text), int.Parse(labelChanged.Text),Operator.Text).ToString();
               Result.Visible = true;
               k++;
            }
        }

        //Création de la fonction abandon, permettant de relancer tous les nombres, et de nettoyer le plateau
        private void abandon_Click(object sender, EventArgs e)
        {
            Form1 Surrender = new Form1();
            Surrender.Show();
            this.Dispose(false);
        }

        //Création de la fonction, permettant l'utilisation de bouton valider
        private void valider_Click(object sender, EventArgs e)
        {
            if(k != 0) // Vérification, qu'au moins 1 calcul a été effectué
            {
                Control finalResult = this.Controls.Find('r' + k.ToString(), true).FirstOrDefault() as Control;
                if (finalResult.Text != "null") //Permet de vérifier que le dernier label r utilisé n'est pas null
                {
                    if (resultat.Text == finalResult.Text) //Vérification de l'égalité entre le dernier calcul, ainsi que le résultat demandé
                    {
                        end NewForm = new end("Bravo, vous avez gagné");//Message de victoire
                        NewForm.Show(); //Apparition du formulaire montrant le message de fin
                    }
                    else
                    {
                        end NewForm = new end("Dommage, c'est perdu"); //Message de défaite
                        NewForm.Show(); //Apparition du formulaire montrant le message de fin
                    }
                }
            }
        }

        //Fonction faisant apparaitre les egals, à chaque calcul effectué
        private void result_TextChanged(object sender, EventArgs e)
        {
            Control resultat = (Control)sender;
            Control equal = this.Controls.Find(resultat.Name.Replace('r', 'e'), true).FirstOrDefault() as Control;
            equal.Visible = true;
        }

        //Fonction créant le bouton recommencer, sauvegardant le résultat à trouver, et netoyant le plateau par la meme occasion
        private void recommencer_Click(object sender, EventArgs e)
        {
            Form1 Surrender = new Form1(Convert.ToInt32(resultat.Text));
            Surrender.Show();
            this.Dispose(false);
        }
    }
}
