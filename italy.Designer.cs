namespace A_chain_of_restaurants_Sau0rin_APP
{
    partial class italy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(italy));
            this.close = new System.Windows.Forms.Button();
            this.tovari = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.all_del = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus_tovar = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.zakaz = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Location = new System.Drawing.Point(469, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 34);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // tovari
            // 
            this.tovari.BackColor = System.Drawing.Color.Azure;
            this.tovari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tovari.Font = new System.Drawing.Font("mr_AprilraG", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tovari.ForeColor = System.Drawing.Color.Teal;
            this.tovari.FormattingEnabled = true;
            this.tovari.ItemHeight = 75;
            this.tovari.Items.AddRange(new object[] {
            " Margherita  135",
            " Панна котта 95",
            " Тирамису     70",
            " Лазанья      85"});
            this.tovari.Location = new System.Drawing.Point(108, 62);
            this.tovari.Name = "tovari";
            this.tovari.Size = new System.Drawing.Size(366, 375);
            this.tovari.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 56);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 64);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 52);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 54);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // all_del
            // 
            this.all_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all_del.FlatAppearance.BorderSize = 0;
            this.all_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_del.Location = new System.Drawing.Point(273, 512);
            this.all_del.Name = "all_del";
            this.all_del.Size = new System.Drawing.Size(109, 52);
            this.all_del.TabIndex = 23;
            this.all_del.Text = "Очистить список заказов";
            this.all_del.UseVisualStyleBackColor = true;
            this.all_del.Click += new System.EventHandler(this.all_del_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 602);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 66);
            this.textBox1.TabIndex = 22;
            // 
            // plus_tovar
            // 
            this.plus_tovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_tovar.FlatAppearance.BorderSize = 0;
            this.plus_tovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_tovar.Location = new System.Drawing.Point(272, 570);
            this.plus_tovar.Name = "plus_tovar";
            this.plus_tovar.Size = new System.Drawing.Size(110, 25);
            this.plus_tovar.TabIndex = 21;
            this.plus_tovar.Text = "Добавить товар";
            this.plus_tovar.UseVisualStyleBackColor = true;
            this.plus_tovar.Click += new System.EventHandler(this.plus_tovar_Click);
            // 
            // sum
            // 
            this.sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum.FlatAppearance.BorderSize = 0;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Location = new System.Drawing.Point(183, 599);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(83, 69);
            this.sum.TabIndex = 20;
            this.sum.Text = "Расчетать сумму заказа";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // del
            // 
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Location = new System.Drawing.Point(99, 599);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(78, 69);
            this.del.TabIndex = 19;
            this.del.Text = "Убрать из списка заказов";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(12, 599);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 69);
            this.add.TabIndex = 18;
            this.add.Text = "Добавить к заказу";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // zakaz
            // 
            this.zakaz.BackColor = System.Drawing.Color.Snow;
            this.zakaz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zakaz.FormattingEnabled = true;
            this.zakaz.Location = new System.Drawing.Point(388, 512);
            this.zakaz.Name = "zakaz";
            this.zakaz.Size = new System.Drawing.Size(100, 156);
            this.zakaz.TabIndex = 17;
            // 
            // italy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.all_del);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plus_tovar);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.zakaz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tovari);
            this.Controls.Add(this.close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "italy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "italy";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.italy_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.italy_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox tovari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button all_del;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus_tovar;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox zakaz;
    }
}