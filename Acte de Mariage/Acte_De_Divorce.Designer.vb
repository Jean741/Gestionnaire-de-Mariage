<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acte_De_Divorce
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.XtraUserControl1 = New DevExpress.XtraEditors.XtraUserControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBB_CIN_HommeEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Acte_De_DivorceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBB_CIN_FemmeEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodeActeMariageSpinEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CIN_HommeLabel = New System.Windows.Forms.Label()
        Me.Nom_HommeLabel = New System.Windows.Forms.Label()
        Me.Adresse_HommeLabel = New System.Windows.Forms.Label()
        Me.CBX_CIN_Notaire = New DevExpress.XtraEditors.TextEdit()
        Me.CBX_CodeActeMariage = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_Annuler = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTN_Nouveau = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Supprimer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Enregistrer = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Modifier = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTN_Suivant = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Dernier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Premier = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_Precedent = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.HommeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Acte_De_MariageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.CBB_CIN_HommeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acte_De_DivorceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBB_CIN_FemmeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeActeMariageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBX_CIN_Notaire.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBX_CodeActeMariage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HommeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acte_De_MariageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraUserControl1
        '
        Me.XtraUserControl1.Location = New System.Drawing.Point(561, 127)
        Me.XtraUserControl1.Name = "XtraUserControl1"
        Me.XtraUserControl1.Size = New System.Drawing.Size(150, 150)
        Me.XtraUserControl1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBB_CIN_HommeEdit)
        Me.GroupBox1.Controls.Add(Me.CBB_CIN_FemmeEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CodeActeMariageSpinEdit)
        Me.GroupBox1.Controls.Add(Me.CIN_HommeLabel)
        Me.GroupBox1.Controls.Add(Me.Nom_HommeLabel)
        Me.GroupBox1.Controls.Add(Me.Adresse_HommeLabel)
        Me.GroupBox1.Controls.Add(Me.CBX_CIN_Notaire)
        Me.GroupBox1.Controls.Add(Me.CBX_CodeActeMariage)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(949, 394)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CBB_CIN_HommeEdit
        '
        Me.CBB_CIN_HommeEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Acte_De_DivorceBindingSource, "CIN_Homme", True))
        Me.CBB_CIN_HommeEdit.EditValue = ""
        Me.CBB_CIN_HommeEdit.Location = New System.Drawing.Point(385, 189)
        Me.CBB_CIN_HommeEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBB_CIN_HommeEdit.Name = "CBB_CIN_HommeEdit"
        Me.CBB_CIN_HommeEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CBB_CIN_HommeEdit.Properties.Appearance.Options.UseFont = True
        Me.CBB_CIN_HommeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBB_CIN_HommeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CBB_CIN_HommeEdit.Size = New System.Drawing.Size(411, 26)
        Me.CBB_CIN_HommeEdit.TabIndex = 94
        '
        'Acte_De_DivorceBindingSource
        '
        Me.Acte_De_DivorceBindingSource.DataSource = GetType(Etat_CivilModels.Acte_divorce)
        '
        'CBB_CIN_FemmeEdit
        '
        Me.CBB_CIN_FemmeEdit.DataBindings.Add(New System.Windows.Forms.Binding("ReadOnly", Me.Acte_De_DivorceBindingSource, "CIN_Femme", True))
        Me.CBB_CIN_FemmeEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Acte_De_DivorceBindingSource, "CIN_Femme", True))
        Me.CBB_CIN_FemmeEdit.EditValue = ""
        Me.CBB_CIN_FemmeEdit.Location = New System.Drawing.Point(385, 256)
        Me.CBB_CIN_FemmeEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBB_CIN_FemmeEdit.Name = "CBB_CIN_FemmeEdit"
        Me.CBB_CIN_FemmeEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CBB_CIN_FemmeEdit.Properties.Appearance.Options.UseFont = True
        Me.CBB_CIN_FemmeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBB_CIN_FemmeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CBB_CIN_FemmeEdit.Size = New System.Drawing.Size(411, 26)
        Me.CBB_CIN_FemmeEdit.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(117, 326)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "CIN Notaire :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(102, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Code Acte Divorce :"
        '
        'CodeActeMariageSpinEdit
        '
        Me.CodeActeMariageSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Acte_De_DivorceBindingSource, "Code_Acte_Mariage", True))
        Me.CodeActeMariageSpinEdit.EditValue = ""
        Me.CodeActeMariageSpinEdit.Enabled = False
        Me.CodeActeMariageSpinEdit.Location = New System.Drawing.Point(385, 55)
        Me.CodeActeMariageSpinEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodeActeMariageSpinEdit.Name = "CodeActeMariageSpinEdit"
        Me.CodeActeMariageSpinEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.CodeActeMariageSpinEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CodeActeMariageSpinEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CodeActeMariageSpinEdit.Properties.Appearance.Options.UseFont = True
        Me.CodeActeMariageSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodeActeMariageSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CodeActeMariageSpinEdit.Size = New System.Drawing.Size(411, 26)
        Me.CodeActeMariageSpinEdit.TabIndex = 86
        '
        'CIN_HommeLabel
        '
        Me.CIN_HommeLabel.AutoSize = True
        Me.CIN_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CIN_HommeLabel.Location = New System.Drawing.Point(121, 192)
        Me.CIN_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CIN_HommeLabel.Name = "CIN_HommeLabel"
        Me.CIN_HommeLabel.Size = New System.Drawing.Size(98, 19)
        Me.CIN_HommeLabel.TabIndex = 81
        Me.CIN_HommeLabel.Text = "CIN Homme:"
        '
        'Nom_HommeLabel
        '
        Me.Nom_HommeLabel.AutoSize = True
        Me.Nom_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Nom_HommeLabel.Location = New System.Drawing.Point(119, 259)
        Me.Nom_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nom_HommeLabel.Name = "Nom_HommeLabel"
        Me.Nom_HommeLabel.Size = New System.Drawing.Size(100, 19)
        Me.Nom_HommeLabel.TabIndex = 82
        Me.Nom_HommeLabel.Text = "CIN Femme :"
        '
        'Adresse_HommeLabel
        '
        Me.Adresse_HommeLabel.AutoSize = True
        Me.Adresse_HommeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Adresse_HommeLabel.Location = New System.Drawing.Point(99, 125)
        Me.Adresse_HommeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Adresse_HommeLabel.Name = "Adresse_HommeLabel"
        Me.Adresse_HommeLabel.Size = New System.Drawing.Size(144, 19)
        Me.Adresse_HommeLabel.TabIndex = 84
        Me.Adresse_HommeLabel.Text = "Code Acte Mariage :"
        '
        'CBX_CIN_Notaire
        '
        Me.CBX_CIN_Notaire.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Acte_De_DivorceBindingSource, "CIN_Notaire", True))
        Me.CBX_CIN_Notaire.EditValue = ""
        Me.CBX_CIN_Notaire.Location = New System.Drawing.Point(385, 323)
        Me.CBX_CIN_Notaire.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBX_CIN_Notaire.Name = "CBX_CIN_Notaire"
        Me.CBX_CIN_Notaire.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CBX_CIN_Notaire.Properties.Appearance.Options.UseFont = True
        Me.CBX_CIN_Notaire.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CBX_CIN_Notaire.Size = New System.Drawing.Size(411, 26)
        Me.CBX_CIN_Notaire.TabIndex = 95
        '
        'CBX_CodeActeMariage
        '
        Me.CBX_CodeActeMariage.Location = New System.Drawing.Point(385, 122)
        Me.CBX_CodeActeMariage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBX_CodeActeMariage.Name = "CBX_CodeActeMariage"
        Me.CBX_CodeActeMariage.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CBX_CodeActeMariage.Properties.Appearance.Options.UseFont = True
        Me.CBX_CodeActeMariage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBX_CodeActeMariage.Properties.DisplayFormat.FormatString = "d"
        Me.CBX_CodeActeMariage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CBX_CodeActeMariage.Properties.EditFormat.FormatString = "d"
        Me.CBX_CodeActeMariage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CBX_CodeActeMariage.Size = New System.Drawing.Size(411, 26)
        Me.CBX_CodeActeMariage.TabIndex = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_Annuler)
        Me.GroupBox2.Controls.Add(Me.BTN_Fermer)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 481)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 200)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Annuler.Appearance.Options.UseFont = True
        Me.BTN_Annuler.Location = New System.Drawing.Point(31, 50)
        Me.BTN_Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Annuler.TabIndex = 56
        Me.BTN_Annuler.Text = "Annuler"
        '
        'BTN_Fermer
        '
        Me.BTN_Fermer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fermer.Appearance.Options.UseFont = True
        Me.BTN_Fermer.Location = New System.Drawing.Point(31, 117)
        Me.BTN_Fermer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Fermer.Name = "BTN_Fermer"
        Me.BTN_Fermer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Fermer.TabIndex = 57
        Me.BTN_Fermer.Text = "Fermer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTN_Nouveau)
        Me.GroupBox3.Controls.Add(Me.BTN_Supprimer)
        Me.GroupBox3.Controls.Add(Me.BTN_Enregistrer)
        Me.GroupBox3.Controls.Add(Me.BTN_Modifier)
        Me.GroupBox3.Location = New System.Drawing.Point(591, 481)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 200)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Nouveau.Appearance.Options.UseFont = True
        Me.BTN_Nouveau.Location = New System.Drawing.Point(35, 21)
        Me.BTN_Nouveau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Nouveau.TabIndex = 100
        Me.BTN_Nouveau.Text = "Nouveau"
        '
        'BTN_Supprimer
        '
        Me.BTN_Supprimer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Supprimer.Appearance.Options.UseFont = True
        Me.BTN_Supprimer.Location = New System.Drawing.Point(35, 150)
        Me.BTN_Supprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Supprimer.Name = "BTN_Supprimer"
        Me.BTN_Supprimer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Supprimer.TabIndex = 57
        Me.BTN_Supprimer.Text = "Supprimer"
        '
        'BTN_Enregistrer
        '
        Me.BTN_Enregistrer.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Enregistrer.Appearance.Options.UseFont = True
        Me.BTN_Enregistrer.Location = New System.Drawing.Point(35, 64)
        Me.BTN_Enregistrer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Enregistrer.Name = "BTN_Enregistrer"
        Me.BTN_Enregistrer.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Enregistrer.TabIndex = 101
        Me.BTN_Enregistrer.Text = "Enregistrer"
        '
        'BTN_Modifier
        '
        Me.BTN_Modifier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Modifier.Appearance.Options.UseFont = True
        Me.BTN_Modifier.Location = New System.Drawing.Point(35, 107)
        Me.BTN_Modifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Modifier.Name = "BTN_Modifier"
        Me.BTN_Modifier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Modifier.TabIndex = 98
        Me.BTN_Modifier.Text = "Modifier"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTN_Suivant)
        Me.GroupBox4.Controls.Add(Me.BTN_Dernier)
        Me.GroupBox4.Controls.Add(Me.BTN_Premier)
        Me.GroupBox4.Controls.Add(Me.BTN_Precedent)
        Me.GroupBox4.Location = New System.Drawing.Point(331, 481)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(175, 200)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'BTN_Suivant
        '
        Me.BTN_Suivant.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Suivant.Appearance.Options.UseFont = True
        Me.BTN_Suivant.Location = New System.Drawing.Point(44, 107)
        Me.BTN_Suivant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Suivant.Name = "BTN_Suivant"
        Me.BTN_Suivant.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Suivant.TabIndex = 97
        Me.BTN_Suivant.Text = "Suivant"
        '
        'BTN_Dernier
        '
        Me.BTN_Dernier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Dernier.Appearance.Options.UseFont = True
        Me.BTN_Dernier.Location = New System.Drawing.Point(44, 64)
        Me.BTN_Dernier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Dernier.Name = "BTN_Dernier"
        Me.BTN_Dernier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Dernier.TabIndex = 99
        Me.BTN_Dernier.Text = "Dernier"
        '
        'BTN_Premier
        '
        Me.BTN_Premier.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Premier.Appearance.Options.UseFont = True
        Me.BTN_Premier.Location = New System.Drawing.Point(44, 21)
        Me.BTN_Premier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Premier.Name = "BTN_Premier"
        Me.BTN_Premier.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Premier.TabIndex = 96
        Me.BTN_Premier.Text = "Premier"
        '
        'BTN_Precedent
        '
        Me.BTN_Precedent.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Precedent.Appearance.Options.UseFont = True
        Me.BTN_Precedent.Location = New System.Drawing.Point(44, 150)
        Me.BTN_Precedent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Precedent.Name = "BTN_Precedent"
        Me.BTN_Precedent.Size = New System.Drawing.Size(112, 33)
        Me.BTN_Precedent.TabIndex = 56
        Me.BTN_Precedent.Text = "Precedent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(605, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 22)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Fiche Des Acte De Divorce :"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'HommeBindingSource
        '
        Me.HommeBindingSource.DataSource = GetType(Etat_CivilModels.Homme)
        '
        'Acte_De_MariageBindingSource
        '
        Me.Acte_De_MariageBindingSource.DataSource = GetType(Etat_CivilModels.Acte_mariage)
        '
        'Acte_De_Divorce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.XtraUserControl1)
        Me.Name = "Acte_De_Divorce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acte_De_Divorce"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CBB_CIN_HommeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acte_De_DivorceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBB_CIN_FemmeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeActeMariageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBX_CIN_Notaire.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBX_CodeActeMariage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HommeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acte_De_MariageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XtraUserControl1 As DevExpress.XtraEditors.XtraUserControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CodeActeMariageSpinEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CIN_HommeLabel As Label
    Friend WithEvents Nom_HommeLabel As Label
    Friend WithEvents Adresse_HommeLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBB_CIN_HommeEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CBB_CIN_FemmeEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BTN_Premier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Dernier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Suivant As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Nouveau As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Enregistrer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Modifier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Supprimer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Precedent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Annuler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Acte_De_DivorceBindingSource As BindingSource
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents CBX_CIN_Notaire As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HommeBindingSource As BindingSource
    Friend WithEvents Acte_De_MariageBindingSource As BindingSource
    Friend WithEvents CBX_CodeActeMariage As DevExpress.XtraEditors.ComboBoxEdit
End Class

