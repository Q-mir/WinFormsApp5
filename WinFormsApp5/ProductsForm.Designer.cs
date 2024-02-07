namespace WinFormsApp5 {
    partial class ProductsForm {
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 47;
            listBox1.Location = new Point(12, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 333);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label1.Location = new Point(351, 28);
            label1.Name = "label1";
            label1.Size = new Size(104, 47);
            label1.TabIndex = 1;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label2.Location = new Point(351, 105);
            label2.Name = "label2";
            label2.Size = new Size(437, 224);
            label2.TabIndex = 2;
            label2.Text = "Описание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label3.Location = new Point(351, 310);
            label3.Name = "label3";
            label3.Size = new Size(117, 47);
            label3.TabIndex = 3;
            label3.Text = "Цена:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(333, 53);
            comboBox1.TabIndex = 4;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "ProductsForm";
            Text = "ProductsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
    }
}