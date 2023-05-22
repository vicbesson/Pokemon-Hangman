Imports System.IO
Public Class HangmanGame
    Dim Letters(25) As Button
    Dim words As New List(Of String)
    Dim Types1 As New List(Of String)
    Dim Types2 As New List(Of String)
    Dim typesymbol1 As String
    Dim typesymbol2 As String
    Dim AlreadyPicked As New List(Of String)
    Dim rng As New Random
    Dim PickedWordBox As New List(Of PictureBox)
    Dim PickedWordBoxText As New List(Of Label)
    Dim PickedWord As String
    Dim hangman As Integer
    Dim score As Integer
    Dim highscore As Integer
    Dim Current As Integer
    Private Sub HangmanGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr, sr2, sr3 As StreamReader
        Dim word, type1, type2
        sr = File.OpenText("PokemonNames.txt")
        sr2 = File.OpenText("PokemonTypes1.txt")
        sr3 = File.OpenText("PokemonTypes2.txt")
        Do
            word = sr.ReadLine
            words.Add(word)
            type1 = sr2.ReadLine
            Types1.Add(type1)
            type2 = sr3.ReadLine
            Types2.Add(type2)
        Loop Until sr.EndOfStream
        MakeLetters()
        sr.Close()
        sr2.Close()
        sr3.Close()
    End Sub
    Sub MakeLetters()
        Dim letter As Button
        Dim margin As Integer = 20
        Dim width As Integer = 50
        For i = 0 To 25
            letter = New Button
            letter.Text = Chr(65 + i)
            letter.Height = width
            letter.Width = width
            letter.FlatStyle = FlatStyle.Flat
            letter.Left = CInt(margin * 1.5 + (width + margin) * i + 50)
            letter.Top = 520
            letter.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular)
            letter.BackColor = Color.DarkGray
            letter.Enabled = False
            If i > 12 Then
                letter.Top = 590
                letter.Left = CInt(margin * 1.5 + (width + margin) * (i - 13) + 50)
            End If
            Controls.Add(letter)
            Letters(i) = letter
            AddHandler Letters(i).Click, AddressOf btnArray_Click
        Next
    End Sub
    Sub PickGeneration()
        Dim Generation As Integer
        If cbGeneration.SelectedIndex = 0 Then
            Generation = 1
        End If
        If cbGeneration.SelectedIndex = 1 Then
            Generation = 2
        End If
        If cbGeneration.SelectedIndex = 2 Then
            Generation = 3
        End If
        If cbGeneration.SelectedIndex = 3 Then
            Generation = 4
        End If
        If cbGeneration.SelectedIndex = 4 Then
            Generation = 5
        End If
        If cbGeneration.SelectedIndex = 5 Then
            Generation = 6
        End If
        lblFinish.Text = ""
        PickWord(Generation)
    End Sub
    Sub PickWord(ByVal Generation As Integer)
        Dim PickedWordLetters As PictureBox
        Dim PickedWordLettersText As Label
        Dim num As Integer
        Dim margin As Integer = 5
        Dim width As Integer = 40
        If Generation = 1 Then
            If AlreadyPicked.Count = 147 Then
                AlreadyPicked.Clear()
            End If
        End If
        If Generation = 2 Then
            If AlreadyPicked.Count = 98 Then
                AlreadyPicked.Clear()
            End If
        End If
        If Generation = 3 Then
            If AlreadyPicked.Count = 135 Then
                AlreadyPicked.Clear()
            End If
        End If
        If Generation = 4 Then
            If AlreadyPicked.Count = 106 Then
                AlreadyPicked.Clear()
            End If
        End If
        If Generation = 5 Then
            If AlreadyPicked.Count = 155 Then
                AlreadyPicked.Clear()
            End If
        End If
        If Generation = 6 Then
            If AlreadyPicked.Count = 69 Then
                AlreadyPicked.Clear()
            End If
        End If
        Do
            If Generation = 1 Then
                num = rng.Next(0, 147)
            End If
            If Generation = 2 Then
                num = rng.Next(147, 245)
            End If
            If Generation = 3 Then
                num = rng.Next(245, 380)
            End If
            If Generation = 4 Then
                num = rng.Next(380, 486)
            End If
            If Generation = 5 Then
                num = rng.Next(486, 641)
            End If
            If Generation = 6 Then
                num = rng.Next(641, 710)
            End If
            PickedWord = words(num)
        Loop Until AlreadyPicked.Contains(words(num)) = False
        AlreadyPicked.Add(PickedWord)
        For i = 0 To PickedWord.Length - 1
            PickedWordLetters = New PictureBox
            PickedWordLettersText = New Label
            PickedWordLetters.BorderStyle = BorderStyle.Fixed3D
            PickedWordLetters.Width = width
            PickedWordLetters.Height = width
            PickedWordLetters.BackColor = Color.White
            PickedWordLettersText.ForeColor = Color.Black
            PickedWordLettersText.Tag = PickedWord.Substring(i, 1).ToUpper
            PickedWordLettersText.Text = ""
            PickedWordLettersText.Left = 4
            PickedWordLettersText.Top = 4
            PickedWordLettersText.Font = New Font("Calibri", 18, FontStyle.Bold)
            PickedWordLetters.Left = CInt(margin * 1.5 + (width + margin) * i + 30)
            PickedWordLetters.Top = Height / 2
            PickedWordLetters.Controls.Add(PickedWordLettersText)
            Controls.Add(PickedWordLetters)
            PickedWordBox.Add(PickedWordLetters)
            PickedWordBoxText.Add(PickedWordLettersText)
        Next
        typesymbol1 = Types1(num)
        typesymbol2 = Types2(num)
        If typesymbol1 = "Bug" Then
            picType1.Image = My.Resources.BugType
        End If
        If typesymbol1 = "Dark" Then
            picType1.Image = My.Resources.DarkType
        End If
        If typesymbol1 = "Dragon" Then
            picType1.Image = My.Resources.DragonType
        End If
        If typesymbol1 = "Electric" Then
            picType1.Image = My.Resources.ElectricType
        End If
        If typesymbol1 = "Fairy" Then
            picType1.Image = My.Resources.FairyType
        End If
        If typesymbol1 = "Fighting" Then
            picType1.Image = My.Resources.FightingType
        End If
        If typesymbol1 = "Fire" Then
            picType1.Image = My.Resources.FireType
        End If
        If typesymbol1 = "Flying" Then
            picType1.Image = My.Resources.FlyingType
        End If
        If typesymbol1 = "Ghost" Then
            picType1.Image = My.Resources.GhostType
        End If
        If typesymbol1 = "Grass" Then
            picType1.Image = My.Resources.GrassType
        End If
        If typesymbol1 = "Ground" Then
            picType1.Image = My.Resources.GroundType
        End If
        If typesymbol1 = "Ice" Then
            picType1.Image = My.Resources.IceType
        End If
        If typesymbol1 = "Normal" Then
            picType1.Image = My.Resources.NormalType
        End If
        If typesymbol1 = "Poison" Then
            picType1.Image = My.Resources.PoisonType
        End If
        If typesymbol1 = "Psychic" Then
            picType1.Image = My.Resources.PsychicType
        End If
        If typesymbol1 = "Rock" Then
            picType1.Image = My.Resources.RockType
        End If
        If typesymbol1 = "Steel" Then
            picType1.Image = My.Resources.SteelType
        End If
        If typesymbol1 = "Water" Then
            picType1.Image = My.Resources.WaterType
        End If
        '-------------------------------------------------------------------------
        If typesymbol2 = "" Then
            PicType2.Image = Nothing
        End If
        If typesymbol2 = "Bug" Then
            PicType2.Image = My.Resources.BugType
        End If
        If typesymbol2 = "Dark" Then
            PicType2.Image = My.Resources.DarkType
        End If
        If typesymbol2 = "Dragon" Then
            PicType2.Image = My.Resources.DragonType
        End If
        If typesymbol2 = "Electric" Then
            PicType2.Image = My.Resources.ElectricType
        End If
        If typesymbol2 = "Fairy" Then
            PicType2.Image = My.Resources.FairyType
        End If
        If typesymbol2 = "Fighting" Then
            PicType2.Image = My.Resources.FightingType
        End If
        If typesymbol2 = "Fire" Then
            PicType2.Image = My.Resources.FireType
        End If
        If typesymbol2 = "Flying" Then
            PicType2.Image = My.Resources.FlyingType
        End If
        If typesymbol2 = "Ghost" Then
            PicType2.Image = My.Resources.GhostType
        End If
        If typesymbol2 = "Grass" Then
            PicType2.Image = My.Resources.GrassType
        End If
        If typesymbol2 = "Ground" Then
            PicType2.Image = My.Resources.GroundType
        End If
        If typesymbol2 = "Ice" Then
            PicType2.Image = My.Resources.IceType
        End If
        If typesymbol2 = "Normal" Then
            PicType2.Image = My.Resources.NormalType
        End If
        If typesymbol2 = "Poison" Then
            PicType2.Image = My.Resources.PoisonType
        End If
        If typesymbol2 = "Psychic" Then
            PicType2.Image = My.Resources.PsychicType
        End If
        If typesymbol2 = "Rock" Then
            PicType2.Image = My.Resources.RockType
        End If
        If typesymbol2 = "Steel" Then
            PicType2.Image = My.Resources.SteelType
        End If
        If typesymbol2 = "Water" Then
            PicType2.Image = My.Resources.WaterType
        End If
    End Sub
    Private Sub btnArray_Click(sender As Object, e As EventArgs)
        Dim Done As Boolean = True
        Dim Check As Boolean
        sender.backcolor = Color.DarkGray
        sender.enabled = False
        For i = 0 To PickedWord.Length - 1
            If sender.text.trim = PickedWordBoxText(i).Tag.Trim Then
                PickedWordBoxText(i).Text = PickedWordBoxText(i).Tag
                Check = True
            End If
        Next
        If Check = False Then
            hangman += 1
            draw(hangman)
            If hangman = 6 Then
                lblFinish.Text = "Try Again!"
                lblFinish.ForeColor = Color.Red
                btnReset.Text = "New Game"
                If highscore < score Then
                    highscore = score
                    lblHighScore.Text = highscore.ToString
                End If
                score = 0
                lblScore.Text = score.ToString
                For l = 0 To PickedWord.Length - 1
                    PickedWordBoxText(l).BackColor = Color.Red
                    PickedWordBox(l).BackColor = Color.Red
                    PickedWordBoxText(l).Text = PickedWordBoxText(l).Tag
                Next
                For k = 0 To Letters.Count - 1
                    Letters(k).BackColor = Color.DarkGray
                    Letters(k).Enabled = False
                Next
                Exit Sub
            End If
        End If
        For j = 0 To PickedWord.Length - 1
            If PickedWordBoxText(j).Text = "" Then
                Done = False
            End If
        Next
        If Done = True Then
            lblFinish.Text = "Good Job!"
            lblFinish.ForeColor = Color.Green
            score += 1
            lblScore.Text = score.ToString
            For p = 0 To Letters.Count - 1
                Letters(p).BackColor = Color.DarkGray
                Letters(p).Enabled = False
            Next
            For o = 0 To PickedWord.Length - 1
                PickedWordBoxText(o).BackColor = Color.Green
                PickedWordBox(o).BackColor = Color.Green
                PickedWordBoxText(o).ForeColor = Color.White
            Next
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        hangman = 0
        For i = 0 To PickedWordBox.Count - 1
            Controls.Remove(PickedWordBox(i))
        Next
        For j = 0 To Letters.Count - 1
            Letters(j).Enabled = True
            Letters(j).BackColor = Color.LightGray
        Next
        If btnReset.Text = "New Game" Then
            If highscore < score Then
                highscore = score
                lblHighScore.Text = highscore.ToString
            End If
            score = 0
            lblScore.Text = score.ToString
        End If
        If lblFinish.Text <> "Good Job!" Then
            If highscore < score Then
                highscore = score
                lblHighScore.Text = highscore.ToString
            End If
            score = 0
            lblScore.Text = score.ToString
        End If
        If btnReset.Text = "New Game" Then
            btnReset.Text = "Next"
        End If
        Current = cbGeneration.SelectedIndex
        PickedWordBox.Clear()
        PickedWordBoxText.Clear()
        PickGeneration()
        draw(hangman)
    End Sub
    Sub draw(ByVal hangman As Integer)
        Dim body, rleg, lleg, rarm, larm, head As Graphics
        body = PicBody.CreateGraphics
        rleg = PicRightLeg.CreateGraphics
        lleg = PicLeftLeg.CreateGraphics
        larm = PicLeftArm.CreateGraphics
        rarm = picRightArm.CreateGraphics
        head = PicHead.CreateGraphics
        Dim blackpen As New Pen(Color.Black, 3)
        Dim blackbrush As Brush = Brushes.Black
        Dim Redbrush As Brush = Brushes.Red
        Dim Redpen As New Pen(Color.Red, 3)
        If hangman = 0 Then
            PicBody.Invalidate()
            PicLeftArm.Invalidate()
            picRightArm.Invalidate()
            PicLeftLeg.Invalidate()
            PicRightLeg.Invalidate()
            PicHead.Invalidate()
        End If
        If hangman = 1 Then
            head.FillEllipse(blackbrush, 0, 0, 44, 44)
        End If
        If hangman = 2 Then
            body.DrawLine(blackpen, New Point(10, 0), New Point(10, 68))
        End If
        If hangman = 3 Then
            larm.DrawLine(blackpen, New Point(54, 0), New Point(0, 44))
        End If
        If hangman = 4 Then
            rarm.DrawLine(blackpen, New Point(0, 0), New Point(54, 44))
        End If
        If hangman = 5 Then
            lleg.DrawLine(blackpen, New Point(0, 45), New Point(45, 0))
        End If
        If hangman = 6 Then
            rleg.DrawLine(Redpen, New Point(0, 0), New Point(45, 45))
            head.FillEllipse(Redbrush, 0, 0, 44, 44)
            body.DrawLine(Redpen, New Point(10, 0), New Point(10, 68))
            larm.DrawLine(Redpen, New Point(54, 0), New Point(0, 44))
            rarm.DrawLine(Redpen, New Point(0, 0), New Point(54, 44))
            lleg.DrawLine(Redpen, New Point(0, 45), New Point(45, 0))
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cbGeneration.SelectedIndex < 0 Then
            lblPickGeneration.ForeColor = Color.Red
            Exit Sub
        End If
        For j = 0 To Letters.Count - 1
            Letters(j).Enabled = True
            Letters(j).BackColor = Color.LightGray
        Next
        Current = cbGeneration.SelectedIndex
        btnReset.Text = "Next"
        lblScoretxt.Text = "Score:"
        lblScore.Text = "0"
        lblHighscoretxt.Text = "Highscore:"
        lblHighScore.Text = "0"
        lblPickGeneration.ForeColor = Color.Black
        btnStart.Hide()
        btnReset.Show()
        PicGallows.Show()
        PickGeneration()
    End Sub
    Private Sub cbGeneration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGeneration.SelectedIndexChanged
        AlreadyPicked.Clear()
        If Current <> cbGeneration.SelectedIndex Then
            btnReset.Text = "New Game"
        End If
        If Current = cbGeneration.SelectedIndex And lblFinish.Text <> "Try Again!" Then
            btnReset.Text = "Next"
        End If
    End Sub
End Class
