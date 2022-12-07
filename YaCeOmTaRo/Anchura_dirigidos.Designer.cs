namespace YaCeOmTaRo
{
    partial class Anchura_dirigidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anchura_dirigidos));
            this.BT_Comenzar = new System.Windows.Forms.Button();
            this.TB_Nodos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Grafo = new System.Windows.Forms.TextBox();
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Inicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Fin = new System.Windows.Forms.TextBox();
            this.BT_Conexion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Recorrido = new System.Windows.Forms.Button();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Comienzo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_Comenzar
            // 
            this.BT_Comenzar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Comenzar.Location = new System.Drawing.Point(490, 34);
            this.BT_Comenzar.Name = "BT_Comenzar";
            this.BT_Comenzar.Size = new System.Drawing.Size(99, 27);
            this.BT_Comenzar.TabIndex = 0;
            this.BT_Comenzar.Text = "Comenzar";
            this.BT_Comenzar.UseVisualStyleBackColor = true;
            this.BT_Comenzar.Click += new System.EventHandler(this.BT_Comenzar_Click);
            // 
            // TB_Nodos
            // 
            this.TB_Nodos.Location = new System.Drawing.Point(428, 35);
            this.TB_Nodos.Name = "TB_Nodos";
            this.TB_Nodos.Size = new System.Drawing.Size(43, 20);
            this.TB_Nodos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuantos nodos tiene tu grafo";
            // 
            // TB_Grafo
            // 
            this.TB_Grafo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Grafo.Location = new System.Drawing.Point(12, 236);
            this.TB_Grafo.Multiline = true;
            this.TB_Grafo.Name = "TB_Grafo";
            this.TB_Grafo.Size = new System.Drawing.Size(380, 354);
            this.TB_Grafo.TabIndex = 3;
            this.TB_Grafo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.Location = new System.Drawing.Point(479, 449);
            this.TB_Resultado.Multiline = true;
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(227, 52);
            this.TB_Resultado.TabIndex = 4;
            this.TB_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grafo en Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "En que nodo Inicia:";
            // 
            // TB_Inicio
            // 
            this.TB_Inicio.Location = new System.Drawing.Point(234, 151);
            this.TB_Inicio.Name = "TB_Inicio";
            this.TB_Inicio.Size = new System.Drawing.Size(43, 20);
            this.TB_Inicio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Con que nodo conecta:";
            // 
            // TB_Fin
            // 
            this.TB_Fin.Location = new System.Drawing.Point(509, 151);
            this.TB_Fin.Name = "TB_Fin";
            this.TB_Fin.Size = new System.Drawing.Size(43, 20);
            this.TB_Fin.TabIndex = 10;
            // 
            // BT_Conexion
            // 
            this.BT_Conexion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Conexion.Location = new System.Drawing.Point(582, 147);
            this.BT_Conexion.Name = "BT_Conexion";
            this.BT_Conexion.Size = new System.Drawing.Size(143, 27);
            this.BT_Conexion.TabIndex = 11;
            this.BT_Conexion.Text = "Hacer Conexion";
            this.BT_Conexion.UseVisualStyleBackColor = true;
            this.BT_Conexion.Click += new System.EventHandler(this.BT_Conexion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(780, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "================== Conexiones del Grafo =====================================";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "====== Recorrido en Anchura =======";
            // 
            // BT_Recorrido
            // 
            this.BT_Recorrido.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Recorrido.Location = new System.Drawing.Point(490, 406);
            this.BT_Recorrido.Name = "BT_Recorrido";
            this.BT_Recorrido.Size = new System.Drawing.Size(193, 27);
            this.BT_Recorrido.TabIndex = 14;
            this.BT_Recorrido.Text = "Realizar Recorrido";
            this.BT_Recorrido.UseVisualStyleBackColor = true;
            this.BT_Recorrido.Click += new System.EventHandler(this.BT_Recorrido_Click);
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Reiniciar.Location = new System.Drawing.Point(658, 563);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(99, 27);
            this.BT_Reiniciar.TabIndex = 15;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "En que nodo comenzar:";
            // 
            // TB_Comienzo
            // 
            this.TB_Comienzo.Location = new System.Drawing.Point(682, 341);
            this.TB_Comienzo.Name = "TB_Comienzo";
            this.TB_Comienzo.Size = new System.Drawing.Size(43, 20);
            this.TB_Comienzo.TabIndex = 17;
            // 
            // Anchura_dirigidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 602);
            this.Controls.Add(this.TB_Comienzo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BT_Reiniciar);
            this.Controls.Add(this.BT_Recorrido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_Conexion);
            this.Controls.Add(this.TB_Fin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Resultado);
            this.Controls.Add(this.TB_Grafo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Nodos);
            this.Controls.Add(this.BT_Comenzar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anchura_dirigidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anchura_dirigidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Comenzar;
        private System.Windows.Forms.TextBox TB_Nodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Grafo;
        private System.Windows.Forms.TextBox TB_Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Fin;
        private System.Windows.Forms.Button BT_Conexion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Recorrido;
        private System.Windows.Forms.Button BT_Reiniciar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Comienzo;
    }
}