
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
            this.SuspendLayout();
            // 
            // lblPirinola
            // 
            this.lblPirinola.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblPirinola.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPirinola.Location = new System.Drawing.Point(214, 201);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPirinola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPirinola;
        private System.Windows.Forms.Timer tmrGiro;
    }
}

