using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDI.CarInterface;

namespace ProjetoDI.CarClassTota
{
    public class CarComplete
    {
        private readonly ICarMotor _carMotor; //Injetando o motor do carro via interface

        public CarComplete(ICarMotor carMotor) //carMotor é uma variavel do tipo ICarMotor, que é uma interface
        {
            _carMotor = carMotor; // Isso permite que a classe CarComplete receba qualquer implementação de ICarMotor
        }
        public void AddNewMotor(string motor)
        {
            _carMotor.NewMotor($"Motor: {motor}");
            Console.WriteLine($"Motor {motor} has been added to the car.");
        }
    }
}