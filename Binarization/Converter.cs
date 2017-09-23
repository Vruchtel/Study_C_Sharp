using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Binarization
{ 
    public class Pixel
    {
        public Pixel() { }

        public Pixel(byte _R, byte _G, byte _B)
        {
            R = _R;
            G = _G;
            B = _B;
        }

        public byte R;
        public byte G;
        public byte B;
    }

    // Позволяет конвертировать изображение 2-мерный массив и обратно
    class Converter
    {
        // Возвращает массив элементов Pixel в координатах [y, x]
        public static Pixel[ , ] BitmapToPixelRGB(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            Pixel[,] result = new Pixel[height, width];

            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color currentPixelColor = bmp.GetPixel(x, y);
                    Pixel currentPixel = new Pixel(currentPixelColor.R,
                        currentPixelColor.G,
                        currentPixelColor.B);

                    result[y, x] = currentPixel;
                }
            }

            return result;
        }

        // По массиву значений RGB для каждого пикселя возвращает массив интенсивностей серого
        public static double[ , ] RGBToGreyIntensity(Pixel[ , ] RGBArray)
        {
            double[,] result = new double[RGBArray.GetLength(0), RGBArray.GetLength(1)];

            for(int y = 0; y < result.GetLength(0); y++)
            {
                for(int x = 0; x < result.GetLength(1); x++)
                {
                    result[y, x] = 0.2125 * RGBArray[y, x].R + 0.7154 * RGBArray[y, x].G + 0.0721 * RGBArray[y, x].B;
                }
            }

            return result;
        }

        // По массиву интенсивностей после бинаризации и пути файла возвращает bitmap с результатом
        public static Bitmap IntensityToBitmap(int[ , ] intensityArray, string imagePath)
        {
            Bitmap resultBmp = new Bitmap(imagePath);

            for(int y = 0; y < intensityArray.GetLength(0); y++)
            {
                for(int x = 0; x < intensityArray.GetLength(1); x++)
                {
                    if(intensityArray[y, x] == 255)
                    {
                        resultBmp.SetPixel(x, y, Color.White);
                    }
                    if(intensityArray[y, x] == 0)
                    {
                        resultBmp.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return resultBmp;
        }

    }
}
