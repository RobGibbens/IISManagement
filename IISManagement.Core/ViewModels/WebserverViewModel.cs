using System;
using System.Collections.Generic;
using PropertyChanged;

namespace IISManagement.Core
{
	[ImplementPropertyChanged]
	public class WebserverViewModel
	{
		public WebserverViewModel()
		{
		}

		public List<string> Settings { get; private set; } = new List<string>() { "Websites", "Other"};
	}
}