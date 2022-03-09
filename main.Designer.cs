namespace A_chain_of_restaurants_Sau0rin_APP
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.close = new System.Windows.Forms.Button();
            this.jap_kit = new System.Windows.Forms.Button();
            this.fast_kit = new System.Windows.Forms.Button();
            this.italy_kit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(470, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 35);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // jap_kit
            // 
            this.jap_kit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jap_kit.BackColor = System.Drawing.Color.Maroon;
            this.jap_kit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jap_kit.BackgroundImage")));
            this.jap_kit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jap_kit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.jap_kit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.jap_kit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.jap_kit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.jap_kit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jap_kit.Location = new System.Drawing.Point(2, 53);
            this.jap_kit.Name = "jap_kit";
            this.jap_kit.Size = new System.Drawing.Size(488, 191);
            this.jap_kit.TabIndex = 1;
            this.jap_kit.UseVisualStyleBackColor = false;
            this.jap_kit.Click += new System.EventHandler(this.jap_kit_Click);
            // 
            // fast_kit
            // 
            this.fast_kit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fast_kit.BackgroundImage")));
            this.fast_kit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fast_kit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.fast_kit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.fast_kit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fast_kit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.fast_kit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fast_kit.Location = new System.Drawing.Point(2, 445);
            this.fast_kit.Name = "fast_kit";
            this.fast_kit.Size = new System.Drawing.Size(488, 232);
            this.fast_kit.TabIndex = 2;
            this.fast_kit.UseVisualStyleBackColor = true;
            this.fast_kit.Click += new System.EventHandler(this.fast_kit_Click);
            // 
            // italy_kit
            // 
            this.italy_kit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("italy_kit.BackgroundImage")));
            this.italy_kit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.italy_kit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.italy_kit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.italy_kit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.italy_kit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.italy_kit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.italy_kit.Location = new System.Drawing.Point(2, 237);
            this.italy_kit.Name = "italy_kit";
            this.italy_kit.Size = new System.Drawing.Size(488, 226);
            this.italy_kit.TabIndex = 3;
            this.italy_kit.UseVisualStyleBackColor = true;
            this.italy_kit.Click += new System.EventHandler(this.italy_kit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.italy_kit);
            this.Controls.Add(this.jap_kit);
            this.Controls.Add(this.close);
            this.Controls.Add(this.fast_kit);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button jap_kit;
        private System.Windows.Forms.Button fast_kit;
        private System.Windows.Forms.Button italy_kit;
    }
}

