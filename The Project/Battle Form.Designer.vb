<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Battle_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Battle_Form))
        Me.btnbattle = New System.Windows.Forms.Button()
        Me.lblEnemyDefence = New System.Windows.Forms.Label()
        Me.lblEnemyOffence = New System.Windows.Forms.Label()
        Me.lblEnemyHp = New System.Windows.Forms.Label()
        Me.lblHeroDefence = New System.Windows.Forms.Label()
        Me.lblHeroOffence = New System.Windows.Forms.Label()
        Me.lblHeroHp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctHero = New System.Windows.Forms.PictureBox()
        Me.pctEnemy = New System.Windows.Forms.PictureBox()
        CType(Me.pctHero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbattle
        '
        Me.btnbattle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbattle.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbattle.Location = New System.Drawing.Point(461, 410)
        Me.btnbattle.Name = "btnbattle"
        Me.btnbattle.Size = New System.Drawing.Size(116, 68)
        Me.btnbattle.TabIndex = 35
        Me.btnbattle.Text = "Battle!"
        Me.btnbattle.UseVisualStyleBackColor = False
        '
        'lblEnemyDefence
        '
        Me.lblEnemyDefence.AutoSize = True
        Me.lblEnemyDefence.Location = New System.Drawing.Point(800, 449)
        Me.lblEnemyDefence.Name = "lblEnemyDefence"
        Me.lblEnemyDefence.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyDefence.TabIndex = 33
        Me.lblEnemyDefence.Text = "0"
        '
        'lblEnemyOffence
        '
        Me.lblEnemyOffence.AutoSize = True
        Me.lblEnemyOffence.Location = New System.Drawing.Point(800, 410)
        Me.lblEnemyOffence.Name = "lblEnemyOffence"
        Me.lblEnemyOffence.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyOffence.TabIndex = 32
        Me.lblEnemyOffence.Text = "0"
        '
        'lblEnemyHp
        '
        Me.lblEnemyHp.AutoSize = True
        Me.lblEnemyHp.Location = New System.Drawing.Point(800, 371)
        Me.lblEnemyHp.Name = "lblEnemyHp"
        Me.lblEnemyHp.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyHp.TabIndex = 31
        Me.lblEnemyHp.Text = "0"
        '
        'lblHeroDefence
        '
        Me.lblHeroDefence.AutoSize = True
        Me.lblHeroDefence.Location = New System.Drawing.Point(270, 449)
        Me.lblHeroDefence.Name = "lblHeroDefence"
        Me.lblHeroDefence.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroDefence.TabIndex = 30
        Me.lblHeroDefence.Text = "0"
        '
        'lblHeroOffence
        '
        Me.lblHeroOffence.AutoSize = True
        Me.lblHeroOffence.Location = New System.Drawing.Point(270, 410)
        Me.lblHeroOffence.Name = "lblHeroOffence"
        Me.lblHeroOffence.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroOffence.TabIndex = 29
        Me.lblHeroOffence.Text = "0"
        '
        'lblHeroHp
        '
        Me.lblHeroHp.AutoSize = True
        Me.lblHeroHp.Location = New System.Drawing.Point(270, 371)
        Me.lblHeroHp.Name = "lblHeroHp"
        Me.lblHeroHp.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroHp.TabIndex = 28
        Me.lblHeroHp.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Defence"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Offence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(654, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = " HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Defence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Offence"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = " HP"
        '
        'pctHero
        '
        Me.pctHero.BackColor = System.Drawing.Color.Transparent
        Me.pctHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctHero.Image = Global.WindowsApplication1.My.Resources.Resources.corg
        Me.pctHero.InitialImage = CType(resources.GetObject("pctHero.InitialImage"), System.Drawing.Image)
        Me.pctHero.Location = New System.Drawing.Point(142, 135)
        Me.pctHero.Name = "pctHero"
        Me.pctHero.Size = New System.Drawing.Size(238, 211)
        Me.pctHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHero.TabIndex = 21
        Me.pctHero.TabStop = False
        '
        'pctEnemy
        '
        Me.pctEnemy.BackColor = System.Drawing.Color.Transparent
        Me.pctEnemy.Location = New System.Drawing.Point(657, 135)
        Me.pctEnemy.Name = "pctEnemy"
        Me.pctEnemy.Size = New System.Drawing.Size(238, 211)
        Me.pctEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEnemy.TabIndex = 20
        Me.pctEnemy.TabStop = False
        '
        'Battle_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.elk_forest
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.btnbattle)
        Me.Controls.Add(Me.lblEnemyDefence)
        Me.Controls.Add(Me.lblEnemyOffence)
        Me.Controls.Add(Me.lblEnemyHp)
        Me.Controls.Add(Me.lblHeroDefence)
        Me.Controls.Add(Me.lblHeroOffence)
        Me.Controls.Add(Me.lblHeroHp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctHero)
        Me.Controls.Add(Me.pctEnemy)
        Me.Name = "Battle_Form"
        Me.Text = "Battle_Form"
        CType(Me.pctHero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbattle As Button
    Friend WithEvents lblEnemyDefence As Label
    Friend WithEvents lblEnemyOffence As Label
    Friend WithEvents lblEnemyHp As Label
    Friend WithEvents lblHeroDefence As Label
    Friend WithEvents lblHeroOffence As Label
    Friend WithEvents lblHeroHp As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pctHero As PictureBox
    Friend WithEvents pctEnemy As PictureBox
End Class
