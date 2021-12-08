
namespace AppTomaTodo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPirinola = new System.Windows.Forms.Label();
            this.tmrGiro = new System.Windows.Forms.Timer(this.components);
            this.chkJugador = new System.Windows.Forms.CheckBox();
            this.chkComputadora = new System.Windows.Forms.CheckBox();
            this.lblPozo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPirinola
            // 
            this.lblPirinola.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblPirinola.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPirinola.Location = new System.Drawing.Point(73, 67);
            this.lblPirinola.Name = "lblPirinola";
            this.lblPirinola.Size = new System.Drawing.Size(169, 138);
            this.lblPirinola.TabIndex = 0;
            this.lblPirinola.Text = "TOMA TODO";
            this.lblPirinola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPirinola.Click += new System.EventHandler(this.lblPirinola_Click);
            // 
            // tmrGiro
            // 
            this.tmrGiro.Interval = 200;
            this.tmrGiro.Tick += new System.EventHandler(this.tmrGiro_Tick);
            // 
            // chkJugador
            // 
            this.chkJugador.AutoSize = true;
            this.chkJugador.Enabled = false;
            this.chkJugador.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkJugador.Location = new System.Drawing.Point(73, 12);
            this.chkJugador.Name = "chkJugador";
            this.chkJugador.Size = new System.Drawing.Size(163, 41);
            this.chkJugador.TabIndex = 1;
            this.chkJugador.Text = "Jugador: 0";
            this.chkJugador.UseVisualStyleBackColor = true;
            // 
            // chkComputadora
            // 
            this.chkComputadora.AutoSize = true;
            this.chkComputadora.Enabled = false;
            this.chkComputadora.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkComputadora.Location = new System.Drawing.Point(73, 225);
            this.chkComputadora.Name = "chkComputadora";
            this.chkComputadora.Size = new System.Drawing.Size(163, 41);
            this.chkComputadora.TabIndex = 1;
            this.chkComputadora.Text = "Jugador: 0";
            this.chkComputadora.UseVisualStyleBackColor = true;
            // 
            // lblPozo
            // 
            this.lblPozo.AutoSize = true;
            this.lblPozo.Location = new System.Drawing.Point(299, 124);
            this.lblPozo.Name = "lblPozo";
            this.lblPozo.Size = new System.Drawing.Size(56, 20);
            this.lblPozo.TabIndex = 2;
            this.lblPozo.Text = "Pozo: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 296);
            this.Controls.Add(this.lblPozo);
            this.Controls.Add(this.chkComputadora);
            this.Controls.Add(this.chkJugador);
            this.Controls.Add(this.lblPirinola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPirinola;
        private System.Windows.Forms.Timer tmrGiro;
        private System.Windows.Forms.CheckBox chkJugador;
        private System.Windows.Forms.CheckBox chkComputadora;
        private System.Windows.Forms.Label lblPozo;
    }
}

