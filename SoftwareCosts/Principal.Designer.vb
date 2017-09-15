<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadoDeCostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BalanceGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadosDeResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FlujoDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.OperacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(958, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Enabled = False
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoDeCostoToolStripMenuItem, Me.BalanceGeneralToolStripMenuItem, Me.EstadosDeResultadosToolStripMenuItem, Me.FlujoDeCajaToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones "
        '
        'EstadoDeCostoToolStripMenuItem
        '
        Me.EstadoDeCostoToolStripMenuItem.Name = "EstadoDeCostoToolStripMenuItem"
        Me.EstadoDeCostoToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.EstadoDeCostoToolStripMenuItem.Text = "Estado de Costo  y Produccion de Ventas "
        '
        'BalanceGeneralToolStripMenuItem
        '
        Me.BalanceGeneralToolStripMenuItem.Enabled = False
        Me.BalanceGeneralToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BalanceGeneralToolStripMenuItem.Name = "BalanceGeneralToolStripMenuItem"
        Me.BalanceGeneralToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.BalanceGeneralToolStripMenuItem.Text = "Balance General"
        '
        'EstadosDeResultadosToolStripMenuItem
        '
        Me.EstadosDeResultadosToolStripMenuItem.Enabled = False
        Me.EstadosDeResultadosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EstadosDeResultadosToolStripMenuItem.Name = "EstadosDeResultadosToolStripMenuItem"
        Me.EstadosDeResultadosToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.EstadosDeResultadosToolStripMenuItem.Text = "Estados de Resultados"
        '
        'FlujoDeCajaToolStripMenuItem
        '
        Me.FlujoDeCajaToolStripMenuItem.Enabled = False
        Me.FlujoDeCajaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FlujoDeCajaToolStripMenuItem.Name = "FlujoDeCajaToolStripMenuItem"
        Me.FlujoDeCajaToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.FlujoDeCajaToolStripMenuItem.Text = "Flujo de Caja "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PictureBox1.Image = Global.SoftwareCosts.My.Resources.Resources.fondo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 813)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(958, 835)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoDeCostoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosDeResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlujoDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
