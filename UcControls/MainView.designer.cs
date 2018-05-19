namespace UcControls
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFitSize = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFitSize});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // tsmiFitSize
            // 
            this.tsmiFitSize.Name = "tsmiFitSize";
            this.tsmiFitSize.Size = new System.Drawing.Size(152, 22);
            this.tsmiFitSize.Text = "图像适应大小";
            this.tsmiFitSize.Click += new System.EventHandler(this.tsmiFitSize_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(355, 333);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.DoubleClick += new System.EventHandler(this.MainView_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainView_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainView_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MainView_MouseEnter);
            this.MouseHover += new System.EventHandler(this.MainView_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFitSize;
    }
}
