namespace Beginner_C_Sharp_WinFormsApp_Assignment
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 50);
            label1.Name = "label1";
            label1.Size = new Size(453, 36);
            label1.TabIndex = 0;
            label1.Text = "ここに計算結果を表示しください [button1]";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(150, 100);
            button1.Name = "button1";
            button1.Size = new Size(242, 46);
            button1.TabIndex = 1;
            button1.Text = "計算結果を表示する";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(150, 270);
            button2.Name = "button2";
            button2.Size = new Size(242, 46);
            button2.TabIndex = 3;
            button2.Text = "計算結果を表示する";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 220);
            label2.Name = "label2";
            label2.Size = new Size(453, 36);
            label2.TabIndex = 2;
            label2.Text = "ここに計算結果を表示しください [button2]";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 41);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(300, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 41);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(260, 170);
            label3.Name = "label3";
            label3.Size = new Size(33, 36);
            label3.TabIndex = 0;
            label3.Text = "÷";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}