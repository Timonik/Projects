namespace NetrikaProject.Server
{
    partial class MainServerWindow
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
            this._clientsTextBox = new System.Windows.Forms.TextBox();
            this._clientsGroupBox = new System.Windows.Forms.GroupBox();
            this._clientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _clientsTextBox
            // 
            this._clientsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._clientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientsTextBox.Location = new System.Drawing.Point(3, 16);
            this._clientsTextBox.Multiline = true;
            this._clientsTextBox.Name = "_clientsTextBox";
            this._clientsTextBox.ReadOnly = true;
            this._clientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._clientsTextBox.Size = new System.Drawing.Size(206, 201);
            this._clientsTextBox.TabIndex = 0;
            // 
            // _clientsGroupBox
            // 
            this._clientsGroupBox.Controls.Add(this._clientsTextBox);
            this._clientsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientsGroupBox.Location = new System.Drawing.Point(0, 0);
            this._clientsGroupBox.Name = "_clientsGroupBox";
            this._clientsGroupBox.Size = new System.Drawing.Size(212, 220);
            this._clientsGroupBox.TabIndex = 2;
            this._clientsGroupBox.TabStop = false;
            this._clientsGroupBox.Text = "Список подлюченных клиентов";
            // 
            // MainServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 220);
            this.Controls.Add(this._clientsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainServerWindow";
            this.Text = "Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainServerWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainServerWindow_Load);
            this._clientsGroupBox.ResumeLayout(false);
            this._clientsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _clientsTextBox;
        private System.Windows.Forms.GroupBox _clientsGroupBox;
    }
}

