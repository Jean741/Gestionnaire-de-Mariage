#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 13/07/2018
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Partial Public Class Homme
Inherits LUNA.LunaBaseClass
'******IMPORTANT: Write your code in the Class object that use this Partial Class.
'******So you can replace DAOClass and EntityClass without lost your code

Public Sub New()

End Sub

#Region "Database Field Map"

Private _CIN_Homme as integer = 0 

<XmlElementAttribute("CIN_Homme")> _
Public property CIN_Homme() as integer
Get
	Return _CIN_Homme
End Get
Set (byval value as integer)
	_CIN_Homme= value
End Set
End property 

Private _Nom_Homme as string = "" 

<XmlElementAttribute("Nom_Homme")> _
Public property Nom_Homme() as string
Get
	Return _Nom_Homme
End Get
Set (byval value as string)
	_Nom_Homme= value
End Set
End property 

Private _Prenom_Homme as string = "" 

<XmlElementAttribute("Prenom_Homme")> _
Public property Prenom_Homme() as string
Get
	Return _Prenom_Homme
End Get
Set (byval value as string)
	_Prenom_Homme= value
End Set
End property 

Private _Date_Naissance as DateTime = Nothing 

<XmlElementAttribute("Date_Naissance")> _
Public property Date_Naissance() as DateTime
Get
	Return _Date_Naissance
End Get
Set (byval value as DateTime)
	_Date_Naissance= value
End Set
End property 

Private _Adresse_Homme as string = "" 

<XmlElementAttribute("Adresse_Homme")> _
Public property Adresse_Homme() as string
Get
	Return _Adresse_Homme
End Get
Set (byval value as string)
	_Adresse_Homme= value
End Set
End property 
#End Region

#Region "Embedded Class"

#End Region

End Class 

Public Class HommeDAO
Inherits LUNA.LunaBaseClassDAO(Of Homme)

Public Sub New()
	MyBase.New()
End Sub

Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
	MyBase.New(Connection)
End Sub

Public Sub New(ByVal ConnectionString As string)
	MyBase.New(ConnectionString)
End Sub

 Private Shared Utilisateur As New HommeDAO
  Public Shared Function getInstance() As HommeDAO
	If IsNothing(Utilisateur) Then
	  Return New HommeDAO
Else

Return Utilisateur

 End If

 End Function

    Public Overrides Function Read(Id As Integer) As Homme
        Dim cls As New Homme

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Homme where CIN_Homme = " & Ap(Id)
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.CIN_Homme = myReader("CIN_Homme")
                If Not myReader("Nom_Homme") Is DBNull.Value Then
                    cls.Nom_Homme = myReader("Nom_Homme")
                End If
                If Not myReader("Prenom_Homme") Is DBNull.Value Then
                    cls.Prenom_Homme = myReader("Prenom_Homme")
                End If
                If Not myReader("Date_Naissance") Is DBNull.Value Then
                    cls.Date_Naissance = myReader("Date_Naissance")
                End If
                If Not myReader("Adresse_Homme") Is DBNull.Value Then
                    cls.Adresse_Homme = myReader("Adresse_Homme")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(byRef cls as Homme) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
Dim myTransaction As SqlTransaction
	Try
		Dim sql As String
		DbCommand.Connection = _cn
		myTransaction = _cn.BeginTransaction
		DbCommand.Transaction = myTransaction
			sql = "set language french;INSERT INTO Homme("
			sql &= "CIN_Homme,"
			sql &= "Nom_Homme,"
			sql &= "Prenom_Homme,"
			sql &= "Date_Naissance,"
			sql &= "Adresse_Homme"
				sql &= ") VALUES ("
	sql &= ap(cls.CIN_Homme) & ","
	sql &= ap(cls.Nom_Homme) & ","
	sql &= ap(cls.Prenom_Homme) & ","
            sql &= Ap(cls.Date_Naissance.ToShortDateString()) & ","
            sql &= ap(cls.Adresse_Homme)
				sql &= ")"
		DbCommand.CommandText = sql
		DbCommand.ExecuteNonQuery()

		myTransaction.Commit()
		DbCommand.Dispose()

	Catch ex As Exception
		myTransaction.RollBack()
		ManageError(ex)
	End Try
Return Ris
End Function


Public  Function Update(byRef cls as Homme) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
Dim myTransaction As SqlTransaction
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            myTransaction = _cn.BeginTransaction
            DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Homme SET "
            sql &= "Nom_Homme = " & ap(cls.Nom_Homme) & ","
            sql &= "Prenom_Homme = " & ap(cls.Prenom_Homme) & ","
            sql &= "Date_Naissance = " & Ap(cls.Date_Naissance.ToShortDateString()) & ","
            sql &= "Adresse_Homme = " & ap(cls.Adresse_Homme)
            sql &= " WHERE CIN_Homme= " & Ap(cls.CIN_Homme)
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            myTransaction.Commit()
            DbCommand.Dispose()

        Catch ex As Exception
#Disable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
            myTransaction.RollBack()
#Enable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
            ManageError(ex)
        End Try
Return Ris
End Function


Private Sub DestroyPermanently(Id as string) 
Try

Dim UpdateCommand As SqlCommand = New SqlCommand()
UpdateCommand.Connection = _cn

'******IMPORTANT: You can use this commented instruction to make a logical delete .
'******Replace DELETED Field with your logic deleted field name.
'Dim Sql As String = "UPDATE Homme SET DELETED=True "
Dim Sql As String = "set language french;DELETE FROM Homme"
Sql &= " Where CIN_Homme = " & Ap(Id) 

UpdateCommand.CommandText = Sql
UpdateCommand.ExecuteNonQuery()
UpdateCommand.Dispose()
Catch ex As Exception
	ManageError(ex)
End Try
End Sub

    Public Overrides Sub Delete(Id As Integer)

        DestroyPermanently(Id)

    End Sub

    Public Overrides Sub Delete(byref obj as Homme, Optional ByRef ListaObj as List (of Homme) = Nothing)

DestroyPermanently (obj.CIN_Homme)
If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

End Sub

Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Homme)
Return FindReal(OrderBy, Parameter)
End Function

Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Homme)
Return FindReal("", Parameter)
End Function

Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Homme)
Dim Ls As New List(Of Homme)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;  SELECT CIN_Homme,Nom_Homme,Prenom_Homme,Date_Naissance,Adresse_Homme from Homme"
For Each Par As LUNA.LunaSearchParameter In Parameter
	If Not Par Is Nothing Then
		If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		Sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
	End if
Next

If OrderBy.Length Then Sql &= " ORDER BY " & OrderBy

myCommand.CommandText = sql
Dim myReader As SqlDataReader = myCommand.ExecuteReader()
while myReader.Read
	Dim classe as new Homme
	if not myReader("CIN_Homme") is DBNull.Value then classe.CIN_Homme = myReader("CIN_Homme")
	if not myReader("Nom_Homme") is DBNull.Value then classe.Nom_Homme = myReader("Nom_Homme")
	if not myReader("Prenom_Homme") is DBNull.Value then classe.Prenom_Homme = myReader("Prenom_Homme")
	if not myReader("Date_Naissance") is DBNull.Value then classe.Date_Naissance = myReader("Date_Naissance")
	if not myReader("Adresse_Homme") is DBNull.Value then classe.Adresse_Homme = myReader("Adresse_Homme")
	Ls.Add(classe)
end while
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Homme)
Dim Ls As New List(Of Homme)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;SELECT CIN_Homme,Nom_Homme,Prenom_Homme,Date_Naissance,Adresse_Homme from Homme"
If OrderByField.Length Then
	Sql &= " ORDER BY " & OrderByField
End If

myCommand.CommandText = sql
Dim myReader As SqlDataReader = myCommand.ExecuteReader()
If AddEmptyItem Then Ls.Add(New  Homme() With {.CIN_Homme = 0 ,.Nom_Homme = "" ,.Prenom_Homme = "" ,.Date_Naissance = Nothing ,.Adresse_Homme = "" })
while myReader.Read
	Dim classe as new Homme
	if not myReader("CIN_Homme") is DBNull.Value then classe.CIN_Homme = myReader("CIN_Homme")
	if not myReader("Nom_Homme") is DBNull.Value then classe.Nom_Homme = myReader("Nom_Homme")
	if not myReader("Prenom_Homme") is DBNull.Value then classe.Prenom_Homme = myReader("Prenom_Homme")
	if not myReader("Date_Naissance") is DBNull.Value then classe.Date_Naissance = myReader("Date_Naissance")
	if not myReader("Adresse_Homme") is DBNull.Value then classe.Adresse_Homme = myReader("Adresse_Homme")
	Ls.Add(classe)
end while
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function
End Class


