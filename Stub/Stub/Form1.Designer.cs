namespace Stub
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
            this.components = new System.ComponentModel.Container();
            this.exit_Label = new System.Windows.Forms.Label();
            this.minimize_Label = new System.Windows.Forms.Label();
            this.title1_Label = new System.Windows.Forms.Label();
            this.title2_Label = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.title3_Label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.string_Label = new System.Windows.Forms.Label();
            this.integer_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_Label
            // 
            this.exit_Label.AutoSize = true;
            this.exit_Label.Location = new System.Drawing.Point(224, 9);
            this.exit_Label.Name = "exit_Label";
            this.exit_Label.Size = new System.Drawing.Size(20, 20);
            this.exit_Label.TabIndex = 0;
            this.exit_Label.Text = "X";
            this.exit_Label.Click += new System.EventHandler(this.exit_Label_Click);
            // 
            // minimize_Label
            // 
            this.minimize_Label.AutoSize = true;
            this.minimize_Label.Location = new System.Drawing.Point(200, 9);
            this.minimize_Label.Name = "minimize_Label";
            this.minimize_Label.Size = new System.Drawing.Size(18, 20);
            this.minimize_Label.TabIndex = 1;
            this.minimize_Label.Text = "_";
            this.minimize_Label.Click += new System.EventHandler(this.minimize_Label_Click);
            // 
            // title1_Label
            // 
            this.title1_Label.AutoSize = true;
            this.title1_Label.Location = new System.Drawing.Point(12, 67);
            this.title1_Label.Name = "title1_Label";
            this.title1_Label.Size = new System.Drawing.Size(96, 20);
            this.title1_Label.TabIndex = 2;
            this.title1_Label.Text = "String Input:";
            // 
            // title2_Label
            // 
            this.title2_Label.AutoSize = true;
            this.title2_Label.Location = new System.Drawing.Point(12, 118);
            this.title2_Label.Name = "title2_Label";
            this.title2_Label.Size = new System.Drawing.Size(105, 20);
            this.title2_Label.TabIndex = 3;
            this.title2_Label.Text = "Integer Input:";
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(131, 171);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(92, 23);
            this.button.TabIndex = 4;
            this.button.Text = "***";
            this.button.UseVisualStyleBackColor = true;
            // 
            // title3_Label
            // 
            this.title3_Label.AutoSize = true;
            this.title3_Label.Location = new System.Drawing.Point(12, 172);
            this.title3_Label.Name = "title3_Label";
            this.title3_Label.Size = new System.Drawing.Size(113, 20);
            this.title3_Label.TabIndex = 5;
            this.title3_Label.Text = "Boolean Input:";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.ForeColor = System.Drawing.Color.BlueViolet;
            // 
            // string_Label
            // 
            this.string_Label.AutoSize = true;
            this.string_Label.Location = new System.Drawing.Point(127, 67);
            this.string_Label.Name = "string_Label";
            this.string_Label.Size = new System.Drawing.Size(51, 20);
            this.string_Label.TabIndex = 6;
            this.string_Label.Text = "String";
            // 
            // integer_Label
            // 
            this.integer_Label.AutoSize = true;
            this.integer_Label.Location = new System.Drawing.Point(127, 118);
            this.integer_Label.Name = "integer_Label";
            this.integer_Label.Size = new System.Drawing.Size(60, 20);
            this.integer_Label.TabIndex = 7;
            this.integer_Label.Text = "Integer";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(131, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color Input:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(247, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.integer_Label);
            this.Controls.Add(this.string_Label);
            this.Controls.Add(this.title3_Label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.title2_Label);
            this.Controls.Add(this.title1_Label);
            this.Controls.Add(this.minimize_Label);
            this.Controls.Add(this.exit_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_Label;
        private System.Windows.Forms.Label minimize_Label;
        private System.Windows.Forms.Label title1_Label;
        private System.Windows.Forms.Label title2_Label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label title3_Label;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label string_Label;
        private System.Windows.Forms.Label integer_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

