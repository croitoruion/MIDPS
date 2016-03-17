object Form1: TForm1
  Left = 322
  Top = 196
  Width = 874
  Height = 674
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 280
    Top = 80
    Width = 247
    Height = 16
    Caption = 'Realizarea unui cronometru in C++ Builder'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clGreen
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 256
    Top = 176
    Width = 276
    Height = 25
    Caption = 'C++ BUILDER CRONOMETRU'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clGreen
    Font.Height = -20
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Edit1: TEdit
    Left = 360
    Top = 128
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
  end
  object Button1: TButton
    Left = 128
    Top = 248
    Width = 75
    Height = 25
    Caption = 'START'
    TabOrder = 1
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 128
    Top = 288
    Width = 75
    Height = 25
    Caption = 'STOP'
    TabOrder = 2
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 128
    Top = 328
    Width = 75
    Height = 25
    Caption = 'ZERO'
    TabOrder = 3
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 488
    Top = 376
    Width = 75
    Height = 17
    Caption = 'EXIT'
    TabOrder = 4
    OnClick = Button4Click
  end
  object Edit2: TEdit
    Left = 368
    Top = 288
    Width = 121
    Height = 33
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -20
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 5
    Text = 'Edit2'
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 96
    Top = 104
  end
  object Timer2: TTimer
    Interval = 100
    OnTimer = Timer2Timer
    Left = 96
    Top = 152
  end
end
