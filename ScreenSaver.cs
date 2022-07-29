using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
		[STAThread]
		static void Main(string[] args) 
		{
			ScrParameters parameters;

			string path = "ScreenSaverParams.json";
			if (File.Exists(path))
			{
				parameters = new JavaScriptSerializer().Deserialize<ScrParameters>(File.ReadAllText(path));
			}
			else
			{
				parameters = new ScrParameters();
			}

			if (args.Length > 0)
			{
				if (args[0].ToLower().Trim().Substring(0,2) == "/c")
				{
					Config c = new Config(parameters);
					c.ShowDialog();
				}
				else if (args[0].ToLower() == "/s")
				{
					Application.Run(new ScreenSaverGenerator(parameters));
				}
			}
			else
			{
				Application.Run(new ScreenSaverGenerator(parameters));
			}
		}
	}
}
