using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvSubscribers.AutoGenerateColumns = false; // Змінено на gvSubscribers

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name"; // Змінено на Name
            column.Name = "Ім'я абонента"; // Змінено на Ім'я абонента
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PhoneNumber"; // Змінено на PhoneNumber
            column.Name = "Номер телефону"; // Змінено на Номер телефону
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Address"; // Змінено на Address
            column.Name = "Адреса"; // Змінено на Адреса
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CallMinutesPerMonth"; // Змінено на CallMinutesPerMonth
            column.Name = "Хвилин дзвінків на місяць"; // Змінено на Хвилин дзвінків на місяць
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SMSPerMonth"; // Змінено на SMSPerMonth
            column.Name = "Кількість SMS на місяць"; // Змінено на Кількість SMS на місяць
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MonthlyFee"; // Змінено на MonthlyFee
            column.Name = "Щомісячна плата, грн"; // Змінено на Щомісячна плата, грн
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasRoaming"; // Змінено на HasRoaming
            column.Name = "Роумінг"; // Змінено на Роумінг
            column.Width = 60;
            gvSubscribers.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasDataPlan"; // Змінено на HasDataPlan
            column.Name = "Тарифний план даних"; // Змінено на Тарифний план даних
            column.Width = 60;
            gvSubscribers.Columns.Add(column);

            // Додайте тестові дані для абонентів
            bindSrcSubscribers.Add(new Subscriber("Іван", "+380501234567", "Київ", 100, 50, 200, true, false));
            bindSrcSubscribers.Add(new Subscriber("Олена", "+380671234567", "Львів", 200, 150, 300, false, true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = new Subscriber();

            fSubscriber fs = new fSubscriber(subscriber); // Змінено на fSubscriber
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcSubscribers.Add(subscriber); // Змінено на bindSrcSubscribers
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = (Subscriber)bindSrcSubscribers.List[bindSrcSubscribers.Position]; // Змінено на Subscriber

            fSubscriber fs = new fSubscriber(subscriber); // Змінено на fSubscriber
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcSubscribers.List[bindSrcSubscribers.Position] = subscriber; // Змінено на bindSrcSubscribers
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcSubscribers.RemoveCurrent(); // Змінено на bindSrcSubscribers
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcSubscribers.Clear(); // Змінено на bindSrcSubscribers
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void gvSubscribers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Додаткові дії для кліку на клітинки, якщо необхідно
        }
    }
}