﻿using System;

namespace EasyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ReorderableListAttribute : SpecialCaseDrawerAttribute
	{
	}
}
