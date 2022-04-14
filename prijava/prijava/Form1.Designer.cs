
namespace prijava
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkorime = new System.Windows.Forms.TextBox();
            this.txtlozinka = new System.Windows.Forms.TextBox();
            this.btnprijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka";
            // 
            // txtkorime
            // 
            this.txtkorime.Location = new System.Drawing.Point(93, 20);
            this.txtkorime.Name = "txtkorime";
            this.txtkorime.Size = new System.Drawing.Size(100, 20);
            this.txtkorime.TabIndex = 2;
            // 
            // txtlozinka
            // 
            this.txtlozinka.Location = new System.Drawing.Point(93, 60);
            this.txtlozinka.Name = "txtlozinka";
            this.txtlozinka.Size = new System.Drawing.Size(100, 20);
            this.txtlozinka.TabIndex = 3;
            // 
            // btnprijava
            // 
            this.btnprijava.Location = new System.Drawing.Point(118, 105);
            this.btnprijava.Name = "btnprijava";
            this.btnprijava.Size = new System.Drawing.Size(75, 23);
            this.btnprijava.TabIndex = 4;
            this.btnprijava.Text = "Prijava";
            this.btnprijava.UseVisualStyleBackColor = true;
            this.btnprijava.Click += new System.EventHandler(this.btnprijava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 162);
            this.Controls.Add(this.btnprijava);
            this.Controls.Add(this.txtlozinka);
            this.Controls.Add(this.txtkorime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkorime;
        private System.Windows.Forms.TextBox txtlozinka;
        private System.Windows.Forms.Button btnprijava;
    }
}

