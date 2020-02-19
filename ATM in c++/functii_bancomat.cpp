#include"Bancomat.h"
#include"Card.h"
#include <stdio.h>
#include<string>
#include<cmath>
Bancomat::Bancomat()
{
    nr_card=0;
    nr_card_f=0;
    pin=0;
    pin_f=0;
    nume='0';
    prenume='0';
    stare='0';
    sold=0.0;
    sold_f=0.0;
}
void Bancomat::strat_securitate()
{
    Bancomat();
    setNrCard();
}
string Bancomat::data()
{
    time_t now = time(0);
    struct tm  tstruct;
    char       buf[80];
    tstruct = *localtime(&now);
    strftime(buf, sizeof(buf), "%Y-%m-%d  %X", &tstruct);
    return buf;
}
void developer()
{
    system("CLS");
    int j;
    for(j=0;j<9;j++)
    {
        cout<<endl;
    }
    cout<<"                                             Incarcare"<<endl;
    cout<<"                         ";
    for(int y;y<45;y++)
    {
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),2);
        cout<< (unsigned char)219;
        Sleep(70);
        fflush(stdout);
    }
    system("COLOR 79");
    system("CLS");
    int opt;
    cout<<"                                     Mod de developer!"<<endl;
    Beep(440,500);
    system("COLOR 19");
    Beep(440,500);
    system("COLOR 21");
    Beep(440,500);
    system("COLOR 32");
    Beep(349,350);
    system("COLOR 23");
    Beep(523,150);
    system("COLOR 45");
    Beep(440,500);
    system("COLOR 54");
    Beep(349,350);
    system("COLOR 67");
    Beep(523,150);
    system("COLOR 76");
    Beep(440,1000);
    system("COLOR 89");
    Beep(659,500);
    system("COLOR 98");
    Beep(659,500);
    system("COLOR 37");
    Beep(659,500);
    system("COLOR 58");
    Beep(698,350);
    system("COLOR 82");
    Beep(523,150);
    system("COLOR 71");
    Beep(415,500);
    system("COLOR 95");
    Beep(349,350);
    system("COLOR 68");
    Beep(523,150);
    system("COLOR 11");
    Beep(440,1000);
    system("COLOR 79");
    int i;
    for(i=0;i<9;i++)
    {
        cout<<endl;
    }
    cout<<"                         1.Adaugati o entitate in baza de date."<<endl;
    cout<<"                         2.Stergeti o entitate din baza de date."<<endl;
    cout<<"                         3.Activati sau dezactivati un card din baza de date."<<endl;
    cout<<"                         4.Restartare program."<<endl;
    cout<<"                         5.Iesiti din program."<<endl;
    cout<<"                                             ";cin>>opt;
    switch(opt)
    {
    case 1:
        {
    system("CLS");
    string linie7;
    ofstream fout("baza_de_date.txt", ios::out | ios::app);
    ifstream n("baza_de_date.txt");
    if(n.is_open())
    {
    cout<<"Baza de date initializata!"<<endl;
    while(getline(n,linie7))
    {
        cout<<linie7<<endl;
    }
    n.close();
    }
    else
    {
       cout<<"Baza de date nu poate fi accesata!"<<endl;
       Sleep(3000);
       developer();
    }
	Card carduri[2];
	cin >> carduri[0];
	bool restart=false;
	do
    {
	cout<<"                                         Date introduse!"<<endl;
	system("CLS");
    int v1;
    for(v1=0;v1<9;v1++)
    {
        cout<<endl;
    }
	cout<<"                                 Doriti sa schimbati numele?"<<endl;
	cout<<"                                     1.[Da]      2.[Nu]"<<endl;
	int opt;
	cout<<"                                             ";cin>>opt;
	if(opt==1)
    {
        string nume,prenume;
        cout<<"                                 Reintroduceti numele:";
        cin>>nume;
        cout<<"                                 Reintroduceti prenumele:";
        cin>>prenume;
        carduri[0].schimba(nume,prenume);
        cout<<"                                     Date schimbate!"<<endl;
        Sleep(1000);
    }
    if(opt==2)
    {
        system("CLS");
    int v2;
    for(v2=0;v2<9;v2++)
    {
        cout<<endl;
    }
        cout<<"                                 Doriti sa schimbati numarul de card?"<<endl;
        cout<<"                                         1.[Da]      2.[Nu]"<<endl;
        int opt_1;
        cout<<"                                                 ";cin>>opt_1;
        if(opt_1==1)
        {
            int nr;
            cout<<"                             Reintroduceti numarul cardului!"<<endl;
            cout<<"                                             ";cin>>nr;
            carduri[0].schimba(nr);
            cout<<"                                     Numar de card schimbat!"<<endl;
            fout << carduri[0];
            Sleep(3000);
            developer();
        }
        if(opt_1==2)
        {
            cout<<"                                     Date schimbate!"<<endl;
            fout << carduri[0];
            Sleep(3000);
            developer();
        }
        if(opt_1!=1 && opt_1!=2)
        {
            cout<<"                            Optiune invalida!"<<endl;
            Sleep(3000);
            restart=true;
        }
    }
    if(opt!=1 && opt!=2)
    {
        cout<<"                             Optiune invalida!"<<endl;
        Sleep(3000);
        restart=true;
    }
    system("CLS");
    int v3;
    for(v3=0;v3<9;v3++)
    {
        cout<<endl;
    }
    cout<<"                                 Doriti sa schimbati numarul de card?"<<endl;
        cout<<"                                         1.[Da]      2.[Nu]"<<endl;
        int opt_2;
        cout<<"                                             ";cin>>opt_2;
        if(opt_2==1)
        {
            int nr_1;
            cout<<"                             Reintroduceti numarul cardului!"<<endl;
            cout<<"                                             ";cin>>nr_1;
            carduri[0].schimba(nr_1);
            cout<<"                                     Numar de card schimbat!"<<endl;
            fout << carduri[0];
            Sleep(3000);
            developer();
        }
        if(opt_2==2)
        {
            fout << carduri[0];
            cout<<"                                     Date schimbate!"<<endl;
            Sleep(3000);
            developer();
        }
        if(opt_2!=1 && opt_2!=2)
        {
            cout<<"                            Optiune invalida!"<<endl;
            Sleep(3000);
            restart=true;
        }
    }while(restart==true);
        }
    case 2:
        {
        system("CLS");
    string nume,prenume,stare;
    int nr_1;
    string linieg,temp,line,linie1,liniuta,stare_i,linie7;
    stringstream ss;
    ifstream n("baza_de_date.txt");
    if(n.is_open())
    {
    cout<<"Baza de date initializata!"<<endl;
    while(getline(n,linie7))
    {
        cout<<linie7<<endl;
    }
    n.close();
    }
    else
    {
       cout<<"Baza de date nu poate fi accesata!"<<endl;
       Sleep(3000);
       developer();
    }
    cout<<endl;
    cout<<"Introduceti contul dorit:";
    cin>>nr_1;
    temp=to_string(nr_1);
    ifstream cr("baza_de_date.txt");
    ofstream tempo("temp1.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp1.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        remove("temp1.txt");
        cout<<endl;
        cout<<"Modificare realizata cu succes!"<<endl;
        Sleep(3000);
        developer();
    }
    case 3:
    {
    system("CLS");
    int nr_card_f,sold_f,pin_f;
    string nume,prenume,stare;
    int nr_1;
    string linieg,temp,line,linie1,liniuta,stare_i,linie7;
    stringstream ss;
    ifstream n("baza_de_date.txt");
    if(n.is_open())
    {
    cout<<"Baza de date initializata!"<<endl;
    while(getline(n,linie7))
    {
        cout<<linie7<<endl;
    }
    n.close();
    }
    else
    {
       cout<<"Baza de date nu poate fi accesata!"<<endl;
       Sleep(3000);
       developer();
    }
    cout<<endl;
    cout<<"Introduceti contul dorit:";
    cin>>nr_1;
    cout<<"Introduceti starea (A_ pentru activ sau F_ pentru inactiv):";
    cin>>stare_i;
    int p=0;
    cout<<"Proces ";
    for(int y;y<8;y++)
    {
        p=p+10;
        if(y<8)
        {
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),2);
        cout<< (unsigned char)219;
        }
        Sleep(500);
        fflush(stdout);
    }
    system("COLOR 79");
    temp=to_string(nr_1);
    ifstream f("baza_de_date.txt");
    ofstream d("temp2.txt");
    getline(f,linie1);
    while(getline(f,linie1))
    {
        if(temp[0]==linie1[0])
        {
            d<<linie1<<endl;
            break;
        }
    }
    f.close();
    d.close();
    int nr,pin_;
    string nume_,prenume_,stare_;
    float sold_;
    ifstream a("temp2.txt");
    while(a>>nr>>pin_>>nume_>>prenume_>>sold_>>stare_)
    {
    nr_card_f=nr_1;
    pin_f=pin_;
    nume=nume_;
    prenume=prenume_;
    sold_f=sold_;
    stare=stare_;
    }
    a.close();
    ofstream r("temp2.txt");
    if(r.is_open())
    {
        r<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare_i;
        ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare_i;
        linieg=ss.str();
    }
    r.close();
    ifstream cr("baza_de_date.txt");
    ofstream tempo("temp1.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream baza1("temp1.txt", ios_base::app | ios_base::out);
        baza1<<linieg<<endl;
        remove("temp2.txt");
        baza1.close();
        ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp1.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        remove("temp1.txt");
        cout<<endl;
        cout<<"Modificare realizata cu succes!"<<endl;
        Sleep(3000);
        developer();
        }
    case 4:
        {
        system("CLS");
        int i;
        for(i=0;i<9;i++)
        {
            cout<<endl;
        }
        cout<<"                                            Restartare"<<endl;
        cout<<"                         ";
        int b=0;
        while(b<45)
        {
            SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),2);
            cout<< (unsigned char)219;
            Sleep(70);
            b++;
        }
        system("COLOR 79");
        Bancomat c;
        c.strat_securitate();
        }
    case 5:
        exit(0);

    }
}
void Bancomat::setNrCard()
{
    system("CLS");
    int nr;
    cout<<"Pentru mod developer introduceti 17"<<endl;
    spatiere_sus();
    cout<<"                                      -->Introduceti cardul!<--"<<endl;
    cout<<"                                                   ";cin>>nr;
    if(nr>9 && nr!=17)
    {
        system("CLS");
        spatiere_sus();
        cout<<"                         Numarul cardului trebuie sa fie de o cifre.Reincercati!";
        cin.clear();
        cin.ignore();
        cin.sync();
        Sleep(3000);
        setNrCard();
    }
    if(cin.fail())
    {
        system("CLS");
        spatiere_sus();
        cout<<"                         Nu sunt permise caracterele sau simbolurile!Reincercati!";
        cin.clear();
        cin.ignore();
        cin.sync();
        Sleep(3000);
        setNrCard();
    }
    if(nr==17)
    {
        developer();
    }
    nr_card=nr;
    if(nr_card!=0 && nr_card!=17)
    {
        scriere_date();
        verificare_nr_card();
    }
}
void Bancomat::setPin(int n)
{
    system("CLS");
    int pin_;
    string parola;
   spatiere_sus();
        cout<<"                                    -->Introduceti codul pin<--"<<endl;
        cout<<"                                                ";
        while((pin_=getch()))
        {
            if(pin_==8)
            {
                if(parola.length()>0)
                {
                    cout<<"\b \b";
                    parola.erase(parola.length()-1);
                }
            }
            else
            {
                if(((char(pin_) >= '0') && (char(pin_) <= '9') && (parola.length()<4)) || ((pin_ == 8)))
                {
                    cout<<"*";
                    parola+=pin_;
                    int pinf=stoi(parola);
                pin=pinf;
                if(parola.length()==4)
                {
                    verificare_pin(n);
                }
                }
            }
        }

}
void Bancomat::scriere_date()
{
    int verificare=0;
    string temp,linie;
    temp=to_string(nr_card);
    ifstream f("baza_de_date.txt");
    ofstream d("date.txt");
    getline(f,linie);
    while(getline(f,linie))
    {
        if(temp[0]!=linie[0])
        {
            continue;
        }
        if(temp[0]==linie[0])
        {
            verificare++;
            d<<linie;
             d.close();
            f.close();
            citire_baza_de_date();
            break;
        }
    }

}
void Bancomat::citire_baza_de_date()
{
    int nr,pin_;
    string nume_,prenume_,stare_;
    float sold_;
    ifstream d("date.txt");
    while(d>>nr>>pin_>>nume_>>prenume_>>sold_>>stare_)
    {
    nr_card_f=nr;
    pin_f=pin_;
    nume=nume_;
    prenume=prenume_;
    sold_f=sold_;
    sold=sold_;
    stare=stare_;
    }
    d.close();
}
void Bancomat::l_procesare()
{
    system("CLS");
    spatiere_sus();
    cout<<"                                               Procesare"<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                               Procesare."<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                               Procesare.."<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                               Procesare..."<<endl;
    Sleep(1000);
    system("CLS");
}
void Bancomat::sf_incep_tranz()
{
    int opt;
    system("CLS");
    spatiere_sus();
    cout<<"                                 Doriti sa mai efectuati alta operatiune?"<<endl;
    cout<<"                                         [1]Da               [2]Nu"<<endl;
    cin>>opt;
    if(opt==1 || opt==2)
    {
    if(opt==1)
    {
        system("CLS");
        cin.clear();
        cin.ignore();
        cin.sync();
        meniu_principal();
    }
    if(opt==2)
    {
        system("CLS");
        spatiere_sus();
        cout<<"                                     Va multumim!Va uram o zi buna!"<<endl;
        Sleep(3000);
        strat_securitate();
    }
    }
    else
    {
        sf_incep_tranz();
    }
}
void Bancomat::l_verificare_pin()
{
    system("CLS");
    spatiere_sus();
    cout<<"                                            Verificare pin"<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                            Verificare pin."<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                            Verificare pin.."<<endl;
    Sleep(1000);
    system("CLS");
    spatiere_sus();
    cout<<"                                            Verificare pin..."<<endl;
    Sleep(1000);
    system("CLS");
}
void Bancomat::meniu_principal()
{
    int x;
    system("CLS");
    spatiere_sus();
    cout<<"Data si ora:"<<data()<<endl;
    cout<<"Buna ziua "<<nume<<" "<<prenume<<" !"<<endl;
    cout<<endl;
    cout<<"[1]--> Plata facturi                                                      Interogare sold <--[5]"<<endl;
    cout<<endl;
    cout<<"[2]--> Transfer in alt cont                                             Retragere numerar <--[6]"<<endl;
    cout<<endl;
    cout<<"[3]--> Schimbare cod pin                                                 Depunere numerar <--[7]"<<endl;
    cout<<endl;
    cout<<"[4]--> Schimbare id card                                                  Depunere valuta <--[8]"<<endl;
    cout<<endl;
    cout<<"                         "<<"-->Introduceti optiunea dumneavoastra:";
    cin>>x;
    optiuni(x);
    system("CLS");

}
void Bancomat::optiuni(int opt)
{
    switch(opt)
    {
    case 1:
        plata_facturi();
    case 2:
        transfer();
    case 3:
        schimbare_pin();
    case 4:
        schimbare_nr();
    case 5:
        afiseaza_sold();
    case 6:
        retragere_num();
    case 7:
        depunere_num();
    case 8:
        depunere_val();
    default:
        cin.ignore();
        cin.clear();
        cin.sync();
        meniu_principal();

    }
}
void Bancomat::verificare_nr_card()
{
    l_procesare();
    string linie;
    string temp=to_string(nr_card);
    ifstream d("baza_de_date.txt");
    getline(d,linie);
    while(getline(d,linie))
    {
        if(linie[0]!=temp[0])
    {
       continue;
    }
    else if(linie[0]==temp[0] && linie.find("A_")!= string::npos)
    {
    setPin(2);
    d.close();
    }
    }
    if(linie[0]!=temp[0] || linie.find("F_")!= string::npos )
    {
        spatiere_sus();
        cout<<"                                         Card respins!";
        Sleep(3000);
        system("CLS");
        setNrCard();
    }
}
void Bancomat::verificare_pin(int nr)
{
    l_verificare_pin();
    if(pin==pin_f)
        {
            meniu_principal();
        }
    else
    {
        if(nr>0)
        {
            spatiere_sus();
            cout<<"                               Pin incorect!Mai aveti "<<nr<<" incercari!"<<endl;
            Sleep(3000);
            system("CLS");
            nr--;
            setPin(nr);
        }
        else
        {
            spatiere_sus();
            cout<<"                                           Card blocat!"<<endl;
            Sleep(3000);
            system("CLS");
            blocare_card();
        }
    }
}
void Bancomat::blocare_card()
{
    string linieg,temp,line,linie1,liniuta;
    stringstream ss;
    temp=to_string(nr_card);
    ifstream f("baza_de_date.txt");
    ofstream d("temp2.txt");
    getline(f,linie1);
    while(getline(f,linie1))
    {
        if(temp[0]==linie1[0])
        {
            d<<linie1<<endl;
            break;
        }
    }
    f.close();
    d.close();
    int nr,pin_;
    string nume_,prenume_,stare_;
    float sold_;
    ifstream a("temp2.txt");
    while(a>>nr>>pin_>>nume_>>prenume_>>sold_>>stare_)
    {
    nr_card_f=nr;
    pin_f=pin_;
    nume=nume_;
    prenume=prenume_;
    sold_f=sold_;
    sold=sold_;
    stare=stare_;
    }
    a.close();
    ofstream r("temp2.txt");
    if(r.is_open())
    {
        r<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<"F_";
        ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<"F_";
        linieg=ss.str();
    }
    r.close();
    ifstream cr("baza_de_date.txt");
    ofstream tempo("temp1.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream baza1("temp1.txt", ios_base::app | ios_base::out);
        baza1<<linieg<<endl;
        remove("temp2.txt");
        baza1.close();
        ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp1.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        remove("temp1.txt");
        setNrCard();

}
void Bancomat::plata_facturi()
{
    system("CLS");
    string linie,temp,line,liniuta;
    stringstream ss;
    string strTemp;
    temp=to_string(nr_card_f);
    int opt;
    spatiere_sus();
    cout<<"                                     Introduceti metoda de plata:"<<endl;
    cout<<"                                        [1] Numerar  [2] Card"<<endl;
    cout<<"                                                   ";cin>>opt;
    switch(opt)
    {
    default:
        cout<<"                                     Optiune incorecta!Reincercati!";
        Sleep(3000);
        plata_facturi();
    case 1:
        {
        int al;
        system("CLS");
        spatiere_sus();
        ifstream f("facturi.txt");
        ofstream d("fact_temp.txt");
        while(getline(f,linie))
        {
            if(temp[0]!=linie[0])
            {
                cout<<linie<<endl;
                Sleep(2000);
                continue;
            }
            if(temp[0]==linie[0])
            {
                d<<linie;
                 d.close();
                f.close();
            }
        }
        ifstream n("fact_temp.txt");
        int nr,nr_f;
        string nume_fact,nume_f;
        float plata,plata_f;
        ifstream a("fact_temp.txt");
        while(a>>nr_f>>nume_f>>plata_f)
        {
        nr=nr_f;
        nume_fact=nume_f;
        plata=plata_f;
        }
    a.close();
        cout<<"                   Aveti urmatoarea factura:"<<nume_fact<<" in valoare de "<<plata<<" lei"<<endl;
        cout<<endl;
        float suma1;
        cout<<"                                   Introduceti suma de plata:";cin>>suma1;
        int len=log10(suma1)+1;
        system("CLS");
        spatiere_sus();
        if(len>4)
        {
            cin.ignore();
            cin.clear();
            cin.sync();
            cout<<"                                                 Introduceti o suma valida!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        if(cin.fail())
        {
            cin.ignore();
            cin.clear();
            cin.sync();
            cout<<"                                                 Introduceti doar cifre!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        system("CLS");
        spatiere_sus();
        if(suma1>=plata)
        {
        cout<<"                     Ati introdus suma de "<<suma1<<" lei."<<"Doriti sa achitati factura la "<<nume_fact<<endl;
        cout<<"                                   1.[Da]                  2.[Nu]"<<endl;
        cout<<"                                             ";cin>>al;
        }
        else
        {
            cout<<"                                 Suma introdusa nu este suficienta!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        switch(al)
        {
        default:
            plata_facturi();
        case 1:
            l_procesare();
            spatiere_sus();
            if(suma1!=0)
            {
            ifstream cr("facturi.txt");
            ofstream tempo("temp1.txt");
           while(getline(cr,line))
           {
               if (line[0]!=temp[0])
               {
                   tempo<<line<<endl;
               }
           }
       cr.close();
       tempo.close();
       ofstream b("facturi.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
       ifstream ct("temp1.txt");
        ofstream tempor("facturi.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        remove("temp1.txt");
        remove("fact_temp.txt");
            cout<<"                                  Factura a fost achitata!"<<endl;
            Sleep(3000);
            sf_incep_tranz();
            }
            else
            {
                cout<<"                            Suma introudusa nu este corecta!";
                Sleep(3000);
                plata_facturi();
            }
        case 2:
            sf_incep_tranz();
        }
        }
    case 2:
        {
        float suma2;
        system("CLS");
        spatiere_sus();
         ifstream e("facturi.txt");
        ofstream h("fact_temp.txt");
        while(getline(e,linie))
        {
            if(temp[0]!=linie[0])
            {
                continue;
            }
            if(temp[0]==linie[0])
            {
                h<<linie;
                 h.close();
                e.close();
            }
        }
        int nr,nr_f;
        string nume_fact,nume_f;
        float plata,plata_f;
        ifstream a("fact_temp.txt");
        while(a>>nr_f>>nume_f>>plata_f)
        {
        nr=nr_f;
        nume_fact=nume_f;
        plata=plata_f;
        }
        a.close();
        cout<<"                   Aveti urmatoarea factura:"<<nume_fact<<" in valoare de "<<plata<<" lei"<<endl;
        cout<<endl;
        cout<<"                                     Introduceti suma de plata:";cin>>suma2;
        int len=log10(suma2)+1;
        system("CLS");
        spatiere_sus();
        if(len>4)
        {
            cin.ignore();
            cin.clear();
            cin.sync();
            cout<<"                                                 Introduceti o suma valida!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        if(cin.fail())
        {
            cin.ignore();
            cin.clear();
            cin.sync();
            cout<<"                                                 Introduceti doar cifre!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        l_procesare();
        system("CLS");
        if (suma2<plata || cin.fail())
        {
            cin.ignore();
            cin.clear();
            cin.sync();
            cout<<"                                         Nu ati introdus o suma suficienta!"<<endl;
            Sleep(3000);
            plata_facturi();
        }
        if(suma2>sold_f)
        {
            spatiere_sus();
            cout<<"                                 Nu dispuneti de suma necesara in cont!";
            cin.ignore();
            cin.clear();
            cin.sync();
            Sleep(3000);
            plata_facturi();
        }
        sold_f=sold_f-suma2;
        system("CLS");
        ofstream f("date.txt");
    if(f.is_open())
    {
        f<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
        ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
        linie=ss.str();
    }
    f.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp.txt");
        if(suma2!=0)
            {
                string v;
            ifstream cy("facturi.txt");
            ofstream tempoy("tem.txt");
           while(getline(cy,v))
           {
               if (v[0]!=temp[0])
               {
                   tempoy<<v<<endl;
               }
           }
       cy.close();
       tempoy.close();
       ofstream m("facturi.txt");
        if(m.is_open())
        {
            m<<" ";
        }
        m.close();
       ifstream cm("tem.txt");
        ofstream tempom("facturi.txt");
        string tr;
       while(getline(cm,tr))
       {
            tempor<<tr<<endl;
       }
       cm.close();
       tempom.close();
        remove("tem.txt");
        remove("fact_temp.txt");
        spatiere_sus();
        cout<<"            Tranzactia a fost realizata!Factura la "<<nume_fact<<" in valoare de:"<<plata<<" lei a fost platita."<<endl;
        cout<<"                                                     [OK]"<<endl;
        getch();
        system("CLS");
        sf_incep_tranz();

    }
}
}
}
void Bancomat::retragere_num()
{
    int suma;
    string linie,temp,line,liniuta;
    stringstream ss;
    temp=to_string(nr_card_f);
    system("CLS");
    spatiere_sus();
    cout<<"                     Bancomatul functioneaza doar cu bancnote de cel putin 10 lei."<<endl;
    cout<<"                          Suma introdusa trebuie sa fie de cel putin 10 lei!"<<endl;
    cout<<"                                         1.[Meniu principal]"<<endl;
    cout<<"                                     Introduceti suma dorita:";cin>>suma;
    if(suma==1)
    {
        cin.clear();
        cin.ignore();
        cin.sync();
        meniu_principal();
    }
    if(suma>sold_f)
    {
        cout<<"                                     Fonduri insuficiente!"<<endl;
        Sleep(3000);
        sf_incep_tranz();
    }
    if(suma!=0 && suma>=10 && suma%10==0 && suma<sold_f)
    {
        l_procesare();
        spatiere_sus();
        cout<<"                 Suma de "<<suma<<" lei a fost retrasa din cont!"<<endl;
        Sleep(3000);
        sold_f=sold_f-suma;
        ofstream d("date.txt");
        if(d.is_open())
        {
            d<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp3.txt");
        spatiere_sus();
        sf_incep_tranz();
    }
    else
    {
        cout<<"                     Suma introdusa nu este corecta!Reincercati!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        retragere_num();
    }
}
void Bancomat::depunere_num()
{
    int suma;
    string linie,temp,line,liniuta;
    stringstream ss;
    temp=to_string(nr_card_f);
    spatiere_sus();
    cout<<"                                         1.[Meniu principal]"<<endl;
    cout<<"                         Introduceti suma pe care doriti sa o depuneti:";cin>>suma;
    if(suma==1)
    {
        cin.clear();
        cin.ignore();
        meniu_principal();
    }
    l_procesare();
    sold_f=sold_f+suma;
    if (suma==0)
    {
        cout<<"                           Suma introdusa nu este corecta!Reincercati!";
        Sleep(3000);
        depunere_num();
    }
    ofstream d("date.txt");
        if(d.is_open())
        {
            d<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp3.txt");
        cout<<"                 Suma de "<<suma<<" lei a fost depusa in cont!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        sf_incep_tranz();

}
void Bancomat::depunere_val()
{
    system("CLS");
    string linie,temp,line,liniuta;
    stringstream ss;
    temp=to_string(nr_card_f);
    int opt,opt1;
    float suma;
    spatiere_sus();
    cout<<"                                    Alegeti valuta dorita:"<<endl;
    cout<<endl;
    cout<<"                     [1]-->Euro"<<" [2]-->Dolari"<<" [3]-->Dolari"<<endl;
    cout<<"                                  0.[Meniu principal]"<<endl;
    cout<<"                                         ";cin>>opt;
    system("CLS");
    spatiere_sus();
    cout<<"                     Introduceti suma pe care doriti sa o depuneti:";cin>>suma;
    cout<<endl;
    if(opt==0)
    {
        cin.clear();
        cin.ignore();
        cin.sync();
        meniu_principal();
    }
    if(opt==1)
    {
        suma=suma*4.6;
       cout<<"                                  Suma introdusa in lei este:"<<suma<<" lei";
       cout<<endl;
       cout<<"                                     Doriti sa o depuneti?"<<endl;
       cout<<"                                  [1]Da"<<"       [2]Nu"<<endl;
       cout<<"                                          ";cin>>opt1;
       if(opt1==1)
       {
            sold_f=sold_f+suma;
       }
       else
       {
           depunere_val();
       }
    }
    if(opt==2)
    {
        suma=suma*4;
       cout<<"                                  Suma introdusa in lei este:"<<suma<<" lei"<<endl;
       cout<<endl;
       cout<<"                                     Doriti sa o depuneti?"<<endl;
       cout<<"                                  [1]Da"<<"       [2]Nu"<<endl;
       cout<<"                                          ";cin>>opt1;
       if(opt1==1)
       {
            sold_f=sold_f+suma;
       }
       else
       {
           depunere_val();
       }
    }
    if(opt==3)
    {
        suma=suma*5.1;
       cout<<"                                  Suma introdusa in lei este:"<<suma<<" lei"<<endl;
       cout<<endl;
       cout<<"                                     Doriti sa o depuneti?"<<endl;
       cout<<"                                  [1]Da"<<"       [2]Nu"<<endl;
       cout<<"                                          ";cin>>opt1;
       if(opt1==1)
       {
            sold_f=sold_f+suma;
       }
       else
       {
           depunere_val();
       }
    }
        ofstream d("date.txt");
        if(d.is_open())
        {
            d<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp3.txt");
        cout<<"                 Suma de "<<suma<<" lei a fost depusa in cont!"<<endl;
        Sleep(3000);
        spatiere_sus();
        sf_incep_tranz();

}
void Bancomat::schimbare_pin()
{
    string linie,temp,line,liniuta;
    stringstream ss;
    temp=to_string(nr_card_f);
    int pin1,pin2;
    system("CLS");
    spatiere_sus();
    cout<<"                     Codul pin trebuie sa fie format din 4 cifre!"<<endl;
    cout<<endl;
    cout<<"                             Introduceti codul pin dorit:";cin>>pin1;
    cout<<endl;
    cout<<"                            Reintroduceti codul pin dorit:";cin>>pin2;
    if(pin1==pin2)
    {
        l_procesare();
        system("CLS");
        spatiere_sus();
        pin_f=pin2;
        ofstream d("date.txt");
        if(d.is_open())
        {
            d<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp3.txt");
        cout<<"                 Codul pin a fost schimbat cu succes!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        cin.clear();
        cin.ignore();
        cin.sync();
        strat_securitate();
    }
    else
    {
        system("CLS");
        spatiere_sus();
        cout<<"         Codurile pin nu se potrivesc!Va rugam sa reincercati!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        schimbare_pin();
    }
}
void Bancomat::schimbare_nr()
{
    system("CLS");
    spatiere_sus();
    string linie,temp,line,liniuta;
    stringstream ss;
    temp=to_string(nr_card_f);
    int cod1,cod2;
    system("CLS");
    spatiere_sus();
    cout<<"                     Numarul cardului trebuie sa fie cuprins intre 0 si 9!"<<endl;
    cout<<"                                         10.[Meniu principal]"<<endl;
    cout<<endl;
    cout<<"                            Introduceti numarul de card dorit:";cin>>cod1;
    cout<<endl;
    if(cod1==10)
    {
        cin.clear();
        cin.ignore();
        cin.sync();
        meniu_principal();
    }
    cout<<"                           Reintroduceti numarul de card dorit:";cin>>cod2;
    string j;
    if(cod1==cod2 && cod1<=9 && cod2<=9 && cod1!=10)
    {
        l_procesare();
        system("CLS");
        spatiere_sus();
        ifstream n("baza_de_date.txt");
        getline(n,j);
        string l=to_string(cod2);
        while(getline(n,j))
        {
            if(j[0]!=l[0])
            {
                continue;
            }
            if(j[0]==l[0])
            {
                cin.clear();
                cin.ignore();
                cin.sync();
                cout<<"                   Numarul de card exista deja in baza de date!Reincerceati"<<endl;
                Sleep(3000);
                schimbare_nr();
                break;
            }
        }
        n.close();
        ofstream d("date.txt");
        if(d.is_open())
        {
            d<<cod2<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<cod2<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0])
           {
               tempo<<line<<endl;
           }
       }
       cr.close();
       tempo.close();
       ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza.close();
        remove("temp3.txt");
        cout<<"                     Numarul cardului a fost schimbat cu succes!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        strat_securitate();
    }
    else
    {
        system("CLS");
        spatiere_sus();
        cout<<"         Numerele de card nu se potrivesc!Va rugam sa reincercati!"<<endl;
        schimbare_pin();
    }
}
void Bancomat::transfer()
{
    int suma,opt;
    int nr,pin_,nr1,pin1;
    string nume_,prenume_,stare_,nume1,prenume1,stare1;
    float sold_,sold1;
    int nr_card_t;
    system("CLS");
    spatiere_sus();
    cout<<"                     Introduceti numarul de card al beneficiarului:";cin>>nr_card_t;
    string linie,line,liniuta,linie_1,alta_linie,lin;
    stringstream ss,bb;
    string temp=to_string(nr_card);
    string temp1=to_string(nr_card_t);
    ifstream d("baza_de_date.txt");
    getline(d,lin);
    while(getline(d,lin))
    {
        if(lin[0]!=temp1[0])
    {
       continue;
    }
    else if(lin[0]==temp1[0] && lin.find("A_")!= string::npos)
    {
        system("CLS");
        spatiere_sus();
    cout<<"                         Numarul de card al beneficiarului este valid!"<<endl;
    Sleep(3000);
    system("CLS");
    spatiere_sus();
    cout<<"                                 Introduceti metoda transfer!"<<endl;
    cout<<endl;
    cout<<"                                 [1]-->Numerar       [2]Card"<<endl;
    cout<<"                                                 ";cin>>opt;
    if(opt==1 || opt==2)
    {
    if(opt==1)
    {
        system("CLS");
        spatiere_sus();
        cout<<"                     Introduceti suma pe care doriti sa o transferati:";cin>>suma;
        if(suma==0)
        {
            system("CLS");
            spatiere_sus();
            cout<<"                             Suma introdusa nu este corecta!Reincercati!";
            Sleep(3000);
            cin.clear();
            cin.ignore();
            cin.sync();
            transfer();
        }
        ifstream g("baza_de_date.txt");
       ofstream e("date_temp.txt");
       getline(g,linie_1);
       while(getline(g,linie_1))
             {
                 if(linie_1[0]==temp1[0])
                 {
                     e<<linie_1;
                 }
             }
       e.close();
       g.close();
       ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp1[0])
           {
               tempo<<line<<endl;
           }
       }
        cr.close();
       tempo.close();
       ifstream a("date_temp.txt");
        while(a>>nr>>pin_>>nume_>>prenume_>>sold_>>stare_)
        {
        nr1=nr;
        pin1=pin_;
        nume1=nume_;
        prenume1=prenume_;
        sold1=sold_;
        stare1=stare_;
        }
        a.close();
        sold1=sold1+suma;
       ofstream n("date_temp.txt");
       if(n.is_open())
        {
            n<<nr1<<" "<<pin1<<" "<<nume1<<" "<<prenume1<<" "<<sold1<<" "<<stare1;
            bb<<nr1<<" "<<pin1<<" "<<nume1<<" "<<prenume1<<" "<<sold1<<" "<<stare1;
            alta_linie=bb.str();
        }
        n.close();
        ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<alta_linie<<endl;
        baza.close();
        remove("temp3.txt");
        remove("date_temp.txt");
        cout<<"                                  Transferul a fost efectuat!";
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        sf_incep_tranz();
    }
    if(opt==2)
    {
        system("CLS");
        spatiere_sus();
        cout<<"                     Introduceti suma pe care doriti sa o transferati:";cin>>suma;
        if(suma<sold_f)
        {
            sold_f=sold_f-suma;
        ofstream d("date.txt");
        if(d.is_open())
        {
            d<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            ss<<nr_card_f<<" "<<pin_f<<" "<<nume<<" "<<prenume<<" "<<sold_f<<" "<<stare;
            linie=ss.str();
        }
        d.close();
        ifstream cr("baza_de_date.txt");
        ofstream tempo("temp3.txt");
       while(getline(cr,line))
       {
           if (line[0]!=temp[0] &&line[0]!=temp1[0])
           {
               tempo<<line<<endl;
           }
       }
        cr.close();
       tempo.close();
       ifstream g("baza_de_date.txt");
       ofstream e("date_temp.txt");
       getline(g,linie_1);
       while(getline(g,linie_1))
             {
                 if(linie_1[0]==temp1[0])
                 {
                     e<<linie_1;
                 }
             }
       e.close();
       g.close();
       ifstream a("date_temp.txt");
        while(a>>nr>>pin_>>nume_>>prenume_>>sold_>>stare_)
        {
        nr1=nr;
        pin1=pin_;
        nume1=nume_;
        prenume1=prenume_;
        sold1=sold_;
        stare1=stare_;
        }
        a.close();
        sold1=sold1+suma;
       ofstream n("date_temp.txt");
       if(n.is_open())
        {
            n<<nr1<<" "<<pin1<<" "<<nume1<<" "<<prenume1<<" "<<sold1<<" "<<stare1;
            bb<<nr1<<" "<<pin1<<" "<<nume1<<" "<<prenume1<<" "<<sold1<<" "<<stare1;
            alta_linie=bb.str();
        }
        n.close();
        ofstream b("baza_de_date.txt");
        if(b.is_open())
        {
            b<<" ";
        }
        b.close();
        ifstream ct("temp3.txt");
        ofstream tempor("baza_de_date.txt");
       while(getline(ct,liniuta))
       {
            tempor<<liniuta<<endl;
       }
       ct.close();
       tempor.close();
        ofstream baza("baza_de_date.txt", ios_base::app | ios_base::out);
        baza<<linie<<endl;
        baza<<alta_linie<<endl;
        baza.close();
        remove("temp3.txt");
        remove("date_temp.txt");
        l_procesare();
        system("CLS");
        spatiere_sus();
        cout<<"                         Transferul a fost realizat cu succes!"<<endl;
        cout<<endl;
        cout<<"                                         [OK]"<<endl;
        getch();
        sf_incep_tranz();
        }
        else
        {
            cout<<"                 Nu dispuneti de suma pe care doriti sa o transferati!"<<endl;
            cout<<endl;
            cout<<"                                             [OK]"<<endl;
            getch();
            transfer();
        }
    }
    }
    else
    {
        transfer();
    }

    d.close();
    }
    }
    if(lin[0]!=temp[0] || lin.find("F_")!= string::npos )
    {
        system("CLS");
        spatiere_sus();
    cout<<"                         Numarul de card al beneficiarului este invalid!"<<endl;
        Sleep(3000);
        system("CLS");
        d.close();
        transfer();
    }

}
void Bancomat::afiseaza_sold()
{
    system("CLS");
    spatiere_sus();
    cout<<"                                     Sold curent:"<<sold_f<<" lei"<<endl;
    cout<<endl;
    cout<<"                                                  [OK]"<<endl;
    getch();
    sf_incep_tranz();
}
Bancomat::~Bancomat()
{
}

