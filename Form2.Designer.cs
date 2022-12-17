namespace ERP
{
    partial class Form2
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
            this.lblCodcliCarro = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblMarcaCarro = new System.Windows.Forms.Label();
            this.txtCodClie2 = new System.Windows.Forms.TextBox();
            this.txtPlacaCarro = new System.Windows.Forms.TextBox();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodcliCarro
            // 
            this.lblCodcliCarro.AutoSize = true;
            this.lblCodcliCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodcliCarro.Location = new System.Drawing.Point(17, 18);
            this.lblCodcliCarro.Name = "lblCodcliCarro";
            this.lblCodcliCarro.Size = new System.Drawing.Size(109, 16);
            this.lblCodcliCarro.TabIndex = 0;
            this.lblCodcliCarro.Text = "Código Cliente";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(17, 48);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(80, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa do Carro:";
            // 
            // lblMarcaCarro
            // 
            this.lblMarcaCarro.AutoSize = true;
            this.lblMarcaCarro.Location = new System.Drawing.Point(17, 89);
            this.lblMarcaCarro.Name = "lblMarcaCarro";
            this.lblMarcaCarro.Size = new System.Drawing.Size(68, 13);
            this.lblMarcaCarro.TabIndex = 0;
            this.lblMarcaCarro.Text = "Marca Carro:";
            // 
            // txtCodClie2
            // 
            this.txtCodClie2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCodClie2.Location = new System.Drawing.Point(132, 14);
            this.txtCodClie2.Name = "txtCodClie2";
            this.txtCodClie2.Size = new System.Drawing.Size(100, 20);
            this.txtCodClie2.TabIndex = 1;
            // 
            // txtPlacaCarro
            // 
            this.txtPlacaCarro.Location = new System.Drawing.Point(132, 48);
            this.txtPlacaCarro.Name = "txtPlacaCarro";
            this.txtPlacaCarro.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaCarro.TabIndex = 1;
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(132, 82);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaCarro.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 25);
            this.button4.TabIndex = 2;
            this.button4.Text = "Read";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMarcaCarro);
            this.Controls.Add(this.txtPlacaCarro);
            this.Controls.Add(this.txtCodClie2);
            this.Controls.Add(this.lblMarcaCarro);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCodcliCarro);
            this.Name = "Form2";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodcliCarro;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblMarcaCarro;
        private System.Windows.Forms.TextBox txtCodClie2;
        private System.Windows.Forms.TextBox txtPlacaCarro;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}