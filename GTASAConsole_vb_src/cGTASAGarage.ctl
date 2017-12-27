VERSION 5.00
Begin VB.UserControl cGTASAGarage 
   ClientHeight    =   315
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   7290
   LockControls    =   -1  'True
   ScaleHeight     =   21
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   486
   Begin VB.ComboBox cboSelectCar 
      Height          =   315
      ItemData        =   "cGTASAGarage.ctx":0000
      Left            =   2145
      List            =   "cGTASAGarage.ctx":0002
      Style           =   2  'Dropdown List
      TabIndex        =   9
      TabStop         =   0   'False
      ToolTipText     =   "Select a car to Park in this Garage/Parkplace"
      Top             =   0
      Width           =   2355
   End
   Begin VB.PictureBox picMajor 
      Height          =   285
      Left            =   5505
      ScaleHeight     =   225
      ScaleWidth      =   795
      TabIndex        =   7
      TabStop         =   0   'False
      ToolTipText     =   "Doubleclick to change"
      Top             =   15
      Width           =   855
      Begin VB.CheckBox chkMajorLock 
         Height          =   195
         Left            =   600
         TabIndex        =   8
         TabStop         =   0   'False
         ToolTipText     =   "Lock Major color"
         Top             =   15
         Width           =   195
      End
   End
   Begin VB.PictureBox picMinor 
      Height          =   285
      Left            =   6390
      ScaleHeight     =   225
      ScaleWidth      =   795
      TabIndex        =   5
      TabStop         =   0   'False
      ToolTipText     =   "Doubleclick to change"
      Top             =   15
      Width           =   855
      Begin VB.CheckBox chkMinorLock 
         Height          =   195
         Left            =   600
         TabIndex        =   6
         TabStop         =   0   'False
         ToolTipText     =   "Lock Minor color"
         Top             =   15
         Width           =   195
      End
   End
   Begin VB.CheckBox chkEP 
      Height          =   315
      Left            =   4545
      TabIndex        =   4
      TabStop         =   0   'False
      ToolTipText     =   "Explosion-proof"
      Top             =   0
      Width           =   210
   End
   Begin VB.CheckBox chkDP 
      Height          =   315
      Left            =   4785
      TabIndex        =   3
      TabStop         =   0   'False
      ToolTipText     =   "Damage-proof"
      Top             =   0
      Width           =   210
   End
   Begin VB.CheckBox chkBP 
      Height          =   315
      Left            =   5010
      TabIndex        =   2
      TabStop         =   0   'False
      ToolTipText     =   "Bullet-proof"
      Top             =   0
      Width           =   210
   End
   Begin VB.CheckBox chkFP 
      Height          =   315
      Left            =   5250
      TabIndex        =   1
      TabStop         =   0   'False
      ToolTipText     =   "Flame-proof"
      Top             =   0
      Width           =   210
   End
   Begin VB.CheckBox chkLockGarage 
      Caption         =   "Garage Caption:"
      Height          =   195
      Left            =   0
      TabIndex        =   0
      TabStop         =   0   'False
      ToolTipText     =   "Lock settings for this garage"
      Top             =   60
      Width           =   2130
   End
End
Attribute VB_Name = "cGTASAGarage"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
'Default Property Values:
Const m_def_PicMajorTag = "0"
Const m_def_PicMinorTag = "0"
'Property Variables:
Dim m_PicMajorTag As String
Dim m_PicMinorTag As String
'Event Declarations:
Event LockGarageClick() 'MappingInfo=chkLockGarage,chkLockGarage,-1,Click
Attribute LockGarageClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event MajorLockClick() 'MappingInfo=chkMajorLock,chkMajorLock,-1,Click
Attribute MajorLockClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event MinorLockClick() 'MappingInfo=chkMinorLock,chkMinorLock,-1,Click
Attribute MinorLockClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event PicMajorDblClick() 'MappingInfo=picMajor,picMajor,-1,DblClick
Attribute PicMajorDblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event PicMinorDblClick() 'MappingInfo=picMinor,picMinor,-1,DblClick
Attribute PicMinorDblClick.VB_Description = "Occurs when the user presses and releases a mouse button and then presses and releases it again over an object."
Event SelectCarClick() 'MappingInfo=cboSelectCar,cboSelectCar,-1,Click
Attribute SelectCarClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event cEPClick() 'MappingInfo=chkEP,chkEP,-1,Click
Attribute cEPClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event cDPClick() 'MappingInfo=chkDP,chkDP,-1,Click
Attribute cDPClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event cBPClick() 'MappingInfo=chkBP,chkBP,-1,Click
Attribute cBPClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."
Event cFPClick() 'MappingInfo=chkFP,chkFP,-1,Click
Attribute cFPClick.VB_Description = "Occurs when the user presses and then releases a mouse button over an object."

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkLockGarage,chkLockGarage,-1,Caption
Public Property Get GarageCaption() As String
Attribute GarageCaption.VB_Description = "Returns/sets the text displayed in an object's title bar or below an object's icon."
    GarageCaption = chkLockGarage.Caption
End Property

Public Property Let GarageCaption(ByVal New_GarageCaption As String)
    chkLockGarage.Caption() = New_GarageCaption
    PropertyChanged "GarageCaption"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkLockGarage,chkLockGarage,-1,Value
Public Property Get LockGarageValue() As Integer
Attribute LockGarageValue.VB_Description = "Returns/sets the value of an object."
    LockGarageValue = chkLockGarage.Value
End Property

Public Property Let LockGarageValue(ByVal New_LockGarageValue As Integer)
    chkLockGarage.Value() = New_LockGarageValue
    PropertyChanged "LockGarageValue"
End Property

Private Sub chkLockGarage_Click()
    RaiseEvent LockGarageClick
End Sub

Private Sub chkMajorLock_Click()
    RaiseEvent MajorLockClick
End Sub

Private Sub chkMinorLock_Click()
    RaiseEvent MinorLockClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkMinorLock,chkMinorLock,-1,Value
Public Property Get isMinorLocked() As Integer
Attribute isMinorLocked.VB_Description = "Returns/sets the value of an object."
    isMinorLocked = chkMinorLock.Value
End Property

Public Property Let isMinorLocked(ByVal New_isMinorLocked As Integer)
    chkMinorLock.Value() = New_isMinorLocked
    PropertyChanged "isMinorLocked"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkMajorLock,chkMajorLock,-1,Value
Public Property Get isMajorLocked() As Integer
Attribute isMajorLocked.VB_Description = "Returns/sets the value of an object."
    isMajorLocked = chkMajorLock.Value
End Property

Public Property Let isMajorLocked(ByVal New_isMajorLocked As Integer)
    chkMajorLock.Value() = New_isMajorLocked
    PropertyChanged "isMajorLocked"
End Property

Private Sub picMajor_DblClick()
    RaiseEvent PicMajorDblClick
End Sub

Private Sub picMinor_DblClick()
    RaiseEvent PicMinorDblClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,0
Public Property Get PicMajorTag() As String
    PicMajorTag = m_PicMajorTag
End Property

Public Property Let PicMajorTag(ByVal New_PicMajorTag As String)
    m_PicMajorTag = New_PicMajorTag
    PropertyChanged "PicMajorTag"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MemberInfo=13,0,0,0
Public Property Get PicMinorTag() As String
    PicMinorTag = m_PicMinorTag
End Property

Public Property Let PicMinorTag(ByVal New_PicMinorTag As String)
    m_PicMinorTag = New_PicMinorTag
    PropertyChanged "PicMinorTag"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=picMajor,picMajor,-1,BackColor
Public Property Get PicMajorColor() As OLE_COLOR
Attribute PicMajorColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    PicMajorColor = picMajor.BackColor
End Property

Public Property Let PicMajorColor(ByVal New_PicMajorColor As OLE_COLOR)
    picMajor.BackColor() = New_PicMajorColor
    PropertyChanged "PicMajorColor"
End Property

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=picMinor,picMinor,-1,BackColor
Public Property Get PicMinorColor() As OLE_COLOR
Attribute PicMinorColor.VB_Description = "Returns/sets the background color used to display text and graphics in an object."
    PicMinorColor = picMinor.BackColor
End Property

Public Property Let PicMinorColor(ByVal New_PicMinorColor As OLE_COLOR)
    picMinor.BackColor() = New_PicMinorColor
    PropertyChanged "PicMinorColor"
End Property

Private Sub cboSelectCar_Click()
    RaiseEvent SelectCarClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=cboSelectCar,cboSelectCar,-1,AddItem
Public Sub SelectCarAdd(ByVal Item As String, ByVal Index As Variant)
Attribute SelectCarAdd.VB_Description = "Adds an item to a Listbox or ComboBox control or a row to a Grid control."
    cboSelectCar.AddItem Item, Index
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=cboSelectCar,cboSelectCar,-1,Clear
Public Sub SelectCarClear()
Attribute SelectCarClear.VB_Description = "Clears the contents of a control or the system Clipboard."
    cboSelectCar.Clear
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=cboSelectCar,cboSelectCar,-1,ListIndex
Public Property Get SelectCarListIndex() As Integer
Attribute SelectCarListIndex.VB_Description = "Returns/sets the index of the currently selected item in the control."
    SelectCarListIndex = cboSelectCar.ListIndex
End Property

Public Property Let SelectCarListIndex(ByVal New_SelectCarListIndex As Integer)
    cboSelectCar.ListIndex() = New_SelectCarListIndex
    PropertyChanged "SelectCarListIndex"
End Property

Private Sub chkEP_Click()
    RaiseEvent cEPClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkEP,chkEP,-1,Value
Public Property Get cEPValue() As Integer
Attribute cEPValue.VB_Description = "Returns/sets the value of an object."
    cEPValue = chkEP.Value
End Property

Public Property Let cEPValue(ByVal New_cEPValue As Integer)
    chkEP.Value() = New_cEPValue
    PropertyChanged "cEPValue"
End Property

Private Sub chkDP_Click()
    RaiseEvent cDPClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkDP,chkDP,-1,Value
Public Property Get cDPValue() As Integer
Attribute cDPValue.VB_Description = "Returns/sets the value of an object."
    cDPValue = chkDP.Value
End Property

Public Property Let cDPValue(ByVal New_cDPValue As Integer)
    chkDP.Value() = New_cDPValue
    PropertyChanged "cDPValue"
End Property

Private Sub chkBP_Click()
    RaiseEvent cBPClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkBP,chkBP,-1,Value
Public Property Get cBPValue() As Integer
Attribute cBPValue.VB_Description = "Returns/sets the value of an object."
    cBPValue = chkBP.Value
End Property

Public Property Let cBPValue(ByVal New_cBPValue As Integer)
    chkBP.Value() = New_cBPValue
    PropertyChanged "cBPValue"
End Property

Private Sub chkFP_Click()
    RaiseEvent cFPClick
End Sub

'WARNING! DO NOT REMOVE OR MODIFY THE FOLLOWING COMMENTED LINES!
'MappingInfo=chkFP,chkFP,-1,Value
Public Property Get cFPValue() As Integer
Attribute cFPValue.VB_Description = "Returns/sets the value of an object."
    cFPValue = chkFP.Value
End Property

Public Property Let cFPValue(ByVal New_cFPValue As Integer)
    chkFP.Value() = New_cFPValue
    PropertyChanged "cFPValue"
End Property

'Initialize Properties for User Control
Private Sub UserControl_InitProperties()
    m_PicMajorTag = m_def_PicMajorTag
    m_PicMinorTag = m_def_PicMinorTag
End Sub

'Load property values from storage
Private Sub UserControl_ReadProperties(PropBag As PropertyBag)

    chkLockGarage.Caption = PropBag.ReadProperty("GarageCaption", "Garage Caption:")
    chkLockGarage.Value = PropBag.ReadProperty("LockGarageValue", 0)
    chkMinorLock.Value = PropBag.ReadProperty("isMinorLocked", 0)
    chkMajorLock.Value = PropBag.ReadProperty("isMajorLocked", 0)
    m_PicMajorTag = PropBag.ReadProperty("PicMajorTag", m_def_PicMajorTag)
    m_PicMinorTag = PropBag.ReadProperty("PicMinorTag", m_def_PicMinorTag)
    picMajor.BackColor = PropBag.ReadProperty("PicMajorColor", &H8000000F)
    picMinor.BackColor = PropBag.ReadProperty("PicMinorColor", &H8000000F)
    cboSelectCar.ListIndex = PropBag.ReadProperty("SelectCarListIndex", 0)
    chkEP.Value = PropBag.ReadProperty("cEPValue", 0)
    chkDP.Value = PropBag.ReadProperty("cDPValue", 0)
    chkBP.Value = PropBag.ReadProperty("cBPValue", 0)
    chkFP.Value = PropBag.ReadProperty("cFPValue", 0)
End Sub

'Write property values to storage
Private Sub UserControl_WriteProperties(PropBag As PropertyBag)

    Call PropBag.WriteProperty("GarageCaption", chkLockGarage.Caption, "Garage Caption:")
    Call PropBag.WriteProperty("LockGarageValue", chkLockGarage.Value, 0)
    Call PropBag.WriteProperty("isMinorLocked", chkMinorLock.Value, 0)
    Call PropBag.WriteProperty("isMajorLocked", chkMajorLock.Value, 0)
    Call PropBag.WriteProperty("PicMajorTag", m_PicMajorTag, m_def_PicMajorTag)
    Call PropBag.WriteProperty("PicMinorTag", m_PicMinorTag, m_def_PicMinorTag)
    Call PropBag.WriteProperty("PicMajorColor", picMajor.BackColor, &H8000000F)
    Call PropBag.WriteProperty("PicMinorColor", picMinor.BackColor, &H8000000F)
    Call PropBag.WriteProperty("SelectCarListIndex", cboSelectCar.ListIndex, 0)
    Call PropBag.WriteProperty("cEPValue", chkEP.Value, 0)
    Call PropBag.WriteProperty("cDPValue", chkDP.Value, 0)
    Call PropBag.WriteProperty("cBPValue", chkBP.Value, 0)
    Call PropBag.WriteProperty("cFPValue", chkFP.Value, 0)
End Sub

