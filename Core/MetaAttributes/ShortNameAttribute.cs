using System;

namespace EasyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ShortNameAttribute : MetaAttribute
	{
		public string Label { get; private set; }

		public ShortNameAttribute(string label)
		{
			Label = label;
		}
	}
}
