namespace CSWeatherApp
{
    partial class condition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(condition));
            cityLabel = new Label();
            TBCity = new TextBox();
            btnSearch = new Button();
            conditionLabel = new Label();
            detailsLabel = new Label();
            sunriseLabel = new Label();
            sunsetLabel = new Label();
            pressureLabel = new Label();
            windLabel = new Label();
            weatherIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)weatherIcon).BeginInit();
            SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = Color.Transparent;
            cityLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cityLabel.ForeColor = SystemColors.ControlLightLight;
            cityLabel.Location = new Point(122, 114);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(82, 41);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City:";
            cityLabel.Click += label1_Click;
            // 
            // TBCity
            // 
            TBCity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TBCity.Location = new Point(226, 108);
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(312, 47);
            TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(559, 127);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search City";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.BackColor = Color.Transparent;
            conditionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            conditionLabel.ForeColor = SystemColors.ControlLightLight;
            conditionLabel.Location = new Point(122, 217);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(166, 41);
            conditionLabel.TabIndex = 4;
            conditionLabel.Text = "Condition:";
            conditionLabel.Click += label2_Click_1;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.BackColor = Color.Transparent;
            detailsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            detailsLabel.ForeColor = SystemColors.ControlLightLight;
            detailsLabel.Location = new Point(122, 258);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(123, 41);
            detailsLabel.TabIndex = 5;
            detailsLabel.Text = "Details:";
            // 
            // sunriseLabel
            // 
            sunriseLabel.AutoSize = true;
            sunriseLabel.BackColor = Color.Transparent;
            sunriseLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sunriseLabel.ForeColor = SystemColors.ControlLightLight;
            sunriseLabel.Location = new Point(122, 329);
            sunriseLabel.Name = "sunriseLabel";
            sunriseLabel.Size = new Size(129, 41);
            sunriseLabel.TabIndex = 6;
            sunriseLabel.Text = "Sunrise:";
            sunriseLabel.Click += label3_Click;
            // 
            // sunsetLabel
            // 
            sunsetLabel.AutoSize = true;
            sunsetLabel.BackColor = Color.Transparent;
            sunsetLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sunsetLabel.ForeColor = SystemColors.ControlLightLight;
            sunsetLabel.Location = new Point(122, 370);
            sunsetLabel.Name = "sunsetLabel";
            sunsetLabel.Size = new Size(120, 41);
            sunsetLabel.TabIndex = 7;
            sunsetLabel.Text = "Sunset:";
            // 
            // pressureLabel
            // 
            pressureLabel.AutoSize = true;
            pressureLabel.BackColor = Color.Transparent;
            pressureLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pressureLabel.ForeColor = SystemColors.ControlLightLight;
            pressureLabel.Location = new Point(481, 258);
            pressureLabel.Name = "pressureLabel";
            pressureLabel.Size = new Size(144, 41);
            pressureLabel.TabIndex = 9;
            pressureLabel.Text = "Pressure:";
            // 
            // windLabel
            // 
            windLabel.AutoSize = true;
            windLabel.BackColor = Color.Transparent;
            windLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            windLabel.ForeColor = SystemColors.ControlLightLight;
            windLabel.Location = new Point(481, 217);
            windLabel.Name = "windLabel";
            windLabel.Size = new Size(102, 41);
            windLabel.TabIndex = 8;
            windLabel.Text = "Wind:";
            windLabel.Click += label2_Click_2;
            // 
            // weatherIcon
            // 
            weatherIcon.BackColor = Color.Transparent;
            weatherIcon.Location = new Point(491, 349);
            weatherIcon.Name = "weatherIcon";
            weatherIcon.Size = new Size(125, 62);
            weatherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            weatherIcon.TabIndex = 10;
            weatherIcon.TabStop = false;
            weatherIcon.Click += pictureBox1_Click;
            // 
            // condition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(848, 580);
            Controls.Add(weatherIcon);
            Controls.Add(pressureLabel);
            Controls.Add(windLabel);
            Controls.Add(sunsetLabel);
            Controls.Add(sunriseLabel);
            Controls.Add(detailsLabel);
            Controls.Add(conditionLabel);
            Controls.Add(btnSearch);
            Controls.Add(TBCity);
            Controls.Add(cityLabel);
            DoubleBuffered = true;
            Name = "condition";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)weatherIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cityLabel;
        private TextBox TBCity;
        private Button btnSearch;
        private Label conditionLabel;
        private Label detailsLabel;
        private Label sunriseLabel;
        private Label sunsetLabel;
        private Label pressureLabel;
        private Label windLabel;
        private PictureBox weatherIcon;
    }
}