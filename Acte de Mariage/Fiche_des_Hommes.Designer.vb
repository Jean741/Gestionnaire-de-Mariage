<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fiche_des_Hommes
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
        Dim Date_NaissanceLabel As System.Windows.Forms.Label
        Me.Adresse_HommeLabel = New System.Windows.Forms.Label()
        Me.Prenom_HommeLabel = New System.Windows.Forms.Label()
        Me.Nom_HommeLabel = New System.Windows.Forms.Label()
        Me.CIN_HommeLabel = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BTN_Nouveau = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Premier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Dernier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Enregistrer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Modifier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Suivant = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Precedent = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Supprimer = New DevExpress.XtraEditors.SimpleButton()
        Me.Date_NaissanceDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.HommeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Adresse_HommeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Prenom_HommeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Nom_HommeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Prenom_HommeSpinEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LBL_Fiche_Des_Hommes = New System.Windows.Forms.Label()
        Me.TXB_Chercher = New System.Windows.Forms.TextBox()
        Me.BTN_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Imprimer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Annuler = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Date_NaissanceLabel = New System.Windows.Forms.Label()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_NaissanceDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HommeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adresse_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prenom_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nom_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prenom_HommeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_NaissanceLabel
        '
        Date_NaissanceLabel.AutoSize = True
        Date_NaissanceLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Date_NaissanceLabel.Location = New System.Drawing.Point(10, 254)
        Date_NaissanceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_NaissanceLabel.Name = "Date_NaissanceLabel"
        Date_NaissanceLabel.Size = New System.Drawing.Size(118, 19)
        Date_NaissanceLabel.TabIndex = 75
        Date_NaissanceLabel.Text = "Date Naissance:"
        '
        'Adresse_HommeLabel
        '
        Me.Adresse_HommeLabel.AutoSize = True
        Me.Adresse_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Adresse_HommeLabel.Location = New System.Drawing.Point(10, 308)
        Me.Adresse_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Adresse_HommeLabel.Name = "Adresse_HommeLabel"
        Me.Adresse_HommeLabel.Size = New System.Drawing.Size(130, 19)
        Me.Adresse_HommeLabel.TabIndex = 74
        Me.Adresse_HommeLabel.Text = "Adresse Hommes :"
        '
        'Prenom_HommeLabel
        '
        Me.Prenom_HommeLabel.AutoSize = True
        Me.Prenom_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Prenom_HommeLabel.Location = New System.Drawing.Point(10, 200)
        Me.Prenom_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Prenom_HommeLabel.Name = "Prenom_HommeLabel"
        Me.Prenom_HommeLabel.Size = New System.Drawing.Size(121, 19)
        Me.Prenom_HommeLabel.TabIndex = 73
        Me.Prenom_HommeLabel.Text = "Prenom Homme:"
        '
        'Nom_HommeLabel
        '
        Me.Nom_HommeLabel.AutoSize = True
        Me.Nom_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Nom_HommeLabel.Location = New System.Drawing.Point(10, 150)
        Me.Nom_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nom_HommeLabel.Name = "Nom_HommeLabel"
        Me.Nom_HommeLabel.Size = New System.Drawing.Size(101, 19)
        Me.Nom_HommeLabel.TabIndex = 72
        Me.Nom_HommeLabel.Text = "Nom Homme:"
        '
        'CIN_HommeLabel
        '
        Me.CIN_HommeLabel.AutoSize = True
        Me.CIN_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CIN_HommeLabel.Location = New System.Drawing.Point(10, 96)
        Me.CIN_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CIN_HommeLabel.Name = "CIN_HommeLabel"
        Me.CIN_HommeLabel.Size = New System.Drawing.Size(98, 19)
        Me.CIN_HommeLabel.TabIndex = 71
        Me.CIN_HommeLabel.Text = "CIN Homme:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupControl2.Controls.Add(Me.BTN_Nouveau)
        Me.GroupControl2.Controls.Add(Me.BTN_Premier)
        Me.GroupControl2.Controls.Add(Me.BTN_Dernier)
        Me.GroupControl2.Controls.Add(Me.BTN_Enregistrer)
        Me.GroupControl2.Controls.Add(Me.BTN_Modifier)
        Me.GroupControl2.Controls.Add(Me.BTN_Suivant)
        Me.GroupControl2.Controls.Add(Me.BTN_Precedent)
        Me.GroupControl2.Controls.Add(Me.BTN_Supprimer)
        Me.GroupControl2.Location = New System.Drawing.Point(170, 446)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1071, 176)
        Me.GroupControl2.TabIndex = 70
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Nouveau.Appearance.Options.UseFont = True
        Me.BTN_Nouveau.Location = New System.Drawing.Point(109, 116)
        Me.BTN_Nouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Nouveau.TabIndex = 56
        Me.BTN_Nouveau.Text = "Nouveau"
        '
        'BTN_Premier
        '
        Me.BTN_Premier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Premier.Appearance.Options.UseFont = True
        Me.BTN_Premier.Location = New System.Drawing.Point(109, 41)
        Me.BTN_Premier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Premier.Name = "BTN_Premier"
        Me.BTN_Premier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Premier.TabIndex = 47
        Me.BTN_Premier.Text = "Premier"
        '
        'BTN_Dernier
        '
        Me.BTN_Dernier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Dernier.Appearance.Options.UseFont = True
        Me.BTN_Dernier.Location = New System.Drawing.Point(375, 41)
        Me.BTN_Dernier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Dernier.Name = "BTN_Dernier"
        Me.BTN_Dernier.Size = New System.Drawing.Size(138, 33)
        Me.BTN_Dernier.TabIndex = 53
        Me.BTN_Dernier.Text = "Dernier"
        '
        'BTN_Enregistrer
        '
        Me.BTN_Enregistrer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Enregistrer.Appearance.Options.UseFont = True
        Me.BTN_Enregistrer.Location = New System.Drawing.Point(377, 116)
        Me.BTN_Enregistrer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Enregistrer.Name = "BTN_Enregistrer"
        Me.BTN_Enregistrer.Size = New System.Drawing.Size(136, 33)
        Me.BTN_Enregistrer.TabIndex = 57
        Me.BTN_Enregistrer.Text = "Enregistrer"
        '
        'BTN_Modifier
        '
        Me.BTN_Modifier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Modifier.Appearance.Options.UseFont = True
        Me.BTN_Modifier.Location = New System.Drawing.Point(662, 116)
        Me.BTN_Modifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Modifier.Name = "BTN_Modifier"
        Me.BTN_Modifier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Modifier.TabIndex = 51
        Me.BTN_Modifier.Text = "Modifier"
        '
        'BTN_Suivant
        '
        Me.BTN_Suivant.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Suivant.Appearance.Options.UseFont = True
        Me.BTN_Suivant.Location = New System.Drawing.Point(662, 41)
        Me.BTN_Suivant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Suivant.Name = "BTN_Suivant"
        Me.BTN_Suivant.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Suivant.TabIndex = 49
        Me.BTN_Suivant.Text = "Suivant"
        '
        'BTN_Precedent
        '
        Me.BTN_Precedent.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Precedent.Appearance.Options.UseFont = True
        Me.BTN_Precedent.Location = New System.Drawing.Point(923, 41)
        Me.BTN_Precedent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Precedent.Name = "BTN_Precedent"
        Me.BTN_Precedent.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Precedent.TabIndex = 50
        Me.BTN_Precedent.Text = "Precedent"
        '
        'BTN_Supprimer
        '
        Me.BTN_Supprimer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Supprimer.Appearance.Options.UseFont = True
        Me.BTN_Supprimer.Location = New System.Drawing.Point(923, 116)
        Me.BTN_Supprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Supprimer.Name = "BTN_Supprimer"
        Me.BTN_Supprimer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Supprimer.TabIndex = 55
        Me.BTN_Supprimer.Text = "Supprimer"
        '
        'Date_NaissanceDateEdit
        '
        Me.Date_NaissanceDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HommeBindingSource, "Date_Naissance", True))
        Me.Date_NaissanceDateEdit.EditValue = Nothing
        Me.Date_NaissanceDateEdit.Location = New System.Drawing.Point(169, 251)
        Me.Date_NaissanceDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_NaissanceDateEdit.Name = "Date_NaissanceDateEdit"
        Me.Date_NaissanceDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Date_NaissanceDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Date_NaissanceDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_NaissanceDateEdit.Size = New System.Drawing.Size(411, 26)
        Me.Date_NaissanceDateEdit.TabIndex = 80
        '
        'HommeBindingSource
        '
        Me.HommeBindingSource.DataSource = GetType(Etat_CivilModels.Homme)
        '
        'Adresse_HommeTextEdit
        '
        Me.Adresse_HommeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HommeBindingSource, "Adresse_Homme", True))
        Me.Adresse_HommeTextEdit.Location = New System.Drawing.Point(169, 305)
        Me.Adresse_HommeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Adresse_HommeTextEdit.Name = "Adresse_HommeTextEdit"
        Me.Adresse_HommeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Adresse_HommeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Adresse_HommeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Adresse_HommeTextEdit.TabIndex = 79
        '
        'Prenom_HommeTextEdit
        '
        Me.Prenom_HommeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HommeBindingSource, "Prenom_Homme", True))
        Me.Prenom_HommeTextEdit.Location = New System.Drawing.Point(169, 197)
        Me.Prenom_HommeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prenom_HommeTextEdit.Name = "Prenom_HommeTextEdit"
        Me.Prenom_HommeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Prenom_HommeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Prenom_HommeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Prenom_HommeTextEdit.TabIndex = 78
        '
        'Nom_HommeTextEdit
        '
        Me.Nom_HommeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HommeBindingSource, "Nom_Homme", True))
        Me.Nom_HommeTextEdit.Location = New System.Drawing.Point(169, 143)
        Me.Nom_HommeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nom_HommeTextEdit.Name = "Nom_HommeTextEdit"
        Me.Nom_HommeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Nom_HommeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Nom_HommeTextEdit.Size = New System.Drawing.Size(411, 26)
        Me.Nom_HommeTextEdit.TabIndex = 77
        '
        'Prenom_HommeSpinEdit
        '
        Me.Prenom_HommeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HommeBindingSource, "CIN_Homme", True))
        Me.Prenom_HommeSpinEdit.EditValue = ""
        Me.Prenom_HommeSpinEdit.Location = New System.Drawing.Point(169, 93)
        Me.Prenom_HommeSpinEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prenom_HommeSpinEdit.Name = "Prenom_HommeSpinEdit"
        Me.Prenom_HommeSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Prenom_HommeSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.Prenom_HommeSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Prenom_HommeSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.Prenom_HommeSpinEdit.Size = New System.Drawing.Size(411, 26)
        Me.Prenom_HommeSpinEdit.TabIndex = 76
        '
        'LBL_Fiche_Des_Hommes
        '
        Me.LBL_Fiche_Des_Hommes.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Fiche_Des_Hommes.Location = New System.Drawing.Point(296, 17)
        Me.LBL_Fiche_Des_Hommes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Fiche_Des_Hommes.Name = "LBL_Fiche_Des_Hommes"
        Me.LBL_Fiche_Des_Hommes.Size = New System.Drawing.Size(248, 71)
        Me.LBL_Fiche_Des_Hommes.TabIndex = 81
        Me.LBL_Fiche_Des_Hommes.Text = "Fiche Des  Hommes :"
        '
        'TXB_Chercher
        '
        Me.TXB_Chercher.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXB_Chercher.Location = New System.Drawing.Point(52, 88)
        Me.TXB_Chercher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXB_Chercher.Name = "TXB_Chercher"
        Me.TXB_Chercher.Size = New System.Drawing.Size(112, 26)
        Me.TXB_Chercher.TabIndex = 84
        '
        'BTN_OK
        '
        Me.BTN_OK.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OK.Appearance.Options.UseFont = True
        Me.BTN_OK.Location = New System.Drawing.Point(52, 138)
        Me.BTN_OK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(121, 33)
        Me.BTN_OK.TabIndex = 83
        Me.BTN_OK.Text = "OK"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 67)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = " Taper CIN Homme à" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Chercher"
        '
        'BTN_Imprimer
        '
        Me.BTN_Imprimer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Imprimer.Appearance.Options.UseFont = True
        Me.BTN_Imprimer.Location = New System.Drawing.Point(61, 210)
        Me.BTN_Imprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Imprimer.Name = "BTN_Imprimer"
        Me.BTN_Imprimer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Imprimer.TabIndex = 87
        Me.BTN_Imprimer.Text = "Imprimer"
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Annuler.Appearance.Options.UseFont = True
        Me.BTN_Annuler.Location = New System.Drawing.Point(498, 631)
        Me.BTN_Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Annuler.TabIndex = 86
        Me.BTN_Annuler.Text = "Annuler"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(814, 631)
        Me.SimpleButton6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(112, 33)
        Me.SimpleButton6.TabIndex = 85
        Me.SimpleButton6.Text = "Fermer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTN_Imprimer)
        Me.GroupBox1.Controls.Add(Me.TXB_Chercher)
        Me.GroupBox1.Controls.Add(Me.BTN_OK)
        Me.GroupBox1.Location = New System.Drawing.Point(961, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 293)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Prenom_HommeSpinEdit)
        Me.GroupBox2.Controls.Add(Me.CIN_HommeLabel)
        Me.GroupBox2.Controls.Add(Me.Nom_HommeLabel)
        Me.GroupBox2.Controls.Add(Me.Prenom_HommeLabel)
        Me.GroupBox2.Controls.Add(Me.LBL_Fiche_Des_Hommes)
        Me.GroupBox2.Controls.Add(Me.Adresse_HommeLabel)
        Me.GroupBox2.Controls.Add(Me.Date_NaissanceDateEdit)
        Me.GroupBox2.Controls.Add(Date_NaissanceLabel)
        Me.GroupBox2.Controls.Add(Me.Adresse_HommeTextEdit)
        Me.GroupBox2.Controls.Add(Me.Nom_HommeTextEdit)
        Me.GroupBox2.Controls.Add(Me.Prenom_HommeTextEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(170, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 366)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Fiche_des_Hommes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_Annuler)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "Fiche_des_Hommes"
        Me.Text = "Fiche_des_Hommes"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Date_NaissanceDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_NaissanceDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HommeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adresse_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prenom_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nom_HommeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prenom_HommeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HommeBindingSource As BindingSource
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BTN_Nouveau As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Premier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Dernier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Enregistrer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Modifier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Suivant As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Precedent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Supprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Date_NaissanceDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Adresse_HommeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Prenom_HommeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nom_HommeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Prenom_HommeSpinEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LBL_Fiche_Des_Hommes As Label
    Friend WithEvents TXB_Chercher As TextBox
    Friend WithEvents BTN_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Imprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Annuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Adresse_HommeLabel As Label
    Friend WithEvents Prenom_HommeLabel As Label
    Friend WithEvents Nom_HommeLabel As Label
    Friend WithEvents CIN_HommeLabel As Label
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
