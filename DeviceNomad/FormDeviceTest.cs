using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceNomad
{
    public partial class FormDeviceTest : Form
    {
        public FormDeviceTest()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitDeviceTypes();
        }

        private void InitDeviceTypes()
        {
            cmbDeviceTypes.Items.Clear();
            List<string> deviceTypes = DeviceN.GetDeviceTypes();
            cmbDeviceTypes.DataSource = deviceTypes;
        }

        private void ListCamerasByType()
        {
            string type = cmbDeviceTypes.SelectedText;
            if (type == DeviceType.Basler.ToString())
            {
            }
            else if (type == DeviceType.Dahua.ToString())
            {
            }
        }

        private void FormDeviceTest_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                Init();
        }

        private void cmbDeviceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListCamerasByType();
        }
    }
}
