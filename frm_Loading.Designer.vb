<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Loading))
        Me.pgb_Loading = New System.Windows.Forms.ProgressBar()
        Me.timer_Timing = New System.Windows.Forms.Timer(Me.components)
        Me.ptb_Loading = New System.Windows.Forms.PictureBox()
        CType(Me.ptb_Loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgb_Loading
        '
        Me.pgb_Loading.Location = New System.Drawing.Point(-1, 375)
        Me.pgb_Loading.Name = "pgb_Loading"
        Me.pgb_Loading.Size = New System.Drawing.Size(800, 23)
        Me.pgb_Loading.TabIndex = 0
        Me.pgb_Loading.Visible = False
        '
        'timer_Timing
        '
        Me.timer_Timing.Enabled = True
        Me.timer_Timing.Interval = 15
        '
        'ptb_Loading
        '
        Me.ptb_Loading.Image = Global.INF205_Asm.My.Resources.Resources.loading_bg2
        Me.ptb_Loading.Location = New System.Drawing.Point(0, 0)
        Me.ptb_Loading.Name = "ptb_Loading"
        Me.ptb_Loading.Size = New System.Drawing.Size(800, 400)
        Me.ptb_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Loading.TabIndex = 1
        Me.ptb_Loading.TabStop = False
        '
        'frm_Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgb_Loading)
        Me.Controls.Add(Me.ptb_Loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptb_Loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgb_Loading As System.Windows.Forms.ProgressBar
    Friend WithEvents timer_Timing As System.Windows.Forms.Timer
    Friend WithEvents ptb_Loading As System.Windows.Forms.PictureBox
End Class
