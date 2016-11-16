namespace CSTrainingApp
{
    partial class mainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.ageField = new System.Windows.Forms.TextBox();
            this.bDayField = new System.Windows.Forms.TextBox();
            this.greeting = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(59, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "C# Training App";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(13, 135);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(43, 20);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age:";
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLabel.Location = new System.Drawing.Point(13, 174);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(84, 20);
            this.bdayLabel.TabIndex = 3;
            this.bdayLabel.Text = "Birthday:";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Black;
            this.submitBtn.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.Location = new System.Drawing.Point(124, 240);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(98, 36);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(104, 96);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(169, 22);
            this.nameField.TabIndex = 5;
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(104, 135);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(169, 22);
            this.ageField.TabIndex = 6;
            // 
            // bDayField
            // 
            this.bDayField.Location = new System.Drawing.Point(104, 174);
            this.bDayField.Name = "bDayField";
            this.bDayField.Size = new System.Drawing.Size(169, 22);
            this.bDayField.TabIndex = 7;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(13, 293);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(80, 20);
            this.greeting.TabIndex = 8;
            this.greeting.Text = "Greeting:";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 324);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(324, 143);
            this.result.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(348, 488);
            this.Controls.Add(this.result);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.bDayField);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.bdayLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSTrainingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.TextBox bDayField;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label result;
    }
}

