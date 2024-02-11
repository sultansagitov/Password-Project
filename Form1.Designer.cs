namespace Password_Project
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
            label2 = new Label();
            lower_chk = new CheckBox();
            upper_chk = new CheckBox();
            numbers_chk = new CheckBox();
            symbols_chk = new CheckBox();
            generate_btn = new Button();
            zero_chk = new CheckBox();
            ltr_o_chk = new CheckBox();
            length_num = new NumericUpDown();
            count_num = new NumericUpDown();
            file_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)length_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)count_num).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Длина пароля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 9);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Количество паролей";
            // 
            // lower_chk
            // 
            lower_chk.AutoSize = true;
            lower_chk.Checked = true;
            lower_chk.CheckState = CheckState.Checked;
            lower_chk.Location = new Point(12, 56);
            lower_chk.Name = "lower_chk";
            lower_chk.Size = new Size(243, 19);
            lower_chk.TabIndex = 3;
            lower_chk.Text = "Использовать буквы нижнего регистра";
            lower_chk.UseVisualStyleBackColor = true;
            lower_chk.CheckedChanged += lower_chk_CheckedChanged;
            // 
            // upper_chk
            // 
            upper_chk.AutoSize = true;
            upper_chk.Location = new Point(12, 81);
            upper_chk.Name = "upper_chk";
            upper_chk.Size = new Size(245, 19);
            upper_chk.TabIndex = 4;
            upper_chk.Text = "Использовать буквы верхнего регистра";
            upper_chk.UseVisualStyleBackColor = true;
            upper_chk.CheckedChanged += upper_chk_CheckedChanged;
            // 
            // numbers_chk
            // 
            numbers_chk.AutoSize = true;
            numbers_chk.Checked = true;
            numbers_chk.CheckState = CheckState.Checked;
            numbers_chk.Location = new Point(12, 106);
            numbers_chk.Name = "numbers_chk";
            numbers_chk.Size = new Size(139, 19);
            numbers_chk.TabIndex = 6;
            numbers_chk.Text = "Использовать числа";
            numbers_chk.UseVisualStyleBackColor = true;
            numbers_chk.CheckedChanged += numbers_chk_CheckedChanged;
            // 
            // symbols_chk
            // 
            symbols_chk.AutoSize = true;
            symbols_chk.Location = new Point(12, 131);
            symbols_chk.Name = "symbols_chk";
            symbols_chk.Size = new Size(157, 19);
            symbols_chk.TabIndex = 8;
            symbols_chk.Text = "Использовать символы";
            symbols_chk.UseVisualStyleBackColor = true;
            symbols_chk.CheckedChanged += symbols_chk_CheckedChanged;
            // 
            // generate_btn
            // 
            generate_btn.Location = new Point(12, 156);
            generate_btn.Name = "generate_btn";
            generate_btn.Size = new Size(398, 23);
            generate_btn.TabIndex = 9;
            generate_btn.Text = "Сгенерировать";
            generate_btn.UseVisualStyleBackColor = true;
            generate_btn.Click += generate_btn_Click;
            // 
            // zero_chk
            // 
            zero_chk.AutoSize = true;
            zero_chk.Checked = true;
            zero_chk.CheckState = CheckState.Checked;
            zero_chk.Location = new Point(157, 106);
            zero_chk.Name = "zero_chk";
            zero_chk.Size = new Size(149, 19);
            zero_chk.TabIndex = 7;
            zero_chk.Text = "Использовать число 0";
            zero_chk.UseVisualStyleBackColor = true;
            // 
            // ltr_o_chk
            // 
            ltr_o_chk.AutoSize = true;
            ltr_o_chk.Checked = true;
            ltr_o_chk.CheckState = CheckState.Checked;
            ltr_o_chk.Location = new Point(261, 56);
            ltr_o_chk.Name = "ltr_o_chk";
            ltr_o_chk.Size = new Size(149, 19);
            ltr_o_chk.TabIndex = 5;
            ltr_o_chk.Text = "Использовать букву О";
            ltr_o_chk.UseVisualStyleBackColor = true;
            // 
            // length_num
            // 
            length_num.Location = new Point(12, 27);
            length_num.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            length_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            length_num.Name = "length_num";
            length_num.Size = new Size(194, 23);
            length_num.TabIndex = 1;
            length_num.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // count_num
            // 
            count_num.Location = new Point(216, 27);
            count_num.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            count_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            count_num.Name = "count_num";
            count_num.Size = new Size(194, 23);
            count_num.TabIndex = 2;
            count_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            count_num.ValueChanged += count_num_ValueChanged;
            // 
            // file_btn
            // 
            file_btn.Location = new Point(12, 417);
            file_btn.Name = "file_btn";
            file_btn.Size = new Size(398, 23);
            file_btn.TabIndex = 18;
            file_btn.Text = "Открыть файл сгенерированных паролей";
            file_btn.UseVisualStyleBackColor = true;
            file_btn.Click += file_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 451);
            Controls.Add(file_btn);
            Controls.Add(count_num);
            Controls.Add(length_num);
            Controls.Add(ltr_o_chk);
            Controls.Add(zero_chk);
            Controls.Add(generate_btn);
            Controls.Add(symbols_chk);
            Controls.Add(numbers_chk);
            Controls.Add(upper_chk);
            Controls.Add(lower_chk);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            Name = "Form1";
            Text = "Генератор пароля";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)length_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)count_num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox lower_chk;
        private CheckBox upper_chk;
        private CheckBox numbers_chk;
        private CheckBox symbols_chk;
        private Button generate_btn;
        private CheckBox zero_chk;
        private CheckBox ltr_o_chk;
        private NumericUpDown length_num;
        private NumericUpDown count_num;
        private Button file_btn;
    }
}
