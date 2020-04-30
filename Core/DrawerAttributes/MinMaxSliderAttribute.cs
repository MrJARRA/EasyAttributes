﻿using System;

namespace EasyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class MinMaxSliderAttribute : DrawerAttribute
	{
		public float MinValue { get; private set; }
		public float MaxValue { get; private set; }

		public MinMaxSliderAttribute(float minValue, float maxValue)
		{
			MinValue = minValue;
			MaxValue = maxValue;
		}
	}
}
