﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyApi
{
	public interface IControllerTypesProvider
	{
		IEnumerable<Type> GetControllerTypes();
	}
}
