<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HangmanGame
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PicLeftLeg = New System.Windows.Forms.PictureBox()
        Me.PicRightLeg = New System.Windows.Forms.PictureBox()
        Me.PicLeftArm = New System.Windows.Forms.PictureBox()
        Me.picRightArm = New System.Windows.Forms.PictureBox()
        Me.PicBody = New System.Windows.Forms.PictureBox()
        Me.PicHead = New System.Windows.Forms.PictureBox()
        Me.PicType2 = New System.Windows.Forms.PictureBox()
        Me.picType1 = New System.Windows.Forms.PictureBox()
        Me.PicGallows = New System.Windows.Forms.PictureBox()
        Me.cbGeneration = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblPickGeneration = New System.Windows.Forms.Label()
        Me.lblScoretxt = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblHighscoretxt = New System.Windows.Forms.Label()
        Me.PicPokemon = New System.Windows.Forms.PictureBox()
        CType(Me.PicLeftLeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRightLeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLeftArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picType1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGallows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightGray
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(37, 418)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(146, 49)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Next"
        Me.btnReset.UseVisualStyleBackColor = False
        Me.btnReset.Visible = False
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.BackColor = System.Drawing.Color.Transparent
        Me.lblFinish.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinish.Location = New System.Drawing.Point(413, 248)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(0, 45)
        Me.lblFinish.TabIndex = 9
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightGray
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(902, 12)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(143, 57)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'PicLeftLeg
        '
        Me.PicLeftLeg.BackColor = System.Drawing.Color.Transparent
        Me.PicLeftLeg.Location = New System.Drawing.Point(807, 278)
        Me.PicLeftLeg.Name = "PicLeftLeg"
        Me.PicLeftLeg.Size = New System.Drawing.Size(45, 45)
        Me.PicLeftLeg.TabIndex = 3
        Me.PicLeftLeg.TabStop = False
        '
        'PicRightLeg
        '
        Me.PicRightLeg.BackColor = System.Drawing.Color.Transparent
        Me.PicRightLeg.Location = New System.Drawing.Point(852, 278)
        Me.PicRightLeg.Name = "PicRightLeg"
        Me.PicRightLeg.Size = New System.Drawing.Size(45, 45)
        Me.PicRightLeg.TabIndex = 8
        Me.PicRightLeg.TabStop = False
        '
        'PicLeftArm
        '
        Me.PicLeftArm.BackColor = System.Drawing.Color.Transparent
        Me.PicLeftArm.Location = New System.Drawing.Point(798, 222)
        Me.PicLeftArm.Name = "PicLeftArm"
        Me.PicLeftArm.Size = New System.Drawing.Size(52, 44)
        Me.PicLeftArm.TabIndex = 7
        Me.PicLeftArm.TabStop = False
        '
        'picRightArm
        '
        Me.picRightArm.BackColor = System.Drawing.Color.Transparent
        Me.picRightArm.Location = New System.Drawing.Point(854, 223)
        Me.picRightArm.Name = "picRightArm"
        Me.picRightArm.Size = New System.Drawing.Size(54, 44)
        Me.picRightArm.TabIndex = 5
        Me.picRightArm.TabStop = False
        '
        'PicBody
        '
        Me.PicBody.BackColor = System.Drawing.Color.Transparent
        Me.PicBody.Location = New System.Drawing.Point(842, 213)
        Me.PicBody.Name = "PicBody"
        Me.PicBody.Size = New System.Drawing.Size(20, 68)
        Me.PicBody.TabIndex = 6
        Me.PicBody.TabStop = False
        '
        'PicHead
        '
        Me.PicHead.BackColor = System.Drawing.Color.Transparent
        Me.PicHead.Location = New System.Drawing.Point(830, 169)
        Me.PicHead.Name = "PicHead"
        Me.PicHead.Size = New System.Drawing.Size(50, 50)
        Me.PicHead.TabIndex = 2
        Me.PicHead.TabStop = False
        '
        'PicType2
        '
        Me.PicType2.BackColor = System.Drawing.Color.Transparent
        Me.PicType2.Location = New System.Drawing.Point(162, 278)
        Me.PicType2.Name = "PicType2"
        Me.PicType2.Size = New System.Drawing.Size(124, 41)
        Me.PicType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicType2.TabIndex = 14
        Me.PicType2.TabStop = False
        '
        'picType1
        '
        Me.picType1.BackColor = System.Drawing.Color.Transparent
        Me.picType1.Location = New System.Drawing.Point(32, 278)
        Me.picType1.Name = "picType1"
        Me.picType1.Size = New System.Drawing.Size(124, 41)
        Me.picType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picType1.TabIndex = 13
        Me.picType1.TabStop = False
        '
        'PicGallows
        '
        Me.PicGallows.BackColor = System.Drawing.Color.Transparent
        Me.PicGallows.Image = Global.HangmanGame.My.Resources.Resources.hangman_game_13
        Me.PicGallows.Location = New System.Drawing.Point(637, -43)
        Me.PicGallows.Name = "PicGallows"
        Me.PicGallows.Size = New System.Drawing.Size(674, 546)
        Me.PicGallows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicGallows.TabIndex = 10
        Me.PicGallows.TabStop = False
        Me.PicGallows.Visible = False
        '
        'cbGeneration
        '
        Me.cbGeneration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneration.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGeneration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbGeneration.FormattingEnabled = True
        Me.cbGeneration.Items.AddRange(New Object() {"Gen 1", "Gen 2", "Gen 3", "Gen 4", "Gen 5", "Gen 6"})
        Me.cbGeneration.Location = New System.Drawing.Point(37, 60)
        Me.cbGeneration.Name = "cbGeneration"
        Me.cbGeneration.Size = New System.Drawing.Size(146, 33)
        Me.cbGeneration.TabIndex = 15
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightGray
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(37, 418)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(146, 49)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblPickGeneration
        '
        Me.lblPickGeneration.AutoSize = True
        Me.lblPickGeneration.BackColor = System.Drawing.Color.Transparent
        Me.lblPickGeneration.Font = New System.Drawing.Font("OCR A Extended", 15.75!)
        Me.lblPickGeneration.Location = New System.Drawing.Point(33, 21)
        Me.lblPickGeneration.Name = "lblPickGeneration"
        Me.lblPickGeneration.Size = New System.Drawing.Size(205, 23)
        Me.lblPickGeneration.TabIndex = 17
        Me.lblPickGeneration.Text = "Pick Generation"
        '
        'lblScoretxt
        '
        Me.lblScoretxt.AutoSize = True
        Me.lblScoretxt.BackColor = System.Drawing.Color.Transparent
        Me.lblScoretxt.Font = New System.Drawing.Font("OCR A Extended", 15.75!)
        Me.lblScoretxt.Location = New System.Drawing.Point(585, 450)
        Me.lblScoretxt.Name = "lblScoretxt"
        Me.lblScoretxt.Size = New System.Drawing.Size(0, 23)
        Me.lblScoretxt.TabIndex = 18
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(672, 450)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 23)
        Me.lblScore.TabIndex = 19
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.Transparent
        Me.lblHighScore.Font = New System.Drawing.Font("OCR A Extended", 15.75!)
        Me.lblHighScore.Location = New System.Drawing.Point(979, 450)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(0, 23)
        Me.lblHighScore.TabIndex = 21
        '
        'lblHighscoretxt
        '
        Me.lblHighscoretxt.AutoSize = True
        Me.lblHighscoretxt.BackColor = System.Drawing.Color.Transparent
        Me.lblHighscoretxt.Font = New System.Drawing.Font("OCR A Extended", 15.75!)
        Me.lblHighscoretxt.Location = New System.Drawing.Point(841, 450)
        Me.lblHighscoretxt.Name = "lblHighscoretxt"
        Me.lblHighscoretxt.Size = New System.Drawing.Size(0, 23)
        Me.lblHighscoretxt.TabIndex = 20
        '
        'PicPokemon
        '
        Me.PicPokemon.BackColor = System.Drawing.Color.Transparent
        Me.PicPokemon.Image = Global.HangmanGame.My.Resources.Resources.PokemonLogo
        Me.PicPokemon.Location = New System.Drawing.Point(420, 12)
        Me.PicPokemon.Name = "PicPokemon"
        Me.PicPokemon.Size = New System.Drawing.Size(246, 104)
        Me.PicPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPokemon.TabIndex = 22
        Me.PicPokemon.TabStop = False
        '
        'HangmanGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImage = Global.HangmanGame.My.Resources.Resources.PokemonBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1057, 677)
        Me.Controls.Add(Me.PicPokemon)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblHighscoretxt)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoretxt)
        Me.Controls.Add(Me.lblPickGeneration)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cbGeneration)
        Me.Controls.Add(Me.PicLeftLeg)
        Me.Controls.Add(Me.PicRightLeg)
        Me.Controls.Add(Me.PicLeftArm)
        Me.Controls.Add(Me.picRightArm)
        Me.Controls.Add(Me.PicBody)
        Me.Controls.Add(Me.PicHead)
        Me.Controls.Add(Me.PicType2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lblFinish)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.picType1)
        Me.Controls.Add(Me.PicGallows)
        Me.MaximumSize = New System.Drawing.Size(1073, 716)
        Me.MinimumSize = New System.Drawing.Size(1073, 716)
        Me.Name = "HangmanGame"
        Me.Text = "Pokemon Hangman by Victor Besson"
        CType(Me.PicLeftLeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRightLeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLeftArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picType1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGallows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As Button
    Friend WithEvents PicHead As PictureBox
    Friend WithEvents PicLeftLeg As PictureBox
    Friend WithEvents picRightArm As PictureBox
    Friend WithEvents PicBody As PictureBox
    Friend WithEvents PicLeftArm As PictureBox
    Friend WithEvents PicRightLeg As PictureBox
    Friend WithEvents lblFinish As Label
    Friend WithEvents PicGallows As PictureBox
    Friend WithEvents btnexit As Button
    Friend WithEvents picType1 As PictureBox
    Friend WithEvents PicType2 As PictureBox
    Friend WithEvents cbGeneration As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblPickGeneration As Label
    Friend WithEvents lblScoretxt As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblHighscoretxt As Label
    Friend WithEvents PicPokemon As PictureBox
End Class
