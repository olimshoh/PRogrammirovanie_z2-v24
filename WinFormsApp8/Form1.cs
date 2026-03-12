using System;
using System.Drawing;
using System.Windows.Forms;

namespace VstrechiProgram
{
    public partial class Form1 : Form
    {
        // Простые списки для хранения данных (как в методичке 2.2)
        private string[] nazvaniya = new string[100];  // названия встреч
        private double[] vremena = new double[100];    // время встреч
        private int kolvo = 0;  // сколько встреч добавлено

        public Form1()
        {
            InitializeComponent();
        }

        // Обновление списка на форме
        private void ObnovitSpisok()
        {
            listBoxMeetings.Items.Clear();
            for (int i = 0; i < kolvo; i++)
            {
                listBoxMeetings.Items.Add(nazvaniya[i] + " : " + vremena[i].ToString("F2"));
            }
        }

        // Кнопка ДОБАВИТЬ
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string nazvanie = textBoxName.Text.Trim();
            double vremya;

            // проверка 1: не пустое ли название
            if (nazvanie == "")
            {
                MessageBox.Show("Введите название встречи!");
                return;
            }

            // проверка 2: число ли введено
            try
            {
                vremya = Convert.ToDouble(textBoxTime.Text);
            }
            catch
            {
                MessageBox.Show("Введите число!");
                return;
            }

            // проверка 3: правильное ли время
            if (vremya < 0 || vremya >= 24)
            {
                MessageBox.Show("Время от 0 до 24!");
                return;
            }


            // всё хорошо - добавляем
            nazvaniya[kolvo] = nazvanie;
            vremena[kolvo] = vremya;
            kolvo++;

            // обновляем список на экране
            ObnovitSpisok();

            // очищаем поля ввода
            textBoxName.Clear();
            textBoxTime.Clear();

            labelResult.Text = "Встреча добавлена";
            labelResult.ForeColor = Color.Blue;
        }

        // Кнопка НАЙТИ
        private void buttonFind_Click(object sender, EventArgs e)
        {
            // если встреч нет
            if (kolvo == 0)
            {
                labelResult.Text = "Список пуст!";
                labelResult.ForeColor = Color.Red;
                return;
            }

            string resultName = "";
            double resultTime = -1;
            int resultIndex = -1;

            // ищем самую позднюю до 12:00
            for (int i = 0; i < kolvo; i++)
            {
                if (vremena[i] < 12)  // если до полудня
                {
                    if (vremena[i] > resultTime)  // если позже предыдущей
                    {
                        resultTime = vremena[i];
                        resultName = nazvaniya[i];
                        resultIndex = i;
                    }
                }
            }

            // выводим результат
            if (resultTime >= 0)
            {
                labelResult.Text = "Найдено: " + resultName + " в " + resultTime.ToString("F2");


                // выделяем в списке
                listBoxMeetings.SelectedIndex = resultIndex;
            }
            else
            {
                labelResult.Text = "Нет встреч до 12:00!";

                listBoxMeetings.SelectedIndex = -1;
            }
        }

        // Кнопка ОЧИСТИТЬ ПОЛЯ
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxTime.Clear();
            kolvo = 0;
            // Очистка списка на форме
            listBoxMeetings.Items.Clear();
            labelResult.Text = "";
        }
    }
}