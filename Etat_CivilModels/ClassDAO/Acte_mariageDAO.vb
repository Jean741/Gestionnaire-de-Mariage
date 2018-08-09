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

Partial Public Class Acte_mariage
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _Code_Acte_Mariage As Integer = 0

    <XmlElementAttribute("Code_Acte_Mariage")>
    Public Property Code_Acte_Mariage() As Integer
        Get
            Return _Code_Acte_Mariage
        End Get
        Set(ByVal value As Integer)
            _Code_Acte_Mariage = value
        End Set
    End Property

    Private _CIN_Homme As Integer = 0

    <XmlElementAttribute("CIN_Homme")>
    Public Property CIN_Homme() As Integer
        Get
            Return _CIN_Homme
        End Get
        Set(ByVal value As Integer)
            _CIN_Homme = value
        End Set
    End Property

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

    Private _Date_Mariage As DateTime = Nothing

    <XmlElementAttribute("Date_Mariage")>
    Public Property Date_Mariage() As DateTime
        Get
            Return _Date_Mariage
        End Get
        Set(ByVal value As DateTime)
            _Date_Mariage = value
        End Set
    End Property

    Private _CIN_Notaire As Integer = 0

    <XmlElementAttribute("CIN_Notaire")>
    Public Property CIN_Notaire() As Integer
        Get
            Return _CIN_Notaire
        End Get
        Set(ByVal value As Integer)
            _CIN_Notaire = value
        End Set
    End Property

    Private _Dot As String = ""

    <XmlElementAttribute("Dot")>
    Public Property Dot() As String
        Get
            Return _Dot
        End Get
        Set(ByVal value As String)
            _Dot = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Public Class Acte_mariageDAO
    Inherits LUNA.LunaBaseClassDAO(Of Acte_mariage)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New Acte_mariageDAO
    Public Shared Function getInstance() As Acte_mariageDAO
        If IsNothing(Utilisateur) Then
            Return New Acte_mariageDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As Integer) As Acte_mariage
        Dim cls As New Acte_mariage

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Acte_mariage where Code_Acte_Mariage = " & Ap(Id)
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.Code_Acte_Mariage = myReader("Code_Acte_Mariage")
                cls.CIN_Homme = myReader("CIN_Homme")
                cls.CIN_Femme = myReader("CIN_Femme")
                cls.Date_Mariage = myReader("Date_Mariage")
                cls.CIN_Notaire = myReader("CIN_Notaire")
                cls.Dot = myReader("Dot")
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Acte_mariage) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Dim myTransaction As SqlTransaction
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            myTransaction = _cn.BeginTransaction
            DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Acte_mariage("
            sql &= "Code_Acte_Mariage,"
            sql &= "CIN_Homme,"
            sql &= "CIN_Femme,"
            sql &= "Date_Mariage,"
            sql &= "CIN_Notaire,"
            sql &= "Dot"
            sql &= ") VALUES ("
            sql &= Ap(cls.Code_Acte_Mariage) & ","
            sql &= Ap(cls.CIN_Homme) & ","
            sql &= Ap(cls.CIN_Femme) & ","
            sql &= Ap(cls.Date_Mariage.ToShortDateString()) & ","
            sql &= Ap(cls.CIN_Notaire) & ","
            sql &= Ap(cls.Dot)
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


    Public Function Update(ByRef cls As Acte_mariage) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Dim myTransaction As SqlTransaction
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            myTransaction = _cn.BeginTransaction
            DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Acte_mariage SET "
            sql &= "CIN_Homme = " & Ap(cls.CIN_Homme) & ","
            sql &= "CIN_Femme = " & Ap(cls.CIN_Femme) & ","
            sql &= "Date_Mariage = " & Ap(cls.Date_Mariage.ToShortDateString()) & ","
            sql &= "CIN_Notaire = " & Ap(cls.CIN_Notaire) & ","
            sql &= "Dot = " & Ap(cls.Dot)
            sql &= " WHERE Code_Acte_Mariage= " & Ap(cls.Code_Acte_Mariage)
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
            'Dim Sql As String = "UPDATE Acte_mariage SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Acte_mariage"
            Sql &= " Where Code_Acte_Mariage = " & Ap(Id)

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

    Public Overrides Sub Delete(ByRef obj As Acte_mariage, Optional ByRef ListaObj As List(Of Acte_mariage) = Nothing)

        DestroyPermanently(obj.Code_Acte_Mariage)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Acte_mariage)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Acte_mariage)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Acte_mariage)
        Dim Ls As New List(Of Acte_mariage)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT Code_Acte_Mariage,CIN_Homme,CIN_Femme,Date_Mariage,CIN_Notaire,Dot from Acte_mariage"
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
                Dim classe As New Acte_mariage
                If Not myReader("Code_Acte_Mariage") Is DBNull.Value Then classe.Code_Acte_Mariage = myReader("Code_Acte_Mariage")
                If Not myReader("CIN_Homme") Is DBNull.Value Then classe.CIN_Homme = myReader("CIN_Homme")
                If Not myReader("CIN_Femme") Is DBNull.Value Then classe.CIN_Femme = myReader("CIN_Femme")
                If Not myReader("Date_Mariage") Is DBNull.Value Then classe.Date_Mariage = myReader("Date_Mariage")
                If Not myReader("CIN_Notaire") Is DBNull.Value Then classe.CIN_Notaire = myReader("CIN_Notaire")
                If Not myReader("Dot") Is DBNull.Value Then classe.Dot = myReader("Dot")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Acte_mariage)
        Dim Ls As New List(Of Acte_mariage)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT Code_Acte_Mariage,CIN_Homme,CIN_Femme,Date_Mariage,CIN_Notaire,Dot from Acte_mariage"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Acte_mariage() With {.Code_Acte_Mariage = 0, .CIN_Homme = 0, .CIN_Femme = 0, .Date_Mariage = Nothing, .CIN_Notaire = 0, .Dot = ""})
            While myReader.Read
                Dim classe As New Acte_mariage
                If Not myReader("Code_Acte_Mariage") Is DBNull.Value Then classe.Code_Acte_Mariage = myReader("Code_Acte_Mariage")
                If Not myReader("CIN_Homme") Is DBNull.Value Then classe.CIN_Homme = myReader("CIN_Homme")
                If Not myReader("CIN_Femme") Is DBNull.Value Then classe.CIN_Femme = myReader("CIN_Femme")
                If Not myReader("Date_Mariage") Is DBNull.Value Then classe.Date_Mariage = myReader("Date_Mariage")
                If Not myReader("CIN_Notaire") Is DBNull.Value Then classe.CIN_Notaire = myReader("CIN_Notaire")
                If Not myReader("Dot") Is DBNull.Value Then classe.Dot = myReader("Dot")
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


