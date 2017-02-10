using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CESCO.IoT.ControllerClient
{
    public partial class frmController : Form
    {
        public frmController()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess dac = new DataAccess();
            HeartbeatEntity deviceInfo = dac.GetDeviceInfomation(textBox1.Text);
            if (deviceInfo == null)
            {
                MessageBox.Show("the device is not yet registered");
                return;
            }
            this.propertyGrid1.SelectedObject = deviceInfo;
            this.propertyGrid2.SelectedObject = deviceInfo.DeviceData;
            //MessageBox.Show(deviceInfo.LASTDATARECIEVED.ToLocalTime().ToString());
            //HeartbeatEntity deviceInfo = (dac.GetDeviceInfomation(textBox1.Text).Wait();
        }
    }
}
