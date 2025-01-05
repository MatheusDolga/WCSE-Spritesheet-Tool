namespace We_Can_Sprite_Everything
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_path = new System.Windows.Forms.Button();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.nud_horizontal = new System.Windows.Forms.NumericUpDown();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.nud_vertical = new System.Windows.Forms.NumericUpDown();
            this.lbl_path = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_output
            // 
            this.btn_output.BackColor = System.Drawing.Color.Red;
            this.btn_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_output.Location = new System.Drawing.Point(147, 102);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(180, 191);
            this.btn_output.TabIndex = 0;
            this.btn_output.Text = "Do spritesheet!";
            this.btn_output.UseVisualStyleBackColor = false;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(147, 38);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(180, 58);
            this.btn_path.TabIndex = 1;
            this.btn_path.Text = "Select folder";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // nud_width
            // 
            this.nud_width.Location = new System.Drawing.Point(31, 72);
            this.nud_width.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_width.Name = "nud_width";
            this.nud_width.Size = new System.Drawing.Size(61, 20);
            this.nud_width.TabIndex = 2;
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info1.Location = new System.Drawing.Point(28, 56);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(95, 13);
            this.lbl_info1.TabIndex = 3;
            this.lbl_info1.Text = "Single sprite width:";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(28, 113);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(99, 13);
            this.lbl_info2.TabIndex = 5;
            this.lbl_info2.Text = "Single sprite height:";
            // 
            // nud_height
            // 
            this.nud_height.Location = new System.Drawing.Point(31, 129);
            this.nud_height.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(61, 20);
            this.nud_height.TabIndex = 4;
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(28, 177);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(90, 13);
            this.lbl_info3.TabIndex = 7;
            this.lbl_info3.Text = "Horizontal sprites:";
            // 
            // nud_horizontal
            // 
            this.nud_horizontal.Location = new System.Drawing.Point(31, 193);
            this.nud_horizontal.Name = "nud_horizontal";
            this.nud_horizontal.Size = new System.Drawing.Size(61, 20);
            this.nud_horizontal.TabIndex = 6;
            // 
            // lbl_info4
            // 
            this.lbl_info4.AutoSize = true;
            this.lbl_info4.Location = new System.Drawing.Point(28, 239);
            this.lbl_info4.Name = "lbl_info4";
            this.lbl_info4.Size = new System.Drawing.Size(78, 13);
            this.lbl_info4.TabIndex = 9;
            this.lbl_info4.Text = "Vertical sprites:";
            // 
            // nud_vertical
            // 
            this.nud_vertical.Location = new System.Drawing.Point(31, 255);
            this.nud_vertical.Name = "nud_vertical";
            this.nud_vertical.Size = new System.Drawing.Size(61, 20);
            this.nud_vertical.TabIndex = 8;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(144, 22);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(74, 13);
            this.lbl_path.TabIndex = 10;
            this.lbl_path.Text = "Current path: -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::We_Can_Sprite_Everything.Properties.Resources.wcse;
            this.pictureBox1.Location = new System.Drawing.Point(346, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lbl_info4);
            this.Controls.Add(this.nud_vertical);
            this.Controls.Add(this.lbl_info3);
            this.Controls.Add(this.nud_horizontal);
            this.Controls.Add(this.lbl_info2);
            this.Controls.Add(this.nud_height);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.nud_width);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.btn_output);
            this.Name = "Form1";
            this.Text = "We Can Sprite Everything";
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.NumericUpDown nud_horizontal;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.NumericUpDown nud_vertical;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

