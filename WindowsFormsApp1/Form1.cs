using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Labor1
{
    public partial class Form1 : Form
    {
        private const string fileName = "INFO.TXT";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadDataFromFile();
        }
        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            List<Trains> trains = new List<Trains>();
            trains.Add(new Trains(tbTrainNumber.Text, tbDestinationStation.Text, tbDepartureTime.ToString, tbTravelTime.Text));
            string trainNumber = tbTrainNumber.Text.Trim();
            string destinationStation = tbDestinationStation.Text.Trim();
            string departureTime = tbDepartureTime.Text.Trim();
            string travelTime = tbTravelTime.Text.Trim();

            if (string.IsNullOrEmpty(trainNumber) || string.IsNullOrEmpty(destinationStation) ||
                string.IsNullOrEmpty(departureTime) || string.IsNullOrEmpty(travelTime))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvTrains.Items.Add(new ListViewItem(new[] { trainNumber, destinationStation, departureTime, travelTime }));
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (ListViewItem item in lvTrains.Items)
                    {
                        sw.WriteLine($"{item.SubItems[0].Text};{item.SubItems[1].Text};{item.SubItems[2].Text};{item.SubItems[3].Text}");
                    }
                }

                MessageBox.Show("Дані успішно збережено до файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних до файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            ReadDataFromFile();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {   
            string trainsInfo = "";

            foreach (ListViewItem item in lvTrains.Items)
            {
                DateTime departureTime = DateTime.Parse(item.SubItems[2].Text);
                if (departureTime.Hour <= 18 && departureTime.Minute <= 0)
                {
                    trainsInfo += $"Поїзд №{item.SubItems[0].Text} до станції {item.SubItems[1].Text}, відправлення о {departureTime.ToString("HH:mm")}, час в дорозі {item.SubItems[3].Text}.\n";
                }
            }

            if (string.IsNullOrEmpty(trainsInfo))
            {
                MessageBox.Show("Не знайдено поїздів, що відправляються до 18:00.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(trainsInfo, "Інформація про поїзди", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReadDataFromFile()
        {
            try
            {
                lvTrains.Items.Clear();

                if (File.Exists(fileName))
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split(';');

                            lvTrains.Items.Add(new ListViewItem(data));
                        }
                    }

                    MessageBox.Show("Дані успішно завантажено з файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Файл {fileName} не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних з файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
