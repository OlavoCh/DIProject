using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoDI.CarInterface
{
    public interface ICarMotor //Interface que define o contrato para adicionar um motor a um carro
    {
        void NewMotor(string motor);
    }
}