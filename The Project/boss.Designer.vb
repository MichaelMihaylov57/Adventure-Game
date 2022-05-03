<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boss
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pctboss = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.pctgate = New System.Windows.Forms.PictureBox()
        CType(Me.pctboss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctgate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctboss
        '
        Me.pctboss.BackColor = System.Drawing.Color.Transparent
        Me.pctboss.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.boss
        Me.pctboss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctboss.Enabled = False
        Me.pctboss.Location = New System.Drawing.Point(497, 12)
        Me.pctboss.Name = "pctboss"
        Me.pctboss.Size = New System.Drawing.Size(541, 578)
        Me.pctboss.TabIndex = 80
        Me.pctboss.TabStop = False
        '
        'Player
        '
        Me.Player.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.corg
        Me.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player.Enabled = False
        Me.Player.Location = New System.Drawing.Point(90, 527)
        Me.Player.Margin = New System.Windows.Forms.Padding(0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(74, 63)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 81
        Me.Player.TabStop = False
        '
        'pctgate
        '
        Me.pctgate.BackColor = System.Drawing.Color.Transparent
        Me.pctgate.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.gatee
        Me.pctgate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctgate.Location = New System.Drawing.Point(-11, 512)
        Me.pctgate.Name = "pctgate"
        Me.pctgate.Size = New System.Drawing.Size(58, 88)
        Me.pctgate.TabIndex = 82
        Me.pctgate.TabStop = False
        '
        'boss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.snow2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1063, 646)
        Me.Controls.Add(Me.pctgate)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.pctboss)
        Me.Name = "boss"
        Me.Text = "boss"
        CType(Me.pctboss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctgate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctboss As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents pctgate As PictureBox
End Class
