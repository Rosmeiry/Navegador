namespace Navegador
{
    partial class Form1
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
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackColor = System.Drawing.Color.Coral;
            this.btnAdelante.Image = global::Navegador.Properties.Resources.adelante;
            this.btnAdelante.Location = new System.Drawing.Point(53, 12);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(46, 37);
            this.btnAdelante.TabIndex = 1;
            this.btnAdelante.UseVisualStyleBackColor = false;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Coral;
            this.btnAtras.Image = global::Navegador.Properties.Resources.back___v1__1_;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(43, 37);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnR.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(105, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(59, 37);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnS.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(163, 12);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(59, 37);
            this.btnS.TabIndex = 3;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnH.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(221, 12);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(59, 37);
            this.btnH.TabIndex = 4;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(286, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 31);
            this.txtSearch.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(793, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(903, 441);
            this.webBrowser1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(927, 519);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Name = "Form1";
            this.Text = "Navegador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

