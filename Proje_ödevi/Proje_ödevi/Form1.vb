Imports System.Data.OleDb ' access veritabanını kullanacağımı belittim
Imports System.Windows.Forms.DataVisualization.Charting 'chart kullanabilmek için tanıttım
Public Class Form1

    'Veri Tabanını gereksiz nesne kullanmayayım diye winzarttan bağlattım.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Veritabanı bağlantısı
        Me.OgrTableAdapter.Fill(Me.GrafikDataSet.ogr)

Grafik_Dizaynı:
        'X_Koordinatları_için
        Chart1.ChartAreas(0).AxisX.TitleFont = New Font("Oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        Chart1.ChartAreas(0).AxisX.TitleForeColor = Color.FromName("DodgeBlue")
        Chart1.ChartAreas(0).AxisX.Title = "Kişilerim"

        'Y_Koordinatları_için
        Chart1.ChartAreas(0).AxisY.TitleFont = New Font("Oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        Chart1.ChartAreas(0).AxisY.Title = "Kişilerim"
        Chart1.ChartAreas(0).AxisY.TitleForeColor = Color.FromName("DodgeBlue")

        Chart1.Series("Kişiler").IsVisibleInLegend = False
        Chart1.Series("Kişiler").IsValueShownAsLabel = True
Kolonları_XveY_Koordinatlarına_ekledik:
        'Koordinatlara Veri girdik
        Chart1.Series("Kişiler").YValueMembers = "yas"
        Chart1.Series("Kişiler").XValueMember = "ad"

        'Chart1.DataSource = Nothing ' aktif edersek grafikteki verileri göstermez
Gösterilecek_veri_aralığı:


Grafiğer_Tip_uygulama:
        Dim grf_tipleri As SeriesChartType
        For grf_tipleri = 0 To 25
            ComboBox1.Items.Add(grf_tipleri)
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Hangi Grafik türünü istediğimizi seçiyoruz
        Chart1.Series("Kişiler").ChartType = ComboBox1.SelectedItem
    End Sub

    Private Sub BüyütToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BüyütToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
        'Dock özelliği fill seçilmelidir
    End Sub

    Private Sub KüçültToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KüçültToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub DGrafikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DGrafikToolStripMenuItem.Click
rafik_3Dve2D_Dönüştürücü:
        If Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True Then
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
        End If
    End Sub

    Private Sub DGrafikToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DGrafikToolStripMenuItem1.Click

        If Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False Then
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        End If
    End Sub
End Class
