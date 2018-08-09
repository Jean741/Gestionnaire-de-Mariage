Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports Etat_CivilModels


Public Class Fiche_Des_Femmes
    Dim listFemmes As List(Of Femme) = New List(Of Femme)
    Public homme As New Femme
    Dim position As Integer
    Public Sub remplir()
        Try
            FemmeBindingSource.DataSource = FemmeDAO.getInstance.GetAll()
        Catch ex As Exception

        End Try
    End Sub

    Public Function chercherCinFemmes(v As Integer) As Boolean
        Dim val As Boolean = False
        For Each it In FemmeDAO.getInstance.GetAll()
            ' MsgBox("voici le cin " + v.CIN_Femme.ToString, MsgBoxStyle.Information)
            If it.CIN_Femme = v Then
                'MsgBox("il a trouvé le CIN", MsgBoxStyle.Information)
                val = True
            End If
        Next
        Return val
    End Function
    Public Sub modifier(f As Femme)
        FemmeBindingSource.DataSource = f
    End Sub
    Public Sub Nouveau()
        Dim f As New Femme
        FemmeBindingSource.DataSource = f
    End Sub

    Private Sub Fiche_Des_Femmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nouveau()
        Me.Prenom_FemmeSpinEdit.Text = ""
        BTN_Premier.PerformClick()
    End Sub

    Private Sub BTN_Enregistrer_Click(sender As Object, e As EventArgs) Handles BTN_Enregistrer.Click
        Try
            If String.IsNullOrEmpty(Nom_FemmeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Nom_FemmeTextEdit, "Nom  obligatoire")

            ElseIf String.IsNullOrEmpty(Prenom_FemmeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Prenom_FemmeTextEdit, "Prenom obligatoire")

            ElseIf String.IsNullOrEmpty(Adresse_FemmeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Adresse_FemmeTextEdit, "Adresse  obligatoire")

            ElseIf DxErrorProvider1.HasErrors Then
                DxErrorProvider1 = New DXErrorProvider.DXErrorProvider()
                Return
            End If


            homme = FemmeBindingSource.Current()
            If Not chercherCinFemmes(homme.CIN_Femme) Then

                FemmeDAO.getInstance.Save(homme)
                FemmeBindingSource.Add(homme)
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
        homme = FemmeBindingSource.Current
        modifier(FemmeBindingSource.Current)
        If XtraMessageBox.Show("Voulez vous vraiment  Modifier...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            FemmeDAO.getInstance.Update(homme)
        End If

    End Sub

    Private Sub BTN_Annuler_Click(sender As Object, e As EventArgs) Handles BTN_Annuler.Click
        FemmeBindingSource.CancelEdit()
        BTN_Suivant.PerformClick()
        BTN_Precedent.PerformClick()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Close()
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Dim f As Femme
        Dim cin As Integer
        If Not Integer.TryParse(TXB_Chercher.Text(), cin) Then
            TXB_Chercher.Text = ""
            MsgBox("Une erreur Veuillez entrer un entier(CIN)", MessageBoxIcon.Exclamation)
        End If
        Try
            If chercherCinFemmes(cin) Then
                f = FemmeDAO.getInstance.Read(cin)
                FemmeBindingSource.DataSource = f
            Else
                MsgBox("Vous  avez entrer un cin inexistant", MsgBoxStyle.OkCancel)
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BTN_Supprimer_Click(sender As Object, e As EventArgs) Handles BTN_Supprimer.Click
        Me.Text = "Suprimer l'etat d'une Femme"
        homme = FemmeBindingSource.Current
        If XtraMessageBox.Show("Voulez vous vraiment  Supprimer...?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                FemmeBindingSource.Remove(homme)
                FemmeDAO.getInstance.Delete(homme)
                Me.TXB_Chercher.Update()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "AS-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub BTN_Premier_Click(sender As Object, e As EventArgs) Handles BTN_Premier.Click
        listFemmes = FemmeDAO.getInstance.GetAll()
        FemmeBindingSource.DataSource = listFemmes.First()

    End Sub

    Private Sub BTN_Dernier_Click(sender As Object, e As EventArgs) Handles BTN_Dernier.Click
        listFemmes = FemmeDAO.getInstance.GetAll()
        FemmeBindingSource.DataSource = listFemmes.Last()
    End Sub

    Private Sub BTN_Suivant_Click(sender As Object, e As EventArgs) Handles BTN_Suivant.Click
        If position < listFemmes.Count() - 1 Then
            position += 1
        Else
            position = 0
        End If
        listFemmes = FemmeDAO.getInstance.GetAll()

        FemmeBindingSource.DataSource = listFemmes(position)
    End Sub

    Private Sub BTN_Precedent_Click(sender As Object, e As EventArgs) Handles BTN_Precedent.Click
        If position > 0 Then
            position -= 1
        Else
            position = listFemmes.Count() - 1
        End If
        listFemmes = FemmeDAO.getInstance.GetAll()

        FemmeBindingSource.DataSource = listFemmes(position)
    End Sub

    Private Sub BTN_Imprimer_Click(sender As Object, e As EventArgs) Handles BTN_Imprimer.Click
        Dim fe As Femme = FemmeBindingSource.Current()
        Dim rpt As New XtraReportFicheFemmes(fe.CIN_Femme)
        rpt.ShowPreviewMarginLines = False
        rpt.ShowPrintMarginsWarning = False
        rpt.ShowPrintStatusDialog = False
        rpt.Print()
    End Sub
End Class