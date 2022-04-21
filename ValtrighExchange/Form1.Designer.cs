namespace ValtrighExchange
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username1 = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.Accedi = new System.Windows.Forms.Button();
            this.Registrati1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back1 = new System.Windows.Forms.Button();
            this.Registrati = new System.Windows.Forms.Button();
            this.Checkpsw = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ValtrighExchange";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // Username1
            // 
            this.Username1.Location = new System.Drawing.Point(101, 108);
            this.Username1.Name = "Username1";
            this.Username1.Size = new System.Drawing.Size(111, 20);
            this.Username1.TabIndex = 3;
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(101, 196);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(111, 20);
            this.Password1.TabIndex = 4;
            this.Password1.UseSystemPasswordChar = true;
            // 
            // Accedi
            // 
            this.Accedi.Location = new System.Drawing.Point(109, 247);
            this.Accedi.Name = "Accedi";
            this.Accedi.Size = new System.Drawing.Size(95, 31);
            this.Accedi.TabIndex = 5;
            this.Accedi.Text = "Accedi";
            this.Accedi.UseVisualStyleBackColor = true;
            this.Accedi.Click += new System.EventHandler(this.Accedi_Click);
            // 
            // Registrati1
            // 
            this.Registrati1.Location = new System.Drawing.Point(108, 346);
            this.Registrati1.Name = "Registrati1";
            this.Registrati1.Size = new System.Drawing.Size(95, 23);
            this.Registrati1.TabIndex = 6;
            this.Registrati1.Text = "Registrati";
            this.Registrati1.UseVisualStyleBackColor = true;
            this.Registrati1.Click += new System.EventHandler(this.Registrati1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Non sei ancora registrato? Registrati ora";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back1);
            this.panel1.Controls.Add(this.Registrati);
            this.panel1.Controls.Add(this.Checkpsw);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Cognome);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 359);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // Back1
            // 
            this.Back1.Location = new System.Drawing.Point(222, 325);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(75, 23);
            this.Back1.TabIndex = 17;
            this.Back1.Text = "<-";
            this.Back1.UseVisualStyleBackColor = true;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // Registrati
            // 
            this.Registrati.Location = new System.Drawing.Point(107, 297);
            this.Registrati.Name = "Registrati";
            this.Registrati.Size = new System.Drawing.Size(94, 23);
            this.Registrati.TabIndex = 16;
            this.Registrati.Text = "Registrati";
            this.Registrati.UseVisualStyleBackColor = true;
            this.Registrati.Click += new System.EventHandler(this.Registrati_Click);
            // 
            // Checkpsw
            // 
            this.Checkpsw.Location = new System.Drawing.Point(91, 251);
            this.Checkpsw.Name = "Checkpsw";
            this.Checkpsw.Size = new System.Drawing.Size(126, 20);
            this.Checkpsw.TabIndex = 15;
            this.Checkpsw.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(91, 185);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 20);
            this.Password.TabIndex = 14;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Cognome
            // 
            this.Cognome.Location = new System.Drawing.Point(91, 119);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(126, 20);
            this.Cognome.TabIndex = 13;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(91, 53);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(126, 20);
            this.Nome.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Conferma password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cognome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Accedi);
            this.Controls.Add(this.Registrati1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username1;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.Button Accedi;
        private System.Windows.Forms.Button Registrati1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.Button Registrati;
        private System.Windows.Forms.TextBox Checkpsw;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

