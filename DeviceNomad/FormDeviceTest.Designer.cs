namespace DeviceNomad
{
    partial class FormDeviceTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRunMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.cmbCameraName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeviceTypes = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainView1 = new JdLogistics.MainView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRunMode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.btnOpenCamera);
            this.panel1.Controls.Add(this.cmbCameraName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDeviceTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(602, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 558);
            this.panel1.TabIndex = 1;
            // 
            // cmbRunMode
            // 
            this.cmbRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunMode.FormattingEnabled = true;
            this.cmbRunMode.Location = new System.Drawing.Point(78, 124);
            this.cmbRunMode.Name = "cmbRunMode";
            this.cmbRunMode.Size = new System.Drawing.Size(121, 20);
            this.cmbRunMode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "运行模式";
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(102, 89);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Enabled = false;
            this.btnOpenCamera.Location = new System.Drawing.Point(21, 89);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCamera.TabIndex = 4;
            this.btnOpenCamera.Text = "打开相机";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // cmbCameraName
            // 
            this.cmbCameraName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraName.FormattingEnabled = true;
            this.cmbCameraName.Location = new System.Drawing.Point(78, 49);
            this.cmbCameraName.Name = "cmbCameraName";
            this.cmbCameraName.Size = new System.Drawing.Size(121, 20);
            this.cmbCameraName.TabIndex = 3;
            this.cmbCameraName.SelectedIndexChanged += new System.EventHandler(this.cmbCameraName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "相机名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "相机类型";
            // 
            // cmbDeviceTypes
            // 
            this.cmbDeviceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceTypes.FormattingEnabled = true;
            this.cmbDeviceTypes.Location = new System.Drawing.Point(78, 23);
            this.cmbDeviceTypes.Name = "cmbDeviceTypes";
            this.cmbDeviceTypes.Size = new System.Drawing.Size(121, 20);
            this.cmbDeviceTypes.TabIndex = 0;
            this.cmbDeviceTypes.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceTypes_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 34);
            this.panel2.TabIndex = 2;
            // 
            // mainView1
            // 
            this.mainView1.Content = null;
            this.mainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView1.Location = new System.Drawing.Point(0, 0);
            this.mainView1.Name = "mainView1";
            this.mainView1.Size = new System.Drawing.Size(602, 524);
            this.mainView1.TabIndex = 0;
            // 
            // FormDeviceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 558);
            this.Controls.Add(this.mainView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDeviceTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相机设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeviceTest_FormClosing);
            this.Load += new System.EventHandler(this.FormDeviceTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JdLogistics.MainView mainView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbRunMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.ComboBox cmbCameraName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeviceTypes;
    }
}