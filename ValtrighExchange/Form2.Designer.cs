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
            this.Firma = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.fotoProfilo = new System.Windows.Forms.PictureBox();
            this.valore_attuale = new System.Windows.Forms.Label();
            this.Orologio = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Grafico = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProfilo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.Firma);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.fotoProfilo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 517);
            this.panel1.TabIndex = 0;
            // 
            // Firma
            // 
            this.Firma.AutoSize = true;
            this.Firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firma.Location = new System.Drawing.Point(158, 489);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(104, 16);
            this.Firma.TabIndex = 4;
            this.Firma.Text = "Graziano e Rota";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(12, 489);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(36, 16);
            this.Data.TabIndex = 3;
            this.Data.Text = "Data";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(84, 267);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(25, 13);
            this.Info.TabIndex = 2;
            this.Info.Text = "Info";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(79, 170);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // fotoProfilo
            // 
            this.fotoProfilo.Image = ((System.Drawing.Image)(resources.GetObject("fotoProfilo.Image")));
            this.fotoProfilo.Location = new System.Drawing.Point(49, 29);
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
            this.valore_attuale.Location = new System.Drawing.Point(621, 19);
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
            this.Grafico.Location = new System.Drawing.Point(271, 64);
            this.Grafico.Name = "Grafico";
            this.Grafico.Size = new System.Drawing.Size(712, 441);
            this.Grafico.TabIndex = 4;
            this.Grafico.Text = "Grafico";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 517);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valore_attuale);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProfilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox fotoProfilo;
        private System.Windows.Forms.Label Firma;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label valore_attuale;
        private System.Windows.Forms.Timer Orologio;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart Grafico;
    }
}