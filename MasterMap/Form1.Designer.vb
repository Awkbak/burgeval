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
        Me.box_divisions = New System.Windows.Forms.ComboBox()
        Me.lbl_division = New System.Windows.Forms.Label()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.lst_players_available = New System.Windows.Forms.ListView()
        Me.btn_lockin = New System.Windows.Forms.Button()
        Me.lbl_picking = New System.Windows.Forms.Label()
        Me.lbl_scores = New System.Windows.Forms.Label()
        Me.btn_Finish = New System.Windows.Forms.Button()
        Me.lbl_plycount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'box_divisions
        '
        Me.box_divisions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_divisions.FormattingEnabled = True
        Me.box_divisions.Items.AddRange(New Object() {"U13B", "U13G", "U15B", "U15G", "U18"})
        Me.box_divisions.Location = New System.Drawing.Point(12, 28)
        Me.box_divisions.Name = "box_divisions"
        Me.box_divisions.Size = New System.Drawing.Size(121, 24)
        Me.box_divisions.TabIndex = 0
        Me.box_divisions.Text = "U13B"
        '
        'lbl_division
        '
        Me.lbl_division.AutoSize = True
        Me.lbl_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_division.Location = New System.Drawing.Point(13, 9)
        Me.lbl_division.Name = "lbl_division"
        Me.lbl_division.Size = New System.Drawing.Size(113, 16)
        Me.lbl_division.TabIndex = 1
        Me.lbl_division.Text = "Player Division"
        '
        'btn_apply
        '
        Me.btn_apply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply.Location = New System.Drawing.Point(16, 55)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_apply.TabIndex = 2
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'lst_players_available
        '
        Me.lst_players_available.AllowColumnReorder = True
        Me.lst_players_available.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_players_available.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_players_available.FullRowSelect = True
        Me.lst_players_available.GridLines = True
        Me.lst_players_available.Location = New System.Drawing.Point(330, 43)
        Me.lst_players_available.MinimumSize = New System.Drawing.Size(20, 40)
        Me.lst_players_available.Name = "lst_players_available"
        Me.lst_players_available.Size = New System.Drawing.Size(666, 656)
        Me.lst_players_available.TabIndex = 3
        Me.lst_players_available.TileSize = New System.Drawing.Size(2, 2)
        Me.lst_players_available.UseCompatibleStateImageBehavior = False
        Me.lst_players_available.View = System.Windows.Forms.View.Details
        '
        'btn_lockin
        '
        Me.btn_lockin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lockin.Location = New System.Drawing.Point(164, 178)
        Me.btn_lockin.Name = "btn_lockin"
        Me.btn_lockin.Size = New System.Drawing.Size(144, 39)
        Me.btn_lockin.TabIndex = 5
        Me.btn_lockin.Text = "Lock-In Choice"
        Me.btn_lockin.UseVisualStyleBackColor = True
        '
        'lbl_picking
        '
        Me.lbl_picking.AutoSize = True
        Me.lbl_picking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_picking.Location = New System.Drawing.Point(597, 20)
        Me.lbl_picking.Name = "lbl_picking"
        Me.lbl_picking.Size = New System.Drawing.Size(115, 20)
        Me.lbl_picking.TabIndex = 6
        Me.lbl_picking.Text = "Picking Now: "
        '
        'lbl_scores
        '
        Me.lbl_scores.AutoSize = True
        Me.lbl_scores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scores.Location = New System.Drawing.Point(8, 262)
        Me.lbl_scores.Name = "lbl_scores"
        Me.lbl_scores.Size = New System.Drawing.Size(117, 20)
        Me.lbl_scores.TabIndex = 7
        Me.lbl_scores.Text = "Coach, Score"
        '
        'btn_Finish
        '
        Me.btn_Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finish.Location = New System.Drawing.Point(601, 705)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.Size = New System.Drawing.Size(116, 46)
        Me.btn_Finish.TabIndex = 8
        Me.btn_Finish.Text = "Finish Draft"
        Me.btn_Finish.UseVisualStyleBackColor = True
        '
        'lbl_plycount
        '
        Me.lbl_plycount.AutoSize = True
        Me.lbl_plycount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plycount.Location = New System.Drawing.Point(207, 262)
        Me.lbl_plycount.Name = "lbl_plycount"
        Me.lbl_plycount.Size = New System.Drawing.Size(111, 20)
        Me.lbl_plycount.TabIndex = 9
        Me.lbl_plycount.Text = "Player Count"
        Me.lbl_plycount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 763)
        Me.Controls.Add(Me.lbl_plycount)
        Me.Controls.Add(Me.btn_Finish)
        Me.Controls.Add(Me.lbl_scores)
        Me.Controls.Add(Me.lbl_picking)
        Me.Controls.Add(Me.btn_lockin)
        Me.Controls.Add(Me.lst_players_available)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.lbl_division)
        Me.Controls.Add(Me.box_divisions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents box_divisions As ComboBox
    Friend WithEvents lbl_division As Label
    Friend WithEvents btn_apply As Button
    Friend WithEvents lst_players_available As ListView
    Friend WithEvents btn_lockin As Button
    Friend WithEvents lbl_picking As Label
    Friend WithEvents lbl_scores As Label
    Friend WithEvents btn_Finish As Button
    Friend WithEvents lbl_plycount As Label
End Class
