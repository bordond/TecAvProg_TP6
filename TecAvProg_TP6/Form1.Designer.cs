
namespace TecAvProg_TP6
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
            this.lblPara = new System.Windows.Forms.Label();
            this.lblCc = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(36, 71);
            this.lblPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(42, 20);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para";
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.Location = new System.Drawing.Point(603, 72);
            this.lblCc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(28, 20);
            this.lblCc.TabIndex = 1;
            this.lblCc.Text = "Cc";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(36, 136);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(60, 20);
            this.lblAsunto.TabIndex = 2;
            this.lblAsunto.Text = "Asunto";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(106, 72);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(464, 26);
            this.txtPara.TabIndex = 3;
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(639, 71);
            this.txtCc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(464, 26);
            this.txtCc.TabIndex = 4;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(106, 136);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(997, 26);
            this.txtAsunto.TabIndex = 5;
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(106, 197);
            this.txtCuerpo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(997, 239);
            this.txtCuerpo.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(979, 490);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(136, 48);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cuerpo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblCc);
            this.Controls.Add(this.lblPara);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Enviar email desde una cuenta de Gmail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
    }
}

