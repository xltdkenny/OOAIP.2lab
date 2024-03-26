namespace films
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnWatchMovie = new System.Windows.Forms.Button();
            this.btnEndMovie = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbMovieNames = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(1136, 28);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(254, 367);
            this.txtOutput.TabIndex = 0;
            // 
            // btnWatchMovie
            // 
            this.btnWatchMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchMovie.Location = new System.Drawing.Point(1276, 428);
            this.btnWatchMovie.Name = "btnWatchMovie";
            this.btnWatchMovie.Size = new System.Drawing.Size(114, 34);
            this.btnWatchMovie.TabIndex = 1;
            this.btnWatchMovie.Text = "Смотреть клип";
            this.btnWatchMovie.UseVisualStyleBackColor = true;
            this.btnWatchMovie.Click += new System.EventHandler(this.btnWatchMovie_Click);
            // 
            // btnEndMovie
            // 
            this.btnEndMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndMovie.Location = new System.Drawing.Point(1276, 503);
            this.btnEndMovie.Name = "btnEndMovie";
            this.btnEndMovie.Size = new System.Drawing.Size(114, 34);
            this.btnEndMovie.TabIndex = 2;
            this.btnEndMovie.Text = "Выключить клип";
            this.btnEndMovie.UseVisualStyleBackColor = true;
            this.btnEndMovie.Click += new System.EventHandler(this.btnEndMovie_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(1276, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbMovieNames
            // 
            this.cmbMovieNames.BackColor = System.Drawing.Color.White;
            this.cmbMovieNames.FormattingEnabled = true;
            this.cmbMovieNames.Location = new System.Drawing.Point(40, 28);
            this.cmbMovieNames.Name = "cmbMovieNames";
            this.cmbMovieNames.Size = new System.Drawing.Size(456, 21);
            this.cmbMovieNames.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(40, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 545);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1421, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMovieNames);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEndMovie);
            this.Controls.Add(this.btnWatchMovie);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "CLIPMANIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnWatchMovie;
        private System.Windows.Forms.Button btnEndMovie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbMovieNames;
        private System.Windows.Forms.Panel panel1;
    }
}

