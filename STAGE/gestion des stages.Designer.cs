namespace STAGE
{
    partial class gestion_des_stages
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
            this.dgvliststage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.listepartype = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listpardate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliststage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvliststage
            // 
            this.dgvliststage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliststage.Location = new System.Drawing.Point(12, 129);
            this.dgvliststage.Name = "dgvliststage";
            this.dgvliststage.Size = new System.Drawing.Size(507, 156);
            this.dgvliststage.TabIndex = 0;
            this.dgvliststage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "liste des inscrits Admis";
            // 
            // listepartype
            // 
            this.listepartype.Location = new System.Drawing.Point(525, 208);
            this.listepartype.Name = "listepartype";
            this.listepartype.Size = new System.Drawing.Size(97, 23);
            this.listepartype.TabIndex = 5;
            this.listepartype.Text = "liste par type";
            this.listepartype.UseVisualStyleBackColor = true;
            this.listepartype.Click += new System.EventHandler(this.listepartype_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "FIN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Affichage";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listpardate
            // 
            this.listpardate.Location = new System.Drawing.Point(525, 150);
            this.listpardate.Name = "listpardate";
            this.listpardate.Size = new System.Drawing.Size(97, 23);
            this.listpardate.TabIndex = 4;
            this.listpardate.Text = "Liste par date";
            this.listpardate.UseVisualStyleBackColor = true;
            this.listpardate.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestion_des_stages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 343);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listepartype);
            this.Controls.Add(this.listpardate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvliststage);
            this.Name = "gestion_des_stages";
            this.Text = "gestion_des_stages";
            this.Load += new System.EventHandler(this.gestion_des_stages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliststage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvliststage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listepartype;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button listpardate;
    }
}