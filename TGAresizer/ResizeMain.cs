using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGAresizer
{
	class ResizeMain
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Reading from file.");
			// read from file, using cmd line args
			byte[] someImage = new byte[10];

			ITGAResize resizer = new TGAResize(someImage);

			Console.WriteLine("Checking if image is resizable.");
			if (resizer.IsResizable())
			{
				Console.WriteLine("Resizing image.");
				resizer.Resize();

				Console.WriteLine("Saving image to file.");
				// save back to file
			}
			else
			{
				// warn about not being able to resize.
			}
			Console.WriteLine("Done!");
		}
	}
}
