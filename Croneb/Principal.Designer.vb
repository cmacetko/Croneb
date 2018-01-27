<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.DtgListaLinks = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Link = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbrirCada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdAberturas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaImagens = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LsbLog = New System.Windows.Forms.ListBox()
        Me.NtfGeral = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TimIsThread = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DtgListaLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgListaLinks
        '
        Me.DtgListaLinks.AllowUserToAddRows = False
        Me.DtgListaLinks.AllowUserToDeleteRows = False
        Me.DtgListaLinks.AllowUserToResizeColumns = False
        Me.DtgListaLinks.AllowUserToResizeRows = False
        Me.DtgListaLinks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtgListaLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgListaLinks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Nome, Me.Link, Me.AbrirCada, Me.Duracao, Me.Timeout, Me.QtdAberturas})
        Me.DtgListaLinks.Location = New System.Drawing.Point(6, 19)
        Me.DtgListaLinks.MultiSelect = False
        Me.DtgListaLinks.Name = "DtgListaLinks"
        Me.DtgListaLinks.ReadOnly = True
        Me.DtgListaLinks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DtgListaLinks.RowHeadersVisible = False
        Me.DtgListaLinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgListaLinks.Size = New System.Drawing.Size(670, 199)
        Me.DtgListaLinks.TabIndex = 0
        '
        'Status
        '
        Me.Status.HeaderText = "*"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 20
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Link
        '
        Me.Link.HeaderText = "Link"
        Me.Link.Name = "Link"
        Me.Link.ReadOnly = True
        Me.Link.Width = 200
        '
        'AbrirCada
        '
        Me.AbrirCada.HeaderText = "Abrir a cada"
        Me.AbrirCada.Name = "AbrirCada"
        Me.AbrirCada.ReadOnly = True
        Me.AbrirCada.Width = 90
        '
        'Duracao
        '
        Me.Duracao.HeaderText = "Duração"
        Me.Duracao.Name = "Duracao"
        Me.Duracao.ReadOnly = True
        '
        'Timeout
        '
        Me.Timeout.HeaderText = "Timeout"
        Me.Timeout.Name = "Timeout"
        Me.Timeout.ReadOnly = True
        Me.Timeout.Width = 50
        '
        'QtdAberturas
        '
        Me.QtdAberturas.HeaderText = "Aberturas"
        Me.QtdAberturas.Name = "QtdAberturas"
        Me.QtdAberturas.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Croneb"
        '
        'ListaImagens
        '
        Me.ListaImagens.ImageStream = CType(resources.GetObject("ListaImagens.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagens.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagens.Images.SetKeyName(0, "Falha.png")
        Me.ListaImagens.Images.SetKeyName(1, "OK.png")
        Me.ListaImagens.Images.SetKeyName(2, "Atencao.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DtgListaLinks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 224)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexões"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LsbLog)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 157)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Log"
        '
        'LsbLog
        '
        Me.LsbLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsbLog.FormattingEnabled = True
        Me.LsbLog.Location = New System.Drawing.Point(7, 21)
        Me.LsbLog.Name = "LsbLog"
        Me.LsbLog.Size = New System.Drawing.Size(662, 134)
        Me.LsbLog.TabIndex = 0
        '
        'NtfGeral
        '
        Me.NtfGeral.Icon = CType(resources.GetObject("NtfGeral.Icon"), System.Drawing.Icon)
        Me.NtfGeral.Text = "Croneb"
        Me.NtfGeral.Visible = True
        '
        'TimIsThread
        '
        Me.TimIsThread.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.Croneb.My.Resources.Resources.About
        Me.Button1.Location = New System.Drawing.Point(659, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 443)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Text = "Croneb"
        CType(Me.DtgListaLinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListaImagens As System.Windows.Forms.ImageList
    Friend WithEvents DtgListaLinks As System.Windows.Forms.DataGridView
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Link As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbrirCada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timeout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtdAberturas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LsbLog As System.Windows.Forms.ListBox
    Friend WithEvents NtfGeral As System.Windows.Forms.NotifyIcon
    Friend WithEvents TimIsThread As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
