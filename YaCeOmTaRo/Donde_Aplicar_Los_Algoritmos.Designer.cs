namespace YaCeOmTaRo
{
    partial class Donde_Aplicar_Los_Algoritmos
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
            this.CB_Problemas = new System.Windows.Forms.ComboBox();
            this.TB_Espacio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Problemas
            // 
            this.CB_Problemas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Problemas.FormattingEnabled = true;
            this.CB_Problemas.Items.AddRange(new object[] {
            "",
            "Algoritmo que genera todas las Permutaciones ",
            "Algoritmo que genera todas las Combinaciones",
            "Algoritmo que genera todas las Cadenas Binarias"});
            this.CB_Problemas.Location = new System.Drawing.Point(140, 74);
            this.CB_Problemas.Name = "CB_Problemas";
            this.CB_Problemas.Size = new System.Drawing.Size(295, 26);
            this.CB_Problemas.TabIndex = 0;
            this.CB_Problemas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TB_Espacio
            // 
            this.TB_Espacio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Espacio.Location = new System.Drawing.Point(140, 131);
            this.TB_Espacio.Multiline = true;
            this.TB_Espacio.Name = "TB_Espacio";
            this.TB_Espacio.Size = new System.Drawing.Size(295, 167);
            this.TB_Espacio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(137, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicaciones en la vida real";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YaCeOmTaRo.Properties.Resources._44_447042_blue_shapes_png_transparent_png1;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(93, 20);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PenFancy;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 31;
            this.iconPictureBox2.Location = new System.Drawing.Point(464, 20);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(33, 31);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // Donde_Aplicar_Los_Algoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Espacio);
            this.Controls.Add(this.CB_Problemas);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Donde_Aplicar_Los_Algoritmos";
            this.Text = "Donde_Aplicar_Los_Algoritmos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Problemas;
        private System.Windows.Forms.TextBox TB_Espacio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}