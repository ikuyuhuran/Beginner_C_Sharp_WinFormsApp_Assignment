﻿namespace Beginner_C_Sharp_WinFormsApp_Assignment
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
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 67);
            label1.Name = "label1";
            label1.Size = new Size(559, 45);
            label1.TabIndex = 0;
            label1.Text = "ここに計算結果を表示しください [button1]";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(171, 133);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(296, 61);
            button1.TabIndex = 1;
            button1.Text = "計算結果を表示する";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(171, 360);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(296, 61);
            button2.TabIndex = 3;
            button2.Text = "計算結果を表示する";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 293);
            label2.Name = "label2";
            label2.Size = new Size(559, 45);
            label2.TabIndex = 2;
            label2.Text = "ここに計算結果を表示しください [button2]";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(171, 227);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 50);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(343, 227);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 50);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(297, 227);
            label3.Name = "label3";
            label3.Size = new Size(42, 45);
            label3.TabIndex = 0;
            label3.Text = "÷";
            // 
            // button3
            // 
            button3.Location = new Point(731, 519);
            button3.Name = "button3";
            button3.Size = new Size(608, 79);
            button3.TabIndex = 6;
            button3.Text = "Form2に移動";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1338, 598);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button3;
    }
}