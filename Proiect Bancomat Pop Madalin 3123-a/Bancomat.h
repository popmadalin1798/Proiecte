#ifndef BANCOMAT_H_INCLUDED
#define BANCOMAT_H_INCLUDED
#include <iostream>
#include<stdlib.h>
#include<stdio.h>
#include<windows.h>
#include<fstream>
#include<cstring>
#include<string>
#include<sstream>
#include<conio.h>
#include<winable.h>
#include <time.h>
#include<ctype.h>

using namespace std;

class Bancomat
{
    int nr_card,pin,nr_card_f,pin_f;
    string nume,prenume,stare;
    float sold,sold_f;
public:
    Bancomat();
    void spatiere_sus()
{
    int i;
    for(i=0;i<9;i++)
    {
        cout<<endl;
    }
}
    void strat_securitate();
    void sunet();
    void setNrCard();
    void citire_baza_de_date();
    void scriere_date();
    void verificare_nr_card();
    void setPin(int n);
    void l_procesare();
    void verificare_pin(int );
    void l_verificare_pin();
    void meniu_principal();
    void afiseaza_sold();
    void plata_facturi();
    void blocare_card();
    void sf_incep_tranz();
    void optiuni(int );
    void retragere_num();
    void depunere_num();
    void depunere_val();
    void schimbare_pin();
    void schimbare_nr();
    void transfer();
    string data();
    virtual ~Bancomat();
};


#endif // BANCOMAT_H_INCLUDED
