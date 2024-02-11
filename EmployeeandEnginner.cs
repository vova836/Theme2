using System;
using System.Linq;

namespace Theme_2;
{

using namespace std;

// Базовый класс Сотрудник
class Employee
{
protected:
    string lastName;
    string firstName;
    double p;
    double k;
public:
    Employee(string lastName, string firstName, double p, double k) : lastName(lastName), firstName(firstName), p(p), k(k) {}
    
    virtual void printInfo() {
        cout << "Сотрудник: " << firstName << " " << lastName << endl;
        cout << "Доход: " << income() << endl;
    }
    
    virtual double income() {
        return k * p;
    }
};

// Потомок Инженер от класса Сотрудник
class Engineer : public Employee {
private:
    int n;
public:
    Engineer(string lastName, string firstName, double p, double k, int n) : Employee(lastName, firstName, p, k), n(n) {}
    
    void printInfo() override {
        cout << "Инженер: " << firstName << " " << lastName << endl;
        cout << "Доход: " << income() << endl;
    }
    
    double income() override {
        if (n > 10) {
            return k * p * (n / 10);
        } else {
            return Employee::income();
        }
    }
}
