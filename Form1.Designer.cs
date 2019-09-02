namespace Selection
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CreatureCounter = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpotRowCounter = new System.Windows.Forms.NumericUpDown();
            this.SpotCounter = new System.Windows.Forms.NumericUpDown();
            this.ChBoxAuto = new System.Windows.Forms.CheckBox();
            this.BtnMakeStep = new System.Windows.Forms.Button();
            this.BtnGenerateCreatures = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SpotTab = new System.Windows.Forms.TabPage();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AggressionChart = new LiveCharts.WinForms.CartesianChart();
            this.GenerationChart = new LiveCharts.WinForms.CartesianChart();
            this.CountChart = new LiveCharts.WinForms.CartesianChart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeChart = new LiveCharts.WinForms.CartesianChart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Automatic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatureCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotRowCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotCounter)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SpotTab.SuspendLayout();
            this.StatTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1121, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.84252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.15748F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 552);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CreatureCounter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SpotRowCounter);
            this.panel1.Controls.Add(this.SpotCounter);
            this.panel1.Controls.Add(this.ChBoxAuto);
            this.panel1.Controls.Add(this.BtnMakeStep);
            this.panel1.Controls.Add(this.BtnGenerateCreatures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1144, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 546);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Creatures";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CreatureCounter
            // 
            this.CreatureCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatureCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatureCounter.Location = new System.Drawing.Point(14, 380);
            this.CreatureCounter.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CreatureCounter.Name = "CreatureCounter";
            this.CreatureCounter.Size = new System.Drawing.Size(100, 27);
            this.CreatureCounter.TabIndex = 8;
            this.CreatureCounter.ValueChanged += new System.EventHandler(this.CreatureCounter_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Spot rows";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Spots";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SpotRowCounter
            // 
            this.SpotRowCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpotRowCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpotRowCounter.Location = new System.Drawing.Point(14, 510);
            this.SpotRowCounter.Name = "SpotRowCounter";
            this.SpotRowCounter.Size = new System.Drawing.Size(100, 27);
            this.SpotRowCounter.TabIndex = 5;
            this.SpotRowCounter.ValueChanged += new System.EventHandler(this.SpotRowCounter_ValueChanged);
            // 
            // SpotCounter
            // 
            this.SpotCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpotCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpotCounter.Location = new System.Drawing.Point(14, 445);
            this.SpotCounter.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SpotCounter.Name = "SpotCounter";
            this.SpotCounter.Size = new System.Drawing.Size(100, 27);
            this.SpotCounter.TabIndex = 4;
            this.SpotCounter.ValueChanged += new System.EventHandler(this.SpotCounter_ValueChanged);
            // 
            // ChBoxAuto
            // 
            this.ChBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChBoxAuto.AutoSize = true;
            this.ChBoxAuto.Enabled = false;
            this.ChBoxAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChBoxAuto.Location = new System.Drawing.Point(14, 81);
            this.ChBoxAuto.Name = "ChBoxAuto";
            this.ChBoxAuto.Size = new System.Drawing.Size(65, 24);
            this.ChBoxAuto.TabIndex = 3;
            this.ChBoxAuto.Text = "Auto";
            this.ChBoxAuto.UseVisualStyleBackColor = true;
            this.ChBoxAuto.CheckedChanged += new System.EventHandler(this.ChBoxAuto_CheckedChanged);
            // 
            // BtnMakeStep
            // 
            this.BtnMakeStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMakeStep.Enabled = false;
            this.BtnMakeStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMakeStep.Location = new System.Drawing.Point(14, 45);
            this.BtnMakeStep.Name = "BtnMakeStep";
            this.BtnMakeStep.Size = new System.Drawing.Size(100, 30);
            this.BtnMakeStep.TabIndex = 2;
            this.BtnMakeStep.Text = "Step";
            this.BtnMakeStep.UseVisualStyleBackColor = true;
            this.BtnMakeStep.Click += new System.EventHandler(this.BtnMakeStep_Click);
            // 
            // BtnGenerateCreatures
            // 
            this.BtnGenerateCreatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateCreatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGenerateCreatures.Location = new System.Drawing.Point(14, 9);
            this.BtnGenerateCreatures.Name = "BtnGenerateCreatures";
            this.BtnGenerateCreatures.Size = new System.Drawing.Size(100, 30);
            this.BtnGenerateCreatures.TabIndex = 1;
            this.BtnGenerateCreatures.Text = "Generate";
            this.BtnGenerateCreatures.UseVisualStyleBackColor = true;
            this.BtnGenerateCreatures.Click += new System.EventHandler(this.BtnGenerateCreatures_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.SpotTab);
            this.tabControl1.Controls.Add(this.StatTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 546);
            this.tabControl1.TabIndex = 3;
            // 
            // SpotTab
            // 
            this.SpotTab.Controls.Add(this.pictureBox1);
            this.SpotTab.Location = new System.Drawing.Point(4, 32);
            this.SpotTab.Name = "SpotTab";
            this.SpotTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpotTab.Size = new System.Drawing.Size(1127, 510);
            this.SpotTab.TabIndex = 0;
            this.SpotTab.Text = "Spots";
            this.SpotTab.UseVisualStyleBackColor = true;
            // 
            // StatTab
            // 
            this.StatTab.Controls.Add(this.tableLayoutPanel2);
            this.StatTab.Controls.Add(this.richTextBox1);
            this.StatTab.Location = new System.Drawing.Point(4, 32);
            this.StatTab.Name = "StatTab";
            this.StatTab.Size = new System.Drawing.Size(1127, 510);
            this.StatTab.TabIndex = 1;
            this.StatTab.Text = "Statistics";
            this.StatTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AggressionChart, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.GenerationChart, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CountChart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AgeChart, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.263773F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.73623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.263773F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.73623F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1127, 510);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AggressionChart
            // 
            this.AggressionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AggressionChart.Location = new System.Drawing.Point(566, 299);
            this.AggressionChart.Name = "AggressionChart";
            this.AggressionChart.Size = new System.Drawing.Size(558, 208);
            this.AggressionChart.TabIndex = 11;
            this.AggressionChart.Text = "cartesianChart1";
            // 
            // GenerationChart
            // 
            this.GenerationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerationChart.Location = new System.Drawing.Point(3, 299);
            this.GenerationChart.Name = "GenerationChart";
            this.GenerationChart.Size = new System.Drawing.Size(557, 208);
            this.GenerationChart.TabIndex = 10;
            this.GenerationChart.Text = "cartesianChart1";
            // 
            // CountChart
            // 
            this.CountChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountChart.Location = new System.Drawing.Point(3, 45);
            this.CountChart.Name = "CountChart";
            this.CountChart.Size = new System.Drawing.Size(557, 206);
            this.CountChart.TabIndex = 9;
            this.CountChart.Text = "cartesianChart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(566, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(558, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aggression";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(566, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeChart
            // 
            this.AgeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeChart.Location = new System.Drawing.Point(566, 45);
            this.AgeChart.Name = "AgeChart";
            this.AgeChart.Size = new System.Drawing.Size(558, 206);
            this.AgeChart.TabIndex = 8;
            this.AgeChart.Text = "cartesianChart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1127, 510);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Automatic
            // 
            this.Automatic.Interval = 300;
            this.Automatic.Tick += new System.EventHandler(this.Automatic_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1270, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatureCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotRowCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpotCounter)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SpotTab.ResumeLayout(false);
            this.StatTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnGenerateCreatures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMakeStep;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SpotTab;
        private System.Windows.Forms.TabPage StatTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox ChBoxAuto;
        private System.Windows.Forms.Timer Automatic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart AgeChart;
        private LiveCharts.WinForms.CartesianChart CountChart;
        private LiveCharts.WinForms.CartesianChart AggressionChart;
        private LiveCharts.WinForms.CartesianChart GenerationChart;
        private System.Windows.Forms.NumericUpDown SpotCounter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SpotRowCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CreatureCounter;
    }
}

