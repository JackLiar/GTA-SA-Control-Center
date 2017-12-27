Attribute VB_Name = "mdlRegistry"
Option Explicit
'hKey Constants:
Public Const HKEY_LOCAL_MACHINE = &H80000002
Public Const REG_SZ = 1                         ' Unicode nul terminated string
Public Const ERROR_SUCCESS = 0&
Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long
Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" (ByVal hKey As Long, ByVal lpSubKey As String, ByVal ulOptions As Long, ByVal samDesired As Long, phkResult As Long) As Long
    Global ulOptions As Long
    Global samDesired As Long
Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As Any, lpcbData As Long) As Long         ' Note that if you declare the lpData parameter as String, you must pass it By Value.
    Global lpReserved As Long
    Global lpType As Long
    Global lpcbData As Long
    Global hKey As Long
'API for user and message GUID's
Private Declare Function CoCreateGuid Lib "ole32" (id As Any) As Long
'API for TickCount, instead of Rnd Function to generate a unique number adding to datetime
Declare Function GetTickCount Lib "kernel32" () As Long

Function CreateGUID() As String
On Error Resume Next 'Creates GUID for users and alarms for ows / e-mail. (ADS alarms have already one guid per alarm)
    Static id(0 To 15) As Byte      'receives new guid in byte array. return from API
    Static lngArrCounter As Long    'allg. counter
    '[re]initialise array:
    Erase id
    If CoCreateGuid(id(0)) = 0 Then 'if we have successfully generated guid,
        For lngArrCounter = 0 To 15 'dump in unicode hex string
            CreateGUID = CreateGUID + IIf(id(lngArrCounter) < 16, "0", "") + Hex$(id(lngArrCounter))
        Next lngArrCounter
    Else 'if not, use system datetime and random long for mimicing a GUID
        CreateGUID = Format(Now, "yyyymmddhhnnss") & Right$("000000" & CStr(GetTickCount), 6) & Format(Now, "yyyymmddhhnnss") & Right$("000000" & CStr(GetTickCount), 6) & Format(Now, "yyyymmddhhnnss") & Right$("000000" & CStr(GetTickCount), 6)
    End If
    'convert string GUID to readable format:
    CreateGUID = UCase$(Left$(CreateGUID, 8) + "-" + Mid$(CreateGUID, 9, 4) + "-" + Mid$(CreateGUID, 13, 4) + "-" + Mid$(CreateGUID, 17, 4) + "-" + Right$(CreateGUID, 12))
End Function

Function GetSettingString(ByVal strValue As String) As String
On Error Resume Next
    Static strPath As String
    Static strBuffer As String
    Dim hCurKey As Long
    Dim lValueType As Long
    Dim lDataBufferSize As Long
    Dim intZeroPos As Integer
    Dim lRegResult As Long
    
    hKey = HKEY_LOCAL_MACHINE
    strPath = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\D:\GTASAcdPC\GTASA.exe"
    
    GetSettingString = ""
    
    ' Open the key and get length of string
    lRegResult = RegOpenKey(hKey, strPath, hCurKey)
    lRegResult = RegQueryValueEx(hCurKey, strValue, 0&, lValueType, ByVal 0&, lDataBufferSize)
    
    If lRegResult = ERROR_SUCCESS Then
    
      If lValueType = REG_SZ Then
        ' initialise string buffer and retrieve string
        strBuffer = String(lDataBufferSize, " ")
        lRegResult = RegQueryValueEx(hCurKey, strValue, 0&, 0&, ByVal strBuffer, lDataBufferSize)
        ' format string
        intZeroPos = InStr(strBuffer, Chr$(0))
        If intZeroPos > 0 Then
          GetSettingString = Left$(strBuffer, intZeroPos - 1)
        Else
          GetSettingString = strBuffer
        End If
      End If
    Else
      ' there is a problem
    End If
    lRegResult = RegCloseKey(hCurKey)
    Err.Clear

End Function

