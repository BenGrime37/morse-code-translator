namespace morse_code_translater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageBox = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.Button();
            this.morseCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.morselengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageBox.Location = new System.Drawing.Point(33, 59);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(735, 51);
            this.messageBox.TabIndex = 0;
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(129, 311);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(514, 114);
            this.Translate.TabIndex = 1;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // morseCodeBox
            // 
            this.morseCodeBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.morseCodeBox.Location = new System.Drawing.Point(33, 230);
            this.morseCodeBox.Name = "morseCodeBox";
            this.morseCodeBox.Size = new System.Drawing.Size(735, 51);
            this.morseCodeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message in here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code in here";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(341, 145);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(29, 20);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "AA";
            this.lengthLabel.Visible = false;
            // 
            // morselengthLabel
            // 
            this.morselengthLabel.AutoSize = true;
            this.morselengthLabel.Location = new System.Drawing.Point(410, 145);
            this.morselengthLabel.Name = "morselengthLabel";
            this.morselengthLabel.Size = new System.Drawing.Size(27, 20);
            this.morselengthLabel.TabIndex = 2;
            this.morselengthLabel.Text = "bb";
            this.morselengthLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.morselengthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.morseCodeBox);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.messageBox);
            this.Name = "Form1";
            this.Text = "Morse Code Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.TextBox morseCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label morselengthLabel;
    }
}

