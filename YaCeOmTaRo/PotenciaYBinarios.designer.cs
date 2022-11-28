using System.Windows.Forms;

namespace YaCeOmTaRo
{
    partial class ConjuntoPotenciaBinario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.richConjunto = new System.Windows.Forms.RichTextBox();
            this.richBinarios = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(215, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correspondencia de Conjunto Potencia y Tabla Binaria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indica el número de elementos del conjunto:";
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamaño.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbTamaño.Location = new System.Drawing.Point(545, 66);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(41, 27);
            this.cmbTamaño.TabIndex = 2;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnEjecutar.FlatAppearance.BorderSize = 3;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEjecutar.Location = new System.Drawing.Point(598, 126);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(154, 153);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Agregar valores al conjunto";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.Location = new System.Drawing.Point(182, 117);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(180, 14);
            this.lblElemento.TabIndex = 4;
            this.lblElemento.Text = "Ingresa el valor del elemento 1:";
            this.lblElemento.Visible = false;
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtElemento.Location = new System.Drawing.Point(467, 117);
            this.txtElemento.MaxLength = 1;
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(86, 27);
            this.txtElemento.TabIndex = 5;
            this.txtElemento.Visible = false;
            this.txtElemento.TextChanged += new System.EventHandler(this.txtElemento_TextChanged);
            this.txtElemento.Enter += new System.EventHandler(this.txtElemento_Enter);
            this.txtElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtElemento_KeyDown);
            // 
            // richConjunto
            // 
            this.richConjunto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.richConjunto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richConjunto.Location = new System.Drawing.Point(109, 161);
            this.richConjunto.Name = "richConjunto";
            this.richConjunto.ReadOnly = true;
            this.richConjunto.Size = new System.Drawing.Size(221, 272);
            this.richConjunto.TabIndex = 6;
            this.richConjunto.Text = "";
            // 
            // richBinarios
            // 
            this.richBinarios.Font = new System.Drawing.Font("Tahoma", 12F);
            this.richBinarios.Location = new System.Drawing.Point(347, 161);
            this.richBinarios.Name = "richBinarios";
            this.richBinarios.ReadOnly = true;
            this.richBinarios.Size = new System.Drawing.Size(221, 272);
            this.richBinarios.TabIndex = 7;
            this.richBinarios.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YaCeOmTaRo.Properties.Resources.au_os_blue_shape_2x;
            this.pictureBox1.Location = new System.Drawing.Point(371, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(173, 16);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 29);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YaCeOmTaRo.Properties.Resources.au_os_blue_shape_2x;
            this.pictureBox2.Location = new System.Drawing.Point(-175, -81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 333);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ConjuntoPotenciaBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 455);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.richBinarios);
            this.Controls.Add(this.richConjunto);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConjuntoPotenciaBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correspondencia de Conjunto Potencia y Tabla Binaria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConjuntoPotenciaBinario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTamaño;
        private Button btnEjecutar;
        private Label lblElemento;
        private TextBox txtElemento;
        private RichTextBox richConjunto;
        private RichTextBox richBinarios;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}