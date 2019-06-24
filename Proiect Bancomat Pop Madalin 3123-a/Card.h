#ifndef CARD_H
#define CARD_H
#include<iostream>
#include"Persoana.h"
#include<fstream>
#include<string>
#include<windows.h>
using namespace std;
class Card :public Persoana
{
    public:
        Card();
        string getStare();
        int getNumar();
        int getPin();
        float getSold();
        void schimba(string nume,string prenume);
        void schimba(int nr);
        void setStare(string stare);
        void setNumar(int nr);
        void setPin(int pin);
        void setSold(float sold);
        Persoana getPersoana()const;
        void setPersoana(Persoana p);
    private:
        int numar;
        int pin;
        float sold;
        string stare;
    private:
        friend istream& operator>>(istream& in,Card& date);
        friend ofstream& operator<<(ofstream& out,const Card& date);
};

#endif // CARD_H
