namespace YaCeOmTaRo
{
    partial class CompConexas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompConexas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNodos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAristas = new System.Windows.Forms.TextBox();
            this.RTBImprimir = new System.Windows.Forms.RichTextBox();
            this.BTCrear = new System.Windows.Forms.Button();
            this.BTMOrdena1 = new System.Windows.Forms.Button();
            this.BTMaCamino = new System.Windows.Forms.Button();
            this.BTOrdenaF = new System.Windows.Forms.Button();
            this.BTComponentes = new System.Windows.Forms.Button();
            this.TBComponentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.TBConexion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBCNodo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(201, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular todas las componentes conexas de un grafo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(98, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Nodos:";
            // 
            // TBNodos
            // 
            this.TBNodos.Location = new System.Drawing.Point(155, 46);
            this.TBNodos.Name = "TBNodos";
            this.TBNodos.Size = new System.Drawing.Size(100, 20);
            this.TBNodos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(275, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de Aristas:";
            // 
            // TBAristas
            // 
            this.TBAristas.Location = new System.Drawing.Point(387, 46);
            this.TBAristas.Name = "TBAristas";
            this.TBAristas.Size = new System.Drawing.Size(100, 20);
            this.TBAristas.TabIndex = 4;
            // 
            // RTBImprimir
            // 
            this.RTBImprimir.Location = new System.Drawing.Point(221, 144);
            this.RTBImprimir.Name = "RTBImprimir";
            this.RTBImprimir.Size = new System.Drawing.Size(339, 248);
            this.RTBImprimir.TabIndex = 6;
            this.RTBImprimir.Text = "";
            // 
            // BTCrear
            // 
            this.BTCrear.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTCrear.FlatAppearance.BorderSize = 3;
            this.BTCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCrear.Location = new System.Drawing.Point(511, 38);
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.Size = new System.Drawing.Size(75, 34);
            this.BTCrear.TabIndex = 7;
            this.BTCrear.Text = "Crear";
            this.BTCrear.UseVisualStyleBackColor = true;
            this.BTCrear.Click += new System.EventHandler(this.BTCrear_Click);
            // 
            // BTMOrdena1
            // 
            this.BTMOrdena1.BackColor = System.Drawing.Color.White;
            this.BTMOrdena1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTMOrdena1.FlatAppearance.BorderSize = 3;
            this.BTMOrdena1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMOrdena1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMOrdena1.Location = new System.Drawing.Point(45, 214);
            this.BTMOrdena1.Name = "BTMOrdena1";
            this.BTMOrdena1.Size = new System.Drawing.Size(135, 64);
            this.BTMOrdena1.TabIndex = 8;
            this.BTMOrdena1.Text = "Matriz ordenada en base a cantidad de 1\'s";
            this.BTMOrdena1.UseVisualStyleBackColor = false;
            this.BTMOrdena1.Click += new System.EventHandler(this.BTMOrdena1_Click);
            // 
            // BTMaCamino
            // 
            this.BTMaCamino.BackColor = System.Drawing.Color.White;
            this.BTMaCamino.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTMaCamino.FlatAppearance.BorderSize = 3;
            this.BTMaCamino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMaCamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMaCamino.Location = new System.Drawing.Point(45, 135);
            this.BTMaCamino.Name = "BTMaCamino";
            this.BTMaCamino.Size = new System.Drawing.Size(135, 64);
            this.BTMaCamino.TabIndex = 9;
            this.BTMaCamino.Text = "Matriz de caminos";
            this.BTMaCamino.UseVisualStyleBackColor = false;
            this.BTMaCamino.Click += new System.EventHandler(this.BTMaCamino_Click);
            // 
            // BTOrdenaF
            // 
            this.BTOrdenaF.BackColor = System.Drawing.Color.White;
            this.BTOrdenaF.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTOrdenaF.FlatAppearance.BorderSize = 3;
            this.BTOrdenaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOrdenaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTOrdenaF.Location = new System.Drawing.Point(45, 292);
            this.BTOrdenaF.Name = "BTOrdenaF";
            this.BTOrdenaF.Size = new System.Drawing.Size(135, 64);
            this.BTOrdenaF.TabIndex = 10;
            this.BTOrdenaF.Text = "Ordenar las columnas segun el orden de las filas";
            this.BTOrdenaF.UseVisualStyleBackColor = false;
            this.BTOrdenaF.Click += new System.EventHandler(this.BTOrdenaF_Click);
            // 
            // BTComponentes
            // 
            this.BTComponentes.BackColor = System.Drawing.Color.White;
            this.BTComponentes.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTComponentes.FlatAppearance.BorderSize = 3;
            this.BTComponentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTComponentes.Location = new System.Drawing.Point(45, 380);
            this.BTComponentes.Name = "BTComponentes";
            this.BTComponentes.Size = new System.Drawing.Size(135, 64);
            this.BTComponentes.TabIndex = 11;
            this.BTComponentes.Text = "Componentes Conexas";
            this.BTComponentes.UseVisualStyleBackColor = false;
            this.BTComponentes.Click += new System.EventHandler(this.BTComponentes_Click);
            // 
            // TBComponentes
            // 
            this.TBComponentes.Location = new System.Drawing.Point(586, 144);
            this.TBComponentes.Multiline = true;
            this.TBComponentes.Name = "TBComponentes";
            this.TBComponentes.Size = new System.Drawing.Size(281, 243);
            this.TBComponentes.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Componentes Conexas:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.White;
            this.BTAgregar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BTAgregar.FlatAppearance.BorderSize = 3;
            this.BTAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(456, 96);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(79, 42);
            this.BTAgregar.TabIndex = 35;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // TBConexion
            // 
            this.TBConexion.Location = new System.Drawing.Point(350, 84);
            this.TBConexion.Name = "TBConexion";
            this.TBConexion.Size = new System.Drawing.Size(100, 20);
            this.TBConexion.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(217, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Conexión con: ";
            // 
            // TBCNodo
            // 
            this.TBCNodo.Location = new System.Drawing.Point(62, 84);
            this.TBCNodo.Name = "TBCNodo";
            this.TBCNodo.Size = new System.Drawing.Size(100, 20);
            this.TBCNodo.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(0, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nodo:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::YaCeOmTaRo.Properties.Resources._85b7a900_b8f0_11eb_92ca_f9a8d80447b81;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 94;
            this.iconPictureBox1.Location = new System.Drawing.Point(657, 21);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(153, 94);
            this.iconPictureBox1.TabIndex = 36;
            this.iconPictureBox1.TabStop = false;
            // 
            // CompConexas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YaCeOmTaRo.Properties.Resources._65203;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 461);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.TBConexion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TBCNodo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBComponentes);
            this.Controls.Add(this.BTComponentes);
            this.Controls.Add(this.BTOrdenaF);
            this.Controls.Add(this.BTMaCamino);
            this.Controls.Add(this.BTMOrdena1);
            this.Controls.Add(this.BTCrear);
            this.Controls.Add(this.RTBImprimir);
            this.Controls.Add(this.TBAristas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompConexas";
            this.Text = "Componentes Conexas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompConexas_FormClosed);
            this.Load += new System.EventHandler(this.CompConexas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAristas;
        private System.Windows.Forms.RichTextBox RTBImprimir;
        private System.Windows.Forms.Button BTCrear;
        private System.Windows.Forms.Button BTMOrdena1;
        private System.Windows.Forms.Button BTMaCamino;
        private System.Windows.Forms.Button BTOrdenaF;
        private System.Windows.Forms.Button BTComponentes;
        private System.Windows.Forms.TextBox TBComponentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.TextBox TBConexion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBCNodo;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}