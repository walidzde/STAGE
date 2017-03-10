namespace STAGE
{
    partial class stagiaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.tnom = new System.Windows.Forms.TextBox();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.tdiplome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Bcreation = new System.Windows.Forms.Button();
            this.bretourins = new System.Windows.Forms.Button();
            this.bstart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tnum = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(60, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(60, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.Location = new System.Drawing.Point(60, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diplome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.Location = new System.Drawing.Point(70, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Male";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label6.Location = new System.Drawing.Point(331, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Female";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbm);
            this.groupBox1.Controls.Add(this.rbf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(67, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(148, 53);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(28, 17);
            this.rbm.TabIndex = 7;
            this.rbm.TabStop = true;
            this.rbm.Text = " ";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(430, 53);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(28, 17);
            this.rbf.TabIndex = 6;
            this.rbf.TabStop = true;
            this.rbf.Text = " ";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // tnom
            // 
            this.tnom.Location = new System.Drawing.Point(276, 125);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(177, 20);
            this.tnom.TabIndex = 7;
            // 
            // tprenom
            // 
            this.tprenom.Location = new System.Drawing.Point(276, 172);
            this.tprenom.Name = "tprenom";
            this.tprenom.Size = new System.Drawing.Size(177, 20);
            this.tprenom.TabIndex = 8;
            // 
            // tdiplome
            // 
            this.tdiplome.Location = new System.Drawing.Point(279, 254);
            this.tdiplome.Name = "tdiplome";
            this.tdiplome.Size = new System.Drawing.Size(174, 20);
            this.tdiplome.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label7.Location = new System.Drawing.Point(171, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Création Stagiaire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Bcreation
            // 
            this.Bcreation.Location = new System.Drawing.Point(506, 142);
            this.Bcreation.Name = "Bcreation";
            this.Bcreation.Size = new System.Drawing.Size(75, 23);
            this.Bcreation.TabIndex = 13;
            this.Bcreation.Text = "Validation";
            this.Bcreation.UseVisualStyleBackColor = true;
            this.Bcreation.Click += new System.EventHandler(this.Bcreation_Click);
            // 
            // bretourins
            // 
            this.bretourins.Location = new System.Drawing.Point(506, 171);
            this.bretourins.Name = "bretourins";
            this.bretourins.Size = new System.Drawing.Size(75, 23);
            this.bretourins.TabIndex = 14;
            this.bretourins.Text = "retour";
            this.bretourins.UseVisualStyleBackColor = true;
            this.bretourins.Click += new System.EventHandler(this.bretourins_Click);
            // 
            // bstart
            // 
            this.bstart.Location = new System.Drawing.Point(506, 200);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(75, 23);
            this.bstart.TabIndex = 15;
            this.bstart.Text = "start";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label8.Location = new System.Drawing.Point(60, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero";
            // 
            // tnum
            // 
            this.tnum.Location = new System.Drawing.Point(276, 92);
            this.tnum.Name = "tnum";
            this.tnum.Size = new System.Drawing.Size(177, 20);
            this.tnum.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // stagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 451);
            this.Controls.Add(this.tnum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.bretourins);
            this.Controls.Add(this.Bcreation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tdiplome);
            this.Controls.Add(this.tprenom);
            this.Controls.Add(this.tnom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stagiaire";
            this.Text = "stagiaire";
            this.Load += new System.EventHandler(this.stagiaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.TextBox tdiplome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Bcreation;
        private System.Windows.Forms.Button bretourins;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tnum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}