Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports Tulpep.NotificationWindow

Public Class CommonServices
    Public Shared inEmpId = 0
    Public Shared UserRole
    Public Shared UserName
    Public Shared UserEmail
    Public Shared con As New SqlConnection("Data Source=DESKTOP-V8UBCG7\SQLEXPRESS;Initial Catalog=Winforms_VB_DUC_Company1a;Integrated Security=True")
    Public Shared Sub ShowPopUpNoti(s As String)
        Dim popupNotifier = New PopupNotifier()
        popupNotifier.Image = My.Resources.information64
        popupNotifier.TitleText = "Message"
        popupNotifier.ContentText = s
        popupNotifier.Popup()
    End Sub
    Public Shared Function GetHashedPassword(input As String) As String
        Dim md5 = MD5Cng.Create()
        'Convert the input string to a byte array And compute the hash
        Dim data = md5.ComputeHash(Encoding.UTF8.GetBytes(input))
        'Create a New stringbuilder to collect the bytes And create a string
        Dim StringBuilder = New StringBuilder()
        For i = 1 To data.Length - 1
            StringBuilder.Append(data(i).ToString("x2"))
        Next
        Return StringBuilder.ToString()
    End Function
End Class
