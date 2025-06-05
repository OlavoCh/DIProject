using Microsoft.Extensions.DependencyInjection; //dotnet add package Microsoft.Extensions.DependencyInjection
using ProjetoDI.CarClass;
using ProjetoDI.CarInterface;
using ProjetoDI.CarClassTota;


var car = new ServiceCollection(); // Criação do container de DI (o container tem o trabalho de guardar as instancias [Tipo de motor])

car.AddSingleton<ICarMotor, CarStructure>(); //Unica instancia para a aplicação (faz com o que o motor seja criado uma vez e reutilizado em toda a aplicação [CarStructure])
car.AddTransient<CarComplete>(); //Registra CarComplete para ser criado toda vez que for requisitado

var serviceProvider = car.BuildServiceProvider(); //Registra a dependencia, diz como cada coisa de ser instanciada, monta o container com os objetos (o motor) e cria o motor com as dependencias injetadas (ICarMotor
var carComplete = serviceProvider.GetService<CarComplete>();
Console.Write("Digite o tipo de motor que deseja adicionar ao carro: "); //Pede para o usuario digitar o tipo de motor
string NovoMotor = Console.ReadLine(); //O conteiner ve que CarComplete precisa de ICarMotor ja foi registrado no addSingleton, e entrega o CarComplete pronto 
carComplete?.AddNewMotor(NovoMotor); //Adiciona o motor V8 ao carro e printa os 2 metodos

//DI ou Injecao de Dependencia é um desing que permite voce injetar algo dentro de uma classe mesmo que essa classe nao tenha nada dentro, sem precisar ficar criando metodos e etc, sendo mais facil a manutencao do codigo
// O exemplo acima mostra como usar DI para injetar uma implementação de ICarMotor em CarComplete, permitindo que CarComplete use qualquer motor que implemente a interface ICarMotor.


