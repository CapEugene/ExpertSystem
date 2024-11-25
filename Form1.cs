using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                string symptoms = GetSelectedSymptoms();
                double temperature = double.Parse(txtTemperature.Text);
                string? age = GetSelectedAge();
                string duration = GetDuration();
                string condition = GetCondition();

                string diagnosis = Analyze(symptoms, temperature, age, duration, condition);

                MessageBox.Show(diagnosis);
            }
            catch { MessageBox.Show("Некорректный формат температуры."); }
        }

        private string GetSelectedSymptoms()
        {
            string symptoms = "";
            if (clbSymptoms.CheckedItems == null) { return symptoms; }
            foreach (var item in clbSymptoms.CheckedItems)
            {
                symptoms += item.ToString()?.ToLower() + ", ";
            }
            return symptoms.TrimEnd(',', ' ');
        }

        private string? GetSelectedAge()
        {
            if (cmbAge.SelectedItem == null) { return ""; }
            else { return cmbAge.SelectedItem.ToString(); }
        }

        private string GetDuration()
        {
            if (rbLess1Day.Checked) { return "менее 1 дня"; }
            else if (rb1to3Days.Checked) { return "1-3 дня"; }
            else if (rbMoreThan3Days.Checked) { return "более 3 дней"; }
            else { return ""; }
        }

        private string GetCondition()
        {
            if (rbMild.Checked) { return "легкая"; }
            else if (rbModerate.Checked) { return "средняя"; }
            else if (rbStrong.Checked) { return "сильная"; }
            else { return ""; }
        }

        private string Analyze(string symptoms, double temperature, string? age, string duration, string condition)
        {
            // Правила на основе температуры
            if (temperature < 35) return "Вам там точно нормально?";
            if (temperature < 36.5 && symptoms.Contains("слабость"))
                return "Возможен диагноз: гипотермия";
            if (temperature >= 36.5 && temperature <= 37.5 && symptoms.Contains("насморк") && symptoms.Contains("слабость"))
                return "Предположительный диагноз: простуда";
            if (temperature > 37.5 && temperature <= 38.5 && symptoms.Contains("головная боль"))
                return "Возможен диагноз: вирусная инфекция";
            if (temperature > 38.5 && symptoms.Contains("боль в горле") && symptoms.Contains("слабость"))
                return "Вероятен диагноз: грипп";
            if (temperature > 39)
                return "Срочно обратитесь к врачу";

            // Правила на основе возраста
            if (age == "ребенок" && temperature > 38 && duration == "1-3 дня")
                return "Необходима консультация педиатра";
            if (age == "пожилой" && symptoms.Contains("слабость") && temperature > 37.5)
                return "Возможна инфекция, обратитесь к врачу";
            if (age == "подросток" && symptoms.Contains("головная боль") && symptoms.Contains("кашель"))
                return "Возможен диагноз: грипп";
            if (age == "взрослый" && symptoms.Contains("боль в горле") && symptoms.Contains("насморк"))
                return "Вероятна простуда";

            // Правила на основе симптомов
            if (symptoms.Contains("кашель") && symptoms.Contains("боль в груди") && temperature > 37.5)
                return "Возможен диагноз: пневмония";
            if (symptoms.Contains("насморк") && temperature >= 36.5 && temperature <= 37.5)
                return "Вероятна аллергия";
            if (symptoms.Contains("головная боль") && temperature > 37.5 && temperature <= 38.5)
                return "Вирусное заболевание";
            if (symptoms.Contains("слабость") && symptoms.Split(',').Length == 1)
                return "Возможно перенапряжение";
            if (symptoms.Contains("боль в горле") && symptoms.Contains("насморк") && temperature >= 37 && temperature <= 38)
                return "Возможен диагноз: фарингит";

            // Правила на основе продолжительности симптомов
            if (duration == "менее 1 дня" && temperature < 38)
                return "Вероятно легкая простуда, наблюдайте за состоянием";
            if (duration == "1-3 дня" && condition == "средняя")
                return "Обратитесь к врачу, если состояние не улучшится";
            if (duration == "более 3 дней" && temperature > 37.5)
                return "Вероятна инфекция, рекомендуется обследование";
            if (duration == "более 3 дней" && condition == "сильная")
                return "Рекомендовано срочное медицинское обследование";

            // Правила на основе степени недомогания
            if (condition == "легкая" && temperature < 37)
                return "Рекомендован отдых";
            if (condition == "средняя" && temperature >= 37.5 && temperature <= 38.5)
                return "Возможен вирус, примите противовирусные меры";
            if (condition == "сильная" && symptoms.Contains("слабость"))
                return "Немедленно обратитесь к врачу";
            if (condition == "сильная" && temperature > 39)
                return "Вызовите скорую помощь";

            // Дополнительные комбинированные правила
            if (symptoms.Contains("кашель") && symptoms.Contains("насморк") && temperature >= 36.5 && temperature <= 37.5)
                return "Вероятна простуда";
            if (symptoms.Contains("головная боль") && symptoms.Contains("слабость") && temperature >= 37 && temperature <= 38)
                return "Возможен диагноз: вирусная инфекция";
            if (symptoms.Contains("кашель") && symptoms.Contains("боль в горле") && temperature > 38)
                return "Вероятен диагноз: грипп";
            if (symptoms.Contains("боль в мышцах") && temperature > 38)
                return "Возможна гриппозная инфекция";
            if (symptoms.Contains("насморк") && symptoms.Contains("кашель") && temperature > 38.5)
                return "Вероятен диагноз: синусит";

            return "Данных недостаточно для постановки диагноза. Обратитесь к врачу.";
        }



    }
}
