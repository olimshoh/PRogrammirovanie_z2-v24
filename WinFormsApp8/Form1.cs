using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp8;

namespace VstrechiProgram
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TVstrechi vstrechi = new TVstrechi();
            vstrechi.nazvanie = Convert.ToString(textBoxName.Text);
            vstrechi.vremya = Convert.ToDouble(textBoxTime.Text);
            listBoxMeetings.Items.Add(vstrechi);
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (listBoxMeetings.Items.Count == 0)
            {
                labelResult.Text = "Список встреч пуст";
                return;
            }

            TVstrechi latest = null; // самая поздняя встреча
            double maxTime = double.MinValue;

            foreach (var item in listBoxMeetings.Items)
            {
                TVstrechi meeting = item as TVstrechi;
                if (meeting != null && meeting.vremya < 12 && meeting.vremya > maxTime)
                {
                    maxTime = meeting.vremya;
                    latest = meeting;
                }
            }

            if (latest != null)
                labelResult.Text = $"Самая поздняя встреча до 12: {latest.nazvanie} в {latest.vremya}";
            else
                labelResult.Text = "Нет встреч до 12 часов";
        }



        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxMeetings.SelectedIndex != -1)
                listBoxMeetings.Items.RemoveAt(listBoxMeetings.SelectedIndex);
            else
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            
        }
    }
}