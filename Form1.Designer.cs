using MaterialSkin.Controls;

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
            label1 = new MaterialLabel();
            label2 = new MaterialLabel();
            lower_chk = new MaterialCheckbox();
            upper_chk = new MaterialCheckbox();
            numbers_chk = new MaterialCheckbox();
            symbols_chk = new MaterialCheckbox();
            generate_btn = new MaterialButton();
            zero_chk = new MaterialCheckbox();
            ltr_o_chk = new MaterialCheckbox();
            length_num = new NumericUpDown();
            count_num = new NumericUpDown();
            file_btn = new MaterialButton();
            theme_changer = new MaterialButton();
            ((System.ComponentModel.ISupportInitialize)length_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)count_num).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(12, 76);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 0;
            label1.Text = "Длина пароля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Depth = 0;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(302, 76);
            label2.MouseState = MaterialSkin.MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 2;
            label2.Text = "Количество паролей";
            // 
            // lower_chk
            // 
            lower_chk.AutoSize = true;
            lower_chk.Checked = true;
            lower_chk.CheckState = CheckState.Checked;
            lower_chk.Depth = 0;
            lower_chk.Location = new Point(12, 127);
            lower_chk.Margin = new Padding(0);
            lower_chk.MouseLocation = new Point(-1, -1);
            lower_chk.MouseState = MaterialSkin.MouseState.HOVER;
            lower_chk.Name = "lower_chk";
            lower_chk.ReadOnly = false;
            lower_chk.Ripple = true;
            lower_chk.Size = new Size(331, 37);
            lower_chk.TabIndex = 3;
            lower_chk.Text = "Использовать буквы нижнего регистра";
            lower_chk.UseVisualStyleBackColor = true;
            lower_chk.CheckedChanged += lower_chk_CheckedChanged;
            // 
            // upper_chk
            // 
            upper_chk.AutoSize = true;
            upper_chk.Depth = 0;
            upper_chk.Location = new Point(12, 164);
            upper_chk.Margin = new Padding(0);
            upper_chk.MouseLocation = new Point(-1, -1);
            upper_chk.MouseState = MaterialSkin.MouseState.HOVER;
            upper_chk.Name = "upper_chk";
            upper_chk.ReadOnly = false;
            upper_chk.Ripple = true;
            upper_chk.Size = new Size(335, 37);
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
            numbers_chk.Depth = 0;
            numbers_chk.Location = new Point(12, 201);
            numbers_chk.Margin = new Padding(0);
            numbers_chk.MouseLocation = new Point(-1, -1);
            numbers_chk.MouseState = MaterialSkin.MouseState.HOVER;
            numbers_chk.Name = "numbers_chk";
            numbers_chk.ReadOnly = false;
            numbers_chk.Ripple = true;
            numbers_chk.Size = new Size(190, 37);
            numbers_chk.TabIndex = 6;
            numbers_chk.Text = "Использовать числа";
            numbers_chk.UseVisualStyleBackColor = true;
            numbers_chk.CheckedChanged += numbers_chk_CheckedChanged;
            // 
            // symbols_chk
            // 
            symbols_chk.AutoSize = true;
            symbols_chk.Depth = 0;
            symbols_chk.Location = new Point(12, 238);
            symbols_chk.Margin = new Padding(0);
            symbols_chk.MouseLocation = new Point(-1, -1);
            symbols_chk.MouseState = MaterialSkin.MouseState.HOVER;
            symbols_chk.Name = "symbols_chk";
            symbols_chk.ReadOnly = false;
            symbols_chk.Ripple = true;
            symbols_chk.Size = new Size(214, 37);
            symbols_chk.TabIndex = 8;
            symbols_chk.Text = "Использовать символы";
            symbols_chk.UseVisualStyleBackColor = true;
            symbols_chk.CheckedChanged += symbols_chk_CheckedChanged;
            // 
            // generate_btn
            // 
            generate_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            generate_btn.Density = MaterialButton.MaterialButtonDensity.Default;
            generate_btn.Depth = 0;
            generate_btn.HighEmphasis = true;
            generate_btn.Icon = null;
            generate_btn.Location = new Point(228, 281);
            generate_btn.Margin = new Padding(4, 6, 4, 6);
            generate_btn.MouseState = MaterialSkin.MouseState.HOVER;
            generate_btn.Name = "generate_btn";
            generate_btn.NoAccentTextColor = Color.Empty;
            generate_btn.Size = new Size(143, 36);
            generate_btn.TabIndex = 9;
            generate_btn.Text = "Сгенерировать";
            generate_btn.Type = MaterialButton.MaterialButtonType.Contained;
            generate_btn.UseAccentColor = false;
            generate_btn.UseVisualStyleBackColor = true;
            generate_btn.Click += generate_btn_Click;
            // 
            // zero_chk
            // 
            zero_chk.AutoSize = true;
            zero_chk.Checked = true;
            zero_chk.CheckState = CheckState.Checked;
            zero_chk.Depth = 0;
            zero_chk.Location = new Point(224, 201);
            zero_chk.Margin = new Padding(0);
            zero_chk.MouseLocation = new Point(-1, -1);
            zero_chk.MouseState = MaterialSkin.MouseState.HOVER;
            zero_chk.Name = "zero_chk";
            zero_chk.ReadOnly = false;
            zero_chk.Ripple = true;
            zero_chk.Size = new Size(203, 37);
            zero_chk.TabIndex = 7;
            zero_chk.Text = "Использовать число 0";
            zero_chk.UseVisualStyleBackColor = true;
            // 
            // ltr_o_chk
            // 
            ltr_o_chk.AutoSize = true;
            ltr_o_chk.Checked = true;
            ltr_o_chk.CheckState = CheckState.Checked;
            ltr_o_chk.Depth = 0;
            ltr_o_chk.Location = new Point(359, 127);
            ltr_o_chk.Margin = new Padding(0);
            ltr_o_chk.MouseLocation = new Point(-1, -1);
            ltr_o_chk.MouseState = MaterialSkin.MouseState.HOVER;
            ltr_o_chk.Name = "ltr_o_chk";
            ltr_o_chk.ReadOnly = false;
            ltr_o_chk.Ripple = true;
            ltr_o_chk.Size = new Size(204, 37);
            ltr_o_chk.TabIndex = 5;
            ltr_o_chk.Text = "Использовать букву О";
            ltr_o_chk.UseVisualStyleBackColor = true;
            // 
            // length_num
            // 
            length_num.Location = new Point(12, 98);
            length_num.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            length_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            length_num.Name = "length_num";
            length_num.Size = new Size(282, 23);
            length_num.TabIndex = 1;
            length_num.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // count_num
            // 
            count_num.Location = new Point(306, 98);
            count_num.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            count_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            count_num.Name = "count_num";
            count_num.Size = new Size(282, 23);
            count_num.TabIndex = 2;
            count_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            count_num.ValueChanged += count_num_ValueChanged;
            // 
            // file_btn
            // 
            file_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            file_btn.Density = MaterialButton.MaterialButtonDensity.Default;
            file_btn.Depth = 0;
            file_btn.HighEmphasis = true;
            file_btn.Icon = null;
            file_btn.Location = new Point(12, 713);
            file_btn.Margin = new Padding(4, 6, 4, 6);
            file_btn.MouseState = MaterialSkin.MouseState.HOVER;
            file_btn.Name = "file_btn";
            file_btn.NoAccentTextColor = Color.Empty;
            file_btn.Size = new Size(360, 36);
            file_btn.TabIndex = 18;
            file_btn.Text = "Открыть файл сгенерированных паролей";
            file_btn.Type = MaterialButton.MaterialButtonType.Contained;
            file_btn.UseAccentColor = false;
            file_btn.UseVisualStyleBackColor = true;
            file_btn.Click += file_btn_Click;
            // 
            // theme_changer
            // 
            theme_changer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            theme_changer.Density = MaterialButton.MaterialButtonDensity.Default;
            theme_changer.Depth = 0;
            theme_changer.HighEmphasis = true;
            theme_changer.Icon = null;
            theme_changer.Location = new Point(453, 713);
            theme_changer.Margin = new Padding(4, 6, 4, 6);
            theme_changer.MouseState = MaterialSkin.MouseState.HOVER;
            theme_changer.Name = "theme_changer";
            theme_changer.NoAccentTextColor = Color.Empty;
            theme_changer.Size = new Size(135, 36);
            theme_changer.TabIndex = 19;
            theme_changer.Text = "Сменить тему";
            theme_changer.Type = MaterialButton.MaterialButtonType.Contained;
            theme_changer.UseAccentColor = false;
            theme_changer.UseVisualStyleBackColor = true;
            theme_changer.Click += theme_changer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 758);
            Controls.Add(theme_changer);
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

        private MaterialLabel label1;
        private MaterialLabel label2;
        private MaterialCheckbox lower_chk;
        private MaterialCheckbox upper_chk;
        private MaterialCheckbox numbers_chk;
        private MaterialCheckbox symbols_chk;
        private MaterialButton generate_btn;
        private MaterialCheckbox zero_chk;
        private MaterialCheckbox ltr_o_chk;
        private NumericUpDown length_num;
        private NumericUpDown count_num;
        private MaterialButton file_btn;
        private MaterialButton theme_changer;
    }
}
