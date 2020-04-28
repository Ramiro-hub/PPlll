namespace pantallas1
{
    partial class Modificar_P
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
            this.label1_N_A = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1_M = new System.Windows.Forms.Button();
            this.button2_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_N_A
            // 
            this.label1_N_A.AutoSize = true;
            this.label1_N_A.Location = new System.Drawing.Point(29, 55);
            this.label1_N_A.Name = "label1_N_A";
            this.label1_N_A.Size = new System.Drawing.Size(65, 20);
            this.label1_N_A.TabIndex = 0;
            this.label1_N_A.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1_M
            // 
            this.button1_M.Location = new System.Drawing.Point(171, 340);
            this.button1_M.Name = "button1_M";
            this.button1_M.Size = new System.Drawing.Size(104, 43);
            this.button1_M.TabIndex = 4;
            this.button1_M.Text = "Modificar";
            this.button1_M.UseVisualStyleBackColor = true;
            this.button1_M.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_C
            // 
            this.button2_C.Location = new System.Drawing.Point(504, 340);
            this.button2_C.Name = "button2_C";
            this.button2_C.Size = new System.Drawing.Size(97, 43);
            this.button2_C.TabIndex = 5;
            this.button2_C.Text = "Cancelar";
            this.button2_C.UseVisualStyleBackColor = true;
            this.button2_C.Click += new System.EventHandler(this.button2_C_Click);
            // 
            // Modificar_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_C);
            this.Controls.Add(this.button1_M);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1_N_A);
            this.Name = "Modificar_P";
            this.Text = "Modificar_P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_N_A;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1_M;
        private System.Windows.Forms.Button button2_C;
    }
}