Imports Etat_CivilModels

Public Class XtraReportFicheFemmes
    Public Sub New(CIN As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ObjectDataSource1.DataSource = FemmeDAO.getInstance.Read(CIN)
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    End Sub
End Class