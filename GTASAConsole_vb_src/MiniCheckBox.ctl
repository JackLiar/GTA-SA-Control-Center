VERSION 5.00
Begin VB.UserControl MiniCheckBox 
   CanGetFocus     =   0   'False
   ClientHeight    =   120
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   120
   Picture         =   "MiniCheckBox.ctx":0000
   ScaleHeight     =   120
   ScaleWidth      =   120
   ToolboxBitmap   =   "MiniCheckBox.ctx":0102
End
Attribute VB_Name = "MiniCheckBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Public isSelected As Boolean
Attribute isSelected.VB_VarMemberFlags = "400"
Public isGreen As Boolean
Attribute isGreen.VB_VarMemberFlags = "400"
Private isMoving As Boolean
'Ereignisdeklarationen:
Event Click() 'MappingInfo=UserControl,UserControl,-1,Click
Attribute Click.VB_Description = "Tritt auf, wenn der Benutzer eine Maustaste über einem Objekt drückt und wieder losläßt."
Event DblClick() 'MappingInfo=UserControl,UserControl,-1,DblClick
Attribute DblClick.VB_Description = "Tritt auf, wenn der Benutzer eine Maustaste über einem Objekt drückt und wieder losläßt und anschließend erneut drückt und wieder losläßt."
Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseDown
Attribute MouseDown.VB_Description = "Tritt auf, wenn der Benutzer die Maustaste drückt, während ein Objekt den Fokus hat."
Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseMove
Attribute MouseMove.VB_Description = "Tritt auf, wenn der Benutzer die Maus bewegt."
Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single) 'MappingInfo=UserControl,UserControl,-1,MouseUp
Attribute MouseUp.VB_Description = "Tritt auf, wenn der Benutzer die Maustaste losläßt, während ein Objekt den Fokus hat."
'Eigenschaftsvariablen:
Dim m_Value As Integer

Private Sub UserControl_Click()
On Error Resume Next
    If isMoving Then
        isMoving = False
    Else
        isSelected = Not isSelected
        m_Value = (m_Value + 1) Mod 2
        RepaintPictures
        RaiseEvent Click
    End If
End Sub

Public Sub SetValue(ByVal New_Value As Integer)
On Error Resume Next
    isSelected = (New_Value = 1)
    m_Value = New_Value
    RepaintPictures
End Sub

Public Sub SetColor(ByVal New_isGreen As Boolean)
On Error Resume Next
    isGreen = New_isGreen
    RepaintPictures
End Sub

Private Sub RepaintPictures()
On Error Resume Next
    If isSelected Then
        UserControl.Picture = LoadResPicture("BLUE_DOWN", vbResBitmap)
    ElseIf isGreen Then
        UserControl.Picture = LoadResPicture("GREEN_UP", vbResBitmap)
    Else
        UserControl.Picture = LoadResPicture("GRAY_UP", vbResBitmap)
    End If
End Sub

Private Sub UserControl_DblClick()
    RaiseEvent DblClick
End Sub

Private Sub UserControl_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseDown(Button, Shift, X, Y)
End Sub

Private Sub UserControl_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 1 And m_Value = 1 Then
        isMoving = True
        RaiseEvent MouseMove(Button, Shift, X, Y)
    ElseIf m_Value = 1 Then
        RaiseEvent MouseMove(Button, Shift, X, Y)
    End If
    
End Sub

Private Sub UserControl_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    RaiseEvent MouseUp(Button, Shift, X, Y)
End Sub

'ACHTUNG! DIE FOLGENDEN KOMMENTIERTEN ZEILEN NICHT ENTFERNEN ODER VERÄNDERN!
'MemberInfo=7,0,2,0
Public Property Get Value() As Integer
Attribute Value.VB_MemberFlags = "400"
    Value = m_Value
End Property

Public Property Let Value(ByVal New_Value As Integer)
    isSelected = (New_Value = 1)
    m_Value = New_Value
    RepaintPictures
End Property

