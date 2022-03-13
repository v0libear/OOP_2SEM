using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    
    public partial class Form1 : Form
    {
        public bool completenessFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tipvklada.Items.Add("Расчетные"); Tipvklada.Items.Add("Страхование");
            Tipvklada.Items.Add("Капитализация"); Tipvklada.Items.Add("Накопительные");
            Podklycheniebankinga.Items.Add("Да"); Podklycheniebankinga.Items.Add("Нет");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (
                    Firstname.Text.Length > 0 && Lastname.Text.Length > 0 &&
                    otchestvo.Text.Length > 0 && Nomer_scheta.Text.Length > 0 &&
                    (VisaRadioBtn.Checked || MastercardRadioBtn.Checked) &&
                    Tipvklada.Text.Length > 0 && Podklycheniebankinga.Text.Length > 0 &&
                    Balance.Text.Length > 0 &&
                    (YesRadioBtn.Checked || NoRadioBtn.Checked) && otchestvo.Text.Length > 0
                ) completenessFlag = true;


            if (completenessFlag)
            {
                FIO fio = new FIO();
                Schet schet = new Schet();
                fio.firstname = Firstname.Text;
                fio.lastname = Lastname.Text;
                fio.Otchestvo = otchestvo.Text;
                schet.nomer_scheta = Nomer_scheta.Text;
                foreach (RadioButton rb in cmc.Controls)
                {
                    if (rb.Checked) schet.podklcmc = rb.Text;
                }
                schet.tipvklada = Tipvklada.Text;
                schet.podklycheniebankinga = Podklycheniebankinga.Text;
                schet.balance = Balance.Text;
                foreach (RadioButton rb in TypeOfCardPanel.Controls)
                {
                    if (rb.Checked) schet.typeOfCardPanel = rb.Text;
                }

                Serialize(fio, schet);

            }
            else
            {
                MessageBox.Show(
                    "Вы не заполнили все необходимые поля!",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }



        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            List<BankForSerialize> disciplinesForSerialize = Deserialize();
            DisplayArea.Text = "";
            foreach (BankForSerialize discipline in disciplinesForSerialize)
            {
                DisplayArea.Text += $"" +
                $"Номер счёта: {discipline.Discipline.nomer_scheta} \r\n" +
                $"Подключение смс: {discipline.Discipline.podklcmc} \r\n" +
                $"Тип вклада: {discipline.Discipline.tipvklada} \r\n" +
                $"Банкинг: {discipline.Discipline.podklycheniebankinga} \r\n" +
                $"Тип карты: {discipline.Discipline.typeOfCardPanel} \r\n" +
                $"Баланс: {discipline.Discipline.balance} RUB \r\n \r\n" +
                $"Владелец: \r\n" +
                $"Фамилия: {discipline.Lector.firstname} \r\n" +
                $"Имя: {discipline.Lector.lastname} \r\n" +
                $"Отчество: {discipline.Lector.Otchestvo} \r\n \r\n \r\n";
            }

        }

        public void Serialize(FIO lector, Schet discipline)
        {
            BankForSerialize serializeMe = new BankForSerialize(lector, discipline);
            List<BankForSerialize> disciplinesForSerialize;
            if (File.Exists("pls.xml")) disciplinesForSerialize = Deserialize();
            else disciplinesForSerialize = new List<BankForSerialize>();
            disciplinesForSerialize.Add(serializeMe);
            XmlSerializer xmlf = new XmlSerializer(disciplinesForSerialize.GetType());

            using (FileStream fs = new FileStream("pls.xml", FileMode.OpenOrCreate))
            {
                xmlf.Serialize(fs, disciplinesForSerialize);
            }
        }

        public List<BankForSerialize> Deserialize()
        {
            List<BankForSerialize> disciplinesForSerialize = new List<BankForSerialize>();

            XmlSerializer xmlf = new XmlSerializer(disciplinesForSerialize.GetType());

            using (FileStream fs = new FileStream("pls.xml", FileMode.OpenOrCreate))
            {
                disciplinesForSerialize = (List<BankForSerialize>)xmlf.Deserialize(fs);
            }

            return disciplinesForSerialize;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 0) textBox.BackColor = Color.Red;
            else textBox.BackColor = Color.White;
        }

        private void LettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            TextBox textbox = (TextBox)sender;
            if (!Char.IsLetter(number)) e.Handled = true;
            if (number == (char)Keys.Back || (number == (char)Keys.Space && textbox.Text.Length > 0)) e.Handled = false;
        }

        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            TextBox textbox = (TextBox)sender;
            if (!Char.IsDigit(number)) e.Handled = true;
            if (!(textbox.Text.Length <= 10)) e.Handled = true;
            if (number == (char)Keys.Back) e.Handled = false;
        }


    }

    public class FIO
    {
        public string firstname;
        public string lastname;
        public string Otchestvo;
    }
    public class Schet
    {
        public string nomer_scheta;
        public string podklcmc;
        public string tipvklada;
        public string podklycheniebankinga;
        public string balance;
        public string numberOfLabratoryExercises;
        public string typeOfCardPanel;
    }
    
    [Serializable]
    public class BankForSerialize
    {
        public FIO Lector { get; set; }
        public Schet Discipline { get; set; }

        public BankForSerialize()
        {

        }

        public BankForSerialize(FIO lector, Schet discipline)
        {
            Lector = lector;
            Discipline = discipline;
        }

    }


}
