namespace Popis_zadataka
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
            this.dataGridViewPopisZadataka = new System.Windows.Forms.DataGridView();
            this.ButtonDodajZadatak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZadataka)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopisZadataka
            // 
            this.dataGridViewPopisZadataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisZadataka.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPopisZadataka.Name = "dataGridViewPopisZadataka";
            this.dataGridViewPopisZadataka.Size = new System.Drawing.Size(479, 311);
            this.dataGridViewPopisZadataka.TabIndex = 0;
            // 
            // ButtonDodajZadatak
            // 
            this.ButtonDodajZadatak.Location = new System.Drawing.Point(400, 329);
            this.ButtonDodajZadatak.Name = "ButtonDodajZadatak";
            this.ButtonDodajZadatak.Size = new System.Drawing.Size(91, 23);
            this.ButtonDodajZadatak.TabIndex = 1;
            this.ButtonDodajZadatak.Text = "Dodaj zadatak";
            this.ButtonDodajZadatak.UseVisualStyleBackColor = true;
            this.ButtonDodajZadatak.Click += new System.EventHandler(this.ButtonDodajZadatak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 377);
            this.Controls.Add(this.ButtonDodajZadatak);
            this.Controls.Add(this.dataGridViewPopisZadataka);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis zadataka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZadataka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopisZadataka;
        private System.Windows.Forms.Button ButtonDodajZadatak;
    }
}

