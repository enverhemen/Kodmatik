<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anasayfa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anasayfa))
        Me.Kaydet_Buton = New System.Windows.Forms.Button()
        Me.Server_Adı_Text = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Devex_Radio = New System.Windows.Forms.RadioButton()
        Me.Microsoft_Radio = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sifre_Text = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Kullanıcı_Adı_Text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Database_Adı_Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Notepad_Radio = New System.Windows.Forms.RadioButton()
        Me.Klavye_Radio = New System.Windows.Forms.RadioButton()
        Me.insert_Buton = New System.Windows.Forms.Button()
        Me.Update_Buton = New System.Windows.Forms.Button()
        Me.Tablo_Adı_Text = New System.Windows.Forms.TextBox()
        Me.Data_Kodu_Text = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Baslik_Yaz_Buton = New System.Windows.Forms.Button()
        Me.Web_Adres_Text = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Sutunları_Cek_Buton = New System.Windows.Forms.Button()
        Me.Sutunlar_Datagrid = New System.Windows.Forms.DataGridView()
        Me.Tablolar_Datagrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Ms_Sql_Radio = New System.Windows.Forms.RadioButton()
        Me.Firebird_Radio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Sutunlar_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tablolar_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Kaydet_Buton
        '
        Me.Kaydet_Buton.Location = New System.Drawing.Point(7, 234)
        Me.Kaydet_Buton.Name = "Kaydet_Buton"
        Me.Kaydet_Buton.Size = New System.Drawing.Size(265, 40)
        Me.Kaydet_Buton.TabIndex = 0
        Me.Kaydet_Buton.Text = "Ayarları Kaydet"
        Me.Kaydet_Buton.UseVisualStyleBackColor = True
        '
        'Server_Adı_Text
        '
        Me.Server_Adı_Text.Location = New System.Drawing.Point(78, 19)
        Me.Server_Adı_Text.Name = "Server_Adı_Text"
        Me.Server_Adı_Text.Size = New System.Drawing.Size(184, 20)
        Me.Server_Adı_Text.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Kaydet_Buton)
        Me.GroupBox1.Controls.Add(Me.Sifre_Text)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Kullanıcı_Adı_Text)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Database_Adı_Text)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Server_Adı_Text)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 293)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Ayarları"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Devex_Radio)
        Me.GroupBox4.Controls.Add(Me.Microsoft_Radio)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 32)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'Devex_Radio
        '
        Me.Devex_Radio.AutoSize = True
        Me.Devex_Radio.Checked = True
        Me.Devex_Radio.Location = New System.Drawing.Point(3, 11)
        Me.Devex_Radio.Name = "Devex_Radio"
        Me.Devex_Radio.Size = New System.Drawing.Size(138, 17)
        Me.Devex_Radio.TabIndex = 16
        Me.Devex_Radio.TabStop = True
        Me.Devex_Radio.Text = "Devexpress Component"
        Me.Devex_Radio.UseVisualStyleBackColor = True
        '
        'Microsoft_Radio
        '
        Me.Microsoft_Radio.AutoSize = True
        Me.Microsoft_Radio.Location = New System.Drawing.Point(141, 11)
        Me.Microsoft_Radio.Name = "Microsoft_Radio"
        Me.Microsoft_Radio.Size = New System.Drawing.Size(125, 17)
        Me.Microsoft_Radio.TabIndex = 17
        Me.Microsoft_Radio.Text = "Microsoft Component"
        Me.Microsoft_Radio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Şifre"
        '
        'Sifre_Text
        '
        Me.Sifre_Text.Location = New System.Drawing.Point(78, 97)
        Me.Sifre_Text.Name = "Sifre_Text"
        Me.Sifre_Text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Sifre_Text.Size = New System.Drawing.Size(184, 20)
        Me.Sifre_Text.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kullanıcı Adı"
        '
        'Kullanıcı_Adı_Text
        '
        Me.Kullanıcı_Adı_Text.Location = New System.Drawing.Point(78, 71)
        Me.Kullanıcı_Adı_Text.Name = "Kullanıcı_Adı_Text"
        Me.Kullanıcı_Adı_Text.Size = New System.Drawing.Size(184, 20)
        Me.Kullanıcı_Adı_Text.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Database"
        '
        'Database_Adı_Text
        '
        Me.Database_Adı_Text.Location = New System.Drawing.Point(78, 45)
        Me.Database_Adı_Text.Name = "Database_Adı_Text"
        Me.Database_Adı_Text.Size = New System.Drawing.Size(184, 20)
        Me.Database_Adı_Text.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Server"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Notepad_Radio)
        Me.GroupBox3.Controls.Add(Me.Klavye_Radio)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 34)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'Notepad_Radio
        '
        Me.Notepad_Radio.AutoSize = True
        Me.Notepad_Radio.Location = New System.Drawing.Point(141, 11)
        Me.Notepad_Radio.Name = "Notepad_Radio"
        Me.Notepad_Radio.Size = New System.Drawing.Size(109, 17)
        Me.Notepad_Radio.TabIndex = 20
        Me.Notepad_Radio.Text = "Notepad' e Yazdır"
        Me.Notepad_Radio.UseVisualStyleBackColor = True
        '
        'Klavye_Radio
        '
        Me.Klavye_Radio.AutoSize = True
        Me.Klavye_Radio.Checked = True
        Me.Klavye_Radio.Location = New System.Drawing.Point(4, 11)
        Me.Klavye_Radio.Name = "Klavye_Radio"
        Me.Klavye_Radio.Size = New System.Drawing.Size(107, 17)
        Me.Klavye_Radio.TabIndex = 19
        Me.Klavye_Radio.TabStop = True
        Me.Klavye_Radio.Text = "Klavye Emilasyon"
        Me.Klavye_Radio.UseVisualStyleBackColor = True
        '
        'insert_Buton
        '
        Me.insert_Buton.Location = New System.Drawing.Point(9, 83)
        Me.insert_Buton.Name = "insert_Buton"
        Me.insert_Buton.Size = New System.Drawing.Size(253, 40)
        Me.insert_Buton.TabIndex = 10
        Me.insert_Buton.Text = "İnsert Kodu"
        Me.insert_Buton.UseVisualStyleBackColor = True
        '
        'Update_Buton
        '
        Me.Update_Buton.Location = New System.Drawing.Point(9, 129)
        Me.Update_Buton.Name = "Update_Buton"
        Me.Update_Buton.Size = New System.Drawing.Size(253, 40)
        Me.Update_Buton.TabIndex = 11
        Me.Update_Buton.Text = "Update Kodu"
        Me.Update_Buton.UseVisualStyleBackColor = True
        '
        'Tablo_Adı_Text
        '
        Me.Tablo_Adı_Text.Location = New System.Drawing.Point(78, 24)
        Me.Tablo_Adı_Text.Name = "Tablo_Adı_Text"
        Me.Tablo_Adı_Text.Size = New System.Drawing.Size(184, 20)
        Me.Tablo_Adı_Text.TabIndex = 10
        '
        'Data_Kodu_Text
        '
        Me.Data_Kodu_Text.Location = New System.Drawing.Point(78, 50)
        Me.Data_Kodu_Text.Name = "Data_Kodu_Text"
        Me.Data_Kodu_Text.Size = New System.Drawing.Size(184, 20)
        Me.Data_Kodu_Text.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Data Kodu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tablo Adı"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Baslik_Yaz_Buton)
        Me.GroupBox2.Controls.Add(Me.Update_Buton)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.insert_Buton)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Tablo_Adı_Text)
        Me.GroupBox2.Controls.Add(Me.Data_Kodu_Text)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 228)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kod Yazdırma İşlemleri"
        '
        'Baslik_Yaz_Buton
        '
        Me.Baslik_Yaz_Buton.Location = New System.Drawing.Point(9, 175)
        Me.Baslik_Yaz_Buton.Name = "Baslik_Yaz_Buton"
        Me.Baslik_Yaz_Buton.Size = New System.Drawing.Size(253, 40)
        Me.Baslik_Yaz_Buton.TabIndex = 13
        Me.Baslik_Yaz_Buton.Text = "Sütün Başlıklarını Yaz"
        Me.Baslik_Yaz_Buton.UseVisualStyleBackColor = True
        '
        'Web_Adres_Text
        '
        Me.Web_Adres_Text.AutoSize = True
        Me.Web_Adres_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Web_Adres_Text.Location = New System.Drawing.Point(71, 9)
        Me.Web_Adres_Text.Name = "Web_Adres_Text"
        Me.Web_Adres_Text.Size = New System.Drawing.Size(168, 18)
        Me.Web_Adres_Text.TabIndex = 14
        Me.Web_Adres_Text.TabStop = True
        Me.Web_Adres_Text.Text = "www.filosoftyazilim.com"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Sutunları_Cek_Buton)
        Me.GroupBox5.Controls.Add(Me.Sutunlar_Datagrid)
        Me.GroupBox5.Controls.Add(Me.Tablolar_Datagrid)
        Me.GroupBox5.Location = New System.Drawing.Point(294, 37)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(767, 476)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sql Tablo ve Sutun Kodlarını Oluştıurma"
        '
        'Sutunları_Cek_Buton
        '
        Me.Sutunları_Cek_Buton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sutunları_Cek_Buton.Location = New System.Drawing.Point(6, 426)
        Me.Sutunları_Cek_Buton.Name = "Sutunları_Cek_Buton"
        Me.Sutunları_Cek_Buton.Size = New System.Drawing.Size(755, 40)
        Me.Sutunları_Cek_Buton.TabIndex = 22
        Me.Sutunları_Cek_Buton.Text = "Kolon ve Data Tiplerini Kodla"
        Me.Sutunları_Cek_Buton.UseVisualStyleBackColor = True
        '
        'Sutunlar_Datagrid
        '
        Me.Sutunlar_Datagrid.AllowUserToAddRows = False
        Me.Sutunlar_Datagrid.AllowUserToDeleteRows = False
        Me.Sutunlar_Datagrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sutunlar_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sutunlar_Datagrid.Location = New System.Drawing.Point(191, 19)
        Me.Sutunlar_Datagrid.Name = "Sutunlar_Datagrid"
        Me.Sutunlar_Datagrid.ReadOnly = True
        Me.Sutunlar_Datagrid.Size = New System.Drawing.Size(570, 398)
        Me.Sutunlar_Datagrid.TabIndex = 24
        '
        'Tablolar_Datagrid
        '
        Me.Tablolar_Datagrid.AllowUserToAddRows = False
        Me.Tablolar_Datagrid.AllowUserToDeleteRows = False
        Me.Tablolar_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tablolar_Datagrid.Location = New System.Drawing.Point(6, 22)
        Me.Tablolar_Datagrid.Name = "Tablolar_Datagrid"
        Me.Tablolar_Datagrid.ReadOnly = True
        Me.Tablolar_Datagrid.Size = New System.Drawing.Size(179, 395)
        Me.Tablolar_Datagrid.TabIndex = 23
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Ms_Sql_Radio)
        Me.GroupBox6.Controls.Add(Me.Firebird_Radio)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 194)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(267, 34)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        '
        'Ms_Sql_Radio
        '
        Me.Ms_Sql_Radio.AutoSize = True
        Me.Ms_Sql_Radio.Location = New System.Drawing.Point(141, 11)
        Me.Ms_Sql_Radio.Name = "Ms_Sql_Radio"
        Me.Ms_Sql_Radio.Size = New System.Drawing.Size(57, 17)
        Me.Ms_Sql_Radio.TabIndex = 20
        Me.Ms_Sql_Radio.Text = "Ms-Sql"
        Me.Ms_Sql_Radio.UseVisualStyleBackColor = True
        '
        'Firebird_Radio
        '
        Me.Firebird_Radio.AutoSize = True
        Me.Firebird_Radio.Checked = True
        Me.Firebird_Radio.Location = New System.Drawing.Point(4, 11)
        Me.Firebird_Radio.Name = "Firebird_Radio"
        Me.Firebird_Radio.Size = New System.Drawing.Size(59, 17)
        Me.Firebird_Radio.TabIndex = 19
        Me.Firebird_Radio.TabStop = True
        Me.Firebird_Radio.Text = "Firebird"
        Me.Firebird_Radio.UseVisualStyleBackColor = True
        '
        'Anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 609)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Web_Adres_Text)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Anasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filosoft Kodmatik"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Sutunlar_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tablolar_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kaydet_Buton As System.Windows.Forms.Button
    Friend WithEvents Server_Adı_Text As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Sifre_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Kullanıcı_Adı_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Database_Adı_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents insert_Buton As System.Windows.Forms.Button
    Friend WithEvents Update_Buton As System.Windows.Forms.Button
    Friend WithEvents Tablo_Adı_Text As System.Windows.Forms.TextBox
    Friend WithEvents Data_Kodu_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Baslik_Yaz_Buton As System.Windows.Forms.Button
    Friend WithEvents Web_Adres_Text As System.Windows.Forms.LinkLabel
    Friend WithEvents Microsoft_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Devex_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Notepad_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Klavye_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Sutunları_Cek_Buton As System.Windows.Forms.Button
    Friend WithEvents Sutunlar_Datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Tablolar_Datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Ms_Sql_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Firebird_Radio As System.Windows.Forms.RadioButton

End Class
