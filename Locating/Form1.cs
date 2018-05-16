using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Locating
{
	public partial class Form1 : Form
	{
		class test
		{
			private string i;
			public test() { I = "null"; }
			public string I
			{
				get { return i; }
				set { this.i = value; }
			}
		}
		public Form1()
		{
			InitializeComponent();
			InitialieOtherComp();
		}
		private System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
		private Dictionary<string, List<DataNode>> NodeDict = new Dictionary<string, List<DataNode>>();

		public void InitialieOtherComp()
		{
			InitChart();
		}
		private void InitChart()
		{
			ChartArea chartArea = new ChartArea("area1");
			chtCurves.ChartAreas.Clear();
			this.chtCurves.ChartAreas.Add(chartArea);
			chtCurves.BackColor = Color.DarkGray;
			chartArea.BackColor = Color.DarkGray;

			chartArea.AxisX.ScaleView.Size = 3;
			chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			chartArea.AxisX.ScrollBar.LineColor = SystemColors.ControlDarkDark;
			chartArea.AxisX.MajorTickMark.LineWidth = 0;
			chartArea.AxisX.MajorTickMark.Size = 0;
			chartArea.AxisX.IsStartedFromZero = true;

			// set Ledgend 
			Legend legend = new Legend("Curve1");
			legend.BackColor = SystemColors.ControlDark;
			chtCurves.Legends.Clear();
			chtCurves.Legends.Add(legend);
			legend.IsDockedInsideChartArea = true;
			legend.DockedToChartArea = "area1";
		}
		/**
		 * Read a line every single time
		 * one line --> one node
		 * display it on the chart
		 * count interval-time after reading from COM
		 */
		 private void ReceiveOnce(string rawData)
		 {
			TimeSpan time = watch.Elapsed;
			DataNode node = SaveNode(time, rawData);
			Series series = this.chtCurves.Series.FindByName(node.GetName());
			if (series == null)
			{
				series = new Series(node.GetName());
				series.LegendText = node.GetName();
				this.chtCurves.Series.Add(series);
				series.ChartType = SeriesChartType.Line;
				series.BorderWidth = 3;
			}
			series.Points.AddXY(Math.Round(node.GetTime().TotalSeconds, 2), node.GetValue());
			this.chtCurves.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
		}
		 //Usable
		 //将数据保存在NodeDict里
		 private DataNode SaveNode(TimeSpan time, string rawData)
		 {
			DataNode node = new DataNode(time, rawData, '#');
			if (NodeDict.ContainsKey(node.GetName()))
			{
				List<DataNode> list;
				NodeDict.TryGetValue(node.GetName(), out list);
				list.Add(node);
			}
			else
			{
				List<DataNode> list = new List<DataNode>();
				list.Add(node);
				NodeDict.Add(node.GetName(), list);
			}
			return node;
		 }

		//测试时间
		
		private string[] stringList1 = {"START#A0#19.229#END",
										"START#A1#19.459#END",
										"START#WRONG#33E3#END"};
		private string[] stringList2 = {"START#A0#27.08#END",
										"START#A2#25#END",
										"START#A1#23.09#END",
										"START#A3#JOD"};
		private int cnt = 0;
		private void btnInput_Click(object sender, EventArgs e)
		{

			//if (watch.IsRunning)
			//{
			//	btnInput.Text = "restart";
			//	watch.Stop();
			//	TimeSpan time = watch.Elapsed;
			//	for (int i = 0; i < stringList.Length; i++)
			//	{
			//		DataNode node = new DataNode(time, stringList[i], '#');
			//		string str = node.GetTimeString() + "   " + node.GetName() + " = " + node.GetValue();
			//		lsbOutput.Items.Add(str);
			//		SaveNode(time, stringList[i]);
			//	}
			//}
			//else {
			//	btnInput.Text = "stop";
			//	watch.Start();
			//}
			if (!watch.IsRunning) watch.Start();
			else
			{
				if (cnt == 0) { 
					foreach(string str in stringList1)
						ReceiveOnce(str);
					cnt++;
				}
				else{
					foreach (string str in stringList2)
						ReceiveOnce(str);
					cnt--;
				}
			}
		}

		//输出检查NodeDict
		private void displayDict(Dictionary<string,List<DataNode>> dictionary)
		{
			txtTips.Clear();
			foreach(KeyValuePair<string,List<DataNode>> KV in dictionary)
			{
				List<DataNode> list = KV.Value;
				string key = KV.Key;
				txtTips.Text += ("name = " + key + "\r\n");
				foreach(DataNode node in list)
				{
					txtTips.Text += ("--- "+node.GetTimeString()+"  value = " + node.GetValue() + "\r\n");
				}
			}
		}
		private void btnTest_Click(object sender, EventArgs e)
		{
			displayDict(NodeDict);
		}

		private void btnRenew_Click(object sender, EventArgs e)
		{
			/**
			 * 查找COM口
			 */
			string[] ports = System.IO.Ports.SerialPort.GetPortNames();
			string preSelected = cmbCOM.Text;
			int index = cmbCOM.Items.IndexOf(preSelected);
			bool flag = false;
			for (int i = 0; i < ports.Length; i++)
			{
				if (preSelected == ports[i])
					flag = true;
			}
			cmbCOM.Items.Clear();
			if (!flag) cmbCOM.Text = "";
			else cmbCOM.Text=preSelected;
			for (int i = 0; i < ports.Length; i++)
			{
				cmbCOM.Items.Add(ports[i]);
			}
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			//连接COM或断开
			if (cmbCOM.Text == "")
				txtTips.Text += "选择COM口!\r\n";
			else if (cmbBaud.Text == "")
				txtTips.Text += "选择波特率!\r\n";
			else
			{
				if (btnConnect.Text == "连接")
				{
					COM.PortName = cmbCOM.Text;
					int baud;
					int.TryParse(cmbBaud.Text, out baud);
					COM.BaudRate = baud;
					if (!COM.IsOpen)
					{
						try
						{
							COM.Open();
							cmbCOM.Enabled = false;
						}catch(System.IO.IOException exce)
						{
							txtTips.Text += exce.Message;
						}
					}
					if (!COM.IsOpen) txtTips.Text += "连接失败!\r\n";
				}
				else if (btnConnect.Text == "关闭") 
				{
					if (COM.IsOpen)
					{
						try
						{
							COM.Close();
							cmbCOM.Enabled = true;
						}
						catch(System.IO.IOException exce)
						{
							txtTips.Text += exce.Message;
						}
					}
					if (COM.IsOpen) txtTips.Text += "关闭失败!\r\n";
				}
			}
			if (COM.IsOpen) btnConnect.Text = "关闭";
			else btnConnect.Text = "连接";
		}

		private void COM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			if (COM.IsOpen)
			{
				int size = COM.BytesToRead;
				byte[] receive = new byte[size];
				COM.Read(receive, 0, size);
				string str = Encoding.Default.GetString(receive);

				ReceiveOnce(str);
				
			}
		}
	}
}
