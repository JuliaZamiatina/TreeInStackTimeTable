namespace RGR
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeekChoiseList = new System.Windows.Forms.ListBox();
            this.WeekChoiceLabel = new System.Windows.Forms.Label();
            this.LessonChoiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.LessonChoiceLabele = new System.Windows.Forms.Label();
            this.AddLessonButton = new System.Windows.Forms.Button();
            this.NameChoiceBox = new System.Windows.Forms.TextBox();
            this.NameChoiceLabel = new System.Windows.Forms.Label();
            this.TheFirstChoice = new System.Windows.Forms.Label();
            this.AddingButton = new System.Windows.Forms.Button();
            this.DayLookingButton = new System.Windows.Forms.Button();
            this.WeekLookingButton = new System.Windows.Forms.Button();
            this.AllDeletingButton = new System.Windows.Forms.Button();
            this.LessonLookingButton = new System.Windows.Forms.Button();
            this.CountingButton = new System.Windows.Forms.Button();
            this.AddLessonLabel = new System.Windows.Forms.Label();
            this.SpecificLessonLookingLabel = new System.Windows.Forms.Label();
            this.SpecificLessonLookingButton = new System.Windows.Forms.Button();
            this.DayLookingLabel = new System.Windows.Forms.Label();
            this.CurrentDayLookingButton = new System.Windows.Forms.Button();
            this.DeleteLastButton = new System.Windows.Forms.Button();
            this.GroupChoiseList = new System.Windows.Forms.ListBox();
            this.GroupChoiseLabel = new System.Windows.Forms.Label();
            this.CountingLabel = new System.Windows.Forms.Label();
            this.GroupCountingButton = new System.Windows.Forms.Button();
            this.CurrentWeekLookingButton = new System.Windows.Forms.Button();
            this.LastLessonDeletingButton = new System.Windows.Forms.Button();
            this.AllTimeTableViewButton = new System.Windows.Forms.Button();
            this.AllTimeTableViewLabel = new System.Windows.Forms.Label();
            this.ViewLabel = new System.Windows.Forms.Label();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LessonChoiceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekChoiseList
            // 
            this.WeekChoiseList.FormattingEnabled = true;
            this.WeekChoiseList.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.WeekChoiseList.Location = new System.Drawing.Point(166, 76);
            this.WeekChoiseList.Name = "WeekChoiseList";
            this.WeekChoiseList.Size = new System.Drawing.Size(120, 95);
            this.WeekChoiseList.TabIndex = 1;
            this.WeekChoiseList.Visible = false;
            // 
            // WeekChoiceLabel
            // 
            this.WeekChoiceLabel.AutoSize = true;
            this.WeekChoiceLabel.Location = new System.Drawing.Point(163, 51);
            this.WeekChoiceLabel.Name = "WeekChoiceLabel";
            this.WeekChoiceLabel.Size = new System.Drawing.Size(123, 13);
            this.WeekChoiceLabel.TabIndex = 2;
            this.WeekChoiceLabel.Text = "Выберите день недели";
            this.WeekChoiceLabel.Visible = false;
            // 
            // LessonChoiceUpDown
            // 
            this.LessonChoiceUpDown.Location = new System.Drawing.Point(343, 76);
            this.LessonChoiceUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.LessonChoiceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LessonChoiceUpDown.Name = "LessonChoiceUpDown";
            this.LessonChoiceUpDown.Size = new System.Drawing.Size(120, 20);
            this.LessonChoiceUpDown.TabIndex = 3;
            this.LessonChoiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LessonChoiceUpDown.Visible = false;
            // 
            // LessonChoiceLabele
            // 
            this.LessonChoiceLabele.AutoSize = true;
            this.LessonChoiceLabele.Location = new System.Drawing.Point(342, 51);
            this.LessonChoiceLabele.Name = "LessonChoiceLabele";
            this.LessonChoiceLabele.Size = new System.Drawing.Size(121, 13);
            this.LessonChoiceLabele.TabIndex = 4;
            this.LessonChoiceLabele.Text = "Выберите номер пары";
            this.LessonChoiceLabele.Visible = false;
            // 
            // AddLessonButton
            // 
            this.AddLessonButton.Location = new System.Drawing.Point(328, 230);
            this.AddLessonButton.Name = "AddLessonButton";
            this.AddLessonButton.Size = new System.Drawing.Size(121, 23);
            this.AddLessonButton.TabIndex = 5;
            this.AddLessonButton.Text = "Добавить пару";
            this.AddLessonButton.UseVisualStyleBackColor = true;
            this.AddLessonButton.Visible = false;
            this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
            // 
            // NameChoiceBox
            // 
            this.NameChoiceBox.Location = new System.Drawing.Point(9, 233);
            this.NameChoiceBox.Name = "NameChoiceBox";
            this.NameChoiceBox.Size = new System.Drawing.Size(190, 20);
            this.NameChoiceBox.TabIndex = 6;
            this.NameChoiceBox.Visible = false;
            // 
            // NameChoiceLabel
            // 
            this.NameChoiceLabel.AutoSize = true;
            this.NameChoiceLabel.Location = new System.Drawing.Point(6, 208);
            this.NameChoiceLabel.Name = "NameChoiceLabel";
            this.NameChoiceLabel.Size = new System.Drawing.Size(129, 13);
            this.NameChoiceLabel.TabIndex = 7;
            this.NameChoiceLabel.Text = "Введите название пары";
            this.NameChoiceLabel.Visible = false;
            // 
            // TheFirstChoice
            // 
            this.TheFirstChoice.AutoSize = true;
            this.TheFirstChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheFirstChoice.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheFirstChoice.Location = new System.Drawing.Point(147, 9);
            this.TheFirstChoice.Name = "TheFirstChoice";
            this.TheFirstChoice.Size = new System.Drawing.Size(239, 27);
            this.TheFirstChoice.TabIndex = 9;
            this.TheFirstChoice.Text = "Что вы хотите сделать?";
            // 
            // AddingButton
            // 
            this.AddingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingButton.Location = new System.Drawing.Point(117, 98);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(120, 49);
            this.AddingButton.TabIndex = 10;
            this.AddingButton.Text = "Добавить пару";
            this.AddingButton.UseVisualStyleBackColor = true;
            this.AddingButton.Click += new System.EventHandler(this.AddingButton_Click);
            // 
            // DayLookingButton
            // 
            this.DayLookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayLookingButton.Location = new System.Drawing.Point(193, 153);
            this.DayLookingButton.Name = "DayLookingButton";
            this.DayLookingButton.Size = new System.Drawing.Size(120, 49);
            this.DayLookingButton.TabIndex = 12;
            this.DayLookingButton.Text = "Посмотреть расписание на день";
            this.DayLookingButton.UseVisualStyleBackColor = true;
            this.DayLookingButton.Click += new System.EventHandler(this.DayLookingButton_Click);
            // 
            // WeekLookingButton
            // 
            this.WeekLookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekLookingButton.Location = new System.Drawing.Point(345, 152);
            this.WeekLookingButton.Name = "WeekLookingButton";
            this.WeekLookingButton.Size = new System.Drawing.Size(120, 49);
            this.WeekLookingButton.TabIndex = 13;
            this.WeekLookingButton.Text = "Посмотреть расписание на неделю";
            this.WeekLookingButton.UseVisualStyleBackColor = true;
            this.WeekLookingButton.Click += new System.EventHandler(this.WeekLookingButton_Click);
            // 
            // AllDeletingButton
            // 
            this.AllDeletingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDeletingButton.Location = new System.Drawing.Point(269, 98);
            this.AllDeletingButton.Name = "AllDeletingButton";
            this.AllDeletingButton.Size = new System.Drawing.Size(120, 49);
            this.AllDeletingButton.TabIndex = 14;
            this.AllDeletingButton.Text = "Очистить расписание";
            this.AllDeletingButton.UseVisualStyleBackColor = true;
            this.AllDeletingButton.Click += new System.EventHandler(this.AllDeletingButton_Click);
            // 
            // LessonLookingButton
            // 
            this.LessonLookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLookingButton.Location = new System.Drawing.Point(40, 153);
            this.LessonLookingButton.Name = "LessonLookingButton";
            this.LessonLookingButton.Size = new System.Drawing.Size(120, 49);
            this.LessonLookingButton.TabIndex = 15;
            this.LessonLookingButton.Text = "Посмотреть конкретную пару";
            this.LessonLookingButton.UseVisualStyleBackColor = true;
            this.LessonLookingButton.Click += new System.EventHandler(this.LessonLookingButton_Click);
            // 
            // CountingButton
            // 
            this.CountingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountingButton.Location = new System.Drawing.Point(193, 43);
            this.CountingButton.Name = "CountingButton";
            this.CountingButton.Size = new System.Drawing.Size(120, 49);
            this.CountingButton.TabIndex = 16;
            this.CountingButton.Text = "Узнать колличество пар на неделе";
            this.CountingButton.UseVisualStyleBackColor = true;
            this.CountingButton.Click += new System.EventHandler(this.CountingButton_Click);
            // 
            // AddLessonLabel
            // 
            this.AddLessonLabel.AutoSize = true;
            this.AddLessonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddLessonLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLessonLabel.Location = new System.Drawing.Point(175, 9);
            this.AddLessonLabel.Name = "AddLessonLabel";
            this.AddLessonLabel.Size = new System.Drawing.Size(155, 27);
            this.AddLessonLabel.TabIndex = 17;
            this.AddLessonLabel.Text = "Добавить пару:";
            this.AddLessonLabel.Visible = false;
            // 
            // SpecificLessonLookingLabel
            // 
            this.SpecificLessonLookingLabel.AutoSize = true;
            this.SpecificLessonLookingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecificLessonLookingLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecificLessonLookingLabel.Location = new System.Drawing.Point(117, 9);
            this.SpecificLessonLookingLabel.Name = "SpecificLessonLookingLabel";
            this.SpecificLessonLookingLabel.Size = new System.Drawing.Size(289, 27);
            this.SpecificLessonLookingLabel.TabIndex = 18;
            this.SpecificLessonLookingLabel.Text = "Посмотреть конкретную пару:";
            this.SpecificLessonLookingLabel.Visible = false;
            // 
            // SpecificLessonLookingButton
            // 
            this.SpecificLessonLookingButton.Location = new System.Drawing.Point(9, 224);
            this.SpecificLessonLookingButton.Name = "SpecificLessonLookingButton";
            this.SpecificLessonLookingButton.Size = new System.Drawing.Size(121, 23);
            this.SpecificLessonLookingButton.TabIndex = 19;
            this.SpecificLessonLookingButton.Text = "Посмотреть пару";
            this.SpecificLessonLookingButton.UseVisualStyleBackColor = true;
            this.SpecificLessonLookingButton.Visible = false;
            this.SpecificLessonLookingButton.Click += new System.EventHandler(this.SpecificLessonLookingButton_Click);
            // 
            // DayLookingLabel
            // 
            this.DayLookingLabel.AutoSize = true;
            this.DayLookingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DayLookingLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayLookingLabel.Location = new System.Drawing.Point(117, 9);
            this.DayLookingLabel.Name = "DayLookingLabel";
            this.DayLookingLabel.Size = new System.Drawing.Size(306, 27);
            this.DayLookingLabel.TabIndex = 20;
            this.DayLookingLabel.Text = "Посмотреть расписание на день:";
            this.DayLookingLabel.Visible = false;
            // 
            // CurrentDayLookingButton
            // 
            this.CurrentDayLookingButton.Location = new System.Drawing.Point(165, 282);
            this.CurrentDayLookingButton.Name = "CurrentDayLookingButton";
            this.CurrentDayLookingButton.Size = new System.Drawing.Size(121, 38);
            this.CurrentDayLookingButton.TabIndex = 21;
            this.CurrentDayLookingButton.Text = "Посмотреть расписание";
            this.CurrentDayLookingButton.UseVisualStyleBackColor = true;
            this.CurrentDayLookingButton.Visible = false;
            this.CurrentDayLookingButton.Click += new System.EventHandler(this.CurrentDayLookingButton_Click);
            // 
            // DeleteLastButton
            // 
            this.DeleteLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLastButton.Location = new System.Drawing.Point(193, 208);
            this.DeleteLastButton.Name = "DeleteLastButton";
            this.DeleteLastButton.Size = new System.Drawing.Size(120, 49);
            this.DeleteLastButton.TabIndex = 22;
            this.DeleteLastButton.Text = "Удалить последнее расписание";
            this.DeleteLastButton.UseVisualStyleBackColor = true;
            this.DeleteLastButton.Click += new System.EventHandler(this.DeleteLastButton_Click);
            // 
            // GroupChoiseList
            // 
            this.GroupChoiseList.FormattingEnabled = true;
            this.GroupChoiseList.Items.AddRange(new object[] {
            "АБ-320",
            "АБ-321",
            "АБс-323"});
            this.GroupChoiseList.Location = new System.Drawing.Point(15, 76);
            this.GroupChoiseList.Name = "GroupChoiseList";
            this.GroupChoiseList.Size = new System.Drawing.Size(120, 95);
            this.GroupChoiseList.TabIndex = 1;
            this.GroupChoiseList.Visible = false;
            // 
            // GroupChoiseLabel
            // 
            this.GroupChoiseLabel.AutoSize = true;
            this.GroupChoiseLabel.Location = new System.Drawing.Point(12, 50);
            this.GroupChoiseLabel.Name = "GroupChoiseLabel";
            this.GroupChoiseLabel.Size = new System.Drawing.Size(93, 13);
            this.GroupChoiseLabel.TabIndex = 2;
            this.GroupChoiseLabel.Text = "Выберите группу";
            this.GroupChoiseLabel.Visible = false;
            // 
            // CountingLabel
            // 
            this.CountingLabel.AutoSize = true;
            this.CountingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountingLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountingLabel.Location = new System.Drawing.Point(117, 9);
            this.CountingLabel.Name = "CountingLabel";
            this.CountingLabel.Size = new System.Drawing.Size(282, 27);
            this.CountingLabel.TabIndex = 20;
            this.CountingLabel.Text = "Посмотреть колличество пар:";
            this.CountingLabel.Visible = false;
            // 
            // GroupCountingButton
            // 
            this.GroupCountingButton.Location = new System.Drawing.Point(12, 193);
            this.GroupCountingButton.Name = "GroupCountingButton";
            this.GroupCountingButton.Size = new System.Drawing.Size(96, 25);
            this.GroupCountingButton.TabIndex = 21;
            this.GroupCountingButton.Text = "Узнать";
            this.GroupCountingButton.UseVisualStyleBackColor = true;
            this.GroupCountingButton.Visible = false;
            this.GroupCountingButton.Click += new System.EventHandler(this.GroupCountingButton_Click);
            // 
            // CurrentWeekLookingButton
            // 
            this.CurrentWeekLookingButton.Location = new System.Drawing.Point(147, 76);
            this.CurrentWeekLookingButton.Name = "CurrentWeekLookingButton";
            this.CurrentWeekLookingButton.Size = new System.Drawing.Size(96, 25);
            this.CurrentWeekLookingButton.TabIndex = 21;
            this.CurrentWeekLookingButton.Text = "Узнать";
            this.CurrentWeekLookingButton.UseVisualStyleBackColor = true;
            this.CurrentWeekLookingButton.Visible = false;
            this.CurrentWeekLookingButton.Click += new System.EventHandler(this.CurrentWeekLookingButton_Click);
            // 
            // LastLessonDeletingButton
            // 
            this.LastLessonDeletingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastLessonDeletingButton.Location = new System.Drawing.Point(40, 208);
            this.LastLessonDeletingButton.Name = "LastLessonDeletingButton";
            this.LastLessonDeletingButton.Size = new System.Drawing.Size(120, 49);
            this.LastLessonDeletingButton.TabIndex = 22;
            this.LastLessonDeletingButton.Text = "Удалить последнюю пару";
            this.LastLessonDeletingButton.UseVisualStyleBackColor = true;
            this.LastLessonDeletingButton.Click += new System.EventHandler(this.LastLessonDeletingButton_Click);
            // 
            // AllTimeTableViewButton
            // 
            this.AllTimeTableViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllTimeTableViewButton.Location = new System.Drawing.Point(343, 207);
            this.AllTimeTableViewButton.Name = "AllTimeTableViewButton";
            this.AllTimeTableViewButton.Size = new System.Drawing.Size(120, 49);
            this.AllTimeTableViewButton.TabIndex = 22;
            this.AllTimeTableViewButton.Text = "Посмотреть все расписание";
            this.AllTimeTableViewButton.UseVisualStyleBackColor = true;
            this.AllTimeTableViewButton.Click += new System.EventHandler(this.AllTimeTableViewButton_Click);
            // 
            // AllTimeTableViewLabel
            // 
            this.AllTimeTableViewLabel.AutoSize = true;
            this.AllTimeTableViewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllTimeTableViewLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllTimeTableViewLabel.Location = new System.Drawing.Point(117, 9);
            this.AllTimeTableViewLabel.Name = "AllTimeTableViewLabel";
            this.AllTimeTableViewLabel.Size = new System.Drawing.Size(266, 27);
            this.AllTimeTableViewLabel.TabIndex = 20;
            this.AllTimeTableViewLabel.Text = "Посмотреть все расписание:";
            this.AllTimeTableViewLabel.Visible = false;
            // 
            // ViewLabel
            // 
            this.ViewLabel.AutoSize = true;
            this.ViewLabel.Location = new System.Drawing.Point(220, 166);
            this.ViewLabel.Name = "ViewLabel";
            this.ViewLabel.Size = new System.Drawing.Size(105, 13);
            this.ViewLabel.TabIndex = 23;
            this.ViewLabel.Text = "Общее расписание";
            this.ViewLabel.Visible = false;
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(124, 161);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 24;
            this.LeftButton.Text = "Левее";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Visible = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(339, 160);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 24;
            this.RightButton.Text = "Правее";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Visible = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(233, 220);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 25;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Visible = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 423);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.ViewLabel);
            this.Controls.Add(this.LastLessonDeletingButton);
            this.Controls.Add(this.AllTimeTableViewButton);
            this.Controls.Add(this.DeleteLastButton);
            this.Controls.Add(this.CurrentWeekLookingButton);
            this.Controls.Add(this.GroupCountingButton);
            this.Controls.Add(this.CurrentDayLookingButton);
            this.Controls.Add(this.AllTimeTableViewLabel);
            this.Controls.Add(this.CountingLabel);
            this.Controls.Add(this.DayLookingLabel);
            this.Controls.Add(this.SpecificLessonLookingButton);
            this.Controls.Add(this.SpecificLessonLookingLabel);
            this.Controls.Add(this.AddLessonLabel);
            this.Controls.Add(this.CountingButton);
            this.Controls.Add(this.LessonLookingButton);
            this.Controls.Add(this.AllDeletingButton);
            this.Controls.Add(this.WeekLookingButton);
            this.Controls.Add(this.DayLookingButton);
            this.Controls.Add(this.AddingButton);
            this.Controls.Add(this.TheFirstChoice);
            this.Controls.Add(this.NameChoiceLabel);
            this.Controls.Add(this.NameChoiceBox);
            this.Controls.Add(this.AddLessonButton);
            this.Controls.Add(this.LessonChoiceLabele);
            this.Controls.Add(this.LessonChoiceUpDown);
            this.Controls.Add(this.GroupChoiseLabel);
            this.Controls.Add(this.WeekChoiceLabel);
            this.Controls.Add(this.GroupChoiseList);
            this.Controls.Add(this.WeekChoiseList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LessonChoiceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WeekChoiseList;
        private System.Windows.Forms.Label WeekChoiceLabel;
        private System.Windows.Forms.NumericUpDown LessonChoiceUpDown;
        private System.Windows.Forms.Label LessonChoiceLabele;
        private System.Windows.Forms.Button AddLessonButton;
        private System.Windows.Forms.TextBox NameChoiceBox;
        private System.Windows.Forms.Label NameChoiceLabel;
        private System.Windows.Forms.Label TheFirstChoice;
        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.Button DayLookingButton;
        private System.Windows.Forms.Button WeekLookingButton;
        private System.Windows.Forms.Button AllDeletingButton;
        private System.Windows.Forms.Button LessonLookingButton;
        private System.Windows.Forms.Button CountingButton;
        private System.Windows.Forms.Label AddLessonLabel;
        private System.Windows.Forms.Label SpecificLessonLookingLabel;
        private System.Windows.Forms.Button SpecificLessonLookingButton;
        private System.Windows.Forms.Label DayLookingLabel;
        private System.Windows.Forms.Button CurrentDayLookingButton;
        private System.Windows.Forms.Button DeleteLastButton;
        private System.Windows.Forms.ListBox GroupChoiseList;
        private System.Windows.Forms.Label GroupChoiseLabel;
        private System.Windows.Forms.Label CountingLabel;
        private System.Windows.Forms.Button GroupCountingButton;
        private System.Windows.Forms.Button CurrentWeekLookingButton;
        private System.Windows.Forms.Button LastLessonDeletingButton;
        private System.Windows.Forms.Button AllTimeTableViewButton;
        private System.Windows.Forms.Label AllTimeTableViewLabel;
        private System.Windows.Forms.Label ViewLabel;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button ReturnButton;

    }
}

