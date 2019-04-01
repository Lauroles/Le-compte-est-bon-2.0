namespace Le_compte_est_bon_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.chiffre1 = new System.Windows.Forms.Button();
            this.chiffre2 = new System.Windows.Forms.Button();
            this.chiffre3 = new System.Windows.Forms.Button();
            this.chiffre4 = new System.Windows.Forms.Button();
            this.chiffre5 = new System.Windows.Forms.Button();
            this.chiffre6 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.multiplier = new System.Windows.Forms.Button();
            this.diviser = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.recommencer = new System.Windows.Forms.Button();
            this.abandon = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.o2 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.Button();
            this.r2 = new System.Windows.Forms.Button();
            this.e2 = new System.Windows.Forms.Label();
            this.o4 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.o3 = new System.Windows.Forms.Label();
            this.r3 = new System.Windows.Forms.Button();
            this.e3 = new System.Windows.Forms.Label();
            this.o6 = new System.Windows.Forms.Label();
            this.s3 = new System.Windows.Forms.Label();
            this.o5 = new System.Windows.Forms.Label();
            this.r4 = new System.Windows.Forms.Button();
            this.e4 = new System.Windows.Forms.Label();
            this.o8 = new System.Windows.Forms.Label();
            this.s4 = new System.Windows.Forms.Label();
            this.o7 = new System.Windows.Forms.Label();
            this.r5 = new System.Windows.Forms.Button();
            this.e5 = new System.Windows.Forms.Label();
            this.o10 = new System.Windows.Forms.Label();
            this.s5 = new System.Windows.Forms.Label();
            this.o9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chiffre1
            // 
            this.chiffre1.Location = new System.Drawing.Point(63, 86);
            this.chiffre1.Name = "chiffre1";
            this.chiffre1.Size = new System.Drawing.Size(75, 23);
            this.chiffre1.TabIndex = 0;
            this.chiffre1.Text = "button1";
            this.chiffre1.UseVisualStyleBackColor = true;
            this.chiffre1.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // chiffre2
            // 
            this.chiffre2.Location = new System.Drawing.Point(201, 86);
            this.chiffre2.Name = "chiffre2";
            this.chiffre2.Size = new System.Drawing.Size(75, 23);
            this.chiffre2.TabIndex = 1;
            this.chiffre2.Text = "button2";
            this.chiffre2.UseVisualStyleBackColor = true;
            this.chiffre2.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // chiffre3
            // 
            this.chiffre3.Location = new System.Drawing.Point(341, 86);
            this.chiffre3.Name = "chiffre3";
            this.chiffre3.Size = new System.Drawing.Size(75, 23);
            this.chiffre3.TabIndex = 2;
            this.chiffre3.Text = "button3";
            this.chiffre3.UseVisualStyleBackColor = true;
            this.chiffre3.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // chiffre4
            // 
            this.chiffre4.Location = new System.Drawing.Point(475, 86);
            this.chiffre4.Name = "chiffre4";
            this.chiffre4.Size = new System.Drawing.Size(75, 23);
            this.chiffre4.TabIndex = 3;
            this.chiffre4.Text = "button4";
            this.chiffre4.UseVisualStyleBackColor = true;
            this.chiffre4.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // chiffre5
            // 
            this.chiffre5.Location = new System.Drawing.Point(607, 86);
            this.chiffre5.Name = "chiffre5";
            this.chiffre5.Size = new System.Drawing.Size(75, 23);
            this.chiffre5.TabIndex = 4;
            this.chiffre5.Text = "button5";
            this.chiffre5.UseVisualStyleBackColor = true;
            this.chiffre5.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // chiffre6
            // 
            this.chiffre6.Location = new System.Drawing.Point(741, 86);
            this.chiffre6.Name = "chiffre6";
            this.chiffre6.Size = new System.Drawing.Size(75, 23);
            this.chiffre6.TabIndex = 5;
            this.chiffre6.Text = "button6";
            this.chiffre6.UseVisualStyleBackColor = true;
            this.chiffre6.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(741, 163);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 37);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.fonctionTransferValueOperator);
            // 
            // moins
            // 
            this.moins.Location = new System.Drawing.Point(741, 257);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(75, 35);
            this.moins.TabIndex = 7;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = true;
            this.moins.Click += new System.EventHandler(this.fonctionTransferValueOperator);
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(741, 347);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(75, 37);
            this.multiplier.TabIndex = 8;
            this.multiplier.Text = "X";
            this.multiplier.UseVisualStyleBackColor = true;
            this.multiplier.Click += new System.EventHandler(this.fonctionTransferValueOperator);
            // 
            // diviser
            // 
            this.diviser.Location = new System.Drawing.Point(741, 437);
            this.diviser.Name = "diviser";
            this.diviser.Size = new System.Drawing.Size(75, 36);
            this.diviser.TabIndex = 9;
            this.diviser.Text = "/";
            this.diviser.UseVisualStyleBackColor = true;
            this.diviser.Click += new System.EventHandler(this.fonctionTransferValueOperator);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(534, 449);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(148, 23);
            this.valider.TabIndex = 10;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // recommencer
            // 
            this.recommencer.Location = new System.Drawing.Point(319, 450);
            this.recommencer.Name = "recommencer";
            this.recommencer.Size = new System.Drawing.Size(119, 23);
            this.recommencer.TabIndex = 12;
            this.recommencer.Text = "Recommencer";
            this.recommencer.UseVisualStyleBackColor = true;
            this.recommencer.Click += new System.EventHandler(this.recommencer_Click);
            // 
            // abandon
            // 
            this.abandon.Location = new System.Drawing.Point(82, 450);
            this.abandon.Name = "abandon";
            this.abandon.Size = new System.Drawing.Size(135, 23);
            this.abandon.TabIndex = 13;
            this.abandon.Text = "Abandon";
            this.abandon.UseVisualStyleBackColor = true;
            this.abandon.Click += new System.EventHandler(this.abandon_Click);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(79, 19);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(32, 17);
            this.resultat.TabIndex = 14;
            this.resultat.Text = "000";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Location = new System.Drawing.Point(79, 153);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(30, 17);
            this.o1.TabIndex = 15;
            this.o1.Text = "null";
            this.o1.Visible = false;
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Location = new System.Drawing.Point(227, 153);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(30, 17);
            this.s1.TabIndex = 16;
            this.s1.Text = "null";
            this.s1.Visible = false;
            // 
            // o2
            // 
            this.o2.AutoSize = true;
            this.o2.Location = new System.Drawing.Point(367, 153);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(30, 17);
            this.o2.TabIndex = 17;
            this.o2.Text = "null";
            this.o2.Visible = false;
            this.o2.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Location = new System.Drawing.Point(501, 153);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(16, 17);
            this.e1.TabIndex = 18;
            this.e1.Text = "=";
            this.e1.Visible = false;
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(604, 147);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(75, 23);
            this.r1.TabIndex = 19;
            this.r1.Text = "button15";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.Visible = false;
            this.r1.TextChanged += new System.EventHandler(this.result_TextChanged);
            this.r1.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // r2
            // 
            this.r2.Location = new System.Drawing.Point(604, 201);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(75, 23);
            this.r2.TabIndex = 24;
            this.r2.Text = "button16";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.Visible = false;
            this.r2.TextChanged += new System.EventHandler(this.result_TextChanged);
            this.r2.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Location = new System.Drawing.Point(501, 207);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(16, 17);
            this.e2.TabIndex = 23;
            this.e2.Text = "=";
            this.e2.Visible = false;
            // 
            // o4
            // 
            this.o4.AutoSize = true;
            this.o4.Location = new System.Drawing.Point(367, 207);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(30, 17);
            this.o4.TabIndex = 22;
            this.o4.Text = "null";
            this.o4.Visible = false;
            this.o4.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Location = new System.Drawing.Point(227, 207);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(30, 17);
            this.s2.TabIndex = 21;
            this.s2.Text = "null";
            this.s2.Visible = false;
            // 
            // o3
            // 
            this.o3.AutoSize = true;
            this.o3.Location = new System.Drawing.Point(79, 207);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(30, 17);
            this.o3.TabIndex = 20;
            this.o3.Text = "null";
            this.o3.Visible = false;
            // 
            // r3
            // 
            this.r3.Location = new System.Drawing.Point(604, 257);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(75, 23);
            this.r3.TabIndex = 29;
            this.r3.Text = "button17";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.Visible = false;
            this.r3.TextChanged += new System.EventHandler(this.result_TextChanged);
            this.r3.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Location = new System.Drawing.Point(501, 263);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(16, 17);
            this.e3.TabIndex = 28;
            this.e3.Text = "=";
            this.e3.Visible = false;
            // 
            // o6
            // 
            this.o6.AutoSize = true;
            this.o6.Location = new System.Drawing.Point(367, 263);
            this.o6.Name = "o6";
            this.o6.Size = new System.Drawing.Size(30, 17);
            this.o6.TabIndex = 27;
            this.o6.Text = "null";
            this.o6.Visible = false;
            this.o6.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Location = new System.Drawing.Point(227, 263);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(30, 17);
            this.s3.TabIndex = 26;
            this.s3.Text = "null";
            this.s3.Visible = false;
            // 
            // o5
            // 
            this.o5.AutoSize = true;
            this.o5.Location = new System.Drawing.Point(79, 263);
            this.o5.Name = "o5";
            this.o5.Size = new System.Drawing.Size(30, 17);
            this.o5.TabIndex = 25;
            this.o5.Text = "null";
            this.o5.Visible = false;
            // 
            // r4
            // 
            this.r4.Location = new System.Drawing.Point(604, 312);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(75, 23);
            this.r4.TabIndex = 34;
            this.r4.Text = "button18";
            this.r4.UseVisualStyleBackColor = true;
            this.r4.Visible = false;
            this.r4.TextChanged += new System.EventHandler(this.result_TextChanged);
            this.r4.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Location = new System.Drawing.Point(501, 318);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(16, 17);
            this.e4.TabIndex = 33;
            this.e4.Text = "=";
            this.e4.Visible = false;
            // 
            // o8
            // 
            this.o8.AutoSize = true;
            this.o8.Location = new System.Drawing.Point(367, 318);
            this.o8.Name = "o8";
            this.o8.Size = new System.Drawing.Size(30, 17);
            this.o8.TabIndex = 32;
            this.o8.Text = "null";
            this.o8.Visible = false;
            this.o8.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.Location = new System.Drawing.Point(227, 318);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(30, 17);
            this.s4.TabIndex = 31;
            this.s4.Text = "null";
            this.s4.Visible = false;
            // 
            // o7
            // 
            this.o7.AutoSize = true;
            this.o7.Location = new System.Drawing.Point(79, 318);
            this.o7.Name = "o7";
            this.o7.Size = new System.Drawing.Size(30, 17);
            this.o7.TabIndex = 30;
            this.o7.Text = "null";
            this.o7.Visible = false;
            // 
            // r5
            // 
            this.r5.Location = new System.Drawing.Point(604, 371);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(75, 23);
            this.r5.TabIndex = 39;
            this.r5.Text = "button1";
            this.r5.UseVisualStyleBackColor = true;
            this.r5.Visible = false;
            this.r5.TextChanged += new System.EventHandler(this.result_TextChanged);
            this.r5.Click += new System.EventHandler(this.fonctionTransferValue);
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.Location = new System.Drawing.Point(501, 377);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(16, 17);
            this.e5.TabIndex = 38;
            this.e5.Text = "=";
            this.e5.Visible = false;
            // 
            // o10
            // 
            this.o10.AutoSize = true;
            this.o10.Location = new System.Drawing.Point(367, 377);
            this.o10.Name = "o10";
            this.o10.Size = new System.Drawing.Size(30, 17);
            this.o10.TabIndex = 37;
            this.o10.Text = "null";
            this.o10.Visible = false;
            this.o10.TextChanged += new System.EventHandler(this.label_TextChanged);
            // 
            // s5
            // 
            this.s5.AutoSize = true;
            this.s5.Location = new System.Drawing.Point(227, 377);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(30, 17);
            this.s5.TabIndex = 36;
            this.s5.Text = "null";
            this.s5.Visible = false;
            // 
            // o9
            // 
            this.o9.AutoSize = true;
            this.o9.Location = new System.Drawing.Point(79, 377);
            this.o9.Name = "o9";
            this.o9.Size = new System.Drawing.Size(30, 17);
            this.o9.TabIndex = 35;
            this.o9.Text = "null";
            this.o9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.r5);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.o10);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.o9);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.o8);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.o7);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.o6);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.o5);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.o4);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.o3);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.o1);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.abandon);
            this.Controls.Add(this.recommencer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.diviser);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.chiffre6);
            this.Controls.Add(this.chiffre5);
            this.Controls.Add(this.chiffre4);
            this.Controls.Add(this.chiffre3);
            this.Controls.Add(this.chiffre2);
            this.Controls.Add(this.chiffre1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chiffre1;
        private System.Windows.Forms.Button chiffre2;
        private System.Windows.Forms.Button chiffre3;
        private System.Windows.Forms.Button chiffre4;
        private System.Windows.Forms.Button chiffre5;
        private System.Windows.Forms.Button chiffre6;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button multiplier;
        private System.Windows.Forms.Button diviser;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button recommencer;
        private System.Windows.Forms.Button abandon;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.Label o1;
        public System.Windows.Forms.Label s1;
        public System.Windows.Forms.Label o2;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Button r1;
        private System.Windows.Forms.Button r2;
        private System.Windows.Forms.Label e2;
        public System.Windows.Forms.Label o4;
        public System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label o3;
        private System.Windows.Forms.Button r3;
        private System.Windows.Forms.Label e3;
        public System.Windows.Forms.Label o6;
        public System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label o5;
        private System.Windows.Forms.Button r4;
        private System.Windows.Forms.Label e4;
        public System.Windows.Forms.Label o8;
        public System.Windows.Forms.Label s4;
        private System.Windows.Forms.Label o7;
        private System.Windows.Forms.Button r5;
        private System.Windows.Forms.Label e5;
        public System.Windows.Forms.Label o10;
        public System.Windows.Forms.Label s5;
        private System.Windows.Forms.Label o9;
    }
}

