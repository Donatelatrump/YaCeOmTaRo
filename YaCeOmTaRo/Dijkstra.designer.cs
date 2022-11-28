using System.Windows.Forms;

namespace YaCeOmTaRo
{
    partial class Dijkstra
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
            this.btnAristas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.lbl1c = new System.Windows.Forms.Label();
            this.lbl2c = new System.Windows.Forms.Label();
            this.lbl3c = new System.Windows.Forms.Label();
            this.lbl4c = new System.Windows.Forms.Label();
            this.lbl5c = new System.Windows.Forms.Label();
            this.lbl6c = new System.Windows.Forms.Label();
            this.lbl7c = new System.Windows.Forms.Label();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(325, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(331, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta más corta: Dijkstra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de vértices o nodos del grafo:";
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
            this.cmbTamaño.Location = new System.Drawing.Point(444, 75);
            this.cmbTamaño.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(137, 32);
            this.cmbTamaño.TabIndex = 2;
            this.cmbTamaño.SelectedIndexChanged += new System.EventHandler(this.cmbTamaño_SelectedIndexChanged);
            // 
            // btnAristas
            // 
            this.btnAristas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAristas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAristas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAristas.FlatAppearance.BorderSize = 3;
            this.btnAristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAristas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAristas.Location = new System.Drawing.Point(671, 75);
            this.btnAristas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAristas.Name = "btnAristas";
            this.btnAristas.Size = new System.Drawing.Size(127, 42);
            this.btnAristas.TabIndex = 3;
            this.btnAristas.Text = "Ingresar aristas";
            this.btnAristas.UseVisualStyleBackColor = false;
            this.btnAristas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.BackColor = System.Drawing.Color.Transparent;
            this.lblNodos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNodos.Location = new System.Drawing.Point(133, 148);
            this.lblNodos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(62, 24);
            this.lblNodos.TabIndex = 5;
            this.lblNodos.Text = "Nodo";
            this.lblNodos.Visible = false;
            // 
            // lbl1c
            // 
            this.lbl1c.AutoSize = true;
            this.lbl1c.BackColor = System.Drawing.Color.White;
            this.lbl1c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl1c.Location = new System.Drawing.Point(149, 139);
            this.lbl1c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1c.Name = "lbl1c";
            this.lbl1c.Size = new System.Drawing.Size(0, 24);
            this.lbl1c.TabIndex = 6;
            // 
            // lbl2c
            // 
            this.lbl2c.AutoSize = true;
            this.lbl2c.BackColor = System.Drawing.Color.White;
            this.lbl2c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl2c.Location = new System.Drawing.Point(240, 139);
            this.lbl2c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2c.Name = "lbl2c";
            this.lbl2c.Size = new System.Drawing.Size(0, 24);
            this.lbl2c.TabIndex = 7;
            // 
            // lbl3c
            // 
            this.lbl3c.AutoSize = true;
            this.lbl3c.BackColor = System.Drawing.Color.White;
            this.lbl3c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl3c.Location = new System.Drawing.Point(331, 139);
            this.lbl3c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl3c.Name = "lbl3c";
            this.lbl3c.Size = new System.Drawing.Size(0, 24);
            this.lbl3c.TabIndex = 8;
            // 
            // lbl4c
            // 
            this.lbl4c.AutoSize = true;
            this.lbl4c.BackColor = System.Drawing.Color.White;
            this.lbl4c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl4c.Location = new System.Drawing.Point(423, 139);
            this.lbl4c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl4c.Name = "lbl4c";
            this.lbl4c.Size = new System.Drawing.Size(0, 24);
            this.lbl4c.TabIndex = 9;
            // 
            // lbl5c
            // 
            this.lbl5c.AutoSize = true;
            this.lbl5c.BackColor = System.Drawing.Color.White;
            this.lbl5c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl5c.Location = new System.Drawing.Point(515, 139);
            this.lbl5c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl5c.Name = "lbl5c";
            this.lbl5c.Size = new System.Drawing.Size(0, 24);
            this.lbl5c.TabIndex = 10;
            // 
            // lbl6c
            // 
            this.lbl6c.AutoSize = true;
            this.lbl6c.BackColor = System.Drawing.Color.White;
            this.lbl6c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl6c.Location = new System.Drawing.Point(605, 139);
            this.lbl6c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl6c.Name = "lbl6c";
            this.lbl6c.Size = new System.Drawing.Size(0, 24);
            this.lbl6c.TabIndex = 11;
            // 
            // lbl7c
            // 
            this.lbl7c.AutoSize = true;
            this.lbl7c.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl7c.Location = new System.Drawing.Point(0, 0);
            this.lbl7c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl7c.Name = "lbl7c";
            this.lbl7c.Size = new System.Drawing.Size(0, 24);
            this.lbl7c.TabIndex = 12;
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.BackColor = System.Drawing.Color.Transparent;
            this.lblMatriz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatriz.Location = new System.Drawing.Point(408, 111);
            this.lblMatriz.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(237, 24);
            this.lblMatriz.TabIndex = 13;
            this.lblMatriz.Text = "Matriz de Adyacencias";
            this.lblMatriz.Visible = false;
            this.lblMatriz.Click += new System.EventHandler(this.lblMatriz_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.Color.White;
            this.btnMatriz.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnMatriz.FlatAppearance.BorderSize = 3;
            this.btnMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriz.Location = new System.Drawing.Point(785, 566);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(112, 31);
            this.btnMatriz.TabIndex = 14;
            this.btnMatriz.Text = "Guardar Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.Visible = false;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.BackColor = System.Drawing.Color.White;
            this.btnDijkstra.Enabled = false;
            this.btnDijkstra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDijkstra.FlatAppearance.BorderSize = 3;
            this.btnDijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDijkstra.Location = new System.Drawing.Point(391, 625);
            this.btnDijkstra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(133, 31);
            this.btnDijkstra.TabIndex = 15;
            this.btnDijkstra.Text = "Calcular ruta ";
            this.btnDijkstra.UseVisualStyleBackColor = false;
            this.btnDijkstra.Visible = false;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRuta.Location = new System.Drawing.Point(533, 628);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(71, 24);
            this.lblRuta.TabIndex = 16;
            this.lblRuta.Text = "Ruta: ";
            this.lblRuta.Visible = false;
            // 
            // cmbInicio
            // 
            this.cmbInicio.BackColor = System.Drawing.Color.White;
            this.cmbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInicio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Location = new System.Drawing.Point(135, 624);
            this.cmbInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(91, 32);
            this.cmbInicio.TabIndex = 17;
            this.cmbInicio.Visible = false;
            // 
            // cmbFin
            // 
            this.cmbFin.BackColor = System.Drawing.Color.White;
            this.cmbFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFin.FormattingEnabled = true;
            this.cmbFin.Location = new System.Drawing.Point(271, 623);
            this.cmbFin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbFin.Name = "cmbFin";
            this.cmbFin.Size = new System.Drawing.Size(91, 32);
            this.cmbFin.TabIndex = 18;
            this.cmbFin.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 527);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 19;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblInicio.Location = new System.Drawing.Point(117, 596);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(120, 24);
            this.lblInicio.TabIndex = 20;
            this.lblInicio.Text = "Nodo inicial:";
            this.lblInicio.Visible = false;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFin.Location = new System.Drawing.Point(265, 596);
            this.lblFin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(107, 24);
            this.lblFin.TabIndex = 21;
            this.lblFin.Text = "Nodo final:";
            this.lblFin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 629);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 22;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblCosto.Location = new System.Drawing.Point(532, 668);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(72, 24);
            this.lblCosto.TabIndex = 23;
            this.lblCosto.Text = "Costo:";
            this.lblCosto.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::YaCeOmTaRo.Properties.Resources.visual_dijkstra_logo;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(762, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(62, 44);
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::YaCeOmTaRo.Properties.Resources.beat_street_background_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 701);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFin);
            this.Controls.Add(this.cmbInicio);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.lbl7c);
            this.Controls.Add(this.lbl6c);
            this.Controls.Add(this.lbl5c);
            this.Controls.Add(this.lbl4c);
            this.Controls.Add(this.lbl3c);
            this.Controls.Add(this.lbl2c);
            this.Controls.Add(this.lbl1c);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAristas);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dijkstra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruta más corta: Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTamaño;
        private Button btnAristas;
        private Label label3;
        private Label lblNodos;
        private Label lbl1c;
        private Label lbl2c;
        private Label lbl3c;
        private Label lbl4c;
        private Label lbl5c;
        private Label lbl6c;
        private Label lbl7c;
        private Label lblMatriz;
        private Button btnMatriz;
        private Button btnDijkstra;
        private Label lblRuta;
        private ComboBox cmbInicio;
        private ComboBox cmbFin;
        private Label label5;
        private Label lblInicio;
        private Label lblFin;
        private Label label4;
        private Label lblCosto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}