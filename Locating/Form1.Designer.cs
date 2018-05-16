namespace Locating
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lsbOutput = new System.Windows.Forms.ListBox();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnInput = new System.Windows.Forms.Button();
			this.txtTips = new System.Windows.Forms.TextBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chtCurves = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPageCOM = new System.Windows.Forms.TabControl();
			this.tabPageTest = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbBaud = new System.Windows.Forms.ComboBox();
			this.cmbCOM = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnRenew = new System.Windows.Forms.Button();
			this.COM = new System.IO.Ports.SerialPort(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chtCurves)).BeginInit();
			this.tabPageCOM.SuspendLayout();
			this.tabPageTest.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lsbOutput
			// 
			this.lsbOutput.FormattingEnabled = true;
			this.lsbOutput.ItemHeight = 12;
			this.lsbOutput.Location = new System.Drawing.Point(3, 440);
			this.lsbOutput.Name = "lsbOutput";
			this.lsbOutput.Size = new System.Drawing.Size(693, 148);
			this.lsbOutput.TabIndex = 0;
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(20, 18);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(97, 21);
			this.txtInput.TabIndex = 1;
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(20, 45);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(97, 24);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "start";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// txtTips
			// 
			this.txtTips.Location = new System.Drawing.Point(702, 440);
			this.txtTips.Multiline = true;
			this.txtTips.Name = "txtTips";
			this.txtTips.Size = new System.Drawing.Size(142, 153);
			this.txtTips.TabIndex = 3;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(20, 75);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(97, 21);
			this.btnTest.TabIndex = 4;
			this.btnTest.Text = "button1";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.62774F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37226F));
			this.tableLayoutPanel1.Controls.Add(this.txtTips, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.chtCurves, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lsbOutput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tabPageCOM, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.48993F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.51007F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(847, 596);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// chtCurves
			// 
			this.chtCurves.Location = new System.Drawing.Point(3, 3);
			this.chtCurves.Name = "chtCurves";
			this.chtCurves.Size = new System.Drawing.Size(693, 431);
			this.chtCurves.TabIndex = 4;
			this.chtCurves.Text = "chart1";
			// 
			// tabPageCOM
			// 
			this.tabPageCOM.Controls.Add(this.tabPageTest);
			this.tabPageCOM.Controls.Add(this.tabPage2);
			this.tabPageCOM.Location = new System.Drawing.Point(702, 3);
			this.tabPageCOM.Name = "tabPageCOM";
			this.tabPageCOM.SelectedIndex = 0;
			this.tabPageCOM.Size = new System.Drawing.Size(142, 431);
			this.tabPageCOM.TabIndex = 5;
			// 
			// tabPageTest
			// 
			this.tabPageTest.Controls.Add(this.txtInput);
			this.tabPageTest.Controls.Add(this.btnTest);
			this.tabPageTest.Controls.Add(this.btnInput);
			this.tabPageTest.Location = new System.Drawing.Point(4, 22);
			this.tabPageTest.Name = "tabPageTest";
			this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTest.Size = new System.Drawing.Size(134, 405);
			this.tabPageTest.TabIndex = 0;
			this.tabPageTest.Text = "Settings";
			this.tabPageTest.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.cmbBaud);
			this.tabPage2.Controls.Add(this.cmbCOM);
			this.tabPage2.Controls.Add(this.btnConnect);
			this.tabPage2.Controls.Add(this.btnRenew);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(134, 405);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "COM";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Baud";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "COM";
			// 
			// cmbBaud
			// 
			this.cmbBaud.FormattingEnabled = true;
			this.cmbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.cmbBaud.Location = new System.Drawing.Point(38, 40);
			this.cmbBaud.Name = "cmbBaud";
			this.cmbBaud.Size = new System.Drawing.Size(88, 20);
			this.cmbBaud.TabIndex = 2;
			// 
			// cmbCOM
			// 
			this.cmbCOM.FormattingEnabled = true;
			this.cmbCOM.Location = new System.Drawing.Point(38, 10);
			this.cmbCOM.Name = "cmbCOM";
			this.cmbCOM.Size = new System.Drawing.Size(88, 20);
			this.cmbCOM.TabIndex = 1;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(8, 110);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(120, 26);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "连接";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnRenew
			// 
			this.btnRenew.Location = new System.Drawing.Point(8, 78);
			this.btnRenew.Name = "btnRenew";
			this.btnRenew.Size = new System.Drawing.Size(120, 26);
			this.btnRenew.TabIndex = 0;
			this.btnRenew.Text = "更新";
			this.btnRenew.UseVisualStyleBackColor = true;
			this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
			// 
			// COM
			// 
			this.COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.COM_DataReceived);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 621);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chtCurves)).EndInit();
			this.tabPageCOM.ResumeLayout(false);
			this.tabPageTest.ResumeLayout(false);
			this.tabPageTest.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lsbOutput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.TextBox txtTips;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chtCurves;
		private System.Windows.Forms.TabControl tabPageCOM;
		private System.Windows.Forms.TabPage tabPageTest;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbBaud;
		private System.Windows.Forms.ComboBox cmbCOM;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnRenew;
		private System.IO.Ports.SerialPort COM;
		private System.Windows.Forms.Label label2;
	}
}

