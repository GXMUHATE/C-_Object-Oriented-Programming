using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_Exercicios {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string nome, double salario){
            Id = id;
            Name = nome;
            Salary = salario;
            }
        public double Aumento( double x) {
            
               return Salary += (Salary * x) / 100;
          
      
        }

        public override string ToString() {
            return "Id: "+Id
                +" Name: "+Name
                +" Salary: "+Salary;
        }
    }
}
