using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backing
{
    class BakeTime : Conexion
    {
		public int id_bt { get; set; }
		public double thickLow { get; set; }
		public double thickHigh { get; set; }
		public string level { get; set; }
		public string bakeTime { get; set; }

		public BakeTime()
		{
			
		}

		
	}
}
