namespace mysql.vt_1_847
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
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btnElestiriForm = new System.Windows.Forms.Button();
            this.btnFilmElestiri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(12, 246);
            this.dgw.Name = "dgw";
            this.dgw.Size = new System.Drawing.Size(644, 161);
            this.dgw.TabIndex = 0;
            // 
            // btnElestiriForm
            // 
            this.btnElestiriForm.Location = new System.Drawing.Point(13, 183);
            this.btnElestiriForm.Name = "btnElestiriForm";
            this.btnElestiriForm.Size = new System.Drawing.Size(169, 41);
            this.btnElestiriForm.TabIndex = 1;
            this.btnElestiriForm.Text = "elestiriler";
            this.btnElestiriForm.UseVisualStyleBackColor = true;
            this.btnElestiriForm.Click += new System.EventHandler(this.btnElestiriForm_Click);
            // 
            // btnFilmElestiri
            // 
            this.btnFilmElestiri.Location = new System.Drawing.Point(188, 183);
            this.btnFilmElestiri.Name = "btnFilmElestiri";
            this.btnFilmElestiri.Size = new System.Drawing.Size(175, 41);
            this.btnFilmElestiri.TabIndex = 2;
            this.btnFilmElestiri.Text = "film eleştiri";
            this.btnFilmElestiri.UseVisualStyleBackColor = true;
            this.btnFilmElestiri.Click += new System.EventHandler(this.btnFilmElestiri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 419);
            this.Controls.Add(this.btnFilmElestiri);
            this.Controls.Add(this.btnElestiriForm);
            this.Controls.Add(this.dgw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btnElestiriForm;
        private System.Windows.Forms.Button btnFilmElestiri;
    }
}

