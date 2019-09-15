namespace SuperParser
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonHabr = new System.Windows.Forms.Button();
            this.buttonFreelansim = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 433);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Point";
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(652, 28);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Point";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(652, 82);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // buttonHabr
            // 
            this.buttonHabr.Location = new System.Drawing.Point(673, 138);
            this.buttonHabr.Name = "buttonHabr";
            this.buttonHabr.Size = new System.Drawing.Size(75, 23);
            this.buttonHabr.TabIndex = 5;
            this.buttonHabr.Text = "Habr";
            this.buttonHabr.UseVisualStyleBackColor = true;
            // 
            // buttonFreelansim
            // 
            this.buttonFreelansim.Location = new System.Drawing.Point(673, 168);
            this.buttonFreelansim.Name = "buttonFreelansim";
            this.buttonFreelansim.Size = new System.Drawing.Size(75, 23);
            this.buttonFreelansim.TabIndex = 6;
            this.buttonFreelansim.Text = "Freelansim";
            this.buttonFreelansim.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(673, 422);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(673, 393);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очитстить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonFreelansim);
            this.Controls.Add(this.buttonHabr);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SuperParser";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button buttonHabr;
        private System.Windows.Forms.Button buttonFreelansim;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonClear;
    }
}

