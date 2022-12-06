namespace YaCeOmTaRo
{
    partial class Bipartito_perfecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bipartito_perfecto));
            this.BT_Comenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NumeroNodos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Inicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Final = new System.Windows.Forms.TextBox();
            this.TB_MatrizGrafo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_Pareamiento = new System.Windows.Forms.Button();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_Comenzar
            // 
            this.BT_Comenzar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Comenzar.Location = new System.Drawing.Point(450, 40);
            this.BT_Comenzar.Name = "BT_Comenzar";
            this.BT_Comenzar.Size = new System.Drawing.Size(85, 31);
            this.BT_Comenzar.TabIndex = 0;
            this.BT_Comenzar.Text = "Comenzar ";
            this.BT_Comenzar.UseVisualStyleBackColor = true;
            this.BT_Comenzar.Click += new System.EventHandler(this.BT_Comenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dame el numero de nodos: ";
            // 
            // TB_NumeroNodos
            // 
            this.TB_NumeroNodos.Location = new System.Drawing.Point(371, 46);
            this.TB_NumeroNodos.Name = "TB_NumeroNodos";
            this.TB_NumeroNodos.Size = new System.Drawing.Size(62, 20);
            this.TB_NumeroNodos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "======== Rellenar la Matriz =====================================";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nodo de inicio:";
            // 
            // TB_Inicio
            // 
            this.TB_Inicio.Location = new System.Drawing.Point(184, 174);
            this.TB_Inicio.Name = "TB_Inicio";
            this.TB_Inicio.Size = new System.Drawing.Size(36, 20);
            this.TB_Inicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nodo de llegada:";
            // 
            // TB_Final
            // 
            this.TB_Final.Location = new System.Drawing.Point(401, 174);
            this.TB_Final.Name = "TB_Final";
            this.TB_Final.Size = new System.Drawing.Size(36, 20);
            this.TB_Final.TabIndex = 7;
            // 
            // TB_MatrizGrafo
            // 
            this.TB_MatrizGrafo.Enabled = false;
            this.TB_MatrizGrafo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MatrizGrafo.Location = new System.Drawing.Point(20, 246);
            this.TB_MatrizGrafo.Multiline = true;
            this.TB_MatrizGrafo.Name = "TB_MatrizGrafo";
            this.TB_MatrizGrafo.Size = new System.Drawing.Size(298, 268);
            this.TB_MatrizGrafo.TabIndex = 8;
            this.TB_MatrizGrafo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear Conexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "===== Pareamiento Perfecto =====";
            // 
            // BT_Pareamiento
            // 
            this.BT_Pareamiento.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pareamiento.Location = new System.Drawing.Point(401, 289);
            this.BT_Pareamiento.Name = "BT_Pareamiento";
            this.BT_Pareamiento.Size = new System.Drawing.Size(184, 26);
            this.BT_Pareamiento.TabIndex = 11;
            this.BT_Pareamiento.Text = "Comenzar Pareamiento";
            this.BT_Pareamiento.UseVisualStyleBackColor = true;
            this.BT_Pareamiento.Click += new System.EventHandler(this.BT_Pareamiento_Click);
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Reiniciar.Location = new System.Drawing.Point(563, 535);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(91, 31);
            this.BT_Reiniciar.TabIndex = 12;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click);
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.Location = new System.Drawing.Point(345, 321);
            this.TB_Resultado.Multiline = true;
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(289, 193);
            this.TB_Resultado.TabIndex = 13;
            // 
            // Bipartito_perfecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 578);
            this.Controls.Add(this.TB_Resultado);
            this.Controls.Add(this.BT_Reiniciar);
            this.Controls.Add(this.BT_Pareamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_MatrizGrafo);
            this.Controls.Add(this.TB_Final);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NumeroNodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Comenzar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bipartito_perfecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bipartito_perfecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Comenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NumeroNodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Final;
        private System.Windows.Forms.TextBox TB_MatrizGrafo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_Pareamiento;
        private System.Windows.Forms.Button BT_Reiniciar;
        private System.Windows.Forms.TextBox TB_Resultado;
    }
}