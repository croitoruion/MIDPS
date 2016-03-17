//---------------------------------------------------------------------------

#include <vcl.h>
#include <dos.h>
#include <stdio.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
int m = 0, s = 0, z = 0;
int day = 0, mon = 0, year = 0, hour = 0, min = 0, sec = 0;
int i = 0;
TForm1 *Form1;
struct date d;
struct time t;
int k = 0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
Timer1->Enabled=true;
	Timer2->Enabled=false;
	Button1->Enabled=true;
	Button2->Enabled=false;
	Button3->Enabled=false;
	Edit2->Text="0 min 0 sec 0 zec";



	getdate(&d);
	gettime(&t);
	char buf[40];

	snprintf ( buf, 40, "%d-%d-%d %d:%d:%d", d.da_day,d.da_mon,d.da_year,t.ti_hour,t.ti_min,t.ti_sec);
	Edit1->Text=(AnsiString)buf;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
getdate(&d);
	gettime(&t);
	char buff[40];

	snprintf ( buff, 40, "%d-%d-%d %d:%d:%d", d.da_day,d.da_mon,d.da_year,t.ti_hour,t.ti_min,t.ti_sec);
	Edit1->Text=(AnsiString)buff;        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{

	char buf[40];

	Timer2->Tag=i;
	if( i<100){
	z = i; }
	if(i == 10){
	  z = 0;
	  s++;
	  i = 0;
	}
	if(s == 60){
	m++;
	s = 0;

	}

	snprintf ( buf, 40, "%d min %d sec %d zec", m,s,z);
	Edit2->Text=(AnsiString)buf;
	i++;
	//Edit2->Text=Timer2->Tag;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
        Button1->Enabled=false;
	Button2->Enabled=true;
	Button3->Enabled=false;

	Timer2->Enabled=true;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
    Button1->Enabled=false;
	Button2->Enabled=false;
	Button3->Enabled=true;
	Timer2->Enabled=false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{

	Button1->Enabled=true;
	Button2->Enabled=false;
	Button3->Enabled=false;
	Timer2->Enabled=false;
	i = z = s = m = 0;
	Edit2->Text="0 min 0 sec 0 zec";
}
//---------------------------------------------------------------------------
