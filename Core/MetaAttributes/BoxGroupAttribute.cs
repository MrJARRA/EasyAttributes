using System;

namespace EasyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class BoxGroupAttribute : MetaAttribute
	{
		public string Name { get; private set; }
		public EColor myColor { get; private set; }
		public BoxGroupAttribute(string name = "", EColor newColor = EColor.Gray)
		{
			Name = name;
			myColor = newColor;
		}
	}
}
