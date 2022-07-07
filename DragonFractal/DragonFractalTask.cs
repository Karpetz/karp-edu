// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			var random = new Random(seed);
			int option = 0;
			double x = 1, y = 0;
			double xsh = 0, ysh = 0;
			for(int i = 0; i < iterationsCount; i++)
            {
				option = random.Next(1, 3);
				if (option == 1)
                {
					xsh = (x * Math.Cos(45) - y * Math.Sin(45)) / Math.Sqrt(2);
					ysh = (x * Math.Sin(45) + y * Math.Cos(45)) / Math.Sqrt(2);
					x = xsh;
					y = ysh;
				}
                else
                {
					xsh = (x * Math.Cos(135) - y * Math.Sin(135)) / Math.Sqrt(2) + 1;
					ysh = (x * Math.Sin(135) + y * Math.Cos(135)) / Math.Sqrt(2);
					x = xsh;
					y = ysh;
				}
				pixels.SetPixel(x, y);
			}
		}
	}
}