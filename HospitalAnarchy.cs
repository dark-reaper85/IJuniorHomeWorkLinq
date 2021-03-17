using System;
using System.Collections.Generic;
using System.Linq;

namespace AnarchyInHospital
{
    class HospitalAnarchy
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            hospital.Operate();
        }
    }

    class Hospital 
    {
        private List<Patient> _patients = new List<Patient>()
        {
            new Patient("Иванов", 23, "насморк" ),
            new Patient("Петров", 35, "ОРВИ" ),
            new Patient("Дикинсон", 78, "Падагра" ),
            new Patient("ТумбаЮмба", 15, "насморк" ),
            new Patient("Сталлоне", 67, "Падагра" ),
            new Patient("Кант", 122, "Коронавирус" ),
            new Patient("Чикатилло", 48, "ОРВИ" ),
            new Patient("Дрозденко", 52, "насморк" ),
            new Patient("Хуй", 22, "Коронавирус" ),
            new Patient("МакДак", 145, "ОРВИ" ),
            new Patient("Бигль", 12, "Падагра" )
        };

        public void Operate() 
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.Clear();

                ShowPatients();

                Console.WriteLine("1 - Отсортировать всех больных по фио");
                Console.WriteLine("2 - Отсортировать всех больных по возрасту");
                Console.WriteLine("3 - Вывести больных с определенным заболеванием");
                Console.WriteLine("4 - Выйти из программы");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        _patients = OrderByFullName();
                        break;
                    case "2":
                        _patients = OrderByAge();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Введите название заболевания");
                        userInput = Console.ReadLine();

                        ShowPatients(ChosePatientsWithCurrentDisease(userInput));
                        break;
                    case "4":
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }

        private List<Patient> ChosePatientsWithCurrentDisease(string currentDisease)
        {
            return _patients.Where(patient => patient.Disease.ToUpper() == currentDisease.ToUpper()).ToList();
        }

        private List<Patient> OrderByAge()
        {
            return _patients.OrderBy(patient => patient.Age).ToList();
        }

        private List<Patient> OrderByFullName() 
        {
            return _patients.OrderBy(patient => patient.FullName).ToList();
        }

        private void ShowPatients() 
        {
            foreach (var patient in _patients)
            {
                patient.ShowInfo();
            }
        }

        private void ShowPatients(List<Patient> patients)
        {
            if (patients.Count > 0)
            {
                foreach (var patient in patients)
                {
                    patient.ShowInfo();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Больных с таким заболеванием в больнице нет.");
                Console.ReadKey();
            }
        }
    }
    
    class Patient 
    {
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string Disease { get; private set; }

        public Patient(string fullName, int age, string disease) 
        {
            FullName = fullName;
            Age = age;
            Disease = disease;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Пациент: {FullName, 15}. Возраст: {Age,4}. Заболевание: {Disease, 15}");
        }
    }
}
