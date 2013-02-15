using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGAresizer
{
	public class TGAResize : ITGAResize
	{
		private byte[] _image;

		public TGAResize(byte[] newImage)
		{
			_image = newImage;
		}

		public bool IsResizable()
		{
			System.Diagnostics.Debug.WriteLine("\tIsResizable() - NOT IMPLEMENTED");

			return true;
		}

		public void Resize()
		{
			System.Diagnostics.Debug.WriteLine("\tResize() - NOT IMPLEMENTED");
		}
	}
}
