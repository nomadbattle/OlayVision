using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeviceNomad.BaslerCam;
using DeviceNomad.DahuaCam;

namespace DeviceNomad
{
    public partial class FormDeviceTest : Form
    {
        private DeviceType _curDeviceType = DeviceType.Basler;
        private string _currentCameraKey = null;
        private ICamera _camera = null;


        public FormDeviceTest()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitDeviceTypes();
            InitCameraRunMode();
        }

        private void InitDeviceTypes()
        {
            cmbDeviceTypes.Items.Clear();
            List<string> deviceTypes = DeviceN.GetDeviceTypes();
            cmbDeviceTypes.DataSource = deviceTypes;
        }

        private void ListCamerasByType()
        {
            string type = cmbDeviceTypes.SelectedValue?.ToString();
            List<string> cameraList = new List<string>();
            if (type == DeviceType.Basler.ToString())
            {
                _curDeviceType = DeviceType.Basler;
            }
            else if (type == DeviceType.Dahua.ToString())
            {
                _curDeviceType = DeviceType.Dahua;
                cameraList = DeviceN.GetCameraKeys(DeviceType.Dahua);
            }

            cmbCameraName.Items.Clear();
            foreach (string key in cameraList)
            {
                cmbCameraName.Items.Add(key);
            }
        }

        private void InitCameraRunMode()
        {
            cmbRunMode.Items.Clear();
            cmbRunMode.Items.Add(CameraRunMode.Single);
            cmbRunMode.Items.Add(CameraRunMode.Continue);
            cmbRunMode.SelectedIndex = 0;
        }

        private void OpenCurrentCamera()
        {
            if (_currentCameraKey == null)
                return;

            if (_curDeviceType == DeviceType.Dahua)
                _camera = new DahuaCamera();
            else
            {
                _camera = new BaslerCamera();
            }
            _camera.CameraKey = _currentCameraKey;
            _camera.InitCamera();
            _camera.Open();
            _camera.OnCameraOpened += Camera_OnCameraOpened;
            _camera.OnCameraClosed += Camera_OnCameraClosed;
            _camera.OnDeviceError += Camera_OnDeviceError;
            _camera.OnImageGrabbed += Camera_OnImageGrabbed;
            btnOpenCamera.Text = "关闭相机";
        }

        private void Camera_OnImageGrabbed(Bitmap bitmap)
        {
            
        }

        private void Camera_OnDeviceError(DeviceError errorType)
        {
            
        }

        private void Camera_OnCameraClosed()
        {
        }

        private void Camera_OnCameraOpened()
        {
            btnOpenCamera.Enabled = false;
        }

        private void Snap()
        {
            if(_camera==null)
                return;
            if (!_camera.IsOpen)
            {
                _camera.Open();
            }

            if (cmbRunMode.SelectedValue == null)
            {
                return;
            }
            CameraRunMode runMode = (CameraRunMode)cmbRunMode.SelectedValue;
            if (runMode == CameraRunMode.Single)
            {

            }
            else
            {

            }
            _camera.Snap();
        }

        private void CloseCamera(string key)
        {
        }

        private void FormDeviceTest_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                Init();
        }
        private void FormDeviceTest_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cmbDeviceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListCamerasByType();
        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpenCamera.Text == "打开相机")
                {
                    OpenCurrentCamera();
                    btnRun.Enabled = true;
                }
                else
                {
                    _camera?.Close();
                    btnRun.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpenCamera.Text == "运行")
                {
                    Snap();
                    btnOpenCamera.Text = "关闭";
                }
                else
                {
                    _camera.StopRun();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbCameraName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentCameraKey != null)
            {
                _camera?.Dispose();
                btnOpenCamera.Text = "打开相机";
            }

            _currentCameraKey = cmbCameraName.SelectedValue as string;
            if (_currentCameraKey == null)
            {
                btnOpenCamera.Enabled = false;
                btnRun.Enabled = false;
            }
            else
                btnOpenCamera.Enabled = true;
        }
    }
}
