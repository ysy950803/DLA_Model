namespace DLA_Model
{
    partial class MyDesign
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDesign));
            this.drawButton = new System.Windows.Forms.Button();
            this.radiusGroupBox = new System.Windows.Forms.GroupBox();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.third_radioButton = new System.Windows.Forms.RadioButton();
            this.second_radioButton = new System.Windows.Forms.RadioButton();
            this.first_radioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.drawMap = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.radiusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawButton.Location = new System.Drawing.Point(138, 368);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.draw_Click);
            // 
            // radiusGroupBox
            // 
            this.radiusGroupBox.Controls.Add(this.highLabel);
            this.radiusGroupBox.Controls.Add(this.lowLabel);
            this.radiusGroupBox.Controls.Add(this.radiusTrackBar);
            this.radiusGroupBox.Location = new System.Drawing.Point(28, 45);
            this.radiusGroupBox.Name = "radiusGroupBox";
            this.radiusGroupBox.Size = new System.Drawing.Size(88, 160);
            this.radiusGroupBox.TabIndex = 1;
            this.radiusGroupBox.TabStop = false;
            this.radiusGroupBox.Text = "Radius";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(18, 21);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(29, 12);
            this.highLabel.TabIndex = 12;
            this.highLabel.Text = "High";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(21, 128);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(23, 12);
            this.lowLabel.TabIndex = 10;
            this.lowLabel.Text = "Low";
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(23, 36);
            this.radiusTrackBar.Maximum = 50;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radiusTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radiusTrackBar.Size = new System.Drawing.Size(45, 89);
            this.radiusTrackBar.TabIndex = 9;
            this.radiusTrackBar.Value = 50;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.third_radioButton);
            this.colorGroupBox.Controls.Add(this.second_radioButton);
            this.colorGroupBox.Controls.Add(this.first_radioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(29, 211);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(87, 94);
            this.colorGroupBox.TabIndex = 2;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            this.colorGroupBox.Enter += new System.EventHandler(this.colorGroupBox_Enter);
            // 
            // third_radioButton
            // 
            this.third_radioButton.AutoSize = true;
            this.third_radioButton.Location = new System.Drawing.Point(19, 64);
            this.third_radioButton.Name = "third_radioButton";
            this.third_radioButton.Size = new System.Drawing.Size(47, 16);
            this.third_radioButton.TabIndex = 2;
            this.third_radioButton.TabStop = true;
            this.third_radioButton.Text = "Blue";
            this.third_radioButton.UseVisualStyleBackColor = true;
            this.third_radioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // second_radioButton
            // 
            this.second_radioButton.AutoSize = true;
            this.second_radioButton.Location = new System.Drawing.Point(19, 42);
            this.second_radioButton.Name = "second_radioButton";
            this.second_radioButton.Size = new System.Drawing.Size(47, 16);
            this.second_radioButton.TabIndex = 1;
            this.second_radioButton.TabStop = true;
            this.second_radioButton.Text = "Pink";
            this.second_radioButton.UseVisualStyleBackColor = true;
            // 
            // first_radioButton
            // 
            this.first_radioButton.AutoSize = true;
            this.first_radioButton.Location = new System.Drawing.Point(19, 20);
            this.first_radioButton.Name = "first_radioButton";
            this.first_radioButton.Size = new System.Drawing.Size(53, 16);
            this.first_radioButton.TabIndex = 0;
            this.first_radioButton.TabStop = true;
            this.first_radioButton.Text = "Black";
            this.first_radioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Location = new System.Drawing.Point(357, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // drawMap
            // 
            this.drawMap.Location = new System.Drawing.Point(138, 45);
            this.drawMap.Multiline = true;
            this.drawMap.Name = "drawMap";
            this.drawMap.Size = new System.Drawing.Size(294, 285);
            this.drawMap.TabIndex = 4;
            this.drawMap.TextChanged += new System.EventHandler(this.drawMap_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.titleLabel.Location = new System.Drawing.Point(60, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(324, 19);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Diffusion-Limited Aggregation Model";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.InitialImage")));
            this.logoPictureBox.Location = new System.Drawing.Point(28, 311);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(88, 80);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // MyDesign
            // 
            this.ClientSize = new System.Drawing.Size(455, 424);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.drawMap);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.radiusGroupBox);
            this.Controls.Add(this.drawButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyDesign";
            this.Tag = "";
            this.Text = "DLA Model";
            this.Load += new System.EventHandler(this.MyDesign_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.drawMap_Paint);
            this.radiusGroupBox.ResumeLayout(false);
            this.radiusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.GroupBox radiusGroupBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton third_radioButton;
        private System.Windows.Forms.RadioButton second_radioButton;
        private System.Windows.Forms.RadioButton first_radioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox drawMap;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}

