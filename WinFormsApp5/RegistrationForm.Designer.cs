namespace WinFormsApp5 {
    partial class RegistrationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            textBox1.Location = new Point(223, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 57);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            textBox2.Location = new Point(223, 94);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '♀';
            textBox2.Size = new Size(375, 57);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            textBox3.Location = new Point(223, 154);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '♂';
            textBox3.Size = new Size(375, 57);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            label1.Location = new Point(87, 41);
            label1.Name = "label1";
            label1.Size = new Size(130, 50);
            label1.TabIndex = 3;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(197, 50);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            label3.Location = new Point(20, 161);
            label3.Name = "label3";
            label3.Size = new Size(197, 50);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            button1.Location = new Point(20, 234);
            button1.Name = "button1";
            button1.Size = new Size(578, 66);
            button1.TabIndex = 6;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 323);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}