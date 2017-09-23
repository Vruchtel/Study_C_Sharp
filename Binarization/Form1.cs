using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binarization
{
    public partial class Binarization : Form
    {
        string imagePath;

        public Binarization()
        {
            InitializeComponent();
            doBinarizationButton.Enabled = false;
        }

        public static Bitmap LoadBitmap(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                return new Bitmap(fs);
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            chooseFileDialog = new OpenFileDialog();

            if(chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем путь до файла
                imagePath = chooseFileDialog.FileName;

                Image img = Image.FromFile(imagePath);
                previewPictureBox.Image = img;

                fileNameLabel.Text = imagePath;

                doBinarizationButton.Enabled = true;
            }
        }

        private void doBinarization_Click(object sender, EventArgs e)
        {
            // Открываем файл в Bitmap
            Bitmap bmp = LoadBitmap(imagePath);

            // Нужно узнать, сколько пикселей в bmp
            long pixelsCount = bmp.Width * bmp.Height;

            // Засекаем время
            /////////////////////////
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Преобразуем его в двумерный массив пикселей
            Pixel[,] convertedBmp = Converter.BitmapToPixelRGB(bmp);
            messageLabel.Text = "Преобразование изображения в массив пикселей...";
            this.Update();

            // Дальше нужно преобразовать значение RGB в интенсивность серого для каждого пикселя
            double[,] convertedBmpInGrey = Converter.RGBToGreyIntensity(convertedBmp);
            messageLabel.Text = "Преобразование цвета в оттенки серого...";
            this.Update();

            // После чего запускается работа алгоритма Брэдли
            messageLabel.Text = "Бинаризация...";
            this.Update();
            BinarizationMaker BM = new BinarizationMaker(convertedBmpInGrey);
            int[,] resultIntensity = BM.Process();

            // Осталось сконвертировать результат бинаризации обратно в изображение
            messageLabel.Text = "Конвертация в изображение...";
            this.Update();
            Bitmap resultBmp = Converter.IntensityToBitmap(resultIntensity, imagePath);

            // Останавливаем замеры времени
            /////////////////////////////////////
            stopWatch.Stop();
            long milliseconds = stopWatch.ElapsedMilliseconds;
            long timeInSeconds = milliseconds / 1000;
            long megapixelsCount = pixelsCount / 1000000;
            MessageBox.Show("Расходы по времени: " + ((double)timeInSeconds / (double)megapixelsCount).ToString() +  " сек / мегапиксель");

            // Сохраняем результат
            messageLabel.Text = "Сохранение результата...";
            this.Update();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultBmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                // Покажем результат
                Image resultImg = Image.FromFile(saveFileDialog.FileName);
                resultPictureBox.Image = resultImg;
            }

            messageLabel.Text = "";
            this.Update();
        }
    }
}
