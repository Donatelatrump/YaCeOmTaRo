namespace YaCeOmTaRo
{
    partial class OtraFormaCaracterizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtraFormaCaracterizar));
            this.BTMostrar = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTCrear = new System.Windows.Forms.Button();
            this.Tamaño = new System.Windows.Forms.ComboBox();
            this.LBMA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RTBMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTMostrar
            // 
            this.BTMostrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BTMostrar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMostrar.ForeColor = System.Drawing.Color.Ivory;
            this.BTMostrar.Location = new System.Drawing.Point(558, 248);
            this.BTMostrar.Name = "BTMostrar";
            this.BTMostrar.Size = new System.Drawing.Size(123, 36);
            this.BTMostrar.TabIndex = 21;
            this.BTMostrar.Text = "Mostrar";
            this.BTMostrar.UseVisualStyleBackColor = false;
            this.BTMostrar.Click += new System.EventHandler(this.BTMostrar_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BTGuardar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardar.ForeColor = System.Drawing.Color.Ivory;
            this.BTGuardar.Location = new System.Drawing.Point(558, 198);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(123, 36);
            this.BTGuardar.TabIndex = 20;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = false;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTCrear
            // 
            this.BTCrear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BTCrear.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCrear.ForeColor = System.Drawing.Color.Ivory;
            this.BTCrear.Location = new System.Drawing.Point(451, 64);
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.Size = new System.Drawing.Size(91, 38);
            this.BTCrear.TabIndex = 19;
            this.BTCrear.Text = "Crear";
            this.BTCrear.UseVisualStyleBackColor = false;
            this.BTCrear.Click += new System.EventHandler(this.BTCrear_Click);
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
            this.Tamaño.Location = new System.Drawing.Point(277, 70);
            this.Tamaño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(104, 27);
            this.Tamaño.TabIndex = 18;
            // 
            // LBMA
            // 
            this.LBMA.AutoSize = true;
            this.LBMA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMA.Location = new System.Drawing.Point(93, 112);
            this.LBMA.Name = "LBMA";
            this.LBMA.Size = new System.Drawing.Size(187, 19);
            this.LBMA.TabIndex = 17;
            this.LBMA.Text = "Matriz de adyacencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(238, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Guardar en un archivo txt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tamaño de la matriz:";
            // 
            // RTBMostrar
            // 
            this.RTBMostrar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBMostrar.Location = new System.Drawing.Point(123, 302);
            this.RTBMostrar.Name = "RTBMostrar";
            this.RTBMostrar.Size = new System.Drawing.Size(323, 145);
            this.RTBMostrar.TabIndex = 22;
            this.RTBMostrar.Text = "";
            // 
            // OtraFormaCaracterizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTBMostrar);
            this.Controls.Add(this.BTMostrar);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.BTCrear);
            this.Controls.Add(this.Tamaño);
            this.Controls.Add(this.LBMA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "OtraFormaCaracterizar";
            this.Text = "OtraFormaCaracterizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTMostrar;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTCrear;
        private System.Windows.Forms.ComboBox Tamaño;
        private System.Windows.Forms.Label LBMA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RTBMostrar;
    }
}