<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HommesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FemmesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActeDeMariageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActeDeDivorceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichiersToolStripMenuItem, Me.EtatsToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichiersToolStripMenuItem
        '
        Me.FichiersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HommesToolStripMenuItem, Me.FemmesToolStripMenuItem, Me.ActeDeMariageToolStripMenuItem, Me.ActeDeDivorceToolStripMenuItem, Me.ConsultationToolStripMenuItem})
        Me.FichiersToolStripMenuItem.Name = "FichiersToolStripMenuItem"
        Me.FichiersToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FichiersToolStripMenuItem.Text = "Fichiers"
        '
        'HommesToolStripMenuItem
        '
        Me.HommesToolStripMenuItem.Name = "HommesToolStripMenuItem"
        Me.HommesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.HommesToolStripMenuItem.Text = "Hommes"
        '
        'FemmesToolStripMenuItem
        '
        Me.FemmesToolStripMenuItem.Name = "FemmesToolStripMenuItem"
        Me.FemmesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FemmesToolStripMenuItem.Text = "Femmes"
        '
        'ActeDeMariageToolStripMenuItem
        '
        Me.ActeDeMariageToolStripMenuItem.Name = "ActeDeMariageToolStripMenuItem"
        Me.ActeDeMariageToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ActeDeMariageToolStripMenuItem.Text = "Acte De Mariage"
        '
        'ActeDeDivorceToolStripMenuItem
        '
        Me.ActeDeDivorceToolStripMenuItem.Name = "ActeDeDivorceToolStripMenuItem"
        Me.ActeDeDivorceToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ActeDeDivorceToolStripMenuItem.Text = "Acte De Divorce"
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ConsultationToolStripMenuItem.Text = "Consultation"
        '
        'EtatsToolStripMenuItem
        '
        Me.EtatsToolStripMenuItem.Name = "EtatsToolStripMenuItem"
        Me.EtatsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.EtatsToolStripMenuItem.Text = "Etats"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabbedMdiManager1.Appearance.Options.UseFont = True
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichiersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HommesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FemmesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActeDeMariageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActeDeDivorceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
End Class
