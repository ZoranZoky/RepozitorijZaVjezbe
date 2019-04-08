namespace Vjezba4zornovose
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
            this.txtPocetnoStanje = new System.Windows.Forms.TextBox();
            this.txtBrojRodenih = new System.Windows.Forms.TextBox();
            this.txtBrojPreminulih = new System.Windows.Forms.TextBox();
            this.txtBrojIseljenih = new System.Windows.Forms.TextBox();
            this.txtUseljenih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputLista = new System.Windows.Forms.ListBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPocetnoStanje
            // 
            this.txtPocetnoStanje.Location = new System.Drawing.Point(194, 47);
            this.txtPocetnoStanje.Name = "txtPocetnoStanje";
            this.txtPocetnoStanje.Size = new System.Drawing.Size(100, 20);
            this.txtPocetnoStanje.TabIndex = 0;
            this.txtPocetnoStanje.TextChanged += new System.EventHandler(this.txtPocetnoStanje_TextChanged);
            // 
            // txtBrojRodenih
            // 
            this.txtBrojRodenih.Location = new System.Drawing.Point(194, 99);
            this.txtBrojRodenih.Name = "txtBrojRodenih";
            this.txtBrojRodenih.Size = new System.Drawing.Size(100, 20);
            this.txtBrojRodenih.TabIndex = 1;
            // 
            // txtBrojPreminulih
            // 
            this.txtBrojPreminulih.Location = new System.Drawing.Point(194, 164);
            this.txtBrojPreminulih.Name = "txtBrojPreminulih";
            this.txtBrojPreminulih.Size = new System.Drawing.Size(100, 20);
            this.txtBrojPreminulih.TabIndex = 2;
            // 
            // txtBrojIseljenih
            // 
            this.txtBrojIseljenih.Location = new System.Drawing.Point(194, 219);
            this.txtBrojIseljenih.Name = "txtBrojIseljenih";
            this.txtBrojIseljenih.Size = new System.Drawing.Size(100, 20);
            this.txtBrojIseljenih.TabIndex = 3;
            // 
            // txtUseljenih
            // 
            this.txtUseljenih.Location = new System.Drawing.Point(194, 278);
            this.txtUseljenih.Name = "txtUseljenih";
            this.txtUseljenih.Size = new System.Drawing.Size(100, 20);
            this.txtUseljenih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Početno stanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj rođenih (mjesečno)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj preminulih (mjesečno)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj iseljenih (tjedno)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj useljenih (tjedno)";
            // 
            // outputLista
            // 
            this.outputLista.FormattingEnabled = true;
            this.outputLista.Location = new System.Drawing.Point(447, 47);
            this.outputLista.Name = "outputLista";
            this.outputLista.Size = new System.Drawing.Size(293, 368);
            this.outputLista.TabIndex = 10;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(142, 365);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 11;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.outputLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUseljenih);
            this.Controls.Add(this.txtBrojIseljenih);
            this.Controls.Add(this.txtBrojPreminulih);
            this.Controls.Add(this.txtBrojRodenih);
            this.Controls.Add(this.txtPocetnoStanje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPocetnoStanje;
        private System.Windows.Forms.TextBox txtBrojRodenih;
        private System.Windows.Forms.TextBox txtBrojPreminulih;
        private System.Windows.Forms.TextBox txtBrojIseljenih;
        private System.Windows.Forms.TextBox txtUseljenih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox outputLista;
        private System.Windows.Forms.Button btnIzracunaj;
    }
}

