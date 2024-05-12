namespace TEST
{
    partial class AddequipmentForm
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
            this.boxnom = new System.Windows.Forms.TextBox();
            this.boxfg = new System.Windows.Forms.TextBox();
            this.boxunite = new System.Windows.Forms.TextBox();
            this.boxref = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxnom
            // 
            this.boxnom.Location = new System.Drawing.Point(309, 34);
            this.boxnom.Name = "boxnom";
            this.boxnom.Size = new System.Drawing.Size(173, 20);
            this.boxnom.TabIndex = 1;
            // 
            // boxfg
            // 
            this.boxfg.Location = new System.Drawing.Point(309, 75);
            this.boxfg.Name = "boxfg";
            this.boxfg.Size = new System.Drawing.Size(173, 20);
            this.boxfg.TabIndex = 2;
            // 
            // boxunite
            // 
            this.boxunite.Location = new System.Drawing.Point(309, 120);
            this.boxunite.Name = "boxunite";
            this.boxunite.Size = new System.Drawing.Size(173, 20);
            this.boxunite.TabIndex = 3;
            // 
            // boxref
            // 
            this.boxref.Location = new System.Drawing.Point(309, 164);
            this.boxref.Name = "boxref";
            this.boxref.Size = new System.Drawing.Size(173, 20);
            this.boxref.TabIndex = 4;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(288, 404);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(176, 34);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TEST.Properties.Resources.add_camera_icon_icon_add_11553485583calilemiyg;
            this.pictureBox1.Location = new System.Drawing.Point(288, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "FONCTION GLOBALE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "UNITE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "REFERENCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "PANNE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NON",
            "OUI"});
            this.comboBox1.Location = new System.Drawing.Point(309, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // AddequipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.boxref);
            this.Controls.Add(this.boxunite);
            this.Controls.Add(this.boxfg);
            this.Controls.Add(this.boxnom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddequipmentForm";
            this.Text = "AddequipmentForm";
            this.Load += new System.EventHandler(this.AddequipmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox boxnom;
        private System.Windows.Forms.TextBox boxfg;
        private System.Windows.Forms.TextBox boxunite;
        private System.Windows.Forms.TextBox boxref;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}