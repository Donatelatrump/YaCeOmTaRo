namespace YaCeOmTaRo
{
    partial class Saber_Si_Es_Arbol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saber_Si_Es_Arbol));
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Creargrafo = new System.Windows.Forms.Button();
            this.TB_Numeronodos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Nodo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Nodo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Grafo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_Comenzar = new System.Windows.Forms.Button();
            this.TB_Respuesta = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(192, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Tu Grafo es un Arbol?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BT_Creargrafo
            // 
            this.BT_Creargrafo.BackColor = System.Drawing.Color.White;
            this.BT_Creargrafo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Creargrafo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_Creargrafo.FlatAppearance.BorderSize = 3;
            this.BT_Creargrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Creargrafo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Creargrafo.Location = new System.Drawing.Point(483, 39);
            this.BT_Creargrafo.Name = "BT_Creargrafo";
            this.BT_Creargrafo.Size = new System.Drawing.Size(125, 32);
            this.BT_Creargrafo.TabIndex = 1;
            this.BT_Creargrafo.Text = "Crear Grafo";
            this.BT_Creargrafo.UseVisualStyleBackColor = false;
            this.BT_Creargrafo.Click += new System.EventHandler(this.BT_Creargrafo_Click);
            // 
            // TB_Numeronodos
            // 
            this.TB_Numeronodos.Location = new System.Drawing.Point(370, 54);
            this.TB_Numeronodos.Name = "TB_Numeronodos";
            this.TB_Numeronodos.Size = new System.Drawing.Size(60, 20);
            this.TB_Numeronodos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(163, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de nodos:";
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_Reiniciar.FlatAppearance.BorderSize = 3;
            this.BT_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Reiniciar.Location = new System.Drawing.Point(502, 468);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(96, 25);
            this.BT_Reiniciar.TabIndex = 4;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "El nodo:";
            // 
            // TB_Nodo1
            // 
            this.TB_Nodo1.Enabled = false;
            this.TB_Nodo1.Location = new System.Drawing.Point(154, 180);
            this.TB_Nodo1.Name = "TB_Nodo1";
            this.TB_Nodo1.Size = new System.Drawing.Size(52, 20);
            this.TB_Nodo1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(226, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Conecta con el nodo:";
            // 
            // TB_Nodo2
            // 
            this.TB_Nodo2.Enabled = false;
            this.TB_Nodo2.Location = new System.Drawing.Point(449, 180);
            this.TB_Nodo2.Name = "TB_Nodo2";
            this.TB_Nodo2.Size = new System.Drawing.Size(52, 20);
            this.TB_Nodo2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(83, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "GRAFO";
            // 
            // TB_Grafo
            // 
            this.TB_Grafo.Location = new System.Drawing.Point(88, 244);
            this.TB_Grafo.Multiline = true;
            this.TB_Grafo.Name = "TB_Grafo";
            this.TB_Grafo.Size = new System.Drawing.Size(243, 218);
            this.TB_Grafo.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(526, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hacer Conexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_Comenzar
            // 
            this.BT_Comenzar.Enabled = false;
            this.BT_Comenzar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BT_Comenzar.FlatAppearance.BorderSize = 3;
            this.BT_Comenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Comenzar.Location = new System.Drawing.Point(370, 244);
            this.BT_Comenzar.Name = "BT_Comenzar";
            this.BT_Comenzar.Size = new System.Drawing.Size(111, 32);
            this.BT_Comenzar.TabIndex = 12;
            this.BT_Comenzar.Text = "Comenzar algoritmo";
            this.BT_Comenzar.UseVisualStyleBackColor = true;
            this.BT_Comenzar.Click += new System.EventHandler(this.BT_Comenzar_Click);
            // 
            // TB_Respuesta
            // 
            this.TB_Respuesta.Enabled = false;
            this.TB_Respuesta.Location = new System.Drawing.Point(362, 282);
            this.TB_Respuesta.Name = "TB_Respuesta";
            this.TB_Respuesta.Size = new System.Drawing.Size(146, 20);
            this.TB_Respuesta.TabIndex = 13;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "png-transparent-tree-line-graph-theory-vertex-planar-graph-path-counterexample-cu" +
        "bic-graph-mathematician.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Saber_Si_Es_Arbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::YaCeOmTaRo.Properties.Resources.brochure_1356182_960_720;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.TB_Respuesta);
            this.Controls.Add(this.BT_Comenzar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Grafo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Nodo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Nodo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Reiniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Numeronodos);
            this.Controls.Add(this.BT_Creargrafo);
            this.Controls.Add(this.label1);
            this.Name = "Saber_Si_Es_Arbol";
            this.Text = "Saber_Si_Es_Arbol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Saber_Si_Es_Arbol_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Creargrafo;
        private System.Windows.Forms.TextBox TB_Numeronodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Reiniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Nodo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Nodo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Grafo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_Comenzar;
        private System.Windows.Forms.TextBox TB_Respuesta;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}