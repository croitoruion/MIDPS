object Form1: TForm1
  Left = 357
  Top = 219
  Width = 1305
  Height = 675
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
    Left = 272
    Top = 32
    Width = 135
    Height = 20
    Caption = 'Data si ora curenta'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 176
    Top = 96
    Width = 352
    Height = 25
    Caption = 'Resurse grafice ale mediului C++ Builder'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -20
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object PaintBox1: TPaintBox
    Left = 256
    Top = 136
    Width = 265
    Height = 233
  end
  object Button1: TButton
    Left = 80
    Top = 176
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 80
    Top = 224
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 80
    Top = 320
    Width = 75
    Height = 17
    Caption = 'Exit'
    TabOrder = 2
    OnClick = Button4Click
  end
  object Edit1: TEdit
    Left = 280
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 3
    Text = 'Edit1'
  end
  object Panel1: TPanel
    Left = 176
    Top = 136
    Width = 57
    Height = 81
    Caption = 'Panel1'
    Color = clBackground
    TabOrder = 4
  end
  object Panel2: TPanel
    Left = 176
    Top = 216
    Width = 57
    Height = 153
    Caption = 'Panel2'
    Color = clGrayText
    TabOrder = 5
  end
  object Button4: TButton
    Left = 80
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Continue'
    TabOrder = 6
    OnClick = Button3Click
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 72
    Top = 48
  end
  object Timer2: TTimer
    Interval = 500
    OnTimer = Timer2Timer
    Left = 72
    Top = 112
  end
end
