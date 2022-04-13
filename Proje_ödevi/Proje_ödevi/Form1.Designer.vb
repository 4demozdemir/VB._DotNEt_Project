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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.D3DGrafikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGrafikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGrafikToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafiktip = New System.Windows.Forms.ToolStripMenuItem()
        Me.BüyütToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KüçültToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OgrBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OgrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.OgrBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrafikDataSet = New Proje_ödevi.grafikDataSet()
        Me.OgrTableAdapter = New Proje_ödevi.grafikDataSetTableAdapters.ogrTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.OgrBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OgrBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrafikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'D3DGrafikToolStripMenuItem
        '
        Me.D3DGrafikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DGrafikToolStripMenuItem, Me.DGrafikToolStripMenuItem1})
        Me.D3DGrafikToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.D3DGrafikToolStripMenuItem.Name = "D3DGrafikToolStripMenuItem"
        Me.D3DGrafikToolStripMenuItem.Size = New System.Drawing.Size(127, 32)
        Me.D3DGrafikToolStripMenuItem.Text = " Grafik Şekli"
        '
        'DGrafikToolStripMenuItem
        '
        Me.DGrafikToolStripMenuItem.Name = "DGrafikToolStripMenuItem"
        Me.DGrafikToolStripMenuItem.Size = New System.Drawing.Size(172, 32)
        Me.DGrafikToolStripMenuItem.Text = "2D Grafik"
        '
        'DGrafikToolStripMenuItem1
        '
        Me.DGrafikToolStripMenuItem1.Name = "DGrafikToolStripMenuItem1"
        Me.DGrafikToolStripMenuItem1.Size = New System.Drawing.Size(172, 32)
        Me.DGrafikToolStripMenuItem1.Text = "3D Grafik"
        '
        'grafiktip
        '
        Me.grafiktip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BüyütToolStripMenuItem, Me.KüçültToolStripMenuItem})
        Me.grafiktip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.grafiktip.Name = "grafiktip"
        Me.grafiktip.Size = New System.Drawing.Size(208, 32)
        Me.grafiktip.Text = "Pencere büyüt/kücült"
        '
        'BüyütToolStripMenuItem
        '
        Me.BüyütToolStripMenuItem.Name = "BüyütToolStripMenuItem"
        Me.BüyütToolStripMenuItem.Size = New System.Drawing.Size(181, 32)
        Me.BüyütToolStripMenuItem.Text = "Büyüt"
        '
        'KüçültToolStripMenuItem
        '
        Me.KüçültToolStripMenuItem.Name = "KüçültToolStripMenuItem"
        Me.KüçültToolStripMenuItem.Size = New System.Drawing.Size(181, 32)
        Me.KüçültToolStripMenuItem.Text = "Küçült"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.D3DGrafikToolStripMenuItem, Me.grafiktip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(998, 36)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OgrBindingSource
        '
        Me.OgrBindingSource.DataMember = "ogr"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.OgrBindingSource1
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 36)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.RoyalBlue
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Name = "Kişiler"
        Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series1.YValuesPerPoint = 2
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(998, 566)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'OgrBindingSource1
        '
        Me.OgrBindingSource1.DataMember = "ogr"
        Me.OgrBindingSource1.DataSource = Me.GrafikDataSet
        '
        'GrafikDataSet
        '
        Me.GrafikDataSet.DataSetName = "grafikDataSet"
        Me.GrafikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OgrTableAdapter
        '
        Me.OgrTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(369, 0)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 30)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Grafik tipi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 602)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.OgrBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OgrBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrafikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents D3DGrafikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grafiktip As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OgrBindingSource2 As BindingSource
    Friend WithEvents OgrBindingSource As BindingSource
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GrafikDataSet As grafikDataSet
    Friend WithEvents OgrBindingSource1 As BindingSource
    Friend WithEvents OgrTableAdapter As grafikDataSetTableAdapters.ogrTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BüyütToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KüçültToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGrafikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGrafikToolStripMenuItem1 As ToolStripMenuItem
End Class
