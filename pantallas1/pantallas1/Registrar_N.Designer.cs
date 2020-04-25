namespace pantallas1
{
    partial class Form1_R
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
            this.label1_nom = new System.Windows.Forms.Label();
            this.label2_apell = new System.Windows.Forms.Label();
            this.label3_E = new System.Windows.Forms.Label();
            this.label4_T = new System.Windows.Forms.Label();
            this.label5_S = new System.Windows.Forms.Label();
            this.label6_F = new System.Windows.Forms.Label();
            this.button1_A = new System.Windows.Forms.Button();
            this.button2_C = new System.Windows.Forms.Button();
            this.textBox1_Nombre = new System.Windows.Forms.TextBox();
            this.textBox2_Apellido = new System.Windows.Forms.TextBox();
            this.textBox3_edad = new System.Windows.Forms.TextBox();
            this.textBox4_Telefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2_M = new System.Windows.Forms.CheckBox();
            this.checkBox1_H = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_nom
            // 
            this.label1_nom.AutoSize = true;
            this.label1_nom.Location = new System.Drawing.Point(31, 49);
            this.label1_nom.Name = "label1_nom";
            this.label1_nom.Size = new System.Drawing.Size(65, 20);
            this.label1_nom.TabIndex = 0;
            this.label1_nom.Text = "Nombre";
            // 
            // label2_apell
            // 
            this.label2_apell.AutoSize = true;
            this.label2_apell.Location = new System.Drawing.Point(31, 98);
            this.label2_apell.Name = "label2_apell";
            this.label2_apell.Size = new System.Drawing.Size(65, 20);
            this.label2_apell.TabIndex = 1;
            this.label2_apell.Text = "Apellido";
            // 
            // label3_E
            // 
            this.label3_E.AutoSize = true;
            this.label3_E.Location = new System.Drawing.Point(31, 149);
            this.label3_E.Name = "label3_E";
            this.label3_E.Size = new System.Drawing.Size(47, 20);
            this.label3_E.TabIndex = 2;
            this.label3_E.Text = "Edad";
            // 
            // label4_T
            // 
            this.label4_T.AutoSize = true;
            this.label4_T.Location = new System.Drawing.Point(31, 200);
            this.label4_T.Name = "label4_T";
            this.label4_T.Size = new System.Drawing.Size(71, 20);
            this.label4_T.TabIndex = 3;
            this.label4_T.Text = "Telefono";
            // 
            // label5_S
            // 
            this.label5_S.AutoSize = true;
            this.label5_S.Location = new System.Drawing.Point(31, 259);
            this.label5_S.Name = "label5_S";
            this.label5_S.Size = new System.Drawing.Size(45, 20);
            this.label5_S.TabIndex = 4;
            this.label5_S.Text = "Sexo";
            // 
            // label6_F
            // 
            this.label6_F.AutoSize = true;
            this.label6_F.Location = new System.Drawing.Point(31, 320);
            this.label6_F.Name = "label6_F";
            this.label6_F.Size = new System.Drawing.Size(54, 20);
            this.label6_F.TabIndex = 5;
            this.label6_F.Text = "Fecha";
            // 
            // button1_A
            // 
            this.button1_A.Location = new System.Drawing.Point(295, 443);
            this.button1_A.Name = "button1_A";
            this.button1_A.Size = new System.Drawing.Size(92, 39);
            this.button1_A.TabIndex = 6;
            this.button1_A.Text = "Agregar";
            this.button1_A.UseVisualStyleBackColor = true;
            // 
            // button2_C
            // 
            this.button2_C.Location = new System.Drawing.Point(691, 443);
            this.button2_C.Name = "button2_C";
            this.button2_C.Size = new System.Drawing.Size(88, 39);
            this.button2_C.TabIndex = 7;
            this.button2_C.Text = "Cancelar";
            this.button2_C.UseVisualStyleBackColor = true;
            this.button2_C.Click += new System.EventHandler(this.button2_C_Click);
            // 
            // textBox1_Nombre
            // 
            this.textBox1_Nombre.Location = new System.Drawing.Point(140, 43);
            this.textBox1_Nombre.Name = "textBox1_Nombre";
            this.textBox1_Nombre.Size = new System.Drawing.Size(215, 26);
            this.textBox1_Nombre.TabIndex = 8;
            this.textBox1_Nombre.TextChanged += new System.EventHandler(this.textBox1_Nombre_TextChanged);
            // 
            // textBox2_Apellido
            // 
            this.textBox2_Apellido.Location = new System.Drawing.Point(140, 92);
            this.textBox2_Apellido.Name = "textBox2_Apellido";
            this.textBox2_Apellido.Size = new System.Drawing.Size(215, 26);
            this.textBox2_Apellido.TabIndex = 9;
            // 
            // textBox3_edad
            // 
            this.textBox3_edad.Location = new System.Drawing.Point(140, 143);
            this.textBox3_edad.Name = "textBox3_edad";
            this.textBox3_edad.Size = new System.Drawing.Size(215, 26);
            this.textBox3_edad.TabIndex = 10;
            // 
            // textBox4_Telefono
            // 
            this.textBox4_Telefono.Location = new System.Drawing.Point(140, 194);
            this.textBox4_Telefono.Name = "textBox4_Telefono";
            this.textBox4_Telefono.Size = new System.Drawing.Size(215, 26);
            this.textBox4_Telefono.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2_M);
            this.groupBox1.Controls.Add(this.checkBox1_H);
            this.groupBox1.Location = new System.Drawing.Point(140, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 47);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2_M
            // 
            this.checkBox2_M.AutoSize = true;
            this.checkBox2_M.Location = new System.Drawing.Point(102, 16);
            this.checkBox2_M.Name = "checkBox2_M";
            this.checkBox2_M.Size = new System.Drawing.Size(74, 24);
            this.checkBox2_M.TabIndex = 16;
            this.checkBox2_M.Text = "Mujer";
            this.checkBox2_M.UseVisualStyleBackColor = true;
            // 
            // checkBox1_H
            // 
            this.checkBox1_H.AutoSize = true;
            this.checkBox1_H.Location = new System.Drawing.Point(0, 17);
            this.checkBox1_H.Name = "checkBox1_H";
            this.checkBox1_H.Size = new System.Drawing.Size(92, 24);
            this.checkBox1_H.TabIndex = 15;
            this.checkBox1_H.Text = "Hombre";
            this.checkBox1_H.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Form1_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 570);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4_Telefono);
            this.Controls.Add(this.textBox3_edad);
            this.Controls.Add(this.textBox2_Apellido);
            this.Controls.Add(this.textBox1_Nombre);
            this.Controls.Add(this.button2_C);
            this.Controls.Add(this.button1_A);
            this.Controls.Add(this.label6_F);
            this.Controls.Add(this.label5_S);
            this.Controls.Add(this.label4_T);
            this.Controls.Add(this.label3_E);
            this.Controls.Add(this.label2_apell);
            this.Controls.Add(this.label1_nom);
            this.Name = "Form1_R";
            this.Text = "Registrar_N";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_nom;
        private System.Windows.Forms.Label label2_apell;
        private System.Windows.Forms.Label label3_E;
        private System.Windows.Forms.Label label4_T;
        private System.Windows.Forms.Label label5_S;
        private System.Windows.Forms.Label label6_F;
        private System.Windows.Forms.Button button1_A;
        private System.Windows.Forms.Button button2_C;
        private System.Windows.Forms.TextBox textBox1_Nombre;
        private System.Windows.Forms.TextBox textBox2_Apellido;
        private System.Windows.Forms.TextBox textBox3_edad;
        private System.Windows.Forms.TextBox textBox4_Telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2_M;
        private System.Windows.Forms.CheckBox checkBox1_H;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

