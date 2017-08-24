namespace Example_02_WindowsForm
{
    partial class MainForm1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.starButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // starButton
            // 
            this.starButton.Location = new System.Drawing.Point(153, 240);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(113, 51);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "登入";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "請輸入神奇寶貝姓名:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(203, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 29);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm1_KeyUp);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageLabel.Location = new System.Drawing.Point(51, 189);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(73, 20);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "訊息文字";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(70, 67);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(45, 20);
            this.Type.TabIndex = 4;
            this.Type.Text = "屬性:";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(70, 102);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(45, 20);
            this.Height.TabIndex = 5;
            this.Height.Text = "身高:";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(70, 135);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(45, 20);
            this.Weight.TabIndex = 6;
            this.Weight.Text = "體重:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(203, 64);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(213, 29);
            this.typeTextBox.TabIndex = 7;
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(203, 99);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(213, 29);
            this.highTextBox.TabIndex = 8;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(203, 132);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(213, 29);
            this.weightTextBox.TabIndex = 9;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 435);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.starButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm1";
            this.Text = "第一個視窗程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
    }
}

