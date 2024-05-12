namespace TEST
{
    partial class StockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Quantitbox = new System.Windows.Forms.NumericUpDown();
            this.boxref = new System.Windows.Forms.TextBox();
            this.PrixBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Quantitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixBox)).BeginInit();
            this.SuspendLayout();
            // 
            // boxnom
            // 
            this.boxnom.Location = new System.Drawing.Point(332, 79);
            this.boxnom.Name = "boxnom";
            this.boxnom.Size = new System.Drawing.Size(100, 20);
            this.boxnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUANTITE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "REF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRIX\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "AJOUTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quantitbox
            // 
            this.Quantitbox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Quantitbox.Location = new System.Drawing.Point(332, 186);
            this.Quantitbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Quantitbox.Name = "Quantitbox";
            this.Quantitbox.Size = new System.Drawing.Size(100, 20);
            this.Quantitbox.TabIndex = 15;
            // 
            // boxref
            // 
            this.boxref.Location = new System.Drawing.Point(332, 138);
            this.boxref.Name = "boxref";
            this.boxref.Size = new System.Drawing.Size(100, 20);
            this.boxref.TabIndex = 16;
            // 
            // PrixBox
            // 
            this.PrixBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PrixBox.Location = new System.Drawing.Point(332, 230);
            this.PrixBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PrixBox.Name = "PrixBox";
            this.PrixBox.Size = new System.Drawing.Size(100, 20);
            this.PrixBox.TabIndex = 17;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrixBox);
            this.Controls.Add(this.boxref);
            this.Controls.Add(this.Quantitbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxnom);
            this.Name = "StockForm";
            this.Text = "StockForm";
            ((System.ComponentModel.ISupportInitialize)(this.Quantitbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Quantitbox;
        private System.Windows.Forms.TextBox boxref;
        private System.Windows.Forms.NumericUpDown PrixBox;
    }
}