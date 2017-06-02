using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Log
{
	public class CheckListLog : BaseLog
	{
		public override string ToHtml()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<div style=\"border: solid 1px #eee;\">");
			for (var i = 0; i < people.Count; i++)
			{
				sb.AppendLine("<input type=\"checkbox\" checked=\"checked\" />");
				sb.Append(GetName(i));
				sb.AppendLine();
			}
			sb.AppendLine("</div>");
			return sb.ToString();
		}
	}
}
