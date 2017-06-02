using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Log
{
	public class TableLog : BaseLog
	{

		//можно было бы вынести в базовый клас так как этот метод будет очень полезен для всех наследников
		public void AddPeople(List<Person> data)
		{
			if (data == null) return;
			if (people == null)
			{
				people = new List<Person>();
			}
			people.AddRange(data);
		}

		public override string ToHtml()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<div>");

			sb.AppendLine("<table>");
			sb.AppendLine("<tr>");
			sb.AppendLine("<th>");
			sb.Append("First name");
			sb.Append("</th>");
			sb.AppendLine("<th>");
			sb.Append("Last name");
			sb.Append("</th>");
			sb.AppendLine("</tr>");

			sb.AppendLine("<tr>");
			for (var i = 0; i < people.Count; i++)
			{
				sb.AppendLine("<th>");
				sb.Append(GetName(i));
				sb.Append("</th>");
			}
			sb.AppendLine("</tr>");
			sb.AppendLine("</table>");

			sb.AppendLine("</div>");
			return sb.ToString();
		}
	}
}
