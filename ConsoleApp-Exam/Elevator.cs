using ConsoleApp_Exam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam
{
    internal class Elevator
    {
        public string[] elevatorTable = [];
        //Car 1
        private int xCoordinate = 5;
        private int yCoordinate = 5;        
        private int floorIndex = 0;
        private int? carCurrentFloorNumber;

        //Car 2
        private int xCoordinate_Second = 5;
        private int yCoordinate_Second = 5;
        private int floorIndex_Second = 0;
        private int? carCurrentFloorNumber_Second;

        //Car 3
        private int xCoordinate_Third = 5;
        private int yCoordinate_Third = 5;
        private int floorIndex_Third = 0;
        private int? carCurrentFloorNumber_Third;

        //Car 4
        private int xCoordinate_Fourth = 5;
        private int yCoordinate_Fourth = 5;
        private int floorIndex_Fourth = 0;
        private int? carCurrentFloorNumber_Fourth;


        private int numberOfFloors = 10;
        private IEnumerable<Passenger>? passengers;
        private IEnumerable<ElevatorCar>? elevatorCars;

        public Elevator()
        {
            IEnumerable<Passenger> passengers = new List<Passenger>();
            IEnumerable<ElevatorCar> elevatorCars = new List<ElevatorCar>();
        }

        
        public void InitializePassengers()
        {
            IEnumerable<Passenger> _passengers = new List<Passenger>()
            {
                new Passenger()
                {
                    PassengerCount = 6,
                    FloorNumber = 7,
                    IsUpAction = false,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 4,
                    FloorNumber = 3,
                    IsUpAction = false,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 9,
                    IsUpAction = false,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 5,
                    FloorNumber = 4,
                    IsUpAction = true
                },
                new Passenger()
                {
                    PassengerCount = 3,
                    FloorNumber = 2,
                    IsUpAction = false,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 2,
                    IsUpAction = true,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 6,
                    FloorNumber = 8,
                    IsUpAction = true,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 5,
                    IsUpAction = true,
                    CarNumber = 1
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 5,
                    IsUpAction = true,
                    CarNumber = 2
                },

                  new Passenger()
                {
                    PassengerCount = 4,
                    FloorNumber = 3,
                    IsUpAction = true,
                    CarNumber = 2
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 8,
                    IsUpAction = false,
                    CarNumber = 2
                },
                new Passenger()
                {
                    PassengerCount = 7,
                    FloorNumber = 2,
                    IsUpAction = true,
                    CarNumber = 2
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 9,
                    IsUpAction = false,
                    CarNumber = 2
                },
                new Passenger()
                {
                    PassengerCount = 3,
                    FloorNumber = 7,
                    IsUpAction = false,
                    CarNumber = 2
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 7,
                    IsUpAction = true,
                    CarNumber = 2
                },
                 new Passenger()
                {
                    PassengerCount = 3,
                    FloorNumber = 7,
                    IsUpAction = false,
                    CarNumber = 3
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 7,
                    IsUpAction = true,
                    CarNumber = 3
                },
                 new Passenger()
                {
                    PassengerCount = 10,
                    FloorNumber = 10,
                    IsUpAction = false,
                    CarNumber = 3
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 6,
                    IsUpAction = true,
                    CarNumber = 3
                },
                 new Passenger()
                {
                    PassengerCount = 4,
                    FloorNumber = 5,
                    IsUpAction = false,
                    CarNumber = 3
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 6,
                    IsUpAction = true,
                    CarNumber = 4
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 4,
                    IsUpAction = true,
                    CarNumber = 4
                },
                new Passenger()
                {
                    PassengerCount = 2,
                    FloorNumber = 9,
                    IsUpAction = false,
                    CarNumber = 4
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 2,
                    IsUpAction = false,
                    CarNumber = 4
                },
                new Passenger()
                {
                    PassengerCount = 1,
                    FloorNumber = 7,
                    IsUpAction = false,
                    CarNumber = 4
                }
            };           

            this.passengers = _passengers;            
           
        }

        public void InitializeElevator()
        {
            IEnumerable<ElevatorCar> _elevatorCars = new List<ElevatorCar>()
            {
                new ElevatorCar()
                {
                    CarId = 1,
                    CurrentFloorNumber = 3
                },
                new ElevatorCar()
                {
                    CarId = 2,
                    CurrentFloorNumber = 10
                },
                new ElevatorCar()
                {
                    CarId = 3,
                    CurrentFloorNumber = 1
                },
                new ElevatorCar()
                {
                    CarId = 4,
                    CurrentFloorNumber = 7
                }
            };

            this.elevatorCars = _elevatorCars;

            elevatorTable = new[]{
                    @"Floor    car1    car2    car3    car4",
                    @"                                     ",
                    @"10                                   ",
                    @"09                                   ",
                    @"08                                   ",
                    @"07                                   ",
                    @"06                                   ",
                    @"05                                   ",
                    @"04                                   ",
                    @"03                                   ",
                    @"02                                   ",
                    @"01                                   ",
            };

            floorIndex = yCoordinate;

            for (int index = 0; index < elevatorTable.Length; index++)
            {
                Console.SetCursorPosition(xCoordinate, floorIndex);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(elevatorTable[index]);

                this.floorIndex++;
            }

            this.floorIndex = 0;
        }

        private void InitializeFirstCar()
        {
            int yCount = yCoordinate + 1;
            this.floorIndex = this.floorIndex > yCount ? this.floorIndex : yCount;

            int? _carCurrentFloorNumber = this.elevatorCars?.Where(x => x.CarId == 1).FirstOrDefault()?.CurrentFloorNumber;
            if (_carCurrentFloorNumber != null)
            {
                this.carCurrentFloorNumber = _carCurrentFloorNumber.Value;
                this.floorIndex = this.floorIndex + (numberOfFloors - this.carCurrentFloorNumber.Value);
            }
        }

        private void InitializeSecondCar()
        {
            int yCount = yCoordinate_Second + 1;
            this.floorIndex_Second = this.floorIndex_Second > yCount ? this.floorIndex_Second : yCount;

            int? _carCurrentFloorNumber = this.elevatorCars?.Where(x => x.CarId == 2).FirstOrDefault()?.CurrentFloorNumber;
            if (_carCurrentFloorNumber != null)
            {
                this.carCurrentFloorNumber_Second = _carCurrentFloorNumber.Value;
                this.floorIndex_Second = this.floorIndex_Second + (numberOfFloors - this.carCurrentFloorNumber_Second.Value);
            }
        }

        private void InitializeThirdCar()
        {
            int yCount = yCoordinate_Third + 1;
            this.floorIndex_Third = this.floorIndex_Third > yCount ? this.floorIndex_Third : yCount;

            int? _carCurrentFloorNumber = this.elevatorCars?.Where(x => x.CarId == 3).FirstOrDefault()?.CurrentFloorNumber;
            if (_carCurrentFloorNumber != null)
            {
                this.carCurrentFloorNumber_Third = _carCurrentFloorNumber.Value;
                this.floorIndex_Third = this.floorIndex_Third + (numberOfFloors - this.carCurrentFloorNumber_Third.Value);
            }
        }

        private void InitializeFourthCar()
        {
            int yCount = yCoordinate_Fourth + 1;
            this.floorIndex_Fourth = this.floorIndex_Fourth> yCount ? this.floorIndex_Fourth : yCount;

            int? _carCurrentFloorNumber = this.elevatorCars?.Where(x => x.CarId == 4).FirstOrDefault()?.CurrentFloorNumber;
            if (_carCurrentFloorNumber != null)
            {
                this.carCurrentFloorNumber_Fourth = _carCurrentFloorNumber.Value;
                this.floorIndex_Fourth = this.floorIndex_Fourth + (numberOfFloors - this.carCurrentFloorNumber_Fourth.Value);
            }
        }

        private void WriteConsole(int xIndex, int yIndex, string message, bool isUpAction)
        {
            Console.SetCursorPosition(xIndex, yIndex);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);

            yIndex = isUpAction ? yIndex + 1 : yIndex - 1;

            Console.SetCursorPosition(xIndex, yIndex);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");

            Console.SetCursorPosition(xIndex + 1, yIndex);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
        }

        private void WriteConsole(int xIndex, int yIndex, string message)
        {
            Console.SetCursorPosition(xIndex, yIndex);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }

        private MoveResponse MoveDown(int carNumber, int? param_CarCurrentFloorNumber, int param_FloorIndex, int param_XIndex, int param_YIndex)
        {         
            int timer = 0;
            int xIndex = param_XIndex;
            int _currentPassengerCount = 0;            

            MoveResponse response = new MoveResponse();
                                   
            for (int y = 0; y < (elevatorTable.Length * 10) - numberOfFloors; y++)
            {
                timer = timer + 1000;


                if (timer == 1000 || timer == 11000)
                {                   
                    if(param_CarCurrentFloorNumber != null)
                    {                                              
                        var _passenger = this.passengers?.Where(x=> x.CarNumber == carNumber && x.IsUpAction == false && x.FloorNumber == param_CarCurrentFloorNumber.Value).FirstOrDefault();
                        int _passengerCount = _passenger != null ? _passenger.PassengerCount : 0;

                        WriteConsole(xIndex, param_FloorIndex, _currentPassengerCount.ToString(), false);


                        if (_passenger != null)
                        {
                            for (int i = 1; i <= 10; i++)
                            {                               

                                WriteConsole(xIndex, param_YIndex - 2, i.ToString() + "s ");

                                Thread.Sleep(1000);                                

                            }                          
                        }

                        _currentPassengerCount = _currentPassengerCount + _passengerCount;

                        WriteConsole(xIndex, param_FloorIndex, _currentPassengerCount.ToString(), false);

                        param_CarCurrentFloorNumber = param_CarCurrentFloorNumber.Value - 1;

                        if (param_CarCurrentFloorNumber.Value == 1)
                        {
                            WriteConsole(param_XIndex, param_FloorIndex, "0 ", false);

                            response.CurrentFloorNumber = param_CarCurrentFloorNumber;
                            response.FloorIndex = param_FloorIndex;

                            return response;
                        }
                    }

                    param_FloorIndex++;
                }

                if (timer > 10000)
                {
                    timer = 1000;
                }

                WriteConsole(xIndex, param_YIndex - 1, (timer / 1000).ToString() + "s ");                

                Thread.Sleep(1000);
                

            }

            return response;
        }

        private MoveResponse MoveUp(int carNumber, int? param_CarCurrentFloorNumber, int param_FloorIndex, int param_XIndex, int param_YIndex)
        {
            int timer = 0;
            int xIndex = param_XIndex;
            int _currentPassengerCount = 0;

            param_FloorIndex++;

            MoveResponse response = new MoveResponse();

            for (int y = 0; y < (elevatorTable.Length * 10) - numberOfFloors; y++)
            {
                timer = timer + 1000;

                if (timer == 1000 || timer == 11000)
                {                    
                    if (param_CarCurrentFloorNumber != null)
                    {
                        var _passenger = this.passengers?.Where(x => x.CarNumber == carNumber && x.IsUpAction == true && x.FloorNumber == param_CarCurrentFloorNumber).FirstOrDefault();
                        int _passengerCount = _passenger != null ? _passenger.PassengerCount : 0;

                        WriteConsole(xIndex, param_FloorIndex, _currentPassengerCount.ToString(), true);

                        if (_passenger != null)
                        {
                            for (int i = 1; i <= 10; i++)
                            {                               

                                WriteConsole(xIndex, param_YIndex - 2, i.ToString() + "s ");

                                Thread.Sleep(1000);
                            }
                        }

                        _currentPassengerCount = _currentPassengerCount + _passengerCount;

                        WriteConsole(xIndex, param_FloorIndex, _currentPassengerCount.ToString(), true);

                        param_CarCurrentFloorNumber = param_CarCurrentFloorNumber.Value + 1;

                        if (param_CarCurrentFloorNumber.Value > numberOfFloors - 1)
                        {
                            WriteConsole(xIndex, param_FloorIndex, "0 ", true);

                            response.CurrentFloorNumber = param_CarCurrentFloorNumber;
                            response.FloorIndex = param_FloorIndex;

                            return response;
                        }
                    }

                    if(param_FloorIndex > 0)
                    {
                        param_FloorIndex--;
                    }
                   
                }

                if (timer > 10000)
                {
                    timer = 1000;
                }               

                WriteConsole(xIndex, param_YIndex - 1, (timer / 1000).ToString() + "s ");


                Thread.Sleep(1000);


            }

            return response;
        }

        private async Task MoveFirstCar()
        {           
            InitializeFirstCar();

            var response = MoveUp(1, this.carCurrentFloorNumber, this.floorIndex, 15, 4);

            this.floorIndex = response.FloorIndex;
            this.carCurrentFloorNumber = response.CurrentFloorNumber;

            MoveDown(1, this.carCurrentFloorNumber, this.floorIndex, 15, 4);

             await Task.Delay(10);
        }

        private async Task MoveSecondCar()
        {
            InitializeSecondCar();

            var response = MoveUp(2, this.carCurrentFloorNumber_Second, this.floorIndex_Second, 24, 4);

            this.floorIndex_Second = response.FloorIndex;
            this.carCurrentFloorNumber_Second = response.CurrentFloorNumber;

            MoveDown(2, this.carCurrentFloorNumber_Second, this.floorIndex_Second, 24, 4);

            await Task.Delay(10);
        }

        private async Task MoveThirdCar()
        {
            InitializeThirdCar();

            var response = MoveUp(3, this.carCurrentFloorNumber_Third, this.floorIndex_Third, 32, 4);

            this.floorIndex_Third = response.FloorIndex;
            this.carCurrentFloorNumber_Third = response.CurrentFloorNumber;

            MoveDown(3, this.carCurrentFloorNumber_Third, this.floorIndex_Third, 32, 4);

            await Task.Delay(10);
        }

        private async Task MoveFourthCar()
        {
            InitializeFourthCar();

            var response = MoveUp(4, this.carCurrentFloorNumber_Fourth, this.floorIndex_Fourth, 42, 4);

            this.floorIndex_Fourth = response.FloorIndex;
            this.carCurrentFloorNumber_Fourth= response.CurrentFloorNumber;

            MoveDown(3, this.carCurrentFloorNumber_Fourth, this.floorIndex_Fourth, 42, 4);

            await Task.Delay(10);
        }

        public async Task MoveAsync()
        {
            InitializeElevator();
            InitializePassengers();

            await MoveFirstCar();
            await MoveSecondCar();
            await MoveThirdCar();
            await MoveFourthCar();

            //var first = Task.Run(() =>
            //{
            //    return MoveFirstCar();
            //});

            //var second = Task.Run(() =>
            //{
            //    return MoveSecondCar();
            //});

            //await Task.WhenAll(first, second);            
        }


        
    }
}
