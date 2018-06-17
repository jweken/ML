using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTestConsole
{
    class Program
    {
        static Bitmap _bitmap;

        private static Color x_col;

        static void Main(string[] args)
        {
            LoadBitMap(@"C:\Users\jweke\Source\Repos\ML\MLTester.v1\MLTestConsole\images\king1.jpg");
            Bitmap redcopy = _bitmap;

            for (int i = 0; i < 3000; i += 1)
            {
                x_col = redcopy.GetPixel(i*4/3, 1500);
                Console.WriteLine("TopLeft pixel = {0}  ::::\t x={1} y={2}", x_col, i*4/3, 1500);

            }
        }

        private static Bitmap LoadBitMap(string v)
        {
            try
            {
                _bitmap = (Bitmap)Image.FromFile(v);

            }
            catch (Exception e)
            {
                Console.WriteLine("Er is een fout opgetreden bij het laden van een bitmap:\n\n{0}", e.StackTrace);
            }
            Console.WriteLine("Image loaded: OK.\n Size of the bitmap = {0}", _bitmap.Size);
            return _bitmap;
        }
    }
}
