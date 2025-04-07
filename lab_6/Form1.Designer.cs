namespace lab_6
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
            sumBox = new TextBox();
            timeBox = new TextBox();
            averageBox = new TextBox();
            calculateRes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // sumBox
            // 
            sumBox.Location = new Point(123, 51);
            sumBox.Margin = new Padding(2, 2, 2, 2);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(106, 23);
            sumBox.TabIndex = 0;
            // 
            // timeBox
            // 
            timeBox.Location = new Point(123, 88);
            timeBox.Margin = new Padding(2, 2, 2, 2);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(147, 23);
            timeBox.TabIndex = 0;
            // 
            // averageBox
            // 
            averageBox.Location = new Point(123, 123);
            averageBox.Margin = new Padding(2, 2, 2, 2);
            averageBox.Name = "averageBox";
            averageBox.Size = new Size(106, 23);
            averageBox.TabIndex = 0;
            // 
            // calculateRes
            // 
            calculateRes.Location = new Point(133, 165);
            calculateRes.Margin = new Padding(2, 2, 2, 2);
            calculateRes.Name = "calculateRes";
            calculateRes.Size = new Size(78, 20);
            calculateRes.TabIndex = 1;
            calculateRes.Text = "Рассчитать";
            calculateRes.UseVisualStyleBackColor = true;
            calculateRes.Click += calculateRes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Время";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Среднее значение";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 352);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calculateRes);
            Controls.Add(averageBox);
            Controls.Add(timeBox);
            Controls.Add(sumBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Лабораторная работа 6. Многопоточность и  асинхронное программирование. Вариант 10. Ермаков, Петровский";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sumBox;
        private TextBox timeBox;
        private TextBox averageBox;
        private Button calculateRes;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
