namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Visualka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabaProgress = new System.Windows.Forms.ProgressBar();
            this.Skills = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Visualka
            // 
            this.Visualka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Visualka.BackgroundImage")));
            this.Visualka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Visualka.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Visualka.Location = new System.Drawing.Point(131, 118);
            this.Visualka.Name = "Visualka";
            this.Visualka.Size = new System.Drawing.Size(400, 300);
            this.Visualka.TabIndex = 0;
            this.Visualka.Text = "Делать лабы";
            this.Visualka.UseVisualStyleBackColor = true;
            this.Visualka.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "лабы: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "опыт: 0/100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "сп: 0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "лаб за клик: 1";
            // 
            // LabaProgress
            // 
            this.LabaProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabaProgress.Location = new System.Drawing.Point(16, 534);
            this.LabaProgress.Name = "LabaProgress";
            this.LabaProgress.Size = new System.Drawing.Size(643, 15);
            this.LabaProgress.Step = 1000;
            this.LabaProgress.TabIndex = 6;
            // 
            // Skills
            // 
            this.Skills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skills.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Skills.Dock = System.Windows.Forms.DockStyle.Right;
            this.Skills.Location = new System.Drawing.Point(684, 0);
            this.Skills.MaximumSize = new System.Drawing.Size(100, 561);
            this.Skills.MinimumSize = new System.Drawing.Size(100, 561);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(100, 561);
            this.Skills.TabIndex = 7;
            this.Skills.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(697, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "+ лабы за клик";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Прогресс выполнения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LabaProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Visualka);
            this.Controls.Add(this.Skills);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Visualka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar LabaProgress;
        private System.Windows.Forms.Splitter Skills;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

