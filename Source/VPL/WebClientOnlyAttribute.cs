﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Object Builder Utility
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace VPL
{
	public class WebClientOnlyAttribute : Attribute
	{
		public WebClientOnlyAttribute()
		{
		}
		public static bool IsWebClientOnly(PropertyDescriptor p)
		{
			Attribute a = p.Attributes[typeof(WebClientOnlyAttribute)];
			return (a != null);
		}
	}
}
