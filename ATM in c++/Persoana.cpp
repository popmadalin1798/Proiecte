#include "Persoana.h"

Persoana::Persoana()
{
    nume='0';
    prenume='0';
}
Persoana::Persoana(string nume_,string prenume_)
{
    nume=nume_;
    prenume=prenume_;
}
string Persoana::getNume()
{
    return nume;
}
string Persoana::getPrenume()
{
    return prenume;
}
void Persoana::setNume(string nume)
{
    this->nume=nume;
}
void Persoana::setPrenume(string prenume)
{
    this->prenume=prenume;
}
istream& operator>>(istream& in,Persoana& date)
{
    cout<<"Introducei numele persoanei:";
    in>>date.nume;
    cout<<"Introduceti prenumele persoanei:";
    in>>date.prenume;
    return in;
}
ofstream& operator<<(ofstream& out,const Persoana& date)
{
    out<<date.nume<<" "<<date.prenume;
    return out;
}
