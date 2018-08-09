Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Etat_CivilModels


Public Class Fiche_des_Hommes

    Dim listHommes As List(Of Homme) = New List(Of Homme)
    Public homme As New Homme
    Dim position As Integer
    Public Sub remplir()
        Try
            HommeBindingSource.DataSource = HommeDAO.getInstance.GetAll()
        Catch ex As Exception

        End Try
    End Sub
    Public Function chercherCinHommes(v As Integer) As Boolean
        Dim val As Boolean = False
        For Each it In HommeDAO.getInstance.GetAll()
            ' MsgBox("voici le cin " + v.CIN_Femme.ToString, MsgBoxStyle.Information)
            If it.CIN_Homme = v Then
                'MsgBox("il a trouvé le CIN", MsgBoxStyle.Information)
                val = True
            End If
        Next
        Return val
    End Function
    Public Sub modifier(h As Homme)
        HommeBindingSource.DataSource = h
    End Sub
    Public Sub Nouveau()
        Dim h As New Homme
        HommeBindingSource.DataSource = h
    End Sub

    Private Sub Fiche_des_Hommes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nouveau()
        Me.Prenom_HommeSpinEdit.Text = ""
        BTN_Premier.PerformClick()
    End Sub

    Private Sub BTN_Enregistrer_Click(sender As Object, e As EventArgs) Handles BTN_Enregistrer.Click
        Try
            If String.IsNullOrEmpty(Nom_HommeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Nom_HommeTextEdit, "Nom  obligatoire")

            ElseIf String.IsNullOrEmpty(Prenom_HommeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Prenom_HommeTextEdit, "Prenom obligatoire")

            ElseIf String.IsNullOrEmpty(Adresse_HommeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Adresse_HommeTextEdit, "Adresse  obligatoire")

            ElseIf DxErrorProvider1.HasErrors Then
                DxErrorProvider1 = New DXErrorProvider.DXErrorProvider()
                Return
            End If


            homme = HommeBindingSource.Current()
            If Not chercherCinHommes(homme.CIN_Homme) Then

                HommeDAO.getInstance.Save(homme)
                HommeBindingSource.Add(homme)
                XtraMessageBox.Show("Bien enregistré", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                XtraMessageBox.Show("Vous enregistrez un CIN existant deja", "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            DialogResult = DialogResult.OK
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BTN_Nouveau_Click(sender As Object, e As EventArgs) Handles BTN_Nouveau.Click
        Nouveau()
        Me.TXB_Chercher.Text = ""
    End Sub

    Private Sub BTN_Modifier_Click(sender As Object, e As EventArgs) Handles BTN_Modifier.Click
        Me.Text = "Modifier l'etat d'une Femme"
        homme = HommeBindingSource.Current
        modifier(HommeBindingSource.Current)
        If XtraMessageBox.Show("Voulez vous vraiment  Modifier...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            HommeDAO.getInstance.Update(homme)
        End If
    End Sub

    Private Sub BTN_Annuler_Click(sender As Object, e As EventArgs) Handles BTN_Annuler.Click
        HommeBindingSource.CancelEdit()
        BTN_Suivant.PerformClick()
        BTN_Precedent.PerformClick()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Close()
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Dim h As Homme
        Dim cin As Integer
        If Not Integer.TryParse(TXB_Chercher.Text(), cin) Then
            TXB_Chercher.Text = ""
            MsgBox("Une erreur Veuillez entrer un entier(CIN)", MessageBoxIcon.Exclamation)
        End If
        Try
            If chercherCinHommes(cin) Then
                h = HommeDAO.getInstance.Read(cin)
                HommeBindingSource.DataSource = h
            Else
                MsgBox("Vous  avez entrer un cin inexistant", MsgBoxStyle.OkCancel)
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTN_Supprimer_Click(sender As Object, e As EventArgs) Handles BTN_Supprimer.Click
        Me.Text = "Suprimer l'etat d'un Homme"
        homme = HommeBindingSource.Current
        If XtraMessageBox.Show("Voulez vous vraiment  Supprimer...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                HommeBindingSource.Remove(homme)
                HommeDAO.getInstance.Delete(homme)
                Me.TXB_Chercher.Update()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        remplir()
    End Sub

    Private Sub BTN_Premier_Click(sender As Object, e As EventArgs) Handles BTN_Premier.Click
        listHommes = HommeDAO.getInstance.GetAll()
        HommeBindingSource.DataSource = listHommes.First()

    End Sub

    Private Sub BTN_Dernier_Click(sender As Object, e As EventArgs) Handles BTN_Dernier.Click
        listHommes = HommeDAO.getInstance.GetAll()
        HommeBindingSource.DataSource = listHommes.Last()
    End Sub

    Private Sub BTN_Suivant_Click(sender As Object, e As EventArgs) Handles BTN_Suivant.Click
        If position < listHommes.Count() - 1 Then
            position += 1
        Else
            position = 0
        End If
        listHommes = HommeDAO.getInstance.GetAll()

        HommeBindingSource.DataSource = listHommes(position)
    End Sub

    Private Sub BTN_Precedent_Click(sender As Object, e As EventArgs) Handles BTN_Precedent.Click
        If position > 0 Then
            position -= 1
        Else
            position = listHommes.Count() - 1
        End If
        listHommes = HommeDAO.getInstance.GetAll()

        HommeBindingSource.DataSource = listHommes(position)
    End Sub

    Private Sub BTN_Imprimer_Click(sender As Object, e As EventArgs) Handles BTN_Imprimer.Click
        Try
            Dim h As Homme = HommeBindingSource.Current()
            Dim rpt As New XtraReportFicheHommes(h.CIN_Homme)
            rpt.ShowPreviewMarginLines = False
            rpt.ShowPrintMarginsWarning = False
            rpt.ShowPrintStatusDialog = False
            rpt.Print()
        Catch ex As Exception

        End Try

    End Sub

End Class