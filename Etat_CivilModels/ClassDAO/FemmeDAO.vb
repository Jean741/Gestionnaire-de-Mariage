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

Partial Public Class Femme
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code
    Private Situation As Boolean
    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _CIN_Femme As Integer = 0

    <XmlElementAttribute("CIN_Femme")>
    Public Property CIN_Femme() As Integer
        Get
            Return _CIN_Femme
        End Get
        Set(ByVal value As Integer)
            _CIN_Femme = value
        End Set
    End Property

    Private _Nom_Femme As String = ""

    <XmlElementAttribute("Nom_Femme")>
    Public Property Nom_Femme() As String
        Get
            Return _Nom_Femme
        End Get
        Set(ByVal value As String)
            _Nom_Femme = value
        End Set
    End Property

    Private _Prenom_Femme As String = ""

    <XmlElementAttribute("Prenom_Femme")>
    Public Property Prenom_Femme() As String
        Get
            Return _Prenom_Femme
        End Get
        Set(ByVal value As String)
            _Prenom_Femme = value
        End Set
    End Property

    Private _Date_Naissance As DateTime = Nothing

    <XmlElementAttribute("Date_Naissance")>
    Public Property Date_Naissance() As DateTime
        Get
            Return _Date_Naissance
        End Get
        Set(ByVal value As DateTime)
            _Date_Naissance = value
        End Set
    End Property

    Private _Adresse_Femme As String = ""

    <XmlElementAttribute("Adresse_Femme")>
    Public Property Adresse_Femme() As String
        Get
            Return _Adresse_Femme
        End Get
        Set(ByVal value As String)
            _Adresse_Femme = value
        End Set
    End Property

    Public Property Situation1 As Boolean
        Get
            Return Situation2
        End Get
        Set(value As Boolean)
            Situation2 = value
        End Set
    End Property

    Public Property Situation2 As Boolean
        Get
            Return Situation
        End Get
        Set(value As Boolean)
            Situation = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Public Class FemmeDAO
    Inherits LUNA.LunaBaseClassDAO(Of Femme)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New FemmeDAO
    Public Shared Function getInstance() As FemmeDAO
        If IsNothing(Utilisateur) Then
            Return New FemmeDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As Integer) As Femme
        Dim cls As New Femme

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Femme where CIN_Femme = " & Ap(Id)
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.CIN_Femme = myReader("CIN_Femme")
                If Not myReader("Nom_Femme") Is DBNull.Value Then
                    cls.Nom_Femme = myReader("Nom_Femme")
                End If
                If Not myReader("Prenom_Femme") Is DBNull.Value Then
                    cls.Prenom_Femme = myReader("Prenom_Femme")
                End If
                If Not myReader("Date_Naissance") Is DBNull.Value Then
                    cls.Date_Naissance = myReader("Date_Naissance")
                End If
                If Not myReader("Adresse_Femme") Is DBNull.Value Then
                    cls.Adresse_Femme = myReader("Adresse_Femme")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Femme) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Dim myTransaction As SqlTransaction
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            myTransaction = _cn.BeginTransaction
            DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Femme("
            sql &= "CIN_Femme,"
            sql &= "Nom_Femme,"
            sql &= "Prenom_Femme,"
            sql &= "Date_Naissance,"
            sql &= "Adresse_Femme"
            sql &= ") VALUES ("
            sql &= Ap(cls.CIN_Femme) & ","
            sql &= Ap(cls.Nom_Femme) & ","
            sql &= Ap(cls.Prenom_Femme) & ","
            sql &= Ap(cls.Date_Naissance.ToShortDateString()) & ","
            sql &= Ap(cls.Adresse_Femme)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            myTransaction.Commit()
            DbCommand.Dispose()

        Catch ex As Exception
            myTransaction.Rollback()
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Femme) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Dim myTransaction As SqlTransaction
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            myTransaction = _cn.BeginTransaction
            DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Femme SET "
            sql &= "Nom_Femme = " & Ap(cls.Nom_Femme) & ","
            sql &= "Prenom_Femme = " & Ap(cls.Prenom_Femme) & ","
            sql &= "Date_Naissance = " & Ap(cls.Date_Naissance.ToShortDateString()) & ","
            sql &= "Adresse_Femme = " & Ap(cls.Adresse_Femme)
            sql &= " WHERE CIN_Femme= " & Ap(cls.CIN_Femme)
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            myTransaction.Commit()
            DbCommand.Dispose()

        Catch ex As Exception
            myTransaction.Rollback()
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Private Sub DestroyPermanently(Id As String)
        Try

            Dim UpdateCommand As SqlCommand = New SqlCommand()
            UpdateCommand.Connection = _cn

            '******IMPORTANT: You can use this commented instruction to make a logical delete .
            '******Replace DELETED Field with your logic deleted field name.
            'Dim Sql As String = "UPDATE Femme SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Femme"
            Sql &= " Where CIN_Femme = " & Ap(Id)

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

    Public Overrides Sub Delete(ByRef obj As Femme, Optional ByRef ListaObj As List(Of Femme) = Nothing)

        DestroyPermanently(obj.CIN_Femme)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Femme)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Femme)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Femme)
        Dim Ls As New List(Of Femme)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT CIN_Femme,Nom_Femme,Prenom_Femme,Date_Naissance,Adresse_Femme from Femme"
            For Each Par As LUNA.LunaSearchParameter In Parameter
                If Not Par Is Nothing Then
                    If sql.IndexOf("WHERE") = -1 Then sql &= " WHERE " Else sql &= " " & Par.LogicOperatorStr & " "
                    sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
                End If
            Next

            If OrderBy.Length Then sql &= " ORDER BY " & OrderBy

            myCommand.CommandText = sql
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read
                Dim classe As New Femme
                If Not myReader("CIN_Femme") Is DBNull.Value Then classe.CIN_Femme = myReader("CIN_Femme")
                If Not myReader("Nom_Femme") Is DBNull.Value Then classe.Nom_Femme = myReader("Nom_Femme")
                If Not myReader("Prenom_Femme") Is DBNull.Value Then classe.Prenom_Femme = myReader("Prenom_Femme")
                If Not myReader("Date_Naissance") Is DBNull.Value Then classe.Date_Naissance = myReader("Date_Naissance")
                If Not myReader("Adresse_Femme") Is DBNull.Value Then classe.Adresse_Femme = myReader("Adresse_Femme")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Femme)
        Dim Ls As New List(Of Femme)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT CIN_Femme,Nom_Femme,Prenom_Femme,Date_Naissance,Adresse_Femme from Femme"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Femme() With {.CIN_Femme = 0, .Nom_Femme = "", .Prenom_Femme = "", .Date_Naissance = Nothing, .Adresse_Femme = ""})
            While myReader.Read
                Dim classe As New Femme
                If Not myReader("CIN_Femme") Is DBNull.Value Then classe.CIN_Femme = myReader("CIN_Femme")
                If Not myReader("Nom_Femme") Is DBNull.Value Then classe.Nom_Femme = myReader("Nom_Femme")
                If Not myReader("Prenom_Femme") Is DBNull.Value Then classe.Prenom_Femme = myReader("Prenom_Femme")
                If Not myReader("Date_Naissance") Is DBNull.Value Then classe.Date_Naissance = myReader("Date_Naissance")
                If Not myReader("Adresse_Femme") Is DBNull.Value Then classe.Adresse_Femme = myReader("Adresse_Femme")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class


