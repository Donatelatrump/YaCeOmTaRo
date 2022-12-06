namespace YaCeOmTaRo
{
    partial class DFS_Dirigido
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
            this.lblDFS = new System.Windows.Forms.Label();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.btnAristas = new System.Windows.Forms.Button();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDFS
            // 
            this.lblDFS.AutoSize = true;
            this.lblDFS.BackColor = System.Drawing.Color.Transparent;
            this.lblDFS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDFS.Location = new System.Drawing.Point(299, 516);
            this.lblDFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDFS.Name = "lblDFS";
            this.lblDFS.Size = new System.Drawing.Size(46, 19);
            this.lblDFS.TabIndex = 32;
            this.lblDFS.Text = "DFS:";
            this.lblDFS.Visible = false;
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.White;
            this.btnDFS.Enabled = false;
            this.btnDFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDFS.FlatAppearance.BorderSize = 3;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Location = new System.Drawing.Point(191, 504);
            this.btnDFS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(100, 47);
            this.btnDFS.TabIndex = 31;
            this.btnDFS.Text = "Obtener recorrido DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Visible = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.Color.White;
            this.btnMatriz.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnMatriz.FlatAppearance.BorderSize = 3;
            this.btnMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriz.Location = new System.Drawing.Point(605, 460);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(84, 25);
            this.btnMatriz.TabIndex = 30;
            this.btnMatriz.Text = "Guardar Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.Visible = false;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.BackColor = System.Drawing.Color.Transparent;
            this.lblMatriz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatriz.Location = new System.Drawing.Point(319, 92);
            this.lblMatriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(191, 19);
            this.lblMatriz.TabIndex = 29;
            this.lblMatriz.Text = "Matriz de Adyacencias";
            this.lblMatriz.Visible = false;
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.BackColor = System.Drawing.Color.Transparent;
            this.lblNodos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNodos.Location = new System.Drawing.Point(100, 120);
            this.lblNodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(51, 19);
            this.lblNodos.TabIndex = 28;
            this.lblNodos.Text = "Nodo";
            this.lblNodos.Visible = false;
            // 
            // btnAristas
            // 
            this.btnAristas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAristas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAristas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAristas.FlatAppearance.BorderSize = 3;
            this.btnAristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAristas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAristas.Location = new System.Drawing.Point(538, 62);
            this.btnAristas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAristas.Name = "btnAristas";
            this.btnAristas.Size = new System.Drawing.Size(95, 34);
            this.btnAristas.TabIndex = 27;
            this.btnAristas.Text = "Ingresar aristas";
            this.btnAristas.UseVisualStyleBackColor = false;
            this.btnAristas.Click += new System.EventHandler(this.btnAristas_Click);
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.BackColor = System.Drawing.Color.White;
            this.cmbTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamaño.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbTamaño.Location = new System.Drawing.Point(368, 62);
            this.cmbTamaño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(104, 27);
            this.cmbTamaño.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total de vértices o nodos del grafo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageKey = "(ninguno)";
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "DFS Grafos Dirigidos";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblInicio.Location = new System.Drawing.Point(53, 504);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(98, 19);
            this.lblInicio.TabIndex = 34;
            this.lblInicio.Text = "Nodo inicial:";
            this.lblInicio.Visible = false;
            // 
            // cmbInicio
            // 
            this.cmbInicio.BackColor = System.Drawing.Color.White;
            this.cmbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInicio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Location = new System.Drawing.Point(66, 527);
            this.cmbInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(69, 27);
            this.cmbInicio.TabIndex = 33;
            this.cmbInicio.Visible = false;
            // 
            // DFS_Dirigido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 576);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.cmbInicio);
            this.Controls.Add(this.lblDFS);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.btnAristas);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DFS_Dirigido";
            this.Text = "DFS_Dirigido";
            this.Load += new System.EventHandler(this.DFS_Dirigido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Button btnAristas;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ComboBox cmbInicio;
    }
}