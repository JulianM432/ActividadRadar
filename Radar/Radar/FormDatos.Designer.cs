namespace Radar
{
    partial class FormDatos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.tbVelocidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEsOficial = new System.Windows.Forms.RadioButton();
            this.rbEsCivil = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVelocidad);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidad:";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(108, 16);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(100, 20);
            this.tbPatente.TabIndex = 2;
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.Location = new System.Drawing.Point(108, 54);
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(100, 20);
            this.tbVelocidad.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEsCivil);
            this.groupBox2.Controls.Add(this.rbEsOficial);
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de vehiculo";
            // 
            // rbEsOficial
            // 
            this.rbEsOficial.AutoSize = true;
            this.rbEsOficial.Location = new System.Drawing.Point(8, 19);
            this.rbEsOficial.Name = "rbEsOficial";
            this.rbEsOficial.Size = new System.Drawing.Size(67, 17);
            this.rbEsOficial.TabIndex = 0;
            this.rbEsOficial.TabStop = true;
            this.rbEsOficial.Text = "Es oficial";
            this.rbEsOficial.UseVisualStyleBackColor = true;
            // 
            // rbEsCivil
            // 
            this.rbEsCivil.AutoSize = true;
            this.rbEsCivil.Location = new System.Drawing.Point(8, 42);
            this.rbEsCivil.Name = "rbEsCivil";
            this.rbEsCivil.Size = new System.Drawing.Size(58, 17);
            this.rbEsCivil.TabIndex = 1;
            this.rbEsCivil.TabStop = true;
            this.rbEsCivil.Text = "Es civil";
            this.rbEsCivil.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(13, 191);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 224);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbVelocidad;
        public System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton rbEsCivil;
        public System.Windows.Forms.RadioButton rbEsOficial;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}