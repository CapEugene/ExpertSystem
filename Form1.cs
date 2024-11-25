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
            catch { MessageBox.Show("������������ ������ �����������."); }
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
            if (rbLess1Day.Checked) { return "����� 1 ���"; }
            else if (rb1to3Days.Checked) { return "1-3 ���"; }
            else if (rbMoreThan3Days.Checked) { return "����� 3 ����"; }
            else { return ""; }
        }

        private string GetCondition()
        {
            if (rbMild.Checked) { return "������"; }
            else if (rbModerate.Checked) { return "�������"; }
            else if (rbStrong.Checked) { return "�������"; }
            else { return ""; }
        }

        private string Analyze(string symptoms, double temperature, string? age, string duration, string condition)
        {
            // ������� �� ������ �����������
            if (temperature < 35) return "��� ��� ����� ���������?";
            if (temperature < 36.5 && symptoms.Contains("��������"))
                return "�������� �������: ����������";
            if (temperature >= 36.5 && temperature <= 37.5 && symptoms.Contains("�������") && symptoms.Contains("��������"))
                return "����������������� �������: ��������";
            if (temperature > 37.5 && temperature <= 38.5 && symptoms.Contains("�������� ����"))
                return "�������� �������: �������� ��������";
            if (temperature > 38.5 && symptoms.Contains("���� � �����") && symptoms.Contains("��������"))
                return "�������� �������: �����";
            if (temperature > 39)
                return "������ ���������� � �����";

            // ������� �� ������ ��������
            if (age == "�������" && temperature > 38 && duration == "1-3 ���")
                return "���������� ������������ ��������";
            if (age == "�������" && symptoms.Contains("��������") && temperature > 37.5)
                return "�������� ��������, ���������� � �����";
            if (age == "���������" && symptoms.Contains("�������� ����") && symptoms.Contains("������"))
                return "�������� �������: �����";
            if (age == "��������" && symptoms.Contains("���� � �����") && symptoms.Contains("�������"))
                return "�������� ��������";

            // ������� �� ������ ���������
            if (symptoms.Contains("������") && symptoms.Contains("���� � �����") && temperature > 37.5)
                return "�������� �������: ���������";
            if (symptoms.Contains("�������") && temperature >= 36.5 && temperature <= 37.5)
                return "�������� ��������";
            if (symptoms.Contains("�������� ����") && temperature > 37.5 && temperature <= 38.5)
                return "�������� �����������";
            if (symptoms.Contains("��������") && symptoms.Split(',').Length == 1)
                return "�������� ��������������";
            if (symptoms.Contains("���� � �����") && symptoms.Contains("�������") && temperature >= 37 && temperature <= 38)
                return "�������� �������: ��������";

            // ������� �� ������ ����������������� ���������
            if (duration == "����� 1 ���" && temperature < 38)
                return "�������� ������ ��������, ���������� �� ����������";
            if (duration == "1-3 ���" && condition == "�������")
                return "���������� � �����, ���� ��������� �� ���������";
            if (duration == "����� 3 ����" && temperature > 37.5)
                return "�������� ��������, ������������� ������������";
            if (duration == "����� 3 ����" && condition == "�������")
                return "������������� ������� ����������� ������������";

            // ������� �� ������ ������� �����������
            if (condition == "������" && temperature < 37)
                return "������������ �����";
            if (condition == "�������" && temperature >= 37.5 && temperature <= 38.5)
                return "�������� �����, ������� ��������������� ����";
            if (condition == "�������" && symptoms.Contains("��������"))
                return "���������� ���������� � �����";
            if (condition == "�������" && temperature > 39)
                return "�������� ������ ������";

            // �������������� ��������������� �������
            if (symptoms.Contains("������") && symptoms.Contains("�������") && temperature >= 36.5 && temperature <= 37.5)
                return "�������� ��������";
            if (symptoms.Contains("�������� ����") && symptoms.Contains("��������") && temperature >= 37 && temperature <= 38)
                return "�������� �������: �������� ��������";
            if (symptoms.Contains("������") && symptoms.Contains("���� � �����") && temperature > 38)
                return "�������� �������: �����";
            if (symptoms.Contains("���� � ������") && temperature > 38)
                return "�������� ���������� ��������";
            if (symptoms.Contains("�������") && symptoms.Contains("������") && temperature > 38.5)
                return "�������� �������: �������";

            return "������ ������������ ��� ���������� ��������. ���������� � �����.";
        }



    }
}
