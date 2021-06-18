using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            AutoCompleteStringCollection source1 = new AutoCompleteStringCollection()
          {
            "Кузнецов",
             "Иванов",
             "Петров",
             "Кустов",
             "Борисов",
             "Яковлев",
            "Григорьев",
            "Романов",
            "Воробьев",
            "Сергеев",
            "Кузьмин",
            "Фролов",
            "Пупкин",
            "Чехлов",
            "Зарубкин",
            "Шишкин",
            "Кочерыжкин",
            "Ёлкин",
            "Дрынов",
            "Петров",
            "Дынин",
            "Кукушкин",
            "Смирнов",
            "Лысенко",
            "Пономарёв",
            "Палкин",
            "Сидоров",
            "Плюшкин",
            "Червоный",
            "Печкин",



           };
            textBox2.AutoCompleteCustomSource = source1;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection source2 = new AutoCompleteStringCollection()
          {
             "Иван",
             "Петр",
             "Илья",
             "Максим",
             "Борис",
             "Яков",
            "Григорий",
            "Роман",
            "Игорь",
            "Сергей",
            "Кузьма",
            "Федор",
            "Вадим",
            "Алексей",
            "Дмитрий",
            "Павел",
            "Юрий",
            "Константин",
            "Василий",
            "Ян",
            "Анатолий",
            "Николай",
            "Антон",
            "Валера",
            "Семен",
            "Владимир",
            "Сидор",
            "Артём",
            "Павел",
            "Данил"


           };
            textBox3.AutoCompleteCustomSource = source2;
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection source3 = new AutoCompleteStringCollection()
          {
            "Иванович",
             "Петрович",
             "Ильич",
             "Максимович",
             "Борисович",
             "Яковлевич",
            "Григорьевич",
            "Романович",
            "Игоревич",
            "Сергеич",
            "Кузьмич",
            "Федорович",
            "Вадимович",
            "Алексеич",
            "Дмитриевич",
            "Павлович",
            "Юрьевич",
            "Константинович",
            "Васильевич",
            "Янович",
            "Анатольевич",
            "Николаевич",
            "Антонович",
            "Валерьевич",
            "Семенович",
            "Владимирович",
            "Сидорович",
            "Артёмович",
            "Павлович",
            "Данилович"


           };
            textBox1.AutoCompleteCustomSource = source3;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
