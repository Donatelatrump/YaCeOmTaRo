namespace YaCeOmTaRo
{
    partial class PareoMaximo_GNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PareoMaximo_GNormal));
            this.MostrarPareo = new System.Windows.Forms.RichTextBox();
            this.BTPareo = new System.Windows.Forms.Button();
            this.Pareo = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.IngresarA = new System.Windows.Forms.Button();
            this.Tamaño = new System.Windows.Forms.ComboBox();
            this.LBMA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarPareo
            // 
            this.MostrarPareo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarPareo.ForeColor = System.Drawing.Color.Teal;
            this.MostrarPareo.Location = new System.Drawing.Point(169, 432);
            this.MostrarPareo.Name = "MostrarPareo";
            this.MostrarPareo.Size = new System.Drawing.Size(216, 115);
            this.MostrarPareo.TabIndex = 19;
            this.MostrarPareo.Text = "";
            // 
            // BTPareo
            // 
            this.BTPareo.BackColor = System.Drawing.Color.SandyBrown;
            this.BTPareo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPareo.ForeColor = System.Drawing.Color.Bisque;
            this.BTPareo.Location = new System.Drawing.Point(616, 215);
            this.BTPareo.Name = "BTPareo";
            this.BTPareo.Size = new System.Drawing.Size(113, 61);
            this.BTPareo.TabIndex = 18;
            this.BTPareo.Text = "Hacer pareo";
            this.BTPareo.UseVisualStyleBackColor = false;
            this.BTPareo.Click += new System.EventHandler(this.BTPareo_Click);
            // 
            // Pareo
            // 
            this.Pareo.AutoSize = true;
            this.Pareo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pareo.Location = new System.Drawing.Point(84, 434);
            this.Pareo.Name = "Pareo";
            this.Pareo.Size = new System.Drawing.Size(68, 19);
            this.Pareo.TabIndex = 17;
            this.Pareo.Text = "Pareo: ";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.SandyBrown;
            this.Guardar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.Color.Bisque;
            this.Guardar.Location = new System.Drawing.Point(616, 173);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(123, 36);
            this.Guardar.TabIndex = 16;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // IngresarA
            // 
            this.IngresarA.BackColor = System.Drawing.Color.SandyBrown;
            this.IngresarA.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarA.ForeColor = System.Drawing.Color.Bisque;
            this.IngresarA.Location = new System.Drawing.Point(522, 62);
            this.IngresarA.Name = "IngresarA";
            this.IngresarA.Size = new System.Drawing.Size(91, 38);
            this.IngresarA.TabIndex = 15;
            this.IngresarA.Text = "Crear";
            this.IngresarA.UseVisualStyleBackColor = false;
            this.IngresarA.Click += new System.EventHandler(this.IngresarA_Click);
            // 
            // Tamaño
            // 
            this.Tamaño.BackColor = System.Drawing.Color.White;
            this.Tamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tamaño.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Tamaño.FormattingEnabled = true;
            this.Tamaño.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Tamaño.Location = new System.Drawing.Point(281, 61);
            this.Tamaño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(104, 27);
            this.Tamaño.TabIndex = 14;
            // 
            // LBMA
            // 
            this.LBMA.AutoSize = true;
            this.LBMA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMA.Location = new System.Drawing.Point(115, 105);
            this.LBMA.Name = "LBMA";
            this.LBMA.Size = new System.Drawing.Size(187, 19);
            this.LBMA.TabIndex = 13;
            this.LBMA.Text = "Matriz de adyacencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pareo Máximo de un Grafo Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tamaño de la matriz:";
            // 
            // PareoMaximo_GNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.MostrarPareo);
            this.Controls.Add(this.BTPareo);
            this.Controls.Add(this.Pareo);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.IngresarA);
            this.Controls.Add(this.Tamaño);
            this.Controls.Add(this.LBMA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PareoMaximo_GNormal";
            this.Text = "PareoMaximo_GNormal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MostrarPareo;
        private System.Windows.Forms.Button BTPareo;
        private System.Windows.Forms.Label Pareo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button IngresarA;
        private System.Windows.Forms.ComboBox Tamaño;
        private System.Windows.Forms.Label LBMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}