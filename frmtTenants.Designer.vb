<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtTenants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRentalInfo = New System.Windows.Forms.TabControl()
        Me.tbTenant = New System.Windows.Forms.TabPage()
        Me.tbRent = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.tbRentalInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TENANTS"
        '
        'tbRentalInfo
        '
        Me.tbRentalInfo.Controls.Add(Me.tbTenant)
        Me.tbRentalInfo.Controls.Add(Me.tbRent)
        Me.tbRentalInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRentalInfo.Location = New System.Drawing.Point(2, 92)
        Me.tbRentalInfo.Name = "tbRentalInfo"
        Me.tbRentalInfo.SelectedIndex = 0
        Me.tbRentalInfo.Size = New System.Drawing.Size(1338, 655)
        Me.tbRentalInfo.TabIndex = 1
        '
        'tbTenant
        '
        Me.tbTenant.Location = New System.Drawing.Point(4, 28)
        Me.tbTenant.Name = "tbTenant"
        Me.tbTenant.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTenant.Size = New System.Drawing.Size(1330, 623)
        Me.tbTenant.TabIndex = 1
        Me.tbTenant.Text = "TENANT DETAILS"
        Me.tbTenant.UseVisualStyleBackColor = True
        '
        'tbRent
        '
        Me.tbRent.Location = New System.Drawing.Point(4, 28)
        Me.tbRent.Name = "tbRent"
        Me.tbRent.Size = New System.Drawing.Size(1330, 623)
        Me.tbRent.TabIndex = 2
        Me.tbRent.Text = "RENT INFO"
        Me.tbRent.UseVisualStyleBackColor = True
        '
        'frmtTenants
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1352, 759)
        Me.Controls.Add(Me.tbRentalInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmtTenants"
        Me.Text = "frmtTenants"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbRentalInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbRentalInfo As TabControl
    Friend WithEvents tbTenant As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRent As TabPage
End Class
