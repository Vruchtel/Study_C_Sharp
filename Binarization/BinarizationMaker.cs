using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarization
{
    class BinarizationMaker
    {
        double[,] imageInGrey;
        int areaSize; // Боковой размер каждой отдельно рассматриваемой области
        int halfAreaSize; 
        double t = 0.15; // Значение порога
        double[,] integralImage;
        int width, height;
        int[,] resultImage;

        // Принимает матрицу изображения в интенсивности серого
        public BinarizationMaker(double[,] _imageInGrey)
        {
            imageInGrey = _imageInGrey;
            areaSize = imageInGrey.GetLength(1);
            halfAreaSize = areaSize / 2;
            width = imageInGrey.GetLength(1);
            height = imageInGrey.GetLength(0);
            integralImage = new double[height, width];
            resultImage = new int[height, width];
        }

        public int[,] Process()
        {
            CalculateIntegralImage();
            CalculateResultImage();

            return resultImage;
        }

        // Рассчёт интегрального изображения
        public void CalculateIntegralImage()
        {
            for(int x = 0; x < width; x++)
            {
                double iterationSum = 0;
                for(int y = 0; y < height; y++)
                {
                    iterationSum += imageInGrey[y, x];
                    if(x == 0)
                    {
                        integralImage[y, x] = iterationSum;
                    }
                    else
                    {
                        integralImage[y, x] = integralImage[y, x - 1] + iterationSum;
                    }
                }
            }
        }

        public void CalculateResultImage()
        {
            // Находим границы для локальных областей
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    int x1 = x - halfAreaSize;
                    int x2 = x + halfAreaSize;
                    int y1 = y - halfAreaSize;
                    int y2 = y + halfAreaSize;

                    if(x1 < 0)
                    {
                        x1 = 0;
                    }
                    if(x2 >= width)
                    {
                        x2 = width - 1;
                    }
                    if(y1 < 0)
                    {
                        y1 = 0;
                    }
                    if (y2 >= height)
                    {
                        y2 = height - 1;
                    }

                    int elementsInAreaCount = (x2 - x1) * (y2 - y1);

                    double currentAreaIntensity = integralImage[y2, x2] - integralImage[y1, x2] - integralImage[y2, x1] + integralImage[y1, x1];

                    if(elementsInAreaCount * imageInGrey[y, x] < currentAreaIntensity * (1.0 - t))
                    {
                        resultImage[y, x] = 0;
                    }
                    else
                    {
                        resultImage[y, x] = 255;
                    }
                }
            }
        }

    }
}
