Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Etat_CivilModels

Public Class Acte_De_Mariage
    Dim acte As New Acte_mariage
    Dim listFemmes As List(Of Femme) = New List(Of Femme)
    Dim listHommes As List(Of Homme) = New List(Of Homme)
    Dim listActeMariage As List(Of Acte_mariage) = New List(Of Acte_mariage)
    Dim Niveau As Integer = 100000 'Niveau indique le statu de la personne marié ou non
    Dim position As Integer 'Sert a controler les different enregistrements
    Public Sub remplirCBB()
        Try

            listFemmes = FemmeDAO.getInstance.GetAll()
            For Each it In listFemmes
                If it.CIN_Femme < Niveau Then
                    CBB_CIN_FemmeEdit.Properties.Items.Add(it.CIN_Femme)
                End If
            Next
            listHommes = HommeDAO.getInstance.GetAll()
            For Each it In listHommes
                If it.CIN_Homme < Niveau Then
                    CBB_CIN_HommeEdit.Properties.Items.Add(it.CIN_Homme)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub remplir()
        Try
            Acte_De_MariageBindingSource.DataSource = Acte_mariageDAO.getInstance.GetAll()
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
        Acte_De_MariageBindingSource.DataSource = Mariage
    End Sub


    Public Sub Nouveau()

        Dim Mariage As New Acte_mariage
        Mariage.Code_Acte_Mariage = Acte_mariageDAO.getInstance.GetAll.Count() + 1

        Acte_De_MariageBindingSource.DataSource = Mariage
    End Sub

    Private Sub BTN_Nouveau_Click(sender As Object, e As EventArgs) Handles BTN_Nouveau.Click
        Nouveau()
        CBB_CIN_HommeEdit.Properties.Items.Clear()
        CBB_CIN_FemmeEdit.Properties.Items.Clear()
        remplirCBB()
        CBB_CIN_FemmeEdit.Text = "Choisir Un CIN  :"
        CBB_CIN_HommeEdit.Text = "Choisir Un CIN  :"
    End Sub

    Private Sub Acte_De_Mariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplir()
        remplirCBB()
        BTN_Premier.PerformClick()
    End Sub

    Private Sub BTN_Enregistrer_Click(sender As Object, e As EventArgs) Handles BTN_Enregistrer.Click
        Try
            If String.IsNullOrEmpty(CBB_CIN_HommeEdit.EditValue) Then
                DxErrorProvider1.SetError(CBB_CIN_HommeEdit, "CIN Homme  obligatoire")

            ElseIf String.IsNullOrEmpty(CBB_CIN_FemmeEdit.EditValue) Then
                DxErrorProvider1.SetError(CBB_CIN_FemmeEdit, "CIN Femme obligatoire")

            ElseIf String.IsNullOrEmpty(DotMariage_TextEdit.EditValue) Then
                DxErrorProvider1.SetError(DotMariage_TextEdit, "Dot  obligatoire")

            ElseIf DxErrorProvider1.HasErrors Then
                DxErrorProvider1 = New DXErrorProvider.DXErrorProvider()
                Return
            End If
            acte = Acte_De_MariageBindingSource.Current()
            'Left CIN de quelqun qui s'est marié augment de Niveau qu'il soi homme ou femme
            'Homme qui se marie
            If Not chercherActe_mariage(acte.Code_Acte_Mariage) Then


                Dim homme As New Homme
                homme = HommeDAO.getInstance.Read(acte.CIN_Homme)
                homme.CIN_Homme += Niveau
                HommeDAO.getInstance.Delete(acte.CIN_Homme)
                HommeDAO.getInstance.Save(homme)
                'Left CIN de quelqun qui s'est marié augment de Niveau qu'il soi homme ou femme
                'Femme qui se marie
                Dim Femme As New Femme
                Femme = FemmeDAO.getInstance.Read(acte.CIN_Femme)
                Femme.CIN_Femme += Niveau
                FemmeDAO.getInstance.Delete(acte.CIN_Femme)
                FemmeDAO.getInstance.Save(Femme)
                acte.CIN_Homme += Niveau
                acte.CIN_Femme += Niveau
                Acte_mariageDAO.getInstance.Save(acte)
                Acte_De_MariageBindingSource.Add(acte)
                XtraMessageBox.Show("Bien enregistré", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Vous enregistrez un CODE existant deja", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            DialogResult = DialogResult.OK
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTN_Supprimer_Click(sender As Object, e As EventArgs) Handles BTN_Supprimer.Click
        acte = Acte_De_MariageBindingSource.Current()
        If XtraMessageBox.Show("Voulez vous vraiment  Supprimer...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                Acte_De_MariageBindingSource.Remove(acte)
                Acte_mariageDAO.getInstance.Delete(acte)

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub BTN_Premier_Click(sender As Object, e As EventArgs) Handles BTN_Premier.Click
        Try
            listActeMariage = Acte_mariageDAO.getInstance.GetAll()
            Acte_De_MariageBindingSource.DataSource = listActeMariage.First()
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Mariage n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try


    End Sub

    Private Sub BTN_Dernier_Click(sender As Object, e As EventArgs) Handles BTN_Dernier.Click
        Try
            listActeMariage = Acte_mariageDAO.getInstance.GetAll()
            Acte_De_MariageBindingSource.DataSource = listActeMariage.Last()
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Mariage n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Suivant_Click(sender As Object, e As EventArgs) Handles BTN_Suivant.Click
        Try
            If position < listActeMariage.Count() - 1 Then
                position += 1
            Else
                position = 0
            End If
            listActeMariage = Acte_mariageDAO.getInstance.GetAll()

            Acte_De_MariageBindingSource.DataSource = listActeMariage(position)
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Mariage n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Precedent_Click(sender As Object, e As EventArgs) Handles BTN_Precedent.Click
        Try
            If position > 0 Then
                position -= 1
            Else
                position = listActeMariage.Count() - 1
            End If
            listActeMariage = Acte_mariageDAO.getInstance.GetAll()

            Acte_De_MariageBindingSource.DataSource = listActeMariage(position)
        Catch ex As Exception
            XtraMessageBox.Show("Aucun Acte de Mariage n'existe encore dans les données", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub BTN_Fermer_Click(sender As Object, e As EventArgs) Handles BTN_Fermer.Click
        Close()
    End Sub

    Private Sub BTN_Imprimer_Click(sender As Object, e As EventArgs) Handles BTN_Imprimer.Click

        Dim acte As Acte_mariage = Acte_De_MariageBindingSource.Current()
        Dim rpt As New XtraReportActe_Mariage(acte.Code_Acte_Mariage, acte.CIN_Femme, acte.CIN_Homme)
        rpt.ShowPreviewMarginLines = False
        rpt.ShowPrintMarginsWarning = False
        rpt.ShowPrintStatusDialog = False
        rpt.Print()
    End Sub
End Class