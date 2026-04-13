namespace Builder
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.minimize_Label = new System.Windows.Forms.Label();
            this.exit_Label = new System.Windows.Forms.Label();
            this.title2_Label = new System.Windows.Forms.Label();
            this.title1_Label = new System.Windows.Forms.Label();
            this.string_TextBox = new System.Windows.Forms.TextBox();
            this.integer_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.color_TextBox = new System.Windows.Forms.TextBox();
            this.build_Button = new System.Windows.Forms.Button();
            this.boolean_Checkbox = new System.Windows.Forms.CheckBox();
            this.title3_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimize_Label
            // 
            this.minimize_Label.AutoSize = true;
            this.minimize_Label.Location = new System.Drawing.Point(191, 9);
            this.minimize_Label.Name = "minimize_Label";
            this.minimize_Label.Size = new System.Drawing.Size(18, 20);
            this.minimize_Label.TabIndex = 3;
            this.minimize_Label.Text = "_";
            this.minimize_Label.Click += new System.EventHandler(this.minimize_Label_Click);
            // 
            // exit_Label
            // 
            this.exit_Label.AutoSize = true;
            this.exit_Label.Location = new System.Drawing.Point(215, 9);
            this.exit_Label.Name = "exit_Label";
            this.exit_Label.Size = new System.Drawing.Size(20, 20);
            this.exit_Label.TabIndex = 2;
            this.exit_Label.Text = "X";
            this.exit_Label.Click += new System.EventHandler(this.exit_Label_Click);
            // 
            // title2_Label
            // 
            this.title2_Label.AutoSize = true;
            this.title2_Label.Location = new System.Drawing.Point(12, 87);
            this.title2_Label.Name = "title2_Label";
            this.title2_Label.Size = new System.Drawing.Size(105, 20);
            this.title2_Label.TabIndex = 7;
            this.title2_Label.Text = "Integer Input:";
            // 
            // title1_Label
            // 
            this.title1_Label.AutoSize = true;
            this.title1_Label.Location = new System.Drawing.Point(12, 57);
            this.title1_Label.Name = "title1_Label";
            this.title1_Label.Size = new System.Drawing.Size(96, 20);
            this.title1_Label.TabIndex = 6;
            this.title1_Label.Text = "String Input:";
            // 
            // string_TextBox
            // 
            this.string_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.string_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.string_TextBox.ForeColor = System.Drawing.Color.BlueViolet;
            this.string_TextBox.Location = new System.Drawing.Point(135, 57);
            this.string_TextBox.Name = "string_TextBox";
            this.string_TextBox.Size = new System.Drawing.Size(100, 19);
            this.string_TextBox.TabIndex = 9;
            // 
            // integer_TextBox
            // 
            this.integer_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.integer_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.integer_TextBox.ForeColor = System.Drawing.Color.BlueViolet;
            this.integer_TextBox.Location = new System.Drawing.Point(135, 87);
            this.integer_TextBox.Name = "integer_TextBox";
            this.integer_TextBox.Size = new System.Drawing.Size(100, 19);
            this.integer_TextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color Input:";
            // 
            // color_TextBox
            // 
            this.color_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.color_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.color_TextBox.ForeColor = System.Drawing.Color.BlueViolet;
            this.color_TextBox.Location = new System.Drawing.Point(135, 117);
            this.color_TextBox.Name = "color_TextBox";
            this.color_TextBox.Size = new System.Drawing.Size(100, 19);
            this.color_TextBox.TabIndex = 13;
            // 
            // build_Button
            // 
            this.build_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build_Button.Location = new System.Drawing.Point(16, 180);
            this.build_Button.Name = "build_Button";
            this.build_Button.Size = new System.Drawing.Size(219, 48);
            this.build_Button.TabIndex = 14;
            this.build_Button.Text = "Build";
            this.build_Button.UseVisualStyleBackColor = true;
            this.build_Button.Click += new System.EventHandler(this.build_Button_Click);
            // 
            // boolean_Checkbox
            // 
            this.boolean_Checkbox.AutoSize = true;
            this.boolean_Checkbox.Location = new System.Drawing.Point(135, 143);
            this.boolean_Checkbox.Name = "boolean_Checkbox";
            this.boolean_Checkbox.Size = new System.Drawing.Size(69, 24);
            this.boolean_Checkbox.TabIndex = 17;
            this.boolean_Checkbox.Text = "True?";
            this.boolean_Checkbox.UseVisualStyleBackColor = true;
            // 
            // title3_Label
            // 
            this.title3_Label.AutoSize = true;
            this.title3_Label.Location = new System.Drawing.Point(12, 143);
            this.title3_Label.Name = "title3_Label";
            this.title3_Label.Size = new System.Drawing.Size(113, 20);
            this.title3_Label.TabIndex = 16;
            this.title3_Label.Text = "Boolean Input:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(247, 240);
            this.Controls.Add(this.boolean_Checkbox);
            this.Controls.Add(this.title3_Label);
            this.Controls.Add(this.build_Button);
            this.Controls.Add(this.color_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.integer_TextBox);
            this.Controls.Add(this.string_TextBox);
            this.Controls.Add(this.title2_Label);
            this.Controls.Add(this.title1_Label);
            this.Controls.Add(this.minimize_Label);
            this.Controls.Add(this.exit_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize_Label;
        private System.Windows.Forms.Label exit_Label;
        private System.Windows.Forms.Label title2_Label;
        private System.Windows.Forms.Label title1_Label;
        private System.Windows.Forms.TextBox string_TextBox;
        private System.Windows.Forms.TextBox integer_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox color_TextBox;
        private System.Windows.Forms.Button build_Button;
        private System.Windows.Forms.CheckBox boolean_Checkbox;
        private System.Windows.Forms.Label title3_Label;
    }
}

