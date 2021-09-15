
namespace PRV_Sorts
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompareButton = new System.Windows.Forms.Button();
            this.ElemsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BubbleTimeLabel = new System.Windows.Forms.Label();
            this.QuickTimeLabel = new System.Windows.Forms.Label();
            this.GnomeTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.shellProgress = new System.Windows.Forms.ProgressBar();
            this.bubbleProgressBar = new System.Windows.Forms.ProgressBar();
            this.quickProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "🧼Bubble sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(295, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "⚡Quick sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(559, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "🍺Gnome sort";
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(268, 239);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(226, 33);
            this.CompareButton.TabIndex = 4;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // ElemsComboBox
            // 
            this.ElemsComboBox.FormattingEnabled = true;
            this.ElemsComboBox.Location = new System.Drawing.Point(13, 44);
            this.ElemsComboBox.Name = "ElemsComboBox";
            this.ElemsComboBox.Size = new System.Drawing.Size(185, 28);
            this.ElemsComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elems count";
            // 
            // BubbleTimeLabel
            // 
            this.BubbleTimeLabel.AutoSize = true;
            this.BubbleTimeLabel.Location = new System.Drawing.Point(28, 140);
            this.BubbleTimeLabel.Name = "BubbleTimeLabel";
            this.BubbleTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.BubbleTimeLabel.TabIndex = 11;
            this.BubbleTimeLabel.Text = "time: ";
            // 
            // QuickTimeLabel
            // 
            this.QuickTimeLabel.AutoSize = true;
            this.QuickTimeLabel.Location = new System.Drawing.Point(297, 152);
            this.QuickTimeLabel.Name = "QuickTimeLabel";
            this.QuickTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.QuickTimeLabel.TabIndex = 12;
            this.QuickTimeLabel.Text = "time: ";
            // 
            // GnomeTimeLabel
            // 
            this.GnomeTimeLabel.AutoSize = true;
            this.GnomeTimeLabel.Location = new System.Drawing.Point(571, 152);
            this.GnomeTimeLabel.Name = "GnomeTimeLabel";
            this.GnomeTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.GnomeTimeLabel.TabIndex = 13;
            this.GnomeTimeLabel.Text = "time: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shellProgress
            // 
            this.shellProgress.Location = new System.Drawing.Point(569, 200);
            this.shellProgress.Name = "shellProgress";
            this.shellProgress.Size = new System.Drawing.Size(180, 23);
            this.shellProgress.TabIndex = 14;
            // 
            // bubbleProgressBar
            // 
            this.bubbleProgressBar.Location = new System.Drawing.Point(23, 200);
            this.bubbleProgressBar.Name = "bubbleProgressBar";
            this.bubbleProgressBar.Size = new System.Drawing.Size(180, 23);
            this.bubbleProgressBar.TabIndex = 15;
            // 
            // quickProgressBar
            // 
            this.quickProgressBar.Location = new System.Drawing.Point(301, 200);
            this.quickProgressBar.Name = "quickProgressBar";
            this.quickProgressBar.Size = new System.Drawing.Size(180, 23);
            this.quickProgressBar.TabIndex = 16;
            this.quickProgressBar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 283);
            this.Controls.Add(this.quickProgressBar);
            this.Controls.Add(this.bubbleProgressBar);
            this.Controls.Add(this.shellProgress);
            this.Controls.Add(this.GnomeTimeLabel);
            this.Controls.Add(this.QuickTimeLabel);
            this.Controls.Add(this.BubbleTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ElemsComboBox);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.ComboBox ElemsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BubbleTimeLabel;
        private System.Windows.Forms.Label QuickTimeLabel;
        private System.Windows.Forms.Label GnomeTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar shellProgress;
        private System.Windows.Forms.ProgressBar bubbleProgressBar;
        private System.Windows.Forms.ProgressBar quickProgressBar;
    }
}

