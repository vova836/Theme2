using System;
using System.Linq;

namespace Theme3;


// Базовый класс Автобус
class Bus {
protected:
    string brand;
    int seats;
    double ticketPrice;
public:
    Bus(string brand, int seats, double ticketPrice) : brand(brand), seats(seats), ticketPrice(ticketPrice) {}
    
    virtual void printInfo() {
        cout << "Автобус: " << brand << endl;
        cout << "Общая стоимость всех мест: " << totalTicketCost() << endl;
    }
    
    virtual double totalTicketCost() {
        return seats * ticketPrice;
    }
};

// Потомок Туристический автобус от класса Автобус
class TouristBus : public Bus {
private:
    double excursionPrice;
public:
    TouristBus(string brand, int seats, double ticketPrice, double excursionPrice) : Bus(brand, seats, ticketPrice), excursionPrice(excursionPrice) {}
    
    void printInfo() override {
        cout << "Туристический автобус: " << brand << endl;
        cout << "Общая стоимость всех мест с учетом экскурсии: " << totalTicketCost() << endl;
    }
    
    double totalTicketCost() override {
        return (seats * ticketPrice) + excursionPrice;
  

}

	}
}
