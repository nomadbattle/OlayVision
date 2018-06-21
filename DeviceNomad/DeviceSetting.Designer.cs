namespace DeviceNomad
{
    partial class DeviceSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRunMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.cmbCameraName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeviceTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbRunMode
            // 
            this.cmbRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunMode.FormattingEnabled = true;
            this.cmbRunMode.Location = new System.Drawing.Point(93, 117);
            this.cmbRunMode.Name = "cmbRunMode";
            this.cmbRunMode.Size = new System.Drawing.Size(121, 20);
            this.cmbRunMode.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "运行模式";
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(117, 82);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Enabled = false;
            this.btnOpenCamera.Location = new System.Drawing.Point(36, 82);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCamera.TabIndex = 12;
            this.btnOpenCamera.Text = "打开相机";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            // 
            // cmbCameraName
            // 
            this.cmbCameraName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraName.FormattingEnabled = true;
            this.cmbCameraName.Location = new System.Drawing.Point(93, 42);
            this.cmbCameraName.Name = "cmbCameraName";
            this.cmbCameraName.Size = new System.Drawing.Size(121, 20);
            this.cmbCameraName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "相机名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "相机类型";
            // 
            // cmbDeviceTypes
            // 
            this.cmbDeviceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceTypes.FormattingEnabled = true;
            this.cmbDeviceTypes.Location = new System.Drawing.Point(93, 16);
            this.cmbDeviceTypes.Name = "cmbDeviceTypes";
            this.cmbDeviceTypes.Size = new System.Drawing.Size(121, 20);
            this.cmbDeviceTypes.TabIndex = 8;
            // 
            // DeviceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbRunMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.cmbCameraName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeviceTypes);
            this.Name = "DeviceSetting";
            this.Size = new System.Drawing.Size(235, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
