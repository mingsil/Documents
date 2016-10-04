

' hwnd = Plugin.Window.Find("UnityWndClass","倩女幽魂")
' TracePrint("窗口句柄为"& hwnd)
' If hwnd <= 0 Then 
' 	MsgBox ("错误！未找到主窗口")
' 	ExitScript
' End If

FindPic 0,0,2096,1024,"Attachment:\input.bmp",0.9,intX, intY
If intX >= 0 And intY >= 0 Then 
    TracePrint ("坐标：" & intX & ";" & intY)
Else
    MsgBox "未找到图形", 4096
    EndScript
End If

MoveTo intX + 20, intY + 20
Delay(1)
//LeftDoubleClick 1
LeftClick 1
Delay (1)
SayString CStr("hello")








Event Form1.Label1.Click

End Event


Function checkTeamCount(count)
    
End Function