Imports System.Globalization
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        Dim strConn As String
        Dim MyConn As FirebirdSql.Data.FirebirdClient.FbConnection
        Dim Cmd As FirebirdSql.Data.FirebirdClient.FbCommand
        Dim Reader As FirebirdSql.Data.FirebirdClient.FbDataReader
        Dim Trans As FirebirdSql.Data.FirebirdClient.FbTransaction

        strConn = ConfigurationManager.ConnectionStrings("FBConnectionString").ConnectionString
        MyConn = New FirebirdSql.Data.FirebirdClient.FbConnection(strConn)
        MyConn.Open()


        Dim sEmailName As String = Nothing
        Dim sEmailPassword As String = Nothing
        Dim cEmailPassword As String = Nothing

        sEmailName = inpEmailName.Text
        sEmailPassword = inpEmailPassword.Text

        cEmailPassword = Crypt.Encrypt(sEmailPassword)


        Cmd = New FirebirdSql.Data.FirebirdClient.FbCommand
        Cmd.Connection = MyConn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "CREATE_EMAIL_PASSWORD"

        Trans = MyConn.BeginTransaction(IsolationLevel.ReadCommitted)
        Cmd.Transaction = Trans

        Cmd.Parameters.Clear()

        Cmd.Parameters.Add("@I_EMAIL_NAME", FirebirdSql.Data.FirebirdClient.FbDbType.Integer).Value = sEmailName
        Cmd.Parameters.Add("@I_EMAIL_PASSWORD", FirebirdSql.Data.FirebirdClient.FbDbType.Integer).Value = cEmailPassword

        Try


            Reader = Cmd.ExecuteReader()
            If Reader.Read() Then
                Dim oID = Reader("O_EMAIL_PASSWORD_ID")

                If oID = 0 Then
                    msgMessage.Text = "Password not inserted correctly - check details"
                    Throw New Exception
                Else
                    msgMessage.Text = "Password inserted correctly"
                    Trans.Commit()

                End If
            Else
                msgMessage.Text = "Password not inserted correctly - check details"
                Throw New Exception
            End If



        Catch ex As Exception

            msgMessage.Text = "Password not inserted correctly - check details"
            Trans.Rollback()
        End Try
        Cmd.Connection.Close()
    End Sub
End Class
