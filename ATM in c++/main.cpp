#include<iostream>
#include <stdio.h>
#include <unistd.h>
#include"Bancomat.h"
#include<windows.h>
#include<wincon.h>
void racheta()
{
int i;
for(i=0;i<9;i++)
    {
        cout<<endl;
    }
system("color 0a");
 cout<<"\n\n\n\t\t\t\t\tPornire bancomat\n\n";
 char a=177, b=219;
 cout<<"\t\t\t\t\t";
 for (int i=0;i<=15;i++)
 cout<<a;
 cout<<"\r";
 cout<<"\t\t\t\t\t";
 for (int i=0;i<=15;i++)
 {
  cout<<b;
  Sleep(250);
 }
}
void fullscreen()
{
keybd_event(VK_MENU,0x38,0,0);
keybd_event(VK_RETURN,0x1c,0,0);
keybd_event(VK_RETURN,0x1c,KEYEVENTF_KEYUP,0);
keybd_event(VK_MENU,0x38,KEYEVENTF_KEYUP,0);
}
int main()
{
    //fullscreen();
    racheta();
    system("COLOR 79");
    Bancomat b;
    b.strat_securitate();
}


