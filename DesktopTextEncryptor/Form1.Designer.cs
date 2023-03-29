namespace DesktopTextEncryptor
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
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.groupClipboard = new System.Windows.Forms.GroupBox();
            this.modeClipboardTextAndKey = new System.Windows.Forms.RadioButton();
            this.modeClipboardKeyOnly = new System.Windows.Forms.RadioButton();
            this.modeClipboardTextOnly = new System.Windows.Forms.RadioButton();
            this.groupKeyMode = new System.Windows.Forms.GroupBox();
            this.keyValue = new System.Windows.Forms.Label();
            this.groupKey = new System.Windows.Forms.GroupBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.keyModeInput = new System.Windows.Forms.RadioButton();
            this.keyModeRand = new System.Windows.Forms.RadioButton();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.modeDecrypt = new System.Windows.Forms.RadioButton();
            this.modeEncrypt = new System.Windows.Forms.RadioButton();
            this.textFirst = new System.Windows.Forms.RichTextBox();
            this.textSecond = new System.Windows.Forms.RichTextBox();
            this.convertText = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.progressCrypting = new System.Windows.Forms.ProgressBar();
            this.groupSettings.SuspendLayout();
            this.groupClipboard.SuspendLayout();
            this.groupKeyMode.SuspendLayout();
            this.groupKey.SuspendLayout();
            this.groupMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.groupClipboard);
            this.groupSettings.Controls.Add(this.groupKeyMode);
            this.groupSettings.Controls.Add(this.groupMode);
            this.groupSettings.Location = new System.Drawing.Point(560, 13);
            this.groupSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupSettings.Size = new System.Drawing.Size(230, 307);
            this.groupSettings.TabIndex = 0;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Настройки";
            // 
            // groupClipboard
            // 
            this.groupClipboard.Controls.Add(this.modeClipboardTextAndKey);
            this.groupClipboard.Controls.Add(this.modeClipboardKeyOnly);
            this.groupClipboard.Controls.Add(this.modeClipboardTextOnly);
            this.groupClipboard.Location = new System.Drawing.Point(7, 230);
            this.groupClipboard.Name = "groupClipboard";
            this.groupClipboard.Size = new System.Drawing.Size(215, 71);
            this.groupClipboard.TabIndex = 2;
            this.groupClipboard.TabStop = false;
            this.groupClipboard.Text = "Скопировать";
            // 
            // modeClipboardTextAndKey
            // 
            this.modeClipboardTextAndKey.AutoSize = true;
            this.modeClipboardTextAndKey.Location = new System.Drawing.Point(8, 47);
            this.modeClipboardTextAndKey.Name = "modeClipboardTextAndKey";
            this.modeClipboardTextAndKey.Size = new System.Drawing.Size(113, 21);
            this.modeClipboardTextAndKey.TabIndex = 2;
            this.modeClipboardTextAndKey.Text = "Текст и ключ";
            this.modeClipboardTextAndKey.UseVisualStyleBackColor = true;
            // 
            // modeClipboardKeyOnly
            // 
            this.modeClipboardKeyOnly.AutoSize = true;
            this.modeClipboardKeyOnly.Location = new System.Drawing.Point(8, 30);
            this.modeClipboardKeyOnly.Name = "modeClipboardKeyOnly";
            this.modeClipboardKeyOnly.Size = new System.Drawing.Size(110, 21);
            this.modeClipboardKeyOnly.TabIndex = 1;
            this.modeClipboardKeyOnly.Text = "Только ключ";
            this.modeClipboardKeyOnly.UseVisualStyleBackColor = true;
            // 
            // modeClipboardTextOnly
            // 
            this.modeClipboardTextOnly.AutoSize = true;
            this.modeClipboardTextOnly.Checked = true;
            this.modeClipboardTextOnly.Location = new System.Drawing.Point(8, 13);
            this.modeClipboardTextOnly.Name = "modeClipboardTextOnly";
            this.modeClipboardTextOnly.Size = new System.Drawing.Size(113, 21);
            this.modeClipboardTextOnly.TabIndex = 0;
            this.modeClipboardTextOnly.TabStop = true;
            this.modeClipboardTextOnly.Text = "Только текст";
            this.modeClipboardTextOnly.UseVisualStyleBackColor = true;
            // 
            // groupKeyMode
            // 
            this.groupKeyMode.Controls.Add(this.keyValue);
            this.groupKeyMode.Controls.Add(this.groupKey);
            this.groupKeyMode.Controls.Add(this.keyModeInput);
            this.groupKeyMode.Controls.Add(this.keyModeRand);
            this.groupKeyMode.Location = new System.Drawing.Point(7, 85);
            this.groupKeyMode.Margin = new System.Windows.Forms.Padding(4);
            this.groupKeyMode.Name = "groupKeyMode";
            this.groupKeyMode.Padding = new System.Windows.Forms.Padding(4);
            this.groupKeyMode.Size = new System.Drawing.Size(215, 143);
            this.groupKeyMode.TabIndex = 1;
            this.groupKeyMode.TabStop = false;
            this.groupKeyMode.Text = "Ключ";
            // 
            // keyValue
            // 
            this.keyValue.AutoSize = true;
            this.keyValue.Location = new System.Drawing.Point(13, 119);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(56, 17);
            this.keyValue.TabIndex = 1;
            this.keyValue.Text = "Ключ: 0";
            // 
            // groupKey
            // 
            this.groupKey.Controls.Add(this.keyInput);
            this.groupKey.Location = new System.Drawing.Point(8, 60);
            this.groupKey.Margin = new System.Windows.Forms.Padding(4);
            this.groupKey.Name = "groupKey";
            this.groupKey.Padding = new System.Windows.Forms.Padding(4);
            this.groupKey.Size = new System.Drawing.Size(200, 55);
            this.groupKey.TabIndex = 2;
            this.groupKey.TabStop = false;
            this.groupKey.Text = "Ввод ключа шифрования";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(8, 20);
            this.keyInput.Margin = new System.Windows.Forms.Padding(4);
            this.keyInput.MaxLength = 9;
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(184, 25);
            this.keyInput.TabIndex = 0;
            this.keyInput.Text = "0";
            this.keyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyInput.TextChanged += new System.EventHandler(this.keyInput_TextChanged);
            this.keyInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInput_KeyPress);
            // 
            // keyModeInput
            // 
            this.keyModeInput.AutoSize = true;
            this.keyModeInput.Checked = true;
            this.keyModeInput.Location = new System.Drawing.Point(8, 40);
            this.keyModeInput.Margin = new System.Windows.Forms.Padding(4);
            this.keyModeInput.Name = "keyModeInput";
            this.keyModeInput.Size = new System.Drawing.Size(135, 21);
            this.keyModeInput.TabIndex = 1;
            this.keyModeInput.TabStop = true;
            this.keyModeInput.Text = "Ввести вручную";
            this.keyModeInput.UseVisualStyleBackColor = true;
            this.keyModeInput.CheckedChanged += new System.EventHandler(this.keyModeInput_CheckedChanged);
            // 
            // keyModeRand
            // 
            this.keyModeRand.AutoSize = true;
            this.keyModeRand.Location = new System.Drawing.Point(8, 21);
            this.keyModeRand.Margin = new System.Windows.Forms.Padding(4);
            this.keyModeRand.Name = "keyModeRand";
            this.keyModeRand.Size = new System.Drawing.Size(127, 21);
            this.keyModeRand.TabIndex = 0;
            this.keyModeRand.Text = "Сгенерировать";
            this.keyModeRand.UseVisualStyleBackColor = true;
            this.keyModeRand.CheckedChanged += new System.EventHandler(this.keyModeRand_CheckedChanged);
            // 
            // groupMode
            // 
            this.groupMode.Controls.Add(this.modeDecrypt);
            this.groupMode.Controls.Add(this.modeEncrypt);
            this.groupMode.Location = new System.Drawing.Point(7, 15);
            this.groupMode.Margin = new System.Windows.Forms.Padding(4);
            this.groupMode.Name = "groupMode";
            this.groupMode.Padding = new System.Windows.Forms.Padding(4);
            this.groupMode.Size = new System.Drawing.Size(215, 68);
            this.groupMode.TabIndex = 0;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Режим работы";
            // 
            // modeDecrypt
            // 
            this.modeDecrypt.AutoSize = true;
            this.modeDecrypt.Location = new System.Drawing.Point(8, 40);
            this.modeDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.modeDecrypt.Name = "modeDecrypt";
            this.modeDecrypt.Size = new System.Drawing.Size(124, 21);
            this.modeDecrypt.TabIndex = 1;
            this.modeDecrypt.Text = "Расшифровать";
            this.modeDecrypt.UseVisualStyleBackColor = true;
            this.modeDecrypt.CheckedChanged += new System.EventHandler(this.modeDecrypt_CheckedChanged);
            // 
            // modeEncrypt
            // 
            this.modeEncrypt.AutoSize = true;
            this.modeEncrypt.Checked = true;
            this.modeEncrypt.Location = new System.Drawing.Point(8, 19);
            this.modeEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.modeEncrypt.Name = "modeEncrypt";
            this.modeEncrypt.Size = new System.Drawing.Size(117, 21);
            this.modeEncrypt.TabIndex = 0;
            this.modeEncrypt.TabStop = true;
            this.modeEncrypt.Text = "Зашифровать";
            this.modeEncrypt.UseVisualStyleBackColor = true;
            this.modeEncrypt.CheckedChanged += new System.EventHandler(this.modeEncrypt_CheckedChanged);
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(12, 12);
            this.textFirst.Margin = new System.Windows.Forms.Padding(4);
            this.textFirst.MaxLength = 16384;
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(539, 122);
            this.textFirst.TabIndex = 1;
            this.textFirst.Text = "";
            this.textFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFirst_KeyPress);
            // 
            // textSecond
            // 
            this.textSecond.Location = new System.Drawing.Point(13, 187);
            this.textSecond.Margin = new System.Windows.Forms.Padding(4);
            this.textSecond.MaxLength = 100001;
            this.textSecond.Name = "textSecond";
            this.textSecond.ReadOnly = true;
            this.textSecond.Size = new System.Drawing.Size(539, 109);
            this.textSecond.TabIndex = 2;
            this.textSecond.Text = "";
            // 
            // convertText
            // 
            this.convertText.Location = new System.Drawing.Point(12, 142);
            this.convertText.Margin = new System.Windows.Forms.Padding(4);
            this.convertText.Name = "convertText";
            this.convertText.Size = new System.Drawing.Size(260, 37);
            this.convertText.TabIndex = 3;
            this.convertText.Text = "Зашифровать";
            this.convertText.UseVisualStyleBackColor = true;
            this.convertText.Click += new System.EventHandler(this.convertText_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(291, 142);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(260, 37);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Скопировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // progressCrypting
            // 
            this.progressCrypting.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressCrypting.Location = new System.Drawing.Point(12, 302);
            this.progressCrypting.Name = "progressCrypting";
            this.progressCrypting.Size = new System.Drawing.Size(539, 17);
            this.progressCrypting.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressCrypting.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 331);
            this.Controls.Add(this.progressCrypting);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.convertText);
            this.Controls.Add(this.textSecond);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.groupSettings);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TextEncryptor";
            this.groupSettings.ResumeLayout(false);
            this.groupClipboard.ResumeLayout(false);
            this.groupClipboard.PerformLayout();
            this.groupKeyMode.ResumeLayout(false);
            this.groupKeyMode.PerformLayout();
            this.groupKey.ResumeLayout(false);
            this.groupKey.PerformLayout();
            this.groupMode.ResumeLayout(false);
            this.groupMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.RadioButton modeDecrypt;
        private System.Windows.Forms.RadioButton modeEncrypt;
        private System.Windows.Forms.RichTextBox textFirst;
        private System.Windows.Forms.RichTextBox textSecond;
        private System.Windows.Forms.Button convertText;
        private System.Windows.Forms.GroupBox groupKeyMode;
        private System.Windows.Forms.GroupBox groupKey;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.RadioButton keyModeInput;
        private System.Windows.Forms.RadioButton keyModeRand;
        private System.Windows.Forms.Label keyValue;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.GroupBox groupClipboard;
        private System.Windows.Forms.RadioButton modeClipboardTextAndKey;
        private System.Windows.Forms.RadioButton modeClipboardKeyOnly;
        private System.Windows.Forms.RadioButton modeClipboardTextOnly;
        private System.Windows.Forms.ProgressBar progressCrypting;
    }
}

