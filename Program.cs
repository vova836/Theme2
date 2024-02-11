using System;
using System.Linq;

namespace П.Р2;

public static class Program
{
	public static void Main() 
{
    Employee emp("Янишевский", "Владимир", 50000, 1.2);
    emp.printInfo();
    
    Engineer eng("Томайлы", "Сергей", 60000, 1.5, 15);
    eng.printInfo();
    
    Bus bus("Mercedes", 30, 100);
    bus.printInfo();
    
    TouristBus touristBus("Volvo", 40, 80, 400);
    touristBus.printInfo();
    
    return 0;
}
	}
}
