namespace Laboration4
{
    partial class Form1
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
            this.Lagerknapp = new System.Windows.Forms.Button();
            this.Kassaknapp = new System.Windows.Forms.Button();
            this.Avsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lagerknapp
            // 
            this.Lagerknapp.Location = new System.Drawing.Point(113, 160);
            this.Lagerknapp.Name = "Lagerknapp";
            this.Lagerknapp.Size = new System.Drawing.Size(248, 80);
            this.Lagerknapp.TabIndex = 1;
            this.Lagerknapp.Text = "Inventory Management";
            this.Lagerknapp.UseVisualStyleBackColor = true;
            this.Lagerknapp.Click += new System.EventHandler(this.Lagerknapp_Click);
            // 
            // Kassaknapp
            // 
            this.Kassaknapp.Location = new System.Drawing.Point(462, 160);
            this.Kassaknapp.Name = "Kassaknapp";
            this.Kassaknapp.Size = new System.Drawing.Size(249, 80);
            this.Kassaknapp.TabIndex = 2;
            this.Kassaknapp.Text = "POS System";
            this.Kassaknapp.UseVisualStyleBackColor = true;
            this.Kassaknapp.Click += new System.EventHandler(this.Kassaknapp_Click);
            // 
            // Avsluta
            // 
            this.Avsluta.BackColor = System.Drawing.Color.Red;
            this.Avsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avsluta.Location = new System.Drawing.Point(614, 382);
            this.Avsluta.Name = "Avsluta";
            this.Avsluta.Size = new System.Drawing.Size(185, 68);
            this.Avsluta.TabIndex = 3;
            this.Avsluta.Text = "Avsluta";
            this.Avsluta.UseVisualStyleBackColor = false;
            this.Avsluta.Click += new System.EventHandler(this.Avsluta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Avsluta);
            this.Controls.Add(this.Kassaknapp);
            this.Controls.Add(this.Lagerknapp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lagerknapp;
        private System.Windows.Forms.Button Kassaknapp;
        private System.Windows.Forms.Button Avsluta;
    }
}

