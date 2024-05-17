namespace Lab_4
{
    partial class CreateAlarmForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.timeField = new System.Windows.Forms.DateTimePicker();
            this.headerlabel = new System.Windows.Forms.Label();
            this.mondayChBox = new System.Windows.Forms.CheckBox();
            this.tuesdayChBox = new System.Windows.Forms.CheckBox();
            this.wednesdayChBox = new System.Windows.Forms.CheckBox();
            this.thursdayChBox = new System.Windows.Forms.CheckBox();
            this.fridayChBox = new System.Windows.Forms.CheckBox();
            this.saturdayChBox = new System.Windows.Forms.CheckBox();
            this.sundayChBox = new System.Windows.Forms.CheckBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.periodLabel);
            this.panel1.Controls.Add(this.sundayChBox);
            this.panel1.Controls.Add(this.saturdayChBox);
            this.panel1.Controls.Add(this.fridayChBox);
            this.panel1.Controls.Add(this.thursdayChBox);
            this.panel1.Controls.Add(this.wednesdayChBox);
            this.panel1.Controls.Add(this.tuesdayChBox);
            this.panel1.Controls.Add(this.mondayChBox);
            this.panel1.Controls.Add(this.headerlabel);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.timeField);
            this.panel1.Location = new System.Drawing.Point(178, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 540);
            this.panel1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(181, 456);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 38);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.nameField.Location = new System.Drawing.Point(123, 185);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(219, 24);
            this.nameField.TabIndex = 1;
            // 
            // timeField
            // 
            this.timeField.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeField.Location = new System.Drawing.Point(132, 133);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(200, 22);
            this.timeField.TabIndex = 0;
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.headerlabel.Location = new System.Drawing.Point(101, 52);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(275, 31);
            this.headerlabel.TabIndex = 4;
            this.headerlabel.Text = "Добавить будильник";
            // 
            // mondayChBox
            // 
            this.mondayChBox.AutoSize = true;
            this.mondayChBox.Location = new System.Drawing.Point(105, 302);
            this.mondayChBox.Name = "mondayChBox";
            this.mondayChBox.Size = new System.Drawing.Size(117, 20);
            this.mondayChBox.TabIndex = 5;
            this.mondayChBox.Text = "Понедельник";
            this.mondayChBox.UseVisualStyleBackColor = true;
            // 
            // tuesdayChBox
            // 
            this.tuesdayChBox.AutoSize = true;
            this.tuesdayChBox.Location = new System.Drawing.Point(105, 342);
            this.tuesdayChBox.Name = "tuesdayChBox";
            this.tuesdayChBox.Size = new System.Drawing.Size(84, 20);
            this.tuesdayChBox.TabIndex = 6;
            this.tuesdayChBox.Text = "Вторник";
            this.tuesdayChBox.UseVisualStyleBackColor = true;
            // 
            // wednesdayChBox
            // 
            this.wednesdayChBox.AutoSize = true;
            this.wednesdayChBox.Location = new System.Drawing.Point(105, 382);
            this.wednesdayChBox.Name = "wednesdayChBox";
            this.wednesdayChBox.Size = new System.Drawing.Size(70, 20);
            this.wednesdayChBox.TabIndex = 7;
            this.wednesdayChBox.Text = "Среда";
            this.wednesdayChBox.UseVisualStyleBackColor = true;
            // 
            // thursdayChBox
            // 
            this.thursdayChBox.AutoSize = true;
            this.thursdayChBox.Location = new System.Drawing.Point(257, 276);
            this.thursdayChBox.Name = "thursdayChBox";
            this.thursdayChBox.Size = new System.Drawing.Size(83, 20);
            this.thursdayChBox.TabIndex = 8;
            this.thursdayChBox.Text = "Четверг";
            this.thursdayChBox.UseVisualStyleBackColor = true;
            // 
            // fridayChBox
            // 
            this.fridayChBox.AutoSize = true;
            this.fridayChBox.Location = new System.Drawing.Point(257, 314);
            this.fridayChBox.Name = "fridayChBox";
            this.fridayChBox.Size = new System.Drawing.Size(85, 20);
            this.fridayChBox.TabIndex = 9;
            this.fridayChBox.Text = "Пятница";
            this.fridayChBox.UseVisualStyleBackColor = true;
            // 
            // saturdayChBox
            // 
            this.saturdayChBox.AutoSize = true;
            this.saturdayChBox.Location = new System.Drawing.Point(257, 354);
            this.saturdayChBox.Name = "saturdayChBox";
            this.saturdayChBox.Size = new System.Drawing.Size(85, 20);
            this.saturdayChBox.TabIndex = 10;
            this.saturdayChBox.Text = "Суббота";
            this.saturdayChBox.UseVisualStyleBackColor = true;
            // 
            // sundayChBox
            // 
            this.sundayChBox.AutoSize = true;
            this.sundayChBox.Location = new System.Drawing.Point(257, 395);
            this.sundayChBox.Name = "sundayChBox";
            this.sundayChBox.Size = new System.Drawing.Size(114, 20);
            this.sundayChBox.TabIndex = 11;
            this.sundayChBox.Text = "Воскресенье";
            this.sundayChBox.UseVisualStyleBackColor = true;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodLabel.Location = new System.Drawing.Point(74, 255);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(148, 20);
            this.periodLabel.TabIndex = 12;
            this.periodLabel.Text = "Периодичность:";
            // 
            // CreateAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(823, 602);
            this.Controls.Add(this.panel1);
            this.Name = "CreateAlarmForm";
            this.Text = "CreateAlarmForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.DateTimePicker timeField;
        private System.Windows.Forms.CheckBox saturdayChBox;
        private System.Windows.Forms.CheckBox fridayChBox;
        private System.Windows.Forms.CheckBox thursdayChBox;
        private System.Windows.Forms.CheckBox wednesdayChBox;
        private System.Windows.Forms.CheckBox tuesdayChBox;
        private System.Windows.Forms.CheckBox mondayChBox;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.CheckBox sundayChBox;
        private System.Windows.Forms.Label periodLabel;
    }
}