namespace Lab_4
{
    partial class AlarmControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.activStatusChkBox = new System.Windows.Forms.CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.periodicityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLabel.Location = new System.Drawing.Point(14, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(117, 42);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "20:24";
            // 
            // activStatusChkBox
            // 
            this.activStatusChkBox.AutoSize = true;
            this.activStatusChkBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activStatusChkBox.Location = new System.Drawing.Point(271, 35);
            this.activStatusChkBox.Name = "activStatusChkBox";
            this.activStatusChkBox.Size = new System.Drawing.Size(92, 20);
            this.activStatusChkBox.TabIndex = 1;
            this.activStatusChkBox.Text = "активный";
            this.activStatusChkBox.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(31, 85);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 26);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // periodicityLabel
            // 
            this.periodicityLabel.AutoSize = true;
            this.periodicityLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.periodicityLabel.Location = new System.Drawing.Point(214, 68);
            this.periodicityLabel.Name = "periodicityLabel";
            this.periodicityLabel.Size = new System.Drawing.Size(113, 16);
            this.periodicityLabel.TabIndex = 3;
            this.periodicityLabel.Text = "Периодичность:";
            // 
            // AlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.periodicityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.activStatusChkBox);
            this.Controls.Add(this.timeLabel);
            this.Name = "AlarmControl";
            this.Size = new System.Drawing.Size(388, 163);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.CheckBox activStatusChkBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label periodicityLabel;
    }
}
