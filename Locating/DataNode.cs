using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locating
{
	class DataNode
	{
		private TimeSpan time;
		private string rawData;
		private string name;
		private double val;
		private char spiltChar;
		private string start = "START";
		private string end = "END";

		public DataNode(TimeSpan time, string rawData, char spiltChar)
		{
			this.time = time;
			this.rawData = rawData;
			this.spiltChar = spiltChar;
			this.Spilt(start, end);
		}

		private void Spilt(string beginMark, string endMark)
		{
			string[] str = rawData.Split(spiltChar);
			if (str[0] == beginMark && str[str.Length - 1] == endMark && str.Length == 4)
			{
				if (System.Text.RegularExpressions.Regex.IsMatch(str[2], @"[0-9]+$")
					&& double.TryParse(str[2], out val)
					&& !(str[2].Contains("E"))
					&& !(str[2].Contains("e"))
					) {}//这个句子有正确格式 
				else val = 0;
				name = str[1];
				return ;
			}
			name = "NULL";
			val = 0;
		}
		public TimeSpan GetTime() { return this.time; }
		public string GetTimeString()
		{
			return this.time.Hours + ":" + this.time.Minutes + ":"
				+ this.time.Seconds + ":" + this.time.Milliseconds;
		}
		public string GetName() { return this.name; }
		public double GetValue() { return this.val; }
	}
	
}
