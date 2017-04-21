namespace NetrikaProject.Client
{
    partial class MainClientWindow
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
            this._sendButton = new System.Windows.Forms.Button();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._familyNameTextBox = new System.Windows.Forms.TextBox();
            this._givenNameTextBox = new System.Windows.Forms.TextBox();
            this._idPatientMISTextBox = new System.Windows.Forms.TextBox();
            this._birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._sexComboBox = new System.Windows.Forms.ComboBox();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _sendButton
            // 
            this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sendButton.Location = new System.Drawing.Point(122, 306);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(137, 23);
            this._sendButton.TabIndex = 0;
            this._sendButton.Text = "Записать пациента";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._sexComboBox);
            this._groupBox.Controls.Add(this._birthDayDateTimePicker);
            this._groupBox.Controls.Add(this._idPatientMISTextBox);
            this._groupBox.Controls.Add(this._givenNameTextBox);
            this._groupBox.Controls.Add(this._familyNameTextBox);
            this._groupBox.Controls.Add(this.label5);
            this._groupBox.Controls.Add(this.label4);
            this._groupBox.Controls.Add(this.label3);
            this._groupBox.Controls.Add(this.label2);
            this._groupBox.Controls.Add(this.label1);
            this._groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._groupBox.Location = new System.Drawing.Point(0, 0);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(382, 293);
            this._groupBox.TabIndex = 1;
            this._groupBox.TabStop = false;
            this._groupBox.Text = "Обязательные поля";
            // 
            // _exitButton
            // 
            this._exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._exitButton.Location = new System.Drawing.Point(285, 306);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(75, 23);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Выход";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this._exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия пациента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя пациента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол пациента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Идентификатор МИС:";
            // 
            // _familyNameTextBox
            // 
            this._familyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._familyNameTextBox.Location = new System.Drawing.Point(182, 35);
            this._familyNameTextBox.Name = "_familyNameTextBox";
            this._familyNameTextBox.Size = new System.Drawing.Size(188, 20);
            this._familyNameTextBox.TabIndex = 5;
            // 
            // _givenNameTextBox
            // 
            this._givenNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._givenNameTextBox.Location = new System.Drawing.Point(182, 68);
            this._givenNameTextBox.Name = "_givenNameTextBox";
            this._givenNameTextBox.Size = new System.Drawing.Size(188, 20);
            this._givenNameTextBox.TabIndex = 6;
            // 
            // _idPatientMISTextBox
            // 
            this._idPatientMISTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._idPatientMISTextBox.Location = new System.Drawing.Point(183, 171);
            this._idPatientMISTextBox.Name = "_idPatientMISTextBox";
            this._idPatientMISTextBox.Size = new System.Drawing.Size(188, 20);
            this._idPatientMISTextBox.TabIndex = 7;
            // 
            // _birthDayDateTimePicker
            // 
            this._birthDayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._birthDayDateTimePicker.Location = new System.Drawing.Point(183, 100);
            this._birthDayDateTimePicker.Name = "_birthDayDateTimePicker";
            this._birthDayDateTimePicker.Size = new System.Drawing.Size(188, 20);
            this._birthDayDateTimePicker.TabIndex = 8;
            // 
            // _sexComboBox
            // 
            this._sexComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sexComboBox.FormattingEnabled = true;
            this._sexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this._sexComboBox.Location = new System.Drawing.Point(183, 137);
            this._sexComboBox.Name = "_sexComboBox";
            this._sexComboBox.Size = new System.Drawing.Size(188, 21);
            this._sexComboBox.TabIndex = 9;
            // 
            // MainClientWindow
            // 
            this.AcceptButton = this._sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 352);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainClientWindow";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.MainClientWindow_Load);
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.ComboBox _sexComboBox;
        private System.Windows.Forms.DateTimePicker _birthDayDateTimePicker;
        private System.Windows.Forms.TextBox _idPatientMISTextBox;
        private System.Windows.Forms.TextBox _givenNameTextBox;
        private System.Windows.Forms.TextBox _familyNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

