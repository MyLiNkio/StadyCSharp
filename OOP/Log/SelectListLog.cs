using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Log
{
	public class SelectListLog : BaseLog
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
			//<select>
			//  <option>Пункт 1</option>
			//  <option>Пункт 2</option>
			//</select>

			sb.AppendLine("<select>");
			for (var i = 0; i < people.Count; i++)
			{
				sb.AppendLine("<option>");
				sb.Append(GetName(i));
				sb.AppendLine("</option>");
			}
			sb.AppendLine("</select>");
			sb.AppendLine("</div>");
			return sb.ToString();
		}
	}
}
