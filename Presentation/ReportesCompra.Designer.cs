namespace Presentation
{
    partial class ReportesCompra
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.txtTotalCompras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(82, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(860, 96);
            this.label7.TabIndex = 17;
            this.label7.Text = "Reporte de Compras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(2222, 805);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(2493, 300);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(433, 55);
            this.txtDate.TabIndex = 19;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2493, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(2549, 374);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(328, 62);
            this.btnFecha.TabIndex = 21;
            this.btnFecha.Text = "Buscar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // txtTotalCompras
            // 
            this.txtTotalCompras.Location = new System.Drawing.Point(2493, 568);
            this.txtTotalCompras.Name = "txtTotalCompras";
            this.txtTotalCompras.Size = new System.Drawing.Size(433, 55);
            this.txtTotalCompras.TabIndex = 22;
            this.txtTotalCompras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2493, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 48);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReportesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4090, 1174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalCompras);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesCompra";
            this.Text = "ReportesCompra";
            this.Load += new System.EventHandler(this.ReportesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private DataGridView dataGridView1;
        private TextBox txtDate;
        private Label label1;
        private Button btnFecha;
        private TextBox txtTotalCompras;
        private Label label2;
    }
}