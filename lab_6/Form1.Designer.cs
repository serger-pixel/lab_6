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
            sumBox.Location = new Point(176, 85);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(150, 31);
            sumBox.TabIndex = 0;
            // 
            // timeBox
            // 
            timeBox.Location = new Point(176, 146);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(208, 31);
            timeBox.TabIndex = 0;
            // 
            // averageBox
            // 
            averageBox.Location = new Point(176, 205);
            averageBox.Name = "averageBox";
            averageBox.Size = new Size(150, 31);
            averageBox.TabIndex = 0;
            // 
            // calculateRes
            // 
            calculateRes.Location = new Point(190, 275);
            calculateRes.Name = "calculateRes";
            calculateRes.Size = new Size(112, 34);
            calculateRes.TabIndex = 1;
            calculateRes.Text = "Рассчитать";
            calculateRes.UseVisualStyleBackColor = true;
            calculateRes.Click += calculateRes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "Сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 152);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Время";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 208);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 2;
            label3.Text = "Среднее значение";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 587);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calculateRes);
            Controls.Add(averageBox);
            Controls.Add(timeBox);
            Controls.Add(sumBox);
            Name = "Form1";
            Text = "Form1";
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
