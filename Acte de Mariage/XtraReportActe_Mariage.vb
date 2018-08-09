Imports Etat_CivilModels

Public Class XtraReportActe_Mariage
    Public Sub New(CIN1 As String, CIN2 As String, CIN3 As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ObjectDataSource1.DataSource = Acte_mariageDAO.getInstance.Read(CIN1)
        ObjectDataSource2.DataSource = FemmeDAO.getInstance.Read(CIN2)
        ObjectDataSource3.DataSource = HommeDAO.getInstance.Read(CIN3)
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

End Class