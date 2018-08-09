<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fiche_Des_Femmes
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CIN_FemmeLabel As System.Windows.Forms.Label
        Dim Nom_FemmeLabel As System.Windows.Forms.Label
        Dim Prenom_FemmeLabel As System.Windows.Forms.Label
        Dim Adresse_FemmeLabel As System.Windows.Forms.Label
        Dim Date_NaissanceLabel As System.Windows.Forms.Label
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.TXB_Chercher = New System.Windows.Forms.TextBox()
        Me.BTN_Enregistrer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Nouveau = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Supprimer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Annuler = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Dernier = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Modifier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Precedent = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Suivant = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Premier = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_Fiche_Des_Femmes = New System.Windows.Forms.Label()
        Me.Nom_FemmeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FemmeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prenom_FemmeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Adresse_FemmeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Date_NaissanceDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Prenom_FemmeSpinEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BTN_Imprimer = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CIN_FemmeLabel = New System.Windows.Forms.Label()
        Nom_FemmeLabel = New System.Windows.Forms.Label()
        Prenom_FemmeLabel = New System.Windows.Forms.Label()
        Adresse_FemmeLabel = New System.Windows.Forms.Label()
        Date_NaissanceLabel = New System.Windows.Forms.Label()
        CType(Me.Nom_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemmeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prenom_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adresse_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_NaissanceDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Prenom_FemmeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CIN_FemmeLabel
        '
        CIN_FemmeLabel.AutoSize = True
        CIN_FemmeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CIN_FemmeLabel.Location = New System.Drawing.Point(24, 99)
        CIN_FemmeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CIN_FemmeLabel.Name = "CIN_FemmeLabel"
        CIN_FemmeLabel.Size = New System.Drawing.Size(96, 19)
        CIN_FemmeLabel.TabIndex = 62
        CIN_FemmeLabel.Text = "CIN Femme:"
        '
        'Nom_FemmeLabel
        '
        Nom_FemmeLabel.AutoSize = True
        Nom_FemmeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Nom_FemmeLabel.Location = New System.Drawing.Point(24, 153)
        Nom_FemmeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nom_FemmeLabel.Name = "Nom_FemmeLabel"
        Nom_FemmeLabel.Size = New System.Drawing.Size(99, 19)
        Nom_FemmeLabel.TabIndex = 63
        Nom_FemmeLabel.Text = "Nom Femme:"
        '
        'Prenom_FemmeLabel
        '
        Prenom_FemmeLabel.AutoSize = True
        Prenom_FemmeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Prenom_FemmeLabel.Location = New System.Drawing.Point(24, 203)
        Prenom_FemmeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Prenom_FemmeLabel.Name = "Prenom_FemmeLabel"
        Prenom_FemmeLabel.Size = New System.Drawing.Size(119, 19)
        Prenom_FemmeLabel.TabIndex = 64
        Prenom_FemmeLabel.Text = "Prenom Femme:"
        '
        'Adresse_FemmeLabel
        '
        Adresse_FemmeLabel.AutoSize = True
        Adresse_FemmeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Adresse_FemmeLabel.Location = New System.Drawing.Point(24, 311)
        Adresse_FemmeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Adresse_FemmeLabel.Name = "Adresse_FemmeLabel"
        Adresse_FemmeLabel.Size = New System.Drawing.Size(118, 19)
        Adresse_FemmeLabel.TabIndex = 65
        Adresse_FemmeLabel.Text = "Adresse Femme:"
        '
        'Date_NaissanceLabel
        '
        Date_NaissanceLabel.AutoSize = True
        Date_NaissanceLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Date_NaissanceLabel.Location = New System.Drawing.Point(24, 257)
        Date_NaissanceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_NaissanceLabel.Name = "Date_NaissanceLabel"
        Date_NaissanceLabel.Size = New System.Drawing.Size(118, 19)
        Date_NaissanceLabel.TabIndex = 66
        Date_NaissanceLabel.Text = "Date Naissance:"
        '
        'TXB_Chercher
        '
        Me.TXB_Chercher.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXB_Chercher.Location = New System.Drawing.Point(49, 99)
        Me.TXB_Chercher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXB_Chercher.Name = "TXB_Chercher"
        Me.TXB_Chercher.Size = New System.Drawing.Size(112, 26)
        Me.TXB_Chercher.TabIndex = 62
        '
        'BTN_Enregistrer
        '
        Me.BTN_Enregistrer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Enregistrer.Appearance.Options.UseFont = True
        Me.BTN_Enregistrer.Location = New System.Drawing.Point(379, 122)
        Me.BTN_Enregistrer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Enregistrer.Name = "BTN_Enregistrer"
        Me.BTN_Enregistrer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Enregistrer.TabIndex = 57
        Me.BTN_Enregistrer.Text = "Enregistrer"
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Nouveau.Appearance.Options.UseFont = True
        Me.BTN_Nouveau.Location = New System.Drawing.Point(95, 119)
        Me.BTN_Nouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Nouveau.TabIndex = 56
        Me.BTN_Nouveau.Text = "Nouveau"
        '
        'BTN_Supprimer
        '
        Me.BTN_Supprimer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Supprimer.Appearance.Options.UseFont = True
        Me.BTN_Supprimer.Location = New System.Drawing.Point(923, 122)
        Me.BTN_Supprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Supprimer.Name = "BTN_Supprimer"
        Me.BTN_Supprimer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Supprimer.TabIndex = 55
        Me.BTN_Supprimer.Text = "Supprimer"
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Annuler.Appearance.Options.UseFont = True
        Me.BTN_Annuler.Location = New System.Drawing.Point(488, 629)
        Me.BTN_Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Annuler.TabIndex = 54
        Me.BTN_Annuler.Text = "Annuler"
        '
        'BTN_Dernier
        '
        Me.BTN_Dernier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Dernier.Appearance.Options.UseFont = True
        Me.BTN_Dernier.Location = New System.Drawing.Point(379, 55)
        Me.BTN_Dernier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Dernier.Name = "BTN_Dernier"
        Me.BTN_Dernier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Dernier.TabIndex = 53
        Me.BTN_Dernier.Text = "Dernier"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(785, 629)
        Me.SimpleButton6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(112, 33)
        Me.SimpleButton6.TabIndex = 52
        Me.SimpleButton6.Text = "Fermer"
        '
        'BTN_Modifier
        '
        Me.BTN_Modifier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Modifier.Appearance.Options.UseFont = True
        Me.BTN_Modifier.Location = New System.Drawing.Point(673, 131)
        Me.BTN_Modifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Modifier.Name = "BTN_Modifier"
        Me.BTN_Modifier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Modifier.TabIndex = 51
        Me.BTN_Modifier.Text = "Modifier"
        '
        'BTN_Precedent
        '
        Me.BTN_Precedent.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Precedent.Appearance.Options.UseFont = True
        Me.BTN_Precedent.Location = New System.Drawing.Point(923, 55)
        Me.BTN_Precedent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Precedent.Name = "BTN_Precedent"
        Me.BTN_Precedent.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Precedent.TabIndex = 50
        Me.BTN_Precedent.Text = "Precedent"
        '
        'BTN_Suivant
        '
        Me.BTN_Suivant.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Suivant.Appearance.Options.UseFont = True
        Me.BTN_Suivant.Location = New System.Drawing.Point(673, 55)
        Me.BTN_Suivant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Suivant.Name = "BTN_Suivant"
        Me.BTN_Suivant.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Suivant.TabIndex = 49
        Me.BTN_Suivant.Text = "Suivant"
        '
        'BTN_OK
        '
        Me.BTN_OK.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OK.Appearance.Options.UseFont = True
        Me.BTN_OK.Location = New System.Drawing.Point(49, 148)
        Me.BTN_OK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(121, 33)
        Me.BTN_OK.TabIndex = 48
        Me.BTN_OK.Text = "OK"
        '
        'BTN_Premier
        '
        Me.BTN_Premier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Premier.Appearance.Options.UseFont = True
        Me.BTN_Premier.Location = New System.Drawing.Point(95, 55)
        Me.BTN_Premier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Premier.Name = "BTN_Premier"
        Me.BTN_Premier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Premier.TabIndex = 47
        Me.BTN_Premier.Text = "Premier"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 63)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = " Taper CIN Femme à" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Chercher"
        '
        'LBL_Fiche_Des_Femmes
        '
        Me.LBL_Fiche_Des_Femmes.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Fiche_Des_Femmes.Location = New System.Drawing.Point(246, 18)
        Me.LBL_Fiche_Des_Femmes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Fiche_Des_Femmes.Name = "LBL_Fiche_Des_Femmes"
        Me.LBL_Fiche_Des_Femmes.Size = New System.Drawing.Size(248, 50)
        Me.LBL_Fiche_Des_Femmes.TabIndex = 40
        Me.LBL_Fiche_Des_Femmes.Text = "Fiche Des  Femmes :"
        '
        'Nom_FemmeTextEdit
        '
        Me.Nom_FemmeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FemmeBindingSource, "Nom_Femme", True))
        Me.Nom_FemmeTextEdit.Location = New System.Drawing.Point(200, 146)
        Me.Nom_FemmeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nom_FemmeTextEdit.Name = "Nom_FemmeTextEdit"
        Me.Nom_FemmeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Nom_FemmeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Nom_FemmeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Nom_FemmeTextEdit.TabIndex = 64
        '
        'FemmeBindingSource
        '
        Me.FemmeBindingSource.DataSource = GetType(Etat_CivilModels.Femme)
        '
        'Prenom_FemmeTextEdit
        '
        Me.Prenom_FemmeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FemmeBindingSource, "Prenom_Femme", True))
        Me.Prenom_FemmeTextEdit.Location = New System.Drawing.Point(200, 200)
        Me.Prenom_FemmeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prenom_FemmeTextEdit.Name = "Prenom_FemmeTextEdit"
        Me.Prenom_FemmeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Prenom_FemmeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Prenom_FemmeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Prenom_FemmeTextEdit.TabIndex = 65
        '
        'Adresse_FemmeTextEdit
        '
        Me.Adresse_FemmeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FemmeBindingSource, "Adresse_Femme", True))
        Me.Adresse_FemmeTextEdit.Location = New System.Drawing.Point(200, 308)
        Me.Adresse_FemmeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Adresse_FemmeTextEdit.Name = "Adresse_FemmeTextEdit"
        Me.Adresse_FemmeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Adresse_FemmeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Adresse_FemmeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Adresse_FemmeTextEdit.TabIndex = 66
        '
        'Date_NaissanceDateEdit
        '
        Me.Date_NaissanceDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FemmeBindingSource, "Date_Naissance", True))
        Me.Date_NaissanceDateEdit.EditValue = Nothing
        Me.Date_NaissanceDateEdit.Location = New System.Drawing.Point(200, 254)
        Me.Date_NaissanceDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_NaissanceDateEdit.Name = "Date_NaissanceDateEdit"
        Me.Date_NaissanceDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Date_NaissanceDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Date_NaissanceDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_NaissanceDateEdit.Size = New System.Drawing.Size(411, 26)
        Me.Date_NaissanceDateEdit.TabIndex = 67
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(294, 500)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(9, 10)
        Me.GroupControl1.TabIndex = 68
        Me.GroupControl1.Text = "GroupControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl2.Controls.Add(Me.BTN_Nouveau)
        Me.GroupControl2.Controls.Add(Me.BTN_Premier)
        Me.GroupControl2.Controls.Add(Me.BTN_Dernier)
        Me.GroupControl2.Controls.Add(Me.BTN_Enregistrer)
        Me.GroupControl2.Controls.Add(Me.BTN_Modifier)
        Me.GroupControl2.Controls.Add(Me.BTN_Suivant)
        Me.GroupControl2.Controls.Add(Me.BTN_Precedent)
        Me.GroupControl2.Controls.Add(Me.BTN_Supprimer)
        Me.GroupControl2.Location = New System.Drawing.Point(179, 400)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1070, 194)
        Me.GroupControl2.TabIndex = 69
        '
        'Prenom_FemmeSpinEdit
        '
        Me.Prenom_FemmeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FemmeBindingSource, "CIN_Femme", True))
        Me.Prenom_FemmeSpinEdit.EditValue = ""
        Me.Prenom_FemmeSpinEdit.Location = New System.Drawing.Point(200, 96)
        Me.Prenom_FemmeSpinEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prenom_FemmeSpinEdit.Name = "Prenom_FemmeSpinEdit"
        Me.Prenom_FemmeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Prenom_FemmeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.Prenom_FemmeSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Prenom_FemmeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.Prenom_FemmeSpinEdit.Size = New System.Drawing.Size(411, 26)
        Me.Prenom_FemmeSpinEdit.TabIndex = 63
        '
        'BTN_Imprimer
        '
        Me.BTN_Imprimer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Imprimer.Appearance.Options.UseFont = True
        Me.BTN_Imprimer.Location = New System.Drawing.Point(58, 232)
        Me.BTN_Imprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Imprimer.Name = "BTN_Imprimer"
        Me.BTN_Imprimer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Imprimer.TabIndex = 58
        Me.BTN_Imprimer.Text = "Imprimer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTN_OK)
        Me.GroupBox1.Controls.Add(Me.BTN_Imprimer)
        Me.GroupBox1.Controls.Add(Me.TXB_Chercher)
        Me.GroupBox1.Location = New System.Drawing.Point(1009, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 314)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_Fiche_Des_Femmes)
        Me.GroupBox2.Controls.Add(Me.Prenom_FemmeSpinEdit)
        Me.GroupBox2.Controls.Add(CIN_FemmeLabel)
        Me.GroupBox2.Controls.Add(Me.Nom_FemmeTextEdit)
        Me.GroupBox2.Controls.Add(Date_NaissanceLabel)
        Me.GroupBox2.Controls.Add(Nom_FemmeLabel)
        Me.GroupBox2.Controls.Add(Me.Date_NaissanceDateEdit)
        Me.GroupBox2.Controls.Add(Me.Prenom_FemmeTextEdit)
        Me.GroupBox2.Controls.Add(Adresse_FemmeLabel)
        Me.GroupBox2.Controls.Add(Prenom_FemmeLabel)
        Me.GroupBox2.Controls.Add(Me.Adresse_FemmeTextEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(179, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 371)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        '
        'Fiche_Des_Femmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.BTN_Annuler)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Fiche_Des_Femmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fiche_Des_Femmes"
        CType(Me.Nom_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemmeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prenom_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adresse_FemmeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_NaissanceDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Prenom_FemmeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents TXB_Chercher As TextBox
    Friend WithEvents BTN_Enregistrer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Nouveau As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Supprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Annuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Dernier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Modifier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Precedent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Suivant As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Premier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_Fiche_Des_Femmes As Label
    Friend WithEvents FemmeBindingSource As BindingSource
    Friend WithEvents Nom_FemmeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Prenom_FemmeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Adresse_FemmeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Date_NaissanceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Prenom_FemmeSpinEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BTN_Imprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
