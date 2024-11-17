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
        lstTaille = New ComboBox()
        rd_1 = New RadioButton()
        rd_2 = New RadioButton()
        rd_3 = New RadioButton()
        chk_1 = New CheckBox()
        chk_2 = New CheckBox()
        chk_3 = New CheckBox()
        chk_4 = New CheckBox()
        btn = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstTaille
        ' 
        lstTaille.BackColor = Color.Sienna
        lstTaille.Font = New Font("Microsoft PhagsPa", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lstTaille.FormattingEnabled = True
        lstTaille.Items.AddRange(New Object() {"petite ", "moyenne ", "grande "})
        lstTaille.Location = New Point(90, 23)
        lstTaille.Name = "lstTaille"
        lstTaille.Size = New Size(193, 28)
        lstTaille.TabIndex = 0
        lstTaille.Text = "La taille du Pizza"
        ' 
        ' rd_1
        ' 
        rd_1.AutoSize = True
        rd_1.BackColor = Color.LightGray
        rd_1.Font = New Font("Microsoft Tai Le", 11F, FontStyle.Italic)
        rd_1.Location = New Point(16, 34)
        rd_1.Name = "rd_1"
        rd_1.Size = New Size(104, 23)
        rd_1.TabIndex = 1
        rd_1.TabStop = True
        rd_1.Text = "Croute fine "
        rd_1.UseVisualStyleBackColor = False
        ' 
        ' rd_2
        ' 
        rd_2.AutoSize = True
        rd_2.BackColor = Color.LightGray
        rd_2.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rd_2.Location = New Point(165, 34)
        rd_2.Name = "rd_2"
        rd_2.Size = New Size(139, 23)
        rd_2.TabIndex = 2
        rd_2.TabStop = True
        rd_2.Text = "Croute classique "
        rd_2.UseVisualStyleBackColor = False
        ' 
        ' rd_3
        ' 
        rd_3.AutoSize = True
        rd_3.BackColor = Color.LightGray
        rd_3.Font = New Font("Microsoft Tai Le", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rd_3.Location = New Point(346, 34)
        rd_3.Name = "rd_3"
        rd_3.Size = New Size(124, 23)
        rd_3.TabIndex = 3
        rd_3.TabStop = True
        rd_3.Text = "Croute épaisse"
        rd_3.UseVisualStyleBackColor = False
        ' 
        ' chk_1
        ' 
        chk_1.AutoSize = True
        chk_1.BackColor = SystemColors.ActiveCaption
        chk_1.Font = New Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chk_1.Location = New Point(16, 35)
        chk_1.Name = "chk_1"
        chk_1.Size = New Size(112, 21)
        chk_1.TabIndex = 4
        chk_1.Text = "Champignons"
        chk_1.UseVisualStyleBackColor = False
        ' 
        ' chk_2
        ' 
        chk_2.AutoSize = True
        chk_2.BackColor = SystemColors.ActiveCaption
        chk_2.Font = New Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chk_2.Location = New Point(101, 73)
        chk_2.Name = "chk_2"
        chk_2.Size = New Size(65, 21)
        chk_2.TabIndex = 5
        chk_2.Text = "Olives"
        chk_2.UseVisualStyleBackColor = False
        ' 
        ' chk_3
        ' 
        chk_3.AutoSize = True
        chk_3.BackColor = SystemColors.ActiveCaption
        chk_3.Font = New Font("Nirmala UI", 10F, FontStyle.Bold)
        chk_3.Location = New Point(218, 33)
        chk_3.Name = "chk_3"
        chk_3.Size = New Size(86, 23)
        chk_3.TabIndex = 6
        chk_3.Text = "Poivrons"
        chk_3.UseVisualStyleBackColor = False
        ' 
        ' chk_4
        ' 
        chk_4.AutoSize = True
        chk_4.BackColor = SystemColors.ActiveCaption
        chk_4.Font = New Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chk_4.Location = New Point(312, 73)
        chk_4.Name = "chk_4"
        chk_4.Size = New Size(185, 21)
        chk_4.TabIndex = 7
        chk_4.Text = "Fromage supplémentaire "
        chk_4.UseVisualStyleBackColor = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btn.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn.Location = New Point(239, 320)
        btn.Name = "btn"
        btn.Size = New Size(249, 31)
        btn.TabIndex = 8
        btn.Text = "Afficher la commande"
        btn.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rd_3)
        GroupBox1.Controls.Add(rd_1)
        GroupBox1.Controls.Add(rd_2)
        GroupBox1.Font = New Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(45, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(585, 97)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Les types de croutes "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chk_1)
        GroupBox2.Controls.Add(chk_2)
        GroupBox2.Controls.Add(chk_3)
        GroupBox2.Controls.Add(chk_4)
        GroupBox2.Font = New Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(45, 205)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(542, 109)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Les ingrédients supplémentaires"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btn)
        Controls.Add(lstTaille)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstTaille As ComboBox
    Friend WithEvents rd_1 As RadioButton
    Friend WithEvents rd_2 As RadioButton
    Friend WithEvents rd_3 As RadioButton
    Friend WithEvents chk_1 As CheckBox
    Friend WithEvents chk_2 As CheckBox
    Friend WithEvents chk_3 As CheckBox
    Friend WithEvents chk_4 As CheckBox
    Friend WithEvents btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
