namespace Sensor_Data_Interface_V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_of_sensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EXCEL_buton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LABEL_STATUS = new System.Windows.Forms.Label();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.comboBox_BAUDRATE = new System.Windows.Forms.ComboBox();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BUTON_CLOSE = new System.Windows.Forms.Button();
            this.BUTON_OPEN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_of_sensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_of_sensor
            // 
            resources.ApplyResources(this.chart_of_sensor, "chart_of_sensor");
            this.chart_of_sensor.BackColor = System.Drawing.Color.LightGray;
            this.chart_of_sensor.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Firebrick;
            chartArea1.Name = "ChartArea1";
            this.chart_of_sensor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_of_sensor.Legends.Add(legend1);
            this.chart_of_sensor.Name = "chart_of_sensor";
            this.chart_of_sensor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.LabelBackColor = System.Drawing.Color.Red;
            series1.LabelBorderColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "SENSORDATA";
            series1.ShadowColor = System.Drawing.Color.Red;
            this.chart_of_sensor.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "Title1";
            title1.Text = "X = Change in time, Y = Current Sensor Data";
            this.chart_of_sensor.Titles.Add(title1);
            // 
            // EXCEL_buton
            // 
            resources.ApplyResources(this.EXCEL_buton, "EXCEL_buton");
            this.EXCEL_buton.Name = "EXCEL_buton";
            this.EXCEL_buton.UseVisualStyleBackColor = true;
            this.EXCEL_buton.Click += new System.EventHandler(this.EXCEL_buton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.EXCEL_buton);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.LABEL_STATUS);
            this.groupBox1.Controls.Add(this.progressBar_statusBar);
            this.groupBox1.Controls.Add(this.comboBox_BAUDRATE);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BUTON_CLOSE);
            this.groupBox1.Controls.Add(this.BUTON_OPEN);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LABEL_STATUS
            // 
            resources.ApplyResources(this.LABEL_STATUS, "LABEL_STATUS");
            this.LABEL_STATUS.Name = "LABEL_STATUS";
            // 
            // progressBar_statusBar
            // 
            resources.ApplyResources(this.progressBar_statusBar, "progressBar_statusBar");
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            // 
            // comboBox_BAUDRATE
            // 
            resources.ApplyResources(this.comboBox_BAUDRATE, "comboBox_BAUDRATE");
            this.comboBox_BAUDRATE.FormattingEnabled = true;
            this.comboBox_BAUDRATE.Items.AddRange(new object[] {
            resources.GetString("comboBox_BAUDRATE.Items"),
            resources.GetString("comboBox_BAUDRATE.Items1"),
            resources.GetString("comboBox_BAUDRATE.Items2")});
            this.comboBox_BAUDRATE.Name = "comboBox_BAUDRATE";
            // 
            // comboBox_comPort
            // 
            resources.ApplyResources(this.comboBox_comPort, "comboBox_comPort");
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.DropDown += new System.EventHandler(this.comboBox_comPort_DropDown);
            this.comboBox_comPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_comPort_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BUTON_CLOSE
            // 
            resources.ApplyResources(this.BUTON_CLOSE, "BUTON_CLOSE");
            this.BUTON_CLOSE.Name = "BUTON_CLOSE";
            this.BUTON_CLOSE.UseVisualStyleBackColor = true;
            this.BUTON_CLOSE.Click += new System.EventHandler(this.BUTON_CLOSE_Click);
            // 
            // BUTON_OPEN
            // 
            resources.ApplyResources(this.BUTON_OPEN, "BUTON_OPEN");
            this.BUTON_OPEN.Name = "BUTON_OPEN";
            this.BUTON_OPEN.UseVisualStyleBackColor = true;
            this.BUTON_OPEN.Click += new System.EventHandler(this.BUTON_OPEN_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_of_sensor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_of_sensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_of_sensor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EXCEL_buton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LABEL_STATUS;
        private System.Windows.Forms.ProgressBar progressBar_statusBar;
        private System.Windows.Forms.ComboBox comboBox_BAUDRATE;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUTON_CLOSE;
        private System.Windows.Forms.Button BUTON_OPEN;
    }
}

