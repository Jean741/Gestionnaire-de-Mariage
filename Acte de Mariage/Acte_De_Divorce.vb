Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Etat_CivilModels


Public Class Acte_De_Divorce
    Dim acte As New Acte_divorce
    'Dim listFemmes As List(Of Femme) = New List(Of Femme)
    'Dim listHommes As List(Of Homme) = New List(Of Homme)
    Dim listActeMariage As List(Of Acte_mariage) = New List(Of Acte_mariage)
    Dim listActeDivorce As List(Of Acte_divorce) = New List(Of Acte_divorce)
    Dim Niveau As Integer = 100000 'Niveau indique le statu de la personne marié ou non

    Dim position As Integer
    Public Sub remplirCBB()
        Try
            listActeMariage = Acte_mariageDAO.getInstance.GetAll()
            For Each it In listActeMariage
                CBX_CodeActeMariage.Properties.Items.Add(it.Code_Acte_Mariage)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub remplir()
        Try
            Acte_De_DivorceBindingSource.DataSource = Acte_mariageDAO.getInstance.GetAll()
        Catch ex As Exception
        End Try
    End Sub


    Public Function chercherActe_mariage(v As Integer) As Boolean
        Dim val As Boolean = False
        For Each it In Acte_mariageDAO.getInstance.GetAll()
            ' MsgBox("voici le cin " + v.CIN_Femme.ToString, MsgBoxStyle.Information)
            If it.Code_Acte_Mariage = v Then
                'MsgBox("il a trouvé le CIN", MsgBoxStyle.Information)
                val = True
            End If
        Next
        Return val
    End Function
    Public Sub modifier(Mariage As Acte_mariage)
        Acte_De_DivorceBindingSource.DataSource = Mariage
    End Sub


    Public Sub Nouveau()

        Dim Divorce As New Acte_divorce
        Divorce.Code_Acte_Divorce = Acte_divorceDAO.getInstance.GetAll.Count() + 1

        Acte_De_DivorceBindingSource.DataSource = Divorce
    End Sub

    Private Sub BTN_Nouveau_Click(sender As Object, e As EventArgs) Handles BTN_Nouveau.Click
        Nouveau()
        CBB_CIN_HommeEdit.Properties.Items.Clear()
        CBB_CIN_FemmeEdit.Properties.Items.Clear()
        remplirCBB()
        CBX_CodeActeMariage.Text = "Choisir Un CODE  :"
    End Sub

    Private Sub Acte_De_Mariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplir()
        remplirCBB()
        BTN_Premier.PerformClick()
        BTN_Nouveau.PerformClick()
    End Sub

    Private Sub BTN_Enregistrer_Click(sender As Object, e As EventArgs) Handles BTN_Enregistrer.Click
        Try
            If String.IsNullOrEmpty(CBX_CodeActeMariage.EditValue) Then
                DxErrorProvider1.SetError(CBX_CodeActeMariage, "CODE ActeMariage  obligatoire")

            ElseIf String.IsNullOrEmpty(CBX_CIN_Notaire.EditValue) Then
                DxErrorProvider1.SetError(CBX_CIN_Notaire, "CIN Notaire obligatoire")

            ElseIf DxErrorProvider1.HasErrors Then
                DxErrorProvider1 = New DXErrorProvider.DXErrorProvider()
                Return
            End If
            acte = Acte_De_DivorceBindingSource.Current()
            'Left CIN de quelqun qui s'est marié augment de 10000 qu'il soi homme ou femme
            'Homme qui se divorce
            Dim homme As New Homme
            homme = HommeDAO.getInstance.Read(acte.CIN_Homme)
            homme.CIN_Homme -= 10000
            HommeDAO.getInstance.Delete(acte.CIN_Homme)
            HommeDAO.getInstance.Save(homme)
            'Left CIN de quelqun qui s'est marié augment de 3000 qu'il soi homme ou femme
            'Femme qui se marie
            Dim Femme As New Femme
            Femme = FemmeDAO.getInstance.Read(acte.CIN_Femme)
            Femme.CIN_Femme += Niveau
            FemmeDAO.getInstance.Delete(acte.CIN_Femme)
            FemmeDAO.getInstance.Save(Femme)
            acte.CIN_Homme -= Niveau
            acte.CIN_Femme -= Niveau
            Acte_divorceDAO.getInstance.Save(acte)
            Acte_De_DivorceBindingSource.Add(acte)
            XtraMessageBox.Show("Bien enregistré", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DialogResult = DialogResult.OK
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTN_Supprimer_Click(sender As Object, e As EventArgs) Handles BTN_Supprimer.Click
        acte = Acte_De_DivorceBindingSource.Current()
        If XtraMessageBox.Show("Voulez vous vraiment  Supprimer...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                Acte_De_DivorceBindingSource.Remove(acte)
                Acte_divorceDAO.getInstance.Delete(acte)

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub BTN_Premier_Click(sender As Object, e As EventArgs) Handles BTN_Premier.Click
        Try
            listActeDivorce = Acte_divorceDAO.getInstance.GetAll()
            Acte_De_DivorceBindingSource.DataSource = listActeDivorce.First()
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Divorce n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Dernier_Click(sender As Object, e As EventArgs) Handles BTN_Dernier.Click
        Try
            listActeDivorce = Acte_divorceDAO.getInstance.GetAll()
            Acte_De_DivorceBindingSource.DataSource = listActeDivorce.Last()
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Divorce n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BTN_Suivant_Click(sender As Object, e As EventArgs) Handles BTN_Suivant.Click
        Try
            If position < listActeDivorce.Count() - 1 Then
                position += 1
            Else
                position = 0
            End If
            listActeDivorce = Acte_divorceDAO.getInstance.GetAll()

            Acte_De_DivorceBindingSource.DataSource = listActeDivorce(position)
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Divorce n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Precedent_Click(sender As Object, e As EventArgs) Handles BTN_Precedent.Click
        Try
            If position > 0 Then
                position -= 1
            Else
                position = listActeDivorce.Count() - 1
            End If
            listActeDivorce = Acte_divorceDAO.getInstance.GetAll()

            Acte_De_DivorceBindingSource.DataSource = listActeDivorce(position)
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Divorce n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Fermer_Click(sender As Object, e As EventArgs) Handles BTN_Fermer.Click
        Close()
    End Sub
End Class