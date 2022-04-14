namespace Filmovi
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
            this.dataGridViewPopisFilmova = new System.Windows.Forms.DataGridView();
            this.buttonDohvatiFilmove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisFilmova)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopisFilmova
            // 
            this.dataGridViewPopisFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisFilmova.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPopisFilmova.Name = "dataGridViewPopisFilmova";
            this.dataGridViewPopisFilmova.Size = new System.Drawing.Size(493, 212);
            this.dataGridViewPopisFilmova.TabIndex = 0;
            // 
            // buttonDohvatiFilmove
            // 
            this.buttonDohvatiFilmove.Location = new System.Drawing.Point(408, 242);
            this.buttonDohvatiFilmove.Name = "buttonDohvatiFilmove";
            this.buttonDohvatiFilmove.Size = new System.Drawing.Size(97, 39);
            this.buttonDohvatiFilmove.TabIndex = 1;
            this.buttonDohvatiFilmove.Text = "Dohvati zapocete filmove";
            this.buttonDohvatiFilmove.UseVisualStyleBackColor = true;
            this.buttonDohvatiFilmove.Click += new System.EventHandler(this.buttonDohvatiFilmove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 304);
            this.Controls.Add(this.buttonDohvatiFilmove);
            this.Controls.Add(this.dataGridViewPopisFilmova);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisFilmova)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopisFilmova;
        private System.Windows.Forms.Button buttonDohvatiFilmove;
    }
}

