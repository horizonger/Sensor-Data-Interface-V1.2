using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Sensor_Data_Interface_V1
{
    public partial class Form1 : Form
    {

            Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();

            int Drows = 1;
            int NColumn1 = 1;
            int NColumn2 = 1;
            

        public Form1()
        {

           

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            

            BUTON_OPEN.Enabled = true;
            BUTON_CLOSE.Enabled = false;
            progressBar_statusBar.Value = 0;
            LABEL_STATUS.Text = "DISCONNECTED";
            LABEL_STATUS.ForeColor = Color.Red;


            comboBox_BAUDRATE.Text = "9600";
            
            

            chart_of_sensor.Series["SENSORDATA"].Points.AddXY(1, 1);
             
            
        }

        private void BUTON_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BAUDRATE.Text);
                serialPort1.Open();

                BUTON_OPEN.Enabled = false;
                BUTON_CLOSE.Enabled = true;
                progressBar_statusBar.Value = 100;
                LABEL_STATUS.Text = "CONNECTED";
                LABEL_STATUS.ForeColor = Color.Green;

                chart_of_sensor.Series["SENSORDATA"].Points.Clear();

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }
        private void BUTON_CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    BUTON_OPEN.Enabled = true;
                    BUTON_CLOSE.Enabled = false;
                    progressBar_statusBar.Value = 0;
                    LABEL_STATUS.Text = "DISCONNECTED";
                    LABEL_STATUS.ForeColor = Color.Red;

                    




                    timer1.Stop();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void LABEL_STATUS_Click(object sender, EventArgs e)
        {

        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           }

        private void Data_Parsing(string serialport)
        {

        }

        private void comboBox_comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_comPort_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.Clear();
            comboBox_comPort.Items.AddRange(portLists);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            string serialport = serialPort1.ReadExisting();
            
                    
            string serialport2 = serialPort1.ReadLine();
            
             
            chart_of_sensor.Series["SENSORDATA"].Points.AddY(serialport2);

            DateTime Tew = DateTime.Now;
        

            Drows = dataGridView1.Rows.Add();

            dataGridView1.Rows[Drows].Cells[0].Value = NColumn1;
            dataGridView1.Rows[Drows].Cells[1].Value = serialport2;
            

            dataGridView1.Rows[Drows].Cells[2].Value = Tew.ToLongTimeString();
            dataGridView1.Rows[Drows].Cells[3].Value = Tew.ToLongDateString();
            Drows++;
            NColumn1++;


            

        }

        private void EXCEL_buton_Click(object sender, EventArgs e)
        {



            objExcel.Visible = true;

               

                Microsoft.Office.Interop.Excel.Workbook objbook = objExcel.Workbooks.Add(System.Reflection.Missing.Value);
     
                Microsoft.Office.Interop.Excel.Worksheet objSheet = (Microsoft.Office.Interop.Excel.Worksheet)objbook.Worksheets.get_Item(1);

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)objSheet.Cells[1, i + 1];
                    myrange.Value2 = dataGridView1.Columns[i].HeaderText;

                }

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)objSheet.Cells[j + 2, i + 1];
                        myrange.Value2 = dataGridView1[i,j].Value;
                    }
                }
                
                
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
