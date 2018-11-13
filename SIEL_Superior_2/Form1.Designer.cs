namespace SIEL_Superior_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxEcuaciones = new System.Windows.Forms.TextBox();
            this.btnNormaInf = new System.Windows.Forms.Button();
            this.lblNorma = new System.Windows.Forms.Label();
            this.btnNorma1 = new System.Windows.Forms.Button();
            this.btnNorma2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMDD = new System.Windows.Forms.Button();
            this.btnJacobi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxEcuaciones
            // 
            this.txtbxEcuaciones.Location = new System.Drawing.Point(28, 12);
            this.txtbxEcuaciones.Multiline = true;
            this.txtbxEcuaciones.Name = "txtbxEcuaciones";
            this.txtbxEcuaciones.Size = new System.Drawing.Size(520, 130);
            this.txtbxEcuaciones.TabIndex = 0;
            // 
            // btnNormaInf
            // 
            this.btnNormaInf.Location = new System.Drawing.Point(5, 20);
            this.btnNormaInf.Name = "btnNormaInf";
            this.btnNormaInf.Size = new System.Drawing.Size(90, 23);
            this.btnNormaInf.TabIndex = 1;
            this.btnNormaInf.TabStop = false;
            this.btnNormaInf.Text = "Norma Infinito";
            this.btnNormaInf.UseVisualStyleBackColor = true;
            this.btnNormaInf.Click += new System.EventHandler(this.btnNormaInf_Click);
            // 
            // lblNorma
            // 
            this.lblNorma.AutoSize = true;
            this.lblNorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorma.Location = new System.Drawing.Point(436, 17);
            this.lblNorma.Name = "lblNorma";
            this.lblNorma.Size = new System.Drawing.Size(66, 24);
            this.lblNorma.TabIndex = 2;
            this.lblNorma.Text = "label1";
            // 
            // btnNorma1
            // 
            this.btnNorma1.Location = new System.Drawing.Point(120, 20);
            this.btnNorma1.Name = "btnNorma1";
            this.btnNorma1.Size = new System.Drawing.Size(90, 23);
            this.btnNorma1.TabIndex = 4;
            this.btnNorma1.TabStop = false;
            this.btnNorma1.Text = "Norma 1";
            this.btnNorma1.UseVisualStyleBackColor = true;
            this.btnNorma1.Click += new System.EventHandler(this.btnNorma1_Click);
            // 
            // btnNorma2
            // 
            this.btnNorma2.Location = new System.Drawing.Point(231, 20);
            this.btnNorma2.Name = "btnNorma2";
            this.btnNorma2.Size = new System.Drawing.Size(90, 23);
            this.btnNorma2.TabIndex = 5;
            this.btnNorma2.TabStop = false;
            this.btnNorma2.Text = "Norma 2";
            this.btnNorma2.UseVisualStyleBackColor = true;
            this.btnNorma2.Click += new System.EventHandler(this.btnNorma2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // btnMDD
            // 
            this.btnMDD.Location = new System.Drawing.Point(28, 205);
            this.btnMDD.Name = "btnMDD";
            this.btnMDD.Size = new System.Drawing.Size(242, 23);
            this.btnMDD.TabIndex = 7;
            this.btnMDD.Text = "Verificar Matriz Diagonalmente Dominante";
            this.btnMDD.UseVisualStyleBackColor = true;
            this.btnMDD.Click += new System.EventHandler(this.btnMDD_Click);
            // 
            // btnJacobi
            // 
            this.btnJacobi.Location = new System.Drawing.Point(10, 75);
            this.btnJacobi.Name = "btnJacobi";
            this.btnJacobi.Size = new System.Drawing.Size(133, 23);
            this.btnJacobi.TabIndex = 9;
            this.btnJacobi.Text = "Resolución por Jacobi";
            this.btnJacobi.UseVisualStyleBackColor = true;
            this.btnJacobi.Click += new System.EventHandler(this.btnJacobi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnGS);
            this.groupBox1.Controls.Add(this.btnJacobi);
            this.groupBox1.Location = new System.Drawing.Point(32, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métodos Numéricos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad de decimales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cota de error (precisión):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vector inicial:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnGS
            // 
            this.btnGS.Location = new System.Drawing.Point(176, 75);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(179, 23);
            this.btnGS.TabIndex = 10;
            this.btnGS.Text = "Resolución por Gauss Seidel";
            this.btnGS.UseVisualStyleBackColor = true;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnNorma2);
            this.groupBox2.Controls.Add(this.btnNorma1);
            this.groupBox2.Controls.Add(this.lblNorma);
            this.groupBox2.Controls.Add(this.btnNormaInf);
            this.groupBox2.Location = new System.Drawing.Point(32, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculo de normas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMDD);
            this.Controls.Add(this.txtbxEcuaciones);
            this.Name = "Form1";
            this.Text = "SIEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxEcuaciones;
        private System.Windows.Forms.Button btnNormaInf;
        private System.Windows.Forms.Label lblNorma;
        private System.Windows.Forms.Button btnNorma1;
        private System.Windows.Forms.Button btnNorma2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMDD;
        private System.Windows.Forms.Button btnJacobi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

