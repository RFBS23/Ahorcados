namespace Ahorcados
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.iconopic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btninicio = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconopic)).BeginInit();
            this.SuspendLayout();
            // 
            // iconopic
            // 
            this.iconopic.BorderRadius = 15;
            this.iconopic.Image = global::Ahorcados.Properties.Resources.memoji_saludando;
            this.iconopic.ImageRotate = 0F;
            this.iconopic.Location = new System.Drawing.Point(91, 42);
            this.iconopic.Name = "iconopic";
            this.iconopic.Size = new System.Drawing.Size(323, 300);
            this.iconopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconopic.TabIndex = 0;
            this.iconopic.TabStop = false;
            // 
            // btninicio
            // 
            this.btninicio.BorderRadius = 12;
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btninicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btninicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btninicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btninicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(91, 384);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(323, 64);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "INGRESAR";
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright 2023, By RFBS23";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.iconopic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 576);
            this.MinimumSize = new System.Drawing.Size(520, 576);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Ahorcados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iconopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox iconopic;
        private Guna.UI2.WinForms.Guna2Button btninicio;
        private System.Windows.Forms.Label label1;
    }
}