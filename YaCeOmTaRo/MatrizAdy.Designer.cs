namespace YaCeOmTaRo
{
    partial class MatrizAdy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrizAdy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBNoDirigido = new System.Windows.Forms.RadioButton();
            this.RBDirigido = new System.Windows.Forms.RadioButton();
            this.BTCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNodos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTBMostrar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCNodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBConexion = new System.Windows.Forms.TextBox();
            this.BTAddArist = new System.Windows.Forms.Button();
            this.BTReiniciar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBAristas = new System.Windows.Forms.TextBox();
            this.CBMA = new System.Windows.Forms.CheckBox();
            this.CBLA = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RBNoDirigido);
            this.groupBox1.Controls.Add(this.RBDirigido);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de grafo";
            // 
            // RBNoDirigido
            // 
            this.RBNoDirigido.AutoSize = true;
            this.RBNoDirigido.Location = new System.Drawing.Point(7, 44);
            this.RBNoDirigido.Name = "RBNoDirigido";
            this.RBNoDirigido.Size = new System.Drawing.Size(75, 17);
            this.RBNoDirigido.TabIndex = 1;
            this.RBNoDirigido.TabStop = true;
            this.RBNoDirigido.Text = "No dirigido";
            this.RBNoDirigido.UseVisualStyleBackColor = true;
            this.RBNoDirigido.CheckedChanged += new System.EventHandler(this.RBNoDirigido_CheckedChanged);
            // 
            // RBDirigido
            // 
            this.RBDirigido.AutoSize = true;
            this.RBDirigido.Location = new System.Drawing.Point(7, 20);
            this.RBDirigido.Name = "RBDirigido";
            this.RBDirigido.Size = new System.Drawing.Size(60, 17);
            this.RBDirigido.TabIndex = 0;
            this.RBDirigido.TabStop = true;
            this.RBDirigido.Text = "Dirigido";
            this.RBDirigido.UseVisualStyleBackColor = true;
            this.RBDirigido.CheckedChanged += new System.EventHandler(this.RBDirigido_CheckedChanged);
            // 
            // BTCrear
            // 
            this.BTCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTCrear.FlatAppearance.BorderSize = 3;
            this.BTCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCrear.Location = new System.Drawing.Point(12, 339);
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.Size = new System.Drawing.Size(90, 40);
            this.BTCrear.TabIndex = 6;
            this.BTCrear.Text = "Crear";
            this.BTCrear.UseVisualStyleBackColor = true;
            this.BTCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de nodos: ";
            // 
            // TBNodos
            // 
            this.TBNodos.Location = new System.Drawing.Point(123, 42);
            this.TBNodos.Name = "TBNodos";
            this.TBNodos.Size = new System.Drawing.Size(39, 20);
            this.TBNodos.TabIndex = 3;
            this.TBNodos.TextChanged += new System.EventHandler(this.TBNodos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(214, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mostrando matriz de adyacencia ";
            // 
            // RTBMostrar
            // 
            this.RTBMostrar.Location = new System.Drawing.Point(193, 74);
            this.RTBMostrar.Name = "RTBMostrar";
            this.RTBMostrar.Size = new System.Drawing.Size(306, 314);
            this.RTBMostrar.TabIndex = 5;
            this.RTBMostrar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nodo: ";
            // 
            // TBCNodo
            // 
            this.TBCNodo.Location = new System.Drawing.Point(63, 191);
            this.TBCNodo.Name = "TBCNodo";
            this.TBCNodo.Size = new System.Drawing.Size(32, 20);
            this.TBCNodo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(22, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "conecta con: ";
            // 
            // TBConexion
            // 
            this.TBConexion.Location = new System.Drawing.Point(101, 224);
            this.TBConexion.Name = "TBConexion";
            this.TBConexion.Size = new System.Drawing.Size(32, 20);
            this.TBConexion.TabIndex = 10;
            // 
            // BTAddArist
            // 
            this.BTAddArist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTAddArist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTAddArist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTAddArist.FlatAppearance.BorderSize = 3;
            this.BTAddArist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAddArist.Location = new System.Drawing.Point(12, 265);
            this.BTAddArist.Name = "BTAddArist";
            this.BTAddArist.Size = new System.Drawing.Size(86, 45);
            this.BTAddArist.TabIndex = 11;
            this.BTAddArist.Text = "Agregar arista";
            this.BTAddArist.UseVisualStyleBackColor = false;
            this.BTAddArist.Click += new System.EventHandler(this.BTAddArist_Click);
            // 
            // BTReiniciar
            // 
            this.BTReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTReiniciar.FlatAppearance.BorderSize = 3;
            this.BTReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTReiniciar.Location = new System.Drawing.Point(443, 394);
            this.BTReiniciar.Name = "BTReiniciar";
            this.BTReiniciar.Size = new System.Drawing.Size(88, 44);
            this.BTReiniciar.TabIndex = 12;
            this.BTReiniciar.Text = "Reiniciar ";
            this.BTReiniciar.UseVisualStyleBackColor = true;
            this.BTReiniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(383, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(22, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad de aristas:";
            // 
            // TBAristas
            // 
            this.TBAristas.Location = new System.Drawing.Point(123, 69);
            this.TBAristas.Name = "TBAristas";
            this.TBAristas.Size = new System.Drawing.Size(39, 20);
            this.TBAristas.TabIndex = 15;
            // 
            // CBMA
            // 
            this.CBMA.AutoSize = true;
            this.CBMA.BackColor = System.Drawing.Color.Transparent;
            this.CBMA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBMA.Location = new System.Drawing.Point(24, 11);
            this.CBMA.Name = "CBMA";
            this.CBMA.Size = new System.Drawing.Size(192, 17);
            this.CBMA.TabIndex = 16;
            this.CBMA.Text = "Capturar una Matriz de Adyacencia";
            this.CBMA.UseVisualStyleBackColor = false;
            this.CBMA.CheckedChanged += new System.EventHandler(this.CBMA_CheckedChanged);
            // 
            // CBLA
            // 
            this.CBLA.AutoSize = true;
            this.CBLA.BackColor = System.Drawing.Color.Transparent;
            this.CBLA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBLA.Location = new System.Drawing.Point(208, 11);
            this.CBLA.Name = "CBLA";
            this.CBLA.Size = new System.Drawing.Size(189, 17);
            this.CBLA.TabIndex = 17;
            this.CBLA.Text = "Capturar una Lista de Adyacencia ";
            this.CBLA.UseVisualStyleBackColor = false;
            this.CBLA.CheckedChanged += new System.EventHandler(this.CBLA_CheckedChanged);
            // 
            // MatrizAdy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YaCeOmTaRo.Properties.Resources._65206;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.CBLA);
            this.Controls.Add(this.CBMA);
            this.Controls.Add(this.BTCrear);
            this.Controls.Add(this.TBAristas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTReiniciar);
            this.Controls.Add(this.BTAddArist);
            this.Controls.Add(this.TBConexion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBCNodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RTBMostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatrizAdy";
            this.Text = "Guardar grafo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatrizAdy_FormClosed);
            this.Load += new System.EventHandler(this.MatrizAdy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBNoDirigido;
        private System.Windows.Forms.RadioButton RBDirigido;
        private System.Windows.Forms.Button BTCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTBMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCNodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBConexion;
        private System.Windows.Forms.Button BTAddArist;
        private System.Windows.Forms.Button BTReiniciar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBAristas;
        private System.Windows.Forms.CheckBox CBMA;
        private System.Windows.Forms.CheckBox CBLA;
    }
}