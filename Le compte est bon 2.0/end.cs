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
    public partial class end : Form
    {
        //Création du constructeur
        public end()
        {
            InitializeComponent();
        }
        //Création d'une fonction, permettant d'initaliser une phrase sur le nouveau formulaire
        public end(string EndText)
        {
            InitializeComponent();
            endPhrase.Text = EndText; //Ajout de la phrass sur le formulaire de fin
        }
    }
}
