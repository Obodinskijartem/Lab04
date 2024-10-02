using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Subscriber
    {
        public string Name { get; set; }                // Ім'я абонента
        public string PhoneNumber { get; set; }         // Номер телефону
        public string Address { get; set; }             // Адреса абонента
        public int CallMinutesPerMonth { get; set; }    // Кількість хвилин дзвінків на місяць
        public int SMSPerMonth { get; set; }            // Кількість SMS на місяць
        public double MonthlyFee { get; set; }          // Щомісячна плата за послуги
        public bool HasRoaming { get; set; }            // Наявність роумінгу
        public bool HasDataPlan { get; set; }           // Наявність тарифного плану даних

        // Метод для розрахунку щомісячної плати зі знижкою
        public double CalculateDiscountedFee()
        {
            double discountPercentage = 20;  // Приклад знижки 20%
            return MonthlyFee - (MonthlyFee * discountPercentage / 100);
        }

        // Метод для розрахунку додаткової знижки для постійних клієнтів
        public double CalculateRegularCustomerDiscount()
        {
            double additionalDiscount = 5;   // Додаткова знижка для постійних клієнтів
            return CalculateDiscountedFee() - (CalculateDiscountedFee() * additionalDiscount / 100);
        }

        // Властивість для отримання зниженої плати
        public double DiscountedFee
        {
            get
            {
                return CalculateDiscountedFee();
            }
        }

        // Властивість для отримання зниженої плати для постійних клієнтів
        public double RegularCustomerDiscountedFee
        {
            get
            {
                return CalculateRegularCustomerDiscount();
            }
        }

        // Конструктор без параметрів
        public Subscriber()
        {
        }

        // Конструктор з параметрами
        public Subscriber(string name, string phoneNumber, string address, int callMinutesPerMonth, int smsPerMonth, double monthlyFee, bool hasRoaming, bool hasDataPlan)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            CallMinutesPerMonth = callMinutesPerMonth;
            SMSPerMonth = smsPerMonth;
            MonthlyFee = monthlyFee;
            HasRoaming = hasRoaming;
            HasDataPlan = hasDataPlan;
        }
    }
}