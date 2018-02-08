VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   8970
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11445
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   8970
   ScaleWidth      =   11445
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   4
      Left            =   2715
      TabIndex        =   20
      Top             =   2160
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   3
      Left            =   2715
      TabIndex        =   19
      Top             =   1620
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "0"
      Height          =   270
      Index           =   2
      Left            =   2715
      TabIndex        =   18
      Top             =   1080
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "400"
      Height          =   270
      Index           =   1
      Left            =   2715
      TabIndex        =   17
      Top             =   540
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "400"
      Height          =   270
      Index           =   0
      Left            =   2715
      TabIndex        =   16
      Top             =   0
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   7
      Left            =   2715
      TabIndex        =   5
      Top             =   2700
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   8
      Left            =   2715
      TabIndex        =   4
      Top             =   3240
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   6
      Left            =   2715
      TabIndex        =   3
      Top             =   3780
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   9
      Left            =   2715
      TabIndex        =   2
      Top             =   4320
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   10
      Left            =   2715
      TabIndex        =   1
      Top             =   4860
      Width           =   705
   End
   Begin VB.CommandButton cmdPedMaxStat 
      Caption         =   "Max"
      Height          =   270
      Index           =   11
      Left            =   2715
      TabIndex        =   0
      Top             =   5400
      Width           =   705
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Pilot Stat  (0):"
      Height          =   195
      Index           =   13
      Left            =   0
      TabIndex        =   6
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Pilot Stat (0 to 1000)"
      Top             =   5400
      Width           =   3405
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Cycling Stat (0):"
      Height          =   195
      Index           =   12
      Left            =   0
      TabIndex        =   7
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Cycling Stat (0 to 1000)"
      Top             =   4860
      Width           =   3405
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Biking Stat (0):"
      Height          =   195
      Index           =   11
      Left            =   0
      TabIndex        =   8
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Bike Stat (0 to 1000)"
      Top             =   4320
      Width           =   3405
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Lung Capacity  (0):"
      Height          =   195
      Index           =   8
      Left            =   0
      TabIndex        =   9
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Underwater Stamina Level (0 to 1000)"
      Top             =   2700
      Width           =   3420
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Driving Stat  (0):"
      Height          =   195
      Index           =   7
      Left            =   0
      TabIndex        =   10
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Driving Stat (0 to 1000)"
      Top             =   3780
      Width           =   3405
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Armor Level  (0):"
      Height          =   195
      Index           =   0
      Left            =   0
      TabIndex        =   11
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Armor Level"
      Top             =   0
      Width           =   2685
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Health Level (0):"
      Height          =   195
      Index           =   1
      Left            =   0
      TabIndex        =   12
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Health"
      Top             =   540
      Width           =   2685
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Fat Stat  (0):"
      Height          =   195
      Index           =   3
      Left            =   0
      TabIndex        =   13
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Fat Level (0 to 1000)"
      Top             =   1080
      Width           =   2685
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Stamina Stat  (0):"
      Height          =   195
      Index           =   4
      Left            =   0
      TabIndex        =   14
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Stamina Level (0 to 1000)"
      Top             =   1620
      Width           =   2685
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Muscle Stat  (0):"
      Height          =   195
      Index           =   5
      Left            =   0
      TabIndex        =   15
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Muscle Level (0 to 1000)"
      Top             =   2160
      Width           =   2685
   End
   Begin VB.CheckBox chkPlayerStats 
      Caption         =   "Current Gambling Stat  (0):"
      Height          =   195
      Index           =   9
      Left            =   0
      TabIndex        =   21
      TabStop         =   0   'False
      ToolTipText     =   "Check to lock Gambling Stat (0 to 1000)"
      Top             =   3240
      Width           =   3405
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   0
      LargeChange     =   10
      Left            =   240
      Max             =   999
      TabIndex        =   22
      TabStop         =   0   'False
      Top             =   255
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   1
      LargeChange     =   10
      Left            =   240
      Max             =   999
      TabIndex        =   23
      TabStop         =   0   'False
      Top             =   795
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   3
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   24
      TabStop         =   0   'False
      Top             =   1335
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   4
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   25
      TabStop         =   0   'False
      Top             =   1875
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   5
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   26
      TabStop         =   0   'False
      Top             =   2415
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   8
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   27
      TabStop         =   0   'False
      Top             =   2955
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   9
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   28
      TabStop         =   0   'False
      Top             =   3495
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   7
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   29
      TabStop         =   0   'False
      Top             =   4035
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   10
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   30
      TabStop         =   0   'False
      Top             =   4575
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   11
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   31
      TabStop         =   0   'False
      Top             =   5115
      Width           =   3180
   End
   Begin VB.HScrollBar scrPlayerStats 
      Height          =   225
      Index           =   12
      LargeChange     =   10
      Left            =   240
      Max             =   1000
      TabIndex        =   32
      TabStop         =   0   'False
      Top             =   5655
      Width           =   3180
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

