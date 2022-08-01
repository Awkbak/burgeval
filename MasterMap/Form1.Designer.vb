<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.lst_players_available = New System.Windows.Forms.ListView()
        Me.btn_lockin = New System.Windows.Forms.Button()
        Me.lbl_picking = New System.Windows.Forms.Label()
        Me.lbl_scores = New System.Windows.Forms.Label()
        Me.btn_Finish = New System.Windows.Forms.Button()
        Me.lbl_plycount = New System.Windows.Forms.Label()
        Me.lbl_div_main = New System.Windows.Forms.Label()
        Me.lbl_div_coach = New System.Windows.Forms.Label()
        Me.btn_pick_div = New System.Windows.Forms.Button()
        Me.btn_pick_coach = New System.Windows.Forms.Button()
        Me.txt_div_main = New System.Windows.Forms.TextBox()
        Me.txt_div_coach = New System.Windows.Forms.TextBox()
        Me.chk_is_u18 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_apply
        '
        Me.btn_apply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply.Location = New System.Drawing.Point(162, 79)
        Me.btn_apply.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(100, 28)
        Me.btn_apply.TabIndex = 2
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'lst_players_available
        '
        Me.lst_players_available.AllowColumnReorder = True
        Me.lst_players_available.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_players_available.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_players_available.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_players_available.FullRowSelect = True
        Me.lst_players_available.GridLines = True
        Me.lst_players_available.HideSelection = False
        Me.lst_players_available.Location = New System.Drawing.Point(440, 53)
        Me.lst_players_available.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_players_available.MinimumSize = New System.Drawing.Size(27, 49)
        Me.lst_players_available.Name = "lst_players_available"
        Me.lst_players_available.Size = New System.Drawing.Size(888, 807)
        Me.lst_players_available.TabIndex = 3
        Me.lst_players_available.TileSize = New System.Drawing.Size(2, 2)
        Me.lst_players_available.UseCompatibleStateImageBehavior = False
        Me.lst_players_available.View = System.Windows.Forms.View.Details
        '
        'btn_lockin
        '
        Me.btn_lockin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lockin.Location = New System.Drawing.Point(240, 258)
        Me.btn_lockin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_lockin.Name = "btn_lockin"
        Me.btn_lockin.Size = New System.Drawing.Size(192, 48)
        Me.btn_lockin.TabIndex = 5
        Me.btn_lockin.Text = "Lock-In Choice"
        Me.btn_lockin.UseVisualStyleBackColor = True
        '
        'lbl_picking
        '
        Me.lbl_picking.AutoSize = True
        Me.lbl_picking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_picking.Location = New System.Drawing.Point(796, 25)
        Me.lbl_picking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_picking.Name = "lbl_picking"
        Me.lbl_picking.Size = New System.Drawing.Size(143, 25)
        Me.lbl_picking.TabIndex = 6
        Me.lbl_picking.Text = "Picking Now: "
        '
        'lbl_scores
        '
        Me.lbl_scores.AutoSize = True
        Me.lbl_scores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scores.Location = New System.Drawing.Point(11, 322)
        Me.lbl_scores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_scores.Name = "lbl_scores"
        Me.lbl_scores.Size = New System.Drawing.Size(144, 25)
        Me.lbl_scores.TabIndex = 7
        Me.lbl_scores.Text = "Coach, Score"
        '
        'btn_Finish
        '
        Me.btn_Finish.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finish.Location = New System.Drawing.Point(801, 868)
        Me.btn_Finish.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.Size = New System.Drawing.Size(155, 57)
        Me.btn_Finish.TabIndex = 8
        Me.btn_Finish.Text = "Finish Draft"
        Me.btn_Finish.UseVisualStyleBackColor = True
        '
        'lbl_plycount
        '
        Me.lbl_plycount.AutoSize = True
        Me.lbl_plycount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plycount.Location = New System.Drawing.Point(276, 322)
        Me.lbl_plycount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plycount.Name = "lbl_plycount"
        Me.lbl_plycount.Size = New System.Drawing.Size(137, 25)
        Me.lbl_plycount.TabIndex = 9
        Me.lbl_plycount.Text = "Player Count"
        Me.lbl_plycount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_div_main
        '
        Me.lbl_div_main.AutoSize = True
        Me.lbl_div_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_div_main.Location = New System.Drawing.Point(13, 9)
        Me.lbl_div_main.Name = "lbl_div_main"
        Me.lbl_div_main.Size = New System.Drawing.Size(101, 17)
        Me.lbl_div_main.TabIndex = 10
        Me.lbl_div_main.Text = "Division File:"
        '
        'lbl_div_coach
        '
        Me.lbl_div_coach.AutoSize = True
        Me.lbl_div_coach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_div_coach.Location = New System.Drawing.Point(13, 39)
        Me.lbl_div_coach.Name = "lbl_div_coach"
        Me.lbl_div_coach.Size = New System.Drawing.Size(89, 17)
        Me.lbl_div_coach.TabIndex = 12
        Me.lbl_div_coach.Text = "Coach File:"
        '
        'btn_pick_div
        '
        Me.btn_pick_div.Location = New System.Drawing.Point(358, 3)
        Me.btn_pick_div.Name = "btn_pick_div"
        Me.btn_pick_div.Size = New System.Drawing.Size(75, 23)
        Me.btn_pick_div.TabIndex = 13
        Me.btn_pick_div.Text = "Choose"
        Me.btn_pick_div.UseVisualStyleBackColor = True
        '
        'btn_pick_coach
        '
        Me.btn_pick_coach.Location = New System.Drawing.Point(357, 36)
        Me.btn_pick_coach.Name = "btn_pick_coach"
        Me.btn_pick_coach.Size = New System.Drawing.Size(75, 23)
        Me.btn_pick_coach.TabIndex = 14
        Me.btn_pick_coach.Text = "Choose"
        Me.btn_pick_coach.UseVisualStyleBackColor = True
        '
        'txt_div_main
        '
        Me.txt_div_main.Location = New System.Drawing.Point(120, 6)
        Me.txt_div_main.Name = "txt_div_main"
        Me.txt_div_main.ReadOnly = True
        Me.txt_div_main.Size = New System.Drawing.Size(202, 22)
        Me.txt_div_main.TabIndex = 15
        '
        'txt_div_coach
        '
        Me.txt_div_coach.Location = New System.Drawing.Point(120, 36)
        Me.txt_div_coach.Name = "txt_div_coach"
        Me.txt_div_coach.ReadOnly = True
        Me.txt_div_coach.Size = New System.Drawing.Size(202, 22)
        Me.txt_div_coach.TabIndex = 16
        '
        'chk_is_u18
        '
        Me.chk_is_u18.AutoSize = True
        Me.chk_is_u18.Location = New System.Drawing.Point(66, 85)
        Me.chk_is_u18.Name = "chk_is_u18"
        Me.chk_is_u18.Size = New System.Drawing.Size(73, 20)
        Me.chk_is_u18.TabIndex = 17
        Me.chk_is_u18.Text = "Is U18?"
        Me.chk_is_u18.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 939)
        Me.Controls.Add(Me.chk_is_u18)
        Me.Controls.Add(Me.txt_div_coach)
        Me.Controls.Add(Me.txt_div_main)
        Me.Controls.Add(Me.btn_pick_coach)
        Me.Controls.Add(Me.btn_pick_div)
        Me.Controls.Add(Me.lbl_div_coach)
        Me.Controls.Add(Me.lbl_div_main)
        Me.Controls.Add(Me.lbl_plycount)
        Me.Controls.Add(Me.btn_Finish)
        Me.Controls.Add(Me.lbl_scores)
        Me.Controls.Add(Me.lbl_picking)
        Me.Controls.Add(Me.btn_lockin)
        Me.Controls.Add(Me.lst_players_available)
        Me.Controls.Add(Me.btn_apply)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_apply As Button
    Friend WithEvents lst_players_available As ListView
    Friend WithEvents btn_lockin As Button
    Friend WithEvents lbl_picking As Label
    Friend WithEvents lbl_scores As Label
    Friend WithEvents btn_Finish As Button
    Friend WithEvents lbl_plycount As Label
    Friend WithEvents lbl_div_main As Label
    Friend WithEvents lbl_div_coach As Label
    Friend WithEvents btn_pick_div As Button
    Friend WithEvents btn_pick_coach As Button
    Friend WithEvents txt_div_main As TextBox
    Friend WithEvents txt_div_coach As TextBox
    Friend WithEvents chk_is_u18 As CheckBox
End Class
