#include <iostream>
#include <windows.h>
#include <MMSystem.h>
using namespace std;
LRESULT CALLBACK WndProc (HWND, UINT, WPARAM, LPARAM) ;
int WINAPI WinMain (HINSTANCE hInstance, HINSTANCE hPrevInstance,
                    PSTR szCmdLine, int iCmdShow)
     {
     static char szAppName[] = "TI-142" ;
     HWND        hwnd ;
     MSG         msg ;
     WNDCLASSEX  wndclass ;
     wndclass.cbSize        = sizeof (wndclass) ;
     wndclass.style         = CS_HREDRAW | CS_VREDRAW ;
     wndclass.lpfnWndProc   = WndProc ;
     wndclass.cbClsExtra    = 0 ;
     wndclass.cbWndExtra    = 0 ;
     wndclass.hInstance     = hInstance ;
     wndclass.hIcon         = LoadIcon (NULL, IDI_WARNING) ;
     wndclass.hCursor       = LoadCursorFromFile("move.cur");
     wndclass.hbrBackground = (HBRUSH) CreateSolidBrush(RGB(228 ,	219 ,	191 	));
     wndclass.lpszMenuName  = NULL ;
     wndclass.lpszClassName = szAppName ;
     wndclass.hIconSm       = LoadIcon (NULL, IDI_ERROR) ;
     RegisterClassEx (&wndclass) ;
     hwnd = CreateWindow (szAppName,         // window class name
		            "Primul program",     // window caption
                    WS_OVERLAPPEDWINDOW,     // window style
                    CW_USEDEFAULT,           // initial x position
                    CW_USEDEFAULT,           // initial y position
                    CW_USEDEFAULT,           // initial x size
                    CW_USEDEFAULT,           // initial y size
                    NULL,                    // parent window handle
                    NULL,                    // window menu handle
                    hInstance,               // program instance handle
		            NULL) ;		             // creation parameters
     ShowWindow (hwnd, iCmdShow) ;
     UpdateWindow (hwnd) ;
     while (GetMessage (&msg, NULL, 0, 0))
          {
          TranslateMessage (&msg) ;
          DispatchMessage (&msg) ;
          }
     return msg.wParam ;
     }
LRESULT CALLBACK WndProc (HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam)
     {
     HDC         hdc ;
     PAINTSTRUCT ps ;
     RECT        rect ;

     switch (iMsg)
          {
          case WM_CREATE :
               PlaySound (TEXT("tts.wav"), NULL, SND_FILENAME | SND_ASYNC) ;//
               return 0 ;
          case WM_PAINT :
	           hdc = BeginPaint (hwnd, &ps) ;
               GetClientRect (hwnd, &rect) ;
               SetBkColor(hdc,RGB(228 ,	219 ,	191));
               SetTextColor(hdc,RGB(220,91,33));
               DrawText (hdc,16+ "Lucrarea de laborator al studentului  grupei TI-142,  Croitoru Ionel", 19,&rect,
			    DT_SINGLELINE | DT_CENTER | DT_VCENTER  ) ;
	           EndPaint (hwnd, &ps) ;
               return 0 ;
          case WM_DESTROY :
               PostQuitMessage (0) ;
               return 0 ;
          }
     return DefWindowProc (hwnd, iMsg, wParam, lParam) ;
     }

