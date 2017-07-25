using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Переводим координаты указателя мыши в строки и записываем в поля ввода
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            // Если координаты мыши лежат в очерчиваемом вокруг кнопки "да, конечно" прямоугольнике
            if(e.X > 230 && e.X < 350 && e.Y > 100 && e.Y < 130)
            {
                // Запоминаем текущее положение окна
                currentWindowLocation = this.Location;

                // Генерируем смещение окна по осям
                currentWindowLocation.X += rnd.Next(-200, 200);
                currentWindowLocation.Y += rnd.Next(-200, 200);

                // Если окно вылезло за пределы экрана по одной из осей
                if (currentWindowLocation.X < 0 
                    || currentWindowLocation.X > (_monitorWidth - this.Width) 
                    || currentWindowLocation.Y < 0 
                    || currentWindowLocation.Y > (_monitorHeight - this.Height))
                {
                    // Новыми координатами станет центр окна
                    currentWindowLocation.X = _monitorWidth / 2;
                    currentWindowLocation.Y = _monitorHeight / 2;
                }

                // Обновляем положение окна на новое сгенерированное
                this.Location = currentWindowLocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы усердны!", "Поздравляем!");
            // Завершить приложение
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Второй параметр - заголовок окна сообщения
            // третий - тип размещаемой кнопки на форме сообщения
            // четвёртый - тип сообщения (иконка + звуковой сигнал)
            MessageBox.Show("Мы не сомневались в Вашем безразличии!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Random rnd = new Random();
        private Point currentWindowLocation;
        private int _monitorWidth = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
        private int _monitorHeight = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

    }
}
