using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDI.CarInterface;

namespace ProjetoDI.CarClass
{
    public class CarStructure : ICarMotor //Implementação da interface ICarMotor, responsável por adicionar um novo motor
    {
        public void NewMotor(string motor)
        {
            Console.WriteLine($"New motor added: {motor}");
        } 
    }
}