namespace WindowsFormsApplication1
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.valor1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.lblresu = new System.Windows.Forms.Label();
            this.lblvalor1 = new System.Windows.Forms.TextBox();
            this.lblvalor2 = new System.Windows.Forms.TextBox();
            this.btsoma = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.ForeColor = System.Drawing.Color.White;
            this.valor1.Location = new System.Drawing.Point(25, 21);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(59, 20);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "Valor 1";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.ForeColor = System.Drawing.Color.White;
            this.valor2.Location = new System.Drawing.Point(25, 51);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(59, 20);
            this.valor2.TabIndex = 1;
            this.valor2.Text = "Valor 2";
            // 
            // lblresu
            // 
            this.lblresu.AutoSize = true;
            this.lblresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresu.ForeColor = System.Drawing.Color.Red;
            this.lblresu.Location = new System.Drawing.Point(205, 92);
            this.lblresu.Name = "lblresu";
            this.lblresu.Size = new System.Drawing.Size(36, 37);
            this.lblresu.TabIndex = 2;
            this.lblresu.Text = "0";
            this.lblresu.Click += new System.EventHandler(this.lblresu_Click);
            // 
            // lblvalor1
            // 
            this.lblvalor1.Location = new System.Drawing.Point(104, 24);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(65, 20);
            this.lblvalor1.TabIndex = 3;
            this.lblvalor1.TextChanged += new System.EventHandler(this.lblvalor1_TextChanged);
            // 
            // lblvalor2
            // 
            this.lblvalor2.Location = new System.Drawing.Point(104, 54);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(65, 20);
            this.lblvalor2.TabIndex = 4;
            this.lblvalor2.TextChanged += new System.EventHandler(this.lblvalor2_TextChanged);
            // 
            // btsoma
            // 
            this.btsoma.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.somar;
            this.btsoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsoma.Location = new System.Drawing.Point(19, 107);
            this.btsoma.Name = "btsoma";
            this.btsoma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btsoma.Size = new System.Drawing.Size(55, 52);
            this.btsoma.TabIndex = 12;
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.btsoma_Click_1);
            // 
            // btdiv
            // 
            this.btdiv.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.div;
            this.btdiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btdiv.Location = new System.Drawing.Point(104, 159);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(56, 52);
            this.btdiv.TabIndex = 11;
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click_1);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btsair.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sair;
            this.btsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.Black;
            this.btsair.Location = new System.Drawing.Point(231, 177);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(42, 34);
            this.btsair.TabIndex = 10;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btlimpar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.limpar;
            this.btlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.ForeColor = System.Drawing.Color.Black;
            this.btlimpar.Location = new System.Drawing.Point(183, 177);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(42, 34);
            this.btlimpar.TabIndex = 9;
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btmult
            // 
            this.btmult.BackColor = System.Drawing.Color.Transparent;
            this.btmult.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.multi;
            this.btmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.ForeColor = System.Drawing.Color.Black;
            this.btmult.Location = new System.Drawing.Point(104, 107);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(55, 52);
            this.btmult.TabIndex = 7;
            this.btmult.UseVisualStyleBackColor = false;
            this.btmult.Click += new System.EventHandler(this.btmult_Click);
            // 
            // btsub
            // 
            this.btsub.BackColor = System.Drawing.Color.Transparent;
            this.btsub.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sub;
            this.btsub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsub.ForeColor = System.Drawing.Color.Transparent;
            this.btsub.Location = new System.Drawing.Point(19, 159);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(55, 52);
            this.btsub.TabIndex = 6;
            this.btsub.UseMnemonic = false;
            this.btsub.UseVisualStyleBackColor = false;
            this.btsub.Click += new System.EventHandler(this.btsub_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.calc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 229);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.lblvalor2);
            this.Controls.Add(this.lblvalor1);
            this.Controls.Add(this.lblresu);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label valor2;
        private System.Windows.Forms.Label lblresu;
        private System.Windows.Forms.TextBox lblvalor1;
        private System.Windows.Forms.TextBox lblvalor2;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btsoma;
    }
}

