namespace pantallas1
{
    partial class Consultar_P
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
            this.label1_N = new System.Windows.Forms.Label();
            this.comboBox1_N_A = new System.Windows.Forms.ComboBox();
            this.button1_C_P = new System.Windows.Forms.Button();
            this.button2_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_N
            // 
            this.label1_N.AutoSize = true;
            this.label1_N.Location = new System.Drawing.Point(57, 41);
            this.label1_N.Name = "label1_N";
            this.label1_N.Size = new System.Drawing.Size(65, 20);
            this.label1_N.TabIndex = 0;
            this.label1_N.Text = "Nombre";
            // 
            // comboBox1_N_A
            // 
            this.comboBox1_N_A.FormattingEnabled = true;
            this.comboBox1_N_A.Location = new System.Drawing.Point(185, 41);
            this.comboBox1_N_A.Name = "comboBox1_N_A";
            this.comboBox1_N_A.Size = new System.Drawing.Size(252, 28);
            this.comboBox1_N_A.TabIndex = 1;
            // 
            // button1_C_P
            // 
            this.button1_C_P.Location = new System.Drawing.Point(185, 364);
            this.button1_C_P.Name = "button1_C_P";
            this.button1_C_P.Size = new System.Drawing.Size(87, 39);
            this.button1_C_P.TabIndex = 2;
            this.button1_C_P.Text = "Consultar";
            this.button1_C_P.UseVisualStyleBackColor = true;
            this.button1_C_P.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_C
            // 
            this.button2_C.Location = new System.Drawing.Point(545, 364);
            this.button2_C.Name = "button2_C";
            this.button2_C.Size = new System.Drawing.Size(93, 39);
            this.button2_C.TabIndex = 3;
            this.button2_C.Text = "Cancelar";
            this.button2_C.UseVisualStyleBackColor = true;
            this.button2_C.Click += new System.EventHandler(this.button2_C_Click);
            // 
            // Consultar_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 468);
            this.Controls.Add(this.button2_C);
            this.Controls.Add(this.button1_C_P);
            this.Controls.Add(this.comboBox1_N_A);
            this.Controls.Add(this.label1_N);
            this.Name = "Consultar_P";
            this.Text = "Consultar_P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_N;
        private System.Windows.Forms.ComboBox comboBox1_N_A;
        private System.Windows.Forms.Button button1_C_P;
        private System.Windows.Forms.Button button2_C;
    }
}