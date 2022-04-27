namespace ValtrighExchange
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.last_trans = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Chiudi = new System.Windows.Forms.Button();
            this.Apri = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Firma = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.fotoProfilo = new System.Windows.Forms.PictureBox();
            this.valore_attuale = new System.Windows.Forms.Label();
            this.Orologio = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Grafico = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProfilo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Firma);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.fotoProfilo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 552);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.last_trans);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 161);
            this.panel3.TabIndex = 6;
            // 
            // last_trans
            // 
            this.last_trans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.last_trans.GridLines = true;
            this.last_trans.HideSelection = false;
            this.last_trans.Location = new System.Drawing.Point(0, 32);
            this.last_trans.Name = "last_trans";
            this.last_trans.Size = new System.Drawing.Size(262, 128);
            this.last_trans.TabIndex = 1;
            this.last_trans.UseCompatibleStateImageBehavior = false;
            this.last_trans.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Transazioni";
            this.columnHeader1.Width = 258;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ultime transazioni";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Chiudi);
            this.panel2.Controls.Add(this.Apri);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(14, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 195);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "ADMIN";
            // 
            // Chiudi
            // 
            this.Chiudi.Location = new System.Drawing.Point(131, 164);
            this.Chiudi.Name = "Chiudi";
            this.Chiudi.Size = new System.Drawing.Size(84, 23);
            this.Chiudi.TabIndex = 11;
            this.Chiudi.Text = "Chiudi mercati";
            this.Chiudi.UseVisualStyleBackColor = true;
            this.Chiudi.Click += new System.EventHandler(this.Chiudi_Click);
            // 
            // Apri
            // 
            this.Apri.Location = new System.Drawing.Point(49, 164);
            this.Apri.Name = "Apri";
            this.Apri.Size = new System.Drawing.Size(84, 23);
            this.Apri.TabIndex = 10;
            this.Apri.Text = "Apri mercati";
            this.Apri.UseVisualStyleBackColor = true;
            this.Apri.Click += new System.EventHandler(this.Apri_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(9, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Broker10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Broker9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(90, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Broker8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Broker7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(171, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Broker6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Broker5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Broker4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Broker3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Broker2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Broker1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Firma
            // 
            this.Firma.AutoSize = true;
            this.Firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firma.Location = new System.Drawing.Point(160, 529);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(84, 13);
            this.Firma.TabIndex = 4;
            this.Firma.Text = "Graziano e Rota";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(10, 529);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 3;
            this.Data.Text = "Data";
            // 
            // Nome
            // 
            this.Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nome.AutoEllipsis = true;
            this.Nome.Location = new System.Drawing.Point(75, 131);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(143, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fotoProfilo
            // 
            this.fotoProfilo.Image = ((System.Drawing.Image)(resources.GetObject("fotoProfilo.Image")));
            this.fotoProfilo.Location = new System.Drawing.Point(75, 12);
            this.fotoProfilo.Name = "fotoProfilo";
            this.fotoProfilo.Size = new System.Drawing.Size(143, 116);
            this.fotoProfilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoProfilo.TabIndex = 0;
            this.fotoProfilo.TabStop = false;
            // 
            // valore_attuale
            // 
            this.valore_attuale.AutoSize = true;
            this.valore_attuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valore_attuale.Location = new System.Drawing.Point(658, 19);
            this.valore_attuale.Name = "valore_attuale";
            this.valore_attuale.Size = new System.Drawing.Size(163, 29);
            this.valore_attuale.TabIndex = 1;
            this.valore_attuale.Text = "valore_attuale";
            this.valore_attuale.TextChanged += new System.EventHandler(this.valore_attuale_TextChanged);
            // 
            // Orologio
            // 
            this.Orologio.Enabled = true;
            this.Orologio.Interval = 1000;
            this.Orologio.Tick += new System.EventHandler(this.Orologio_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valore attuale:";
            // 
            // Grafico
            // 
            this.Grafico.Location = new System.Drawing.Point(298, 51);
            this.Grafico.Name = "Grafico";
            this.Grafico.Size = new System.Drawing.Size(806, 491);
            this.Grafico.TabIndex = 4;
            this.Grafico.Text = "Grafico";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 552);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valore_attuale);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProfilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox fotoProfilo;
        private System.Windows.Forms.Label Firma;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label valore_attuale;
        private System.Windows.Forms.Timer Orologio;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart Grafico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Chiudi;
        private System.Windows.Forms.Button Apri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView last_trans;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}