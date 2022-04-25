namespace Presentation
{
    partial class Carrito2
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
            this.comprar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comprar
            // 
            this.comprar.BackColor = System.Drawing.Color.Gold;
            this.comprar.FlatAppearance.BorderSize = 0;
            this.comprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comprar.Location = new System.Drawing.Point(2141, 116);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(373, 110);
            this.comprar.TabIndex = 0;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = false;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1644, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(2141, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 110);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vaciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Carrito2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(3288, 1332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito2";
            this.Text = "Carrito2";
            this.Load += new System.EventHandler(this.Carrito2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button comprar;
        private Label label2;
        private Button button1;
    }
}