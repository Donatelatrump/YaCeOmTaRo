namespace YaCeOmTaRo
{
    partial class DFSyBFS_Dirigidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DFSyBFS_Dirigidos));
            this.label3 = new System.Windows.Forms.Label();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "BFS y DFS para grafos dirigidos";
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBFS.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBFS.FlatAppearance.BorderSize = 3;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBFS.Location = new System.Drawing.Point(170, 138);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(152, 58);
            this.btnBFS.TabIndex = 4;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDFS.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDFS.FlatAppearance.BorderSize = 3;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDFS.Location = new System.Drawing.Point(480, 138);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(152, 58);
            this.btnDFS.TabIndex = 5;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // DFSyBFS_Dirigidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DFSyBFS_Dirigidos";
            this.Text = "DFSyBFS_Dirigidos";
            this.Load += new System.EventHandler(this.DFSyBFS_Dirigidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
    }
}