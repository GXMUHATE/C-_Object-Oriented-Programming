using System;
using System.Collections.Generic;
using System.Globalization;
namespace Listas_Exercicios {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<Employee> lista = new List<Employee>();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Employee(a, nome, salario));
            }
                Console.Write("Enter the employee id that will have salary increase :");
                int num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee emp = lista.Find(x => x.Id == num);
                if (emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Aumento(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }

                Console.WriteLine();
                Console.WriteLine("Updated list of employees:");
                foreach (Employee obj in lista)
                {
                    Console.WriteLine(obj);
                }

            }
        }
    
}
