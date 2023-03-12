using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_с_студентом_СиШарп_
{

    class Student
    {
        private string famil;
        private string name;
        private string otches;
        private DateTime birth;
        private string phone;
        private string city;
        private string street;
        private int dom;

        private int[] zachet;
        private int[] dz;
        private int[] ekz;

        public string getFamil()
        {
            return famil;
        }
        public string getName()
        {
            return name;
        }
        public string getOtches()
        {
            return otches;
        }
        public DateTime getBirth()
        {
            return birth;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getCity()
        {
            return city;
        }
        public string getStreet()
        {
            return street;
        }
        public int getDom()
        {
            return dom;
        }

        public int getZachet(int index)
        {
            return zachet[index];
        }
        public int getDZ(int index)
        {
            return dz[index];
        }
        public int getEkz(int index)
        {
            return ekz[index];
        }

        public void setFamil(string famil1)
        {
            famil = famil1;
        }
        public void setName(string name1)
        {
            name = name1;
        }
        public void setOtches(string otches1)
        {
            otches = otches1;
        }
        public void setBirth(DateTime birth1)
        {
            birth = birth1;
        }
        public void setPhone(string phone1)
        {
            phone = phone1;
        }
        public void setCity(string city1)
        {
            city = city1;
        }
        public void setStret(string street1)
        {
           street = street1;
        }
        public void setDom(int dom1)
        {
            dom = dom1;
        }

        public void setZachet(int zachet1, int index)
        {
            zachet[index] = zachet1;
        }
        public void setDZ(int DZ, int index)
        {
            dz[index] = DZ;
        }
        public void setEkz(int ekz1, int index)
        {
            ekz[index] = ekz1;
        }
        public Student()
        {
            Console.WriteLine("Сработал конструктор по умолчанию");
            famil = "Неизвестно";
            name = "Неизвестно";
            otches = "Неизвестно";
            birth = new DateTime(0, 0, 0);
            phone = "Неизвестно";
            city = "Неизвестно";
            street = "Неизвестно";
            dom = 0;
            zachet = new int[0];
            dz = new int[0];
            ekz = new int[0];
        }
        public Student(string famil1, string name1, string otches1) : this()
        {
        }

        public Student(string famil, string name, string otches, DateTime birth,
            string phone, int[] zachet, int[] dz, int[] ekz,string city,string street,int dom)
        {
            Console.WriteLine("Сработал конструктор с параметрами");
            this.famil = famil;
            this.name = name;
            this.otches = otches;
            this.birth = birth;
            this.phone = phone;
            this.zachet = zachet;
            this.dz = dz;
            this.ekz = ekz;
            this.city = city;
            this.street = street;
            this.dom = dom;
        }
        public void AllInfo()
        {
            Console.WriteLine("---Вся информация о студенте---\n");
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}", famil,
                name, otches);
            Console.WriteLine("Дата рождения: " + birth);
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Дом: " + dom);
            Console.WriteLine("Оценки(зачет):");
            for (int i = 0; i < zachet.Length; i++)
            {
                Console.WriteLine(zachet[i] + " ");
            }
            Console.WriteLine("Оценки(ДЗ):");
            for (int i = 0; i < dz.Length; i++)
            {
                Console.WriteLine(dz[i] + " ");
            }
            Console.WriteLine("Оценки(экзамен):");
            for (int i = 0; i < ekz.Length; i++)
            {
                Console.WriteLine(ekz[i] + " ");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый студент(стандарт): ");
            Student stud = new Student("Prigolovkin", "Nikita", "Vital", new DateTime(2005, 10, 28), "123", new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 },"Odessa","Poskot",16);
            stud.AllInfo();
            Console.WriteLine("Второй студент(кастомный): \nВведите фамилию: ");
            string famil = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string otches = Console.ReadLine();
            Console.WriteLine("Введите дату рождения(год,месяц,день): ");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime birth = new DateTime(year, month, day);
            Console.WriteLine("Введите номер: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine();
            Console.WriteLine("Введите улица: ");
            string street = Console.ReadLine();
            Console.WriteLine("Введите дом: ");
            int dom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество оценок(зачет):");
            int count1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оценки(зачет):");
            int[] zachet=new int[count1];
            for (int i = 0; i < zachet.Length; i++)
            {
                zachet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Количество оценок(ДЗ):");
            int count2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оценки(ДЗ):");
            int[] dz = new int[count2];
            for (int i = 0; i < dz.Length; i++)
            {
                dz[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Количество оценок(экзамен):");
            int count3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Оценки(экзамен):");
            int[] ekz = new int[count3];
            for (int i = 0; i < ekz.Length; i++)
            {
                ekz[i] = int.Parse(Console.ReadLine());
            }
            Student stud1 = new Student(famil, name, otches, birth, phone, zachet, dz, ekz, city, street, dom);
            stud1.AllInfo();




        }
    }
}
