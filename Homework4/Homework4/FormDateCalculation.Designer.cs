namespace Homework4
{
    partial class FormDateCalculation
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
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.radioButtonMonths = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYears.Location = new System.Drawing.Point(429, 160);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(52, 22);
            this.radioButtonYears.TabIndex = 0;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Лет";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            this.radioButtonYears.CheckedChanged += new System.EventHandler(this.RadioButtonYears_CheckedChanged);
            // 
            // radioButtonMonths
            // 
            this.radioButtonMonths.AutoSize = true;
            this.radioButtonMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMonths.Location = new System.Drawing.Point(429, 183);
            this.radioButtonMonths.Name = "radioButtonMonths";
            this.radioButtonMonths.Size = new System.Drawing.Size(87, 22);
            this.radioButtonMonths.TabIndex = 1;
            this.radioButtonMonths.TabStop = true;
            this.radioButtonMonths.Text = "Месяцев";
            this.radioButtonMonths.UseVisualStyleBackColor = true;
            this.radioButtonMonths.CheckedChanged += new System.EventHandler(this.RadioButtonMonths_CheckedChanged);
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDays.Location = new System.Drawing.Point(429, 207);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(62, 22);
            this.radioButtonDays.TabIndex = 2;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Дней";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            this.radioButtonDays.CheckedChanged += new System.EventHandler(this.RadioButtonDays_CheckedChanged);
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMinutes.Location = new System.Drawing.Point(429, 231);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(69, 22);
            this.radioButtonMinutes.TabIndex = 3;
            this.radioButtonMinutes.TabStop = true;
            this.radioButtonMinutes.Text = "Минут";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            this.radioButtonMinutes.CheckedChanged += new System.EventHandler(this.RadioButtonMinutes_CheckedChanged);
            // 
            // radioButtonSeconds
            // 
            this.radioButtonSeconds.AutoSize = true;
            this.radioButtonSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSeconds.Location = new System.Drawing.Point(429, 255);
            this.radioButtonSeconds.Name = "radioButtonSeconds";
            this.radioButtonSeconds.Size = new System.Drawing.Size(77, 22);
            this.radioButtonSeconds.TabIndex = 4;
            this.radioButtonSeconds.TabStop = true;
            this.radioButtonSeconds.Text = "Секунд";
            this.radioButtonSeconds.UseVisualStyleBackColor = true;
            this.radioButtonSeconds.CheckedChanged += new System.EventHandler(this.RadioButtonSeconds_CheckedChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(198, 74);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(151, 26);
            this.textBoxDate.TabIndex = 5;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(96, 26);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(357, 18);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Введите необходимую дату в формате гггг.мм.дд";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 160);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(223, 18);
            this.label.TabIndex = 7;
            this.label.Text = "До выбранной даты осталось:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.DarkRed;
            this.labelResult.Location = new System.Drawing.Point(246, 160);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 8;
            // 
            // FormDateCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 310);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.radioButtonSeconds);
            this.Controls.Add(this.radioButtonMinutes);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.radioButtonMonths);
            this.Controls.Add(this.radioButtonYears);
            this.Name = "FormDateCalculation";
            this.Text = "Вычисление даты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.RadioButton radioButtonMonths;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonMinutes;
        private System.Windows.Forms.RadioButton radioButtonSeconds;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelResult;
    }
}

