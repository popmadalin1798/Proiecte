#include "Card.h"

Card::Card()
{
    numar=0;
    sold=0.0;
    stare='0';
}
string Card::getStare()
{
    return stare;
}
int Card::getNumar()
{
    return numar;
}
int Card::getPin()
{
    return pin;
}
float Card::getSold()
{
    return sold;
}
void Card::schimba(string nume,string prenume)
{
    setNume(nume);
    setPrenume(prenume);
}
void Card::schimba(int nr)
{
    setNumar(nr);
}
void Card::setStare(string stare)
{
    this->stare=stare;
}
void Card::setNumar(int nr)
{
    this->numar=nr;
}
void Card::setPin(int pin)
{
    this->pin=pin;
}
void Card::setSold(float sold)
{
    this->sold=sold;
}
Persoana Card::getPersoana()const
{
    return Persoana(nume,prenume);
}
void Card::setPersoana(Persoana p)
{
    nume=p.getNume();
    prenume=p.getPrenume();
}
istream& operator>>(istream& in,Card& date)
{
    int v;
    for(v=0;v<5;v++)
    {
        cout<<endl;
    }
    cout<<"                                 Introduceti datele cardului!"<<endl;
    in>>(Persoana&)date;
    cout<<"Numarul de card(o cifra,diferit de cele din baza de date):";
    in>>date.numar;
    cout<<"Pin(4 cifre):";
    in>>date.pin;
    cout<<"Sold:";
    in>>date.sold;
    cout<<"Stare(A_ activ F_ inactiv):";
    in>>date.stare;
    return in;
}
ofstream& operator<<(ofstream& out,const Card& date)
{
    out<<date.numar<<" ";
    out<<date.pin<<" ";
    out<<date.getPersoana();
    out<<" "<<date.sold<<" "<<date.stare<<endl;
    return out;
}
