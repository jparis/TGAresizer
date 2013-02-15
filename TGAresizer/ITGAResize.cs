using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGAresizer
{
	public interface ITGAResize
	{
		bool IsResizable();
		void Resize();
	}
}