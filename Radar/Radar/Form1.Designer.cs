
namespace Radar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(59, 19);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(143, 20);
            this.tbPatente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de infractores por patente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(347, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Location = new System.Drawing.Point(359, 82);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(108, 45);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registrar vehiculo";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(359, 133);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(108, 45);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Infractores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 83);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(340, 173);
            this.listBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 264);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnListar;
        public System.Windows.Forms.TextBox tbPatente;
        public System.Windows.Forms.ListBox listBox;
    }
}

