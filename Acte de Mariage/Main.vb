Imports DevExpress.XtraEditors
Imports Etat_CivilModels
Public Class Main

    Private Function IsFormActived(form As Form) As Boolean
        Dim open As Boolean = False
        If (MdiChildren.Count() > 0) Then
            For Each var In MdiChildren
                If (form.Name = var.Name) Then
                    var.Activate()
                    open = True
                End If
            Next
        End If
        Return open
    End Function
    Private Sub affiche(form As Form)
        If Not IsFormActived(form) Then
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleParametrage.ChaineCNX = GetChaineConnectFromXML()
    End Sub


    Private Sub HommesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HommesToolStripMenuItem.Click
        Dim form As New Fiche_des_Hommes
        affiche(form)
    End Sub

    Private Sub FemmesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemmesToolStripMenuItem.Click
        Dim form As New Fiche_Des_Femmes
        affiche(form)


    End Sub

    Private Sub ActeDeMariageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActeDeMariageToolStripMenuItem.Click
        Dim form As New Acte_De_Mariage
        affiche(form)
    End Sub

    Private Sub ActeDeDivorceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActeDeDivorceToolStripMenuItem.Click
        Dim form As New Acte_De_Divorce
        affiche(form)
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If XtraMessageBox.Show("Voulez vous vraiment  Fermer..?", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class