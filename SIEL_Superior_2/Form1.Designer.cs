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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbxEcuaciones = new System.Windows.Forms.TextBox();
            this.btnNormaInf = new System.Windows.Forms.Button();
            this.lblNorma = new System.Windows.Forms.Label();
            this.btnNorma1 = new System.Windows.Forms.Button();
            this.btnNorma2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMDD = new System.Windows.Forms.Button();
            this.btnJacobi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxoutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxcantdecimales = new System.Windows.Forms.TextBox();
            this.txtbxprecision = new System.Windows.Forms.TextBox();
            this.txtbxvinicial = new System.Windows.Forms.TextBox();
            this.btnGS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipvinicial = new System.Windows.Forms.ToolTip(this.components);
            this.tipPrecision = new System.Windows.Forms.ToolTip(this.components);
            this.btninfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxEcuaciones
            // 
            this.txtbxEcuaciones.Location = new System.Drawing.Point(28, 12);
            this.txtbxEcuaciones.Multiline = true;
            this.txtbxEcuaciones.Name = "txtbxEcuaciones";
            this.txtbxEcuaciones.Size = new System.Drawing.Size(602, 130);
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
            this.lblNorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorma.Location = new System.Drawing.Point(428, 19);
            this.lblNorma.Name = "lblNorma";
            this.lblNorma.Size = new System.Drawing.Size(57, 20);
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
            this.btnMDD.Location = new System.Drawing.Point(37, 204);
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
            this.groupBox1.Controls.Add(this.txtbxoutput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbxcantdecimales);
            this.groupBox1.Controls.Add(this.txtbxprecision);
            this.groupBox1.Controls.Add(this.txtbxvinicial);
            this.groupBox1.Controls.Add(this.btnGS);
            this.groupBox1.Controls.Add(this.btnJacobi);
            this.groupBox1.Location = new System.Drawing.Point(32, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 208);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métodos Numéricos";
            // 
            // txtbxoutput
            // 
            this.txtbxoutput.Location = new System.Drawing.Point(10, 105);
            this.txtbxoutput.Multiline = true;
            this.txtbxoutput.Name = "txtbxoutput";
            this.txtbxoutput.ReadOnly = true;
            this.txtbxoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxoutput.Size = new System.Drawing.Size(564, 97);
            this.txtbxoutput.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = ")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "(";
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
            this.tipPrecision.SetToolTip(this.label3, "CUIDADO: La coma decimal es \",\" y NO el punto \".\"\r\nPor ejemplo, una precisión vál" +
        "ida es 0,01 y NO 0.01");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vector inicial:";
            this.tipvinicial.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // txtbxcantdecimales
            // 
            this.txtbxcantdecimales.Location = new System.Drawing.Point(328, 39);
            this.txtbxcantdecimales.Name = "txtbxcantdecimales";
            this.txtbxcantdecimales.Size = new System.Drawing.Size(100, 20);
            this.txtbxcantdecimales.TabIndex = 13;
            // 
            // txtbxprecision
            // 
            this.txtbxprecision.Location = new System.Drawing.Point(173, 39);
            this.txtbxprecision.Name = "txtbxprecision";
            this.txtbxprecision.Size = new System.Drawing.Size(100, 20);
            this.txtbxprecision.TabIndex = 12;
            // 
            // txtbxvinicial
            // 
            this.txtbxvinicial.Location = new System.Drawing.Point(17, 39);
            this.txtbxvinicial.Name = "txtbxvinicial";
            this.txtbxvinicial.Size = new System.Drawing.Size(100, 20);
            this.txtbxvinicial.TabIndex = 11;
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
            this.groupBox2.Size = new System.Drawing.Size(598, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculo de normas:";
            // 
            // tipvinicial
            // 
            this.tipvinicial.AutomaticDelay = 1000000000;
            this.tipvinicial.AutoPopDelay = 50000000;
            this.tipvinicial.InitialDelay = 500;
            this.tipvinicial.ReshowDelay = 100;
            this.tipvinicial.ShowAlways = true;
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(522, 459);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(108, 23);
            this.btninfo.TabIndex = 12;
            this.btninfo.Text = "Acerca de SEIL";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 493);
            this.Controls.Add(this.btninfo);
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
        private System.Windows.Forms.TextBox txtbxvinicial;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxcantdecimales;
        private System.Windows.Forms.TextBox txtbxprecision;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip tipvinicial;
        private System.Windows.Forms.TextBox txtbxoutput;
        private System.Windows.Forms.ToolTip tipPrecision;
        private System.Windows.Forms.Button btninfo;
    }
}

