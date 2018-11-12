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
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.btnNormaInf = new System.Windows.Forms.Button();
            this.lblNorma = new System.Windows.Forms.Label();
            this.btnNorma1 = new System.Windows.Forms.Button();
            this.btnNorma2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMDD = new System.Windows.Forms.Button();
            this.lblMDD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(28, 26);
            this.txtbx1.Multiline = true;
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(401, 127);
            this.txtbx1.TabIndex = 0;
            // 
            // btnNormaInf
            // 
            this.btnNormaInf.Location = new System.Drawing.Point(458, 26);
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
            this.lblNorma.Location = new System.Drawing.Point(117, 164);
            this.lblNorma.Name = "lblNorma";
            this.lblNorma.Size = new System.Drawing.Size(66, 24);
            this.lblNorma.TabIndex = 2;
            this.lblNorma.Text = "label1";
            // 
            // btnNorma1
            // 
            this.btnNorma1.Location = new System.Drawing.Point(458, 70);
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
            this.btnNorma2.Location = new System.Drawing.Point(458, 116);
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
            this.label1.Location = new System.Drawing.Point(28, 166);
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
            // lblMDD
            // 
            this.lblMDD.AutoSize = true;
            this.lblMDD.Location = new System.Drawing.Point(326, 205);
            this.lblMDD.Name = "lblMDD";
            this.lblMDD.Size = new System.Drawing.Size(35, 13);
            this.lblMDD.TabIndex = 8;
            this.lblMDD.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 366);
            this.Controls.Add(this.lblMDD);
            this.Controls.Add(this.btnMDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNorma2);
            this.Controls.Add(this.btnNorma1);
            this.Controls.Add(this.lblNorma);
            this.Controls.Add(this.btnNormaInf);
            this.Controls.Add(this.txtbx1);
            this.Name = "Form1";
            this.Text = "SIEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.Button btnNormaInf;
        private System.Windows.Forms.Label lblNorma;
        private System.Windows.Forms.Button btnNorma1;
        private System.Windows.Forms.Button btnNorma2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMDD;
        private System.Windows.Forms.Label lblMDD;
    }
}

