﻿namespace day10_winform
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
            question_text = new TextBox();
            button1 = new Button();
            solution_textbox = new TextBox();
            solution_label = new Label();
            SuspendLayout();
            // 
            // question_text
            // 
            question_text.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_text.Location = new Point(81, 53);
            question_text.Multiline = true;
            question_text.Name = "question_text";
            question_text.Size = new Size(303, 40);
            question_text.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(435, 53);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 1;
            button1.Text = "คำนวน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // solution_textbox
            // 
            solution_textbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solution_textbox.ForeColor = Color.Green;
            solution_textbox.Location = new Point(81, 121);
            solution_textbox.Multiline = true;
            solution_textbox.Name = "solution_textbox";
            solution_textbox.Size = new Size(125, 43);
            solution_textbox.TabIndex = 2;
            solution_textbox.Text = "0";
            // 
            // solution_label
            // 
            solution_label.AutoSize = true;
            solution_label.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solution_label.ForeColor = Color.Red;
            solution_label.Location = new Point(313, 127);
            solution_label.Name = "solution_label";
            solution_label.Size = new Size(32, 37);
            solution_label.TabIndex = 3;
            solution_label.Text = "0";
            solution_label.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(solution_label);
            Controls.Add(solution_textbox);
            Controls.Add(button1);
            Controls.Add(question_text);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox question_text;
        private Button button1;
        private TextBox solution_textbox;
        private Label solution_label;
    }
}
