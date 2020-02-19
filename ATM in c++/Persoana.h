#ifndef PERSOANA_H
#define PERSOANA_H
#include<string>
#include<fstream>
#include<iostream>
using namespace std;
class Persoana
{
    public:
        Persoana();
        Persoana(string nume,string prenume);
        string getNume();
        string getPrenume();
        void setNume(string nume);
        void setPrenume(string prenume);

    protected:
        string nume;
        string prenume;
    private:
        friend istream& operator>>(istream& in,Persoana& date);
        friend ofstream& operator<<(ofstream& out,const Persoana& date);
};

#endif // PERSOANA_H
