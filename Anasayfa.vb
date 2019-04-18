Imports System.IO
Imports System.Data.SqlClient

Public Class Anasayfa
    Dim Ayaryaz As New StreamReader("Ayarlar.ini")
    Dim Serveradı As String = Ayaryaz.ReadLine
    Dim DatabaseAdı As String = Ayaryaz.ReadLine
    Dim KullanıcıAdı As String = Ayaryaz.ReadLine
    Dim Sifre As String = Ayaryaz.ReadLine
    Dim Winfom As String = Ayaryaz.ReadLine
    Dim Klavye_Notepad As String = Ayaryaz.ReadLine
    Dim DB_ConnectionString As String = ("Server=" & Serveradı & ";Database=" & DatabaseAdı & ";MultipleActiveResultSets=True;Integrated Security=False ;User ID='" & KullanıcıAdı & "';Password='" & Sifre & "';Connect Timeout=3")
    Dim DatabaseBaglan As New SqlConnection(DB_ConnectionString)
    Dim Sqlkodu As New SqlCommand
    Dim TOPLAMSAYI, GRIDVIEW, INSERTKOD, KOD As Object
    Dim TablolarDatatable As New DataTable

    Private Sub Kaydet_Buton_Click(sender As Object, e As EventArgs) Handles Kaydet_Buton.Click
        Try


            Dim Ayaryaz As New StreamWriter("Ayarlar.ini")
            Ayaryaz.WriteLine(Server_Adı_Text.Text)
            Ayaryaz.WriteLine(Database_Adı_Text.Text)
            Ayaryaz.WriteLine(Kullanıcı_Adı_Text.Text)
            Ayaryaz.WriteLine(Sifre_Text.Text)


            Serveradı = Server_Adı_Text.Text
            DatabaseAdı = Database_Adı_Text.Text
            KullanıcıAdı = Kullanıcı_Adı_Text.Text
            Sifre = Sifre_Text.Text


            If Devex_Radio.Checked = True Then
                Ayaryaz.WriteLine("0")
            Else
                Ayaryaz.WriteLine("1")
            End If

            If Klavye_Radio.Checked = True Then
                Ayaryaz.WriteLine("0")
            Else
                Ayaryaz.WriteLine("1")
            End If


            If Firebird_Radio.Checked = True Then
                Ayaryaz.WriteLine("0")
            Else
                Ayaryaz.WriteLine("1")
            End If




            Ayaryaz.Close()

            Me.Cursor = Cursors.WaitCursor

            If DatabaseBaglan.State = ConnectionState.Open Then
                DatabaseBaglan.Close()
            End If


            Dim DB_ConnectionString As String = ("Server=" & Serveradı & ";Database=" & DatabaseAdı & ";MultipleActiveResultSets=True;Integrated Security=False ;User ID='" & KullanıcıAdı & "';Password='" & Sifre & "';Connect Timeout=3")
            DatabaseBaglan = New SqlConnection(DB_ConnectionString)
            DatabaseBaglan.Open()
            Me.Cursor = Cursors.Default
            MsgBox("Ayar Kayıt Başarılı !", 64, "Bilgi")



        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, 16, "Hata !")
        End Try
    End Sub


    Sub Ayar_Oku()

        Server_Adı_Text.Text = Serveradı
        Database_Adı_Text.Text = DatabaseAdı
        Kullanıcı_Adı_Text.Text = KullanıcıAdı
        Sifre_Text.Text = Sifre
        If Winfom = "0" Then
            Devex_Radio.Checked = True
        Else
            Microsoft_Radio.Checked = True
        End If

        If Klavye_Notepad = "0" Then
            Klavye_Radio.Checked = True
        Else
            Notepad_Radio.Checked = True
        End If

    End Sub

   

    Private Sub insert_Buton_Click(sender As Object, e As EventArgs) Handles insert_Buton.Click

        Try
            ErrorProvider1.Clear()
            Tablo_Adı_Text.Text = Tablo_Adı_Text.Text.TrimStart
            Tablo_Adı_Text.Text = Tablo_Adı_Text.Text.TrimEnd
            If Tablo_Adı_Text.Text = "" Then
                ErrorProvider1.SetError(Tablo_Adı_Text, "! Tablo Adını Yazınız")
                Exit Sub

            End If

            If DatabaseBaglan.State = ConnectionState.Closed Then
                DatabaseBaglan.Open()
            End If

            Dim Datatablo As New DataTable
            Dim Adapter As New SqlDataAdapter("Select * From " & Tablo_Adı_Text.Text & "", DatabaseBaglan)
            Adapter.Fill(Datatablo)
            TOPLAMSAYI = Datatablo.Columns.Count
            GRIDVIEW = Datatablo.Columns

            KOD = ""
            INSERTKOD = ""


            If Klavye_Radio.Checked = True Then
                For i As Integer = 0 To TOPLAMSAYI - 1
                    KOD = KOD & "," & GRIDVIEW(i).ColumnName
                Next

                For i As Integer = 0 To TOPLAMSAYI - 1
                    INSERTKOD = INSERTKOD & ",@" & GRIDVIEW(i).ColumnName
                Next

                KOD = KOD.TrimStart(",")
                INSERTKOD = INSERTKOD.TrimStart(",")
                KOD = "{(}" & KOD & "{)} Values {(}" & INSERTKOD
                System.Threading.Thread.Sleep(2000)
                My.Computer.Keyboard.SendKeys("Using SqlKodu As New SqlCommand{(}" & Chr(34) & "Insert Into " & Tablo_Adı_Text.Text & " " & KOD & "{)}" & Chr(34) & ",DatabaseBaglan{)}" & Chr(13))
                For s As Integer = 1 To TOPLAMSAYI - 1
                    My.Computer.Keyboard.SendKeys("Sqlkodu.Parameters.AddWithValue{(}" & Chr(34) & "@" & GRIDVIEW(s).ColumnName & Chr(34) & "," & Chr(34) & "" & Chr(34) & "{)}" & Chr(13))
                Next
                My.Computer.Keyboard.SendKeys("Sqlkodu.ExecuteNonQuery{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys("End Using" & Chr(13))
                My.Computer.Keyboard.SendKeys("Textleri_Temizle{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys("Textleri_Kilitle{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys(Data_Kodu_Text.Text & "{(}{)}" & Chr(13))

                If Devex_Radio.Checked = True Then
                    My.Computer.Keyboard.SendKeys("XtraMessageBox.Show{(}" & Chr(34) & "Kayıt İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information{)}")
                Else
                    My.Computer.Keyboard.SendKeys("MessageBox.Show{(}" & Chr(34) & "Kayıt İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information{)}")

                End If


            Else


                For i As Integer = 0 To TOPLAMSAYI - 1
                    KOD = KOD & "," & GRIDVIEW(i).ColumnName
                Next

                For i As Integer = 0 To TOPLAMSAYI - 1
                    INSERTKOD = INSERTKOD & ",@" & GRIDVIEW(i).ColumnName
                Next

                KOD = KOD.TrimStart(",")
                INSERTKOD = INSERTKOD.TrimStart(",")
                KOD = "Using SqlKodu As New SqlCommand(" & Chr(34) & "Insert Into " & Tablo_Adı_Text.Text & " (" & KOD & ") Values (" & INSERTKOD & ")" & Chr(34) & ",DatabaseBaglan)" & vbCrLf

                For s As Integer = 0 To TOPLAMSAYI - 1
                    KOD = KOD & ("Sqlkodu.Parameters.AddWithValue(" & Chr(34) & "@" & GRIDVIEW(s).ColumnName & Chr(34) & "," & Chr(34) & "" & Chr(34) & ")" & vbCrLf)
                Next
                KOD = KOD & "Sqlkodu.ExecuteNonQuery()" & vbCrLf
                KOD = KOD & "End Using" & vbCrLf
                KOD = KOD & "Textleri_Temizle()" & vbCrLf
                KOD = KOD & "Textleri_Kilitle()" & vbCrLf

                If Data_Kodu_Text.Text <> "" Then
                    KOD = KOD & Data_Kodu_Text.Text & "()" & vbCrLf
                Else
                    KOD = KOD & vbCrLf
                End If


                If Devex_Radio.Checked = True Then
                    KOD = KOD & ("XtraMessageBox.Show(" & Chr(34) & "Kayıt İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information)") & vbCrLf
                Else
                    KOD = KOD & ("MessageBox.Show(" & Chr(34) & "Kayıt İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information)") & vbCrLf

                End If


                Dim Yaz As New StreamWriter("insertCode.txt")
                Yaz.WriteLine(KOD)
                Yaz.Close()
                System.Diagnostics.Process.Start("insertCode.txt")


            End If

        Catch ex As Exception
            MsgBox(ex.Message, 16, "Hata !")

        End Try
    End Sub

    Private Sub Update_Buton_Click(sender As Object, e As EventArgs) Handles Update_Buton.Click
        Try

            ErrorProvider1.Clear()
            Tablo_Adı_Text.Text = Tablo_Adı_Text.Text.TrimStart
            Tablo_Adı_Text.Text = Tablo_Adı_Text.Text.TrimEnd
            If Tablo_Adı_Text.Text = "" Then
                ErrorProvider1.SetError(Tablo_Adı_Text, "! Tablo Adını Yazınız")
                Exit Sub

            End If

            KOD = ""
            INSERTKOD = ""

            If DatabaseBaglan.State = ConnectionState.Closed Then
                DatabaseBaglan.Open()
            End If

            Dim Datatablo As New DataTable
            Dim Adapter As New SqlDataAdapter("Select * From " & Tablo_Adı_Text.Text & " ", DatabaseBaglan)
            Adapter.Fill(Datatablo)
            TOPLAMSAYI = Datatablo.Columns.Count
            GRIDVIEW = Datatablo.Columns


            If Klavye_Radio.Checked = True Then

                For i As Integer = 1 To TOPLAMSAYI - 1
                    KOD = KOD & "," & GRIDVIEW(i).ColumnName & "=@" & GRIDVIEW(i).ColumnName
                Next

                KOD = KOD.TrimStart(",")
                System.Threading.Thread.Sleep(2000)

                My.Computer.Keyboard.SendKeys("Using Sqlkodu As New SqlCommand({(}" & Chr(34) & "Update " & Tablo_Adı_Text.Text & " Set " & KOD & " Where ID='" & Chr(34) & "& Sırano &" & Chr(34) & "'" & Chr(34) & ",DatabaseBaglan{)}" & Chr(13))

                For s As Integer = 1 To TOPLAMSAYI - 1
                    My.Computer.Keyboard.SendKeys("Sqlkodu.Parameters.AddWithValue{(}" & Chr(34) & "@" & GRIDVIEW(s).ColumnName & Chr(34) & "," & Chr(34) & "" & Chr(34) & "{)}" & Chr(13))
                Next


                My.Computer.Keyboard.SendKeys("Sqlkodu.ExecuteNonQuery{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys("End Using" & Chr(13))
                My.Computer.Keyboard.SendKeys("Textleri_Temizle{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys("Textleri_Kilitle{(}{)}" & Chr(13))
                My.Computer.Keyboard.SendKeys(Data_Kodu_Text.Text & "{(}{)}" & Chr(13))

                If Devex_Radio.Checked = True Then
                    My.Computer.Keyboard.SendKeys("XtraMessageBox.Show{(}" & Chr(34) & "Bilgi Güncelleme İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information{)}")

                Else
                    My.Computer.Keyboard.SendKeys("MessageBox.Show{(}" & Chr(34) & "Bilgi Güncelleme İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information{)}")

                End If



            Else


                For i As Integer = 1 To TOPLAMSAYI - 1
                    KOD = KOD & "," & GRIDVIEW(i).ColumnName & "=@" & GRIDVIEW(i).ColumnName
                Next

                KOD = KOD.TrimStart(",")

                KOD = "Using Sqlkodu As New SqlCommand(" & Chr(34) & "Update " & Tablo_Adı_Text.Text & " Set " & KOD & " Where ID='" & Chr(34) & "& Sırano &" & Chr(34) & "'" & Chr(34) & ",DatabaseBaglan)" & vbCrLf


                For s As Integer = 1 To TOPLAMSAYI - 1
                    KOD = KOD & "Sqlkodu.Parameters.AddWithValue(" & Chr(34) & "@" & GRIDVIEW(s).ColumnName & Chr(34) & "," & Chr(34) & "" & Chr(34) & ")" & vbCrLf
                Next

                KOD = KOD & "Sqlkodu.ExecuteNonQuery()" & vbCrLf
                KOD = KOD & "End Using" & vbCrLf

                KOD = KOD & "Textleri_Temizle()" & vbCrLf
                KOD = KOD & "Textleri_Kilitle()" & vbCrLf
                KOD = KOD & Data_Kodu_Text.Text & "()" & vbCrLf

                If Devex_Radio.Checked = True Then
                    KOD = KOD & ("XtraMessageBox.Show(" & Chr(34) & "Bilgi Güncelleme İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information)") & vbCrLf
                Else
                    KOD = KOD & ("MessageBox.Show(" & Chr(34) & "Bilgi Güncelleme İşlemi Başarılı !" & Chr(34) & "," & Chr(34) & "Bilgi" & Chr(34) & ",MessageBoxButtons.OK, MessageBoxIcon.Information)") & vbCrLf

                End If

                Dim Yaz As New StreamWriter("UpdateCode.txt")
                Yaz.WriteLine(KOD)
                Yaz.Close()
                System.Diagnostics.Process.Start("UpdateCode.txt")



            End If
        Catch ex As Exception
            MsgBox(ex.Message, 16, "Hata !")
        End Try
    End Sub

    Private Sub Baslik_Yaz_Buton_Click(sender As Object, e As EventArgs) Handles Baslik_Yaz_Buton.Click
        Try
            ErrorProvider1.Clear()
            Data_Kodu_Text.Text = Data_Kodu_Text.Text.TrimStart
            Data_Kodu_Text.Text = Data_Kodu_Text.Text.TrimEnd
            If Data_Kodu_Text.Text = "" Then
                ErrorProvider1.SetError(Data_Kodu_Text, "! Gridview Adını Yazınız")
                Exit Sub

            End If
            KOD = ""
            INSERTKOD = ""

            If DatabaseBaglan.State = ConnectionState.Closed Then
                DatabaseBaglan.Open()
            End If

            Dim Datatablo As New DataTable
            Dim Adapter As New SqlDataAdapter("Select * From " & Tablo_Adı_Text.Text & "", DatabaseBaglan)
            Adapter.Fill(Datatablo)

            If Klavye_Radio.Checked = True Then
                System.Threading.Thread.Sleep(2000)
                For i As Integer = 0 To Datatablo.Columns.Count - 1
                    If Microsoft_Radio.Checked = True Then
                        KOD = KOD & Data_Kodu_Text.Text & ".Columns{(}" & Chr(34) & Datatablo.Columns(i).ColumnName & Chr(34) & "{)}.HeaderText=" & Chr(34) & Chr(34) & Chr(13)
                    Else
                        KOD = KOD & Data_Kodu_Text.Text & ".Columns{(}" & Chr(34) & Datatablo.Columns(i).ColumnName & Chr(34) & "{)}.Caption=" & Chr(34) & Chr(34) & Chr(13)
                    End If
                Next
                My.Computer.Keyboard.SendKeys(KOD)
            Else

                For i As Integer = 0 To Datatablo.Columns.Count - 1
                    If Microsoft_Radio.Checked = True Then
                        KOD = KOD & Data_Kodu_Text.Text & ".Columns(" & Chr(34) & Datatablo.Columns(i).ColumnName & Chr(34) & ").HeaderText=" & Chr(34) & Chr(34) & vbCrLf
                    Else
                        KOD = KOD & Data_Kodu_Text.Text & ".Columns(" & Chr(34) & Datatablo.Columns(i).ColumnName & Chr(34) & ").Caption=" & Chr(34) & Chr(34) & vbCrLf
                    End If
                Next
                Dim Yaz As New StreamWriter("ColumnsCode.txt")
                Yaz.WriteLine(KOD)
                Yaz.Close()
                System.Diagnostics.Process.Start("ColumnsCode.txt")

            End If












        Catch ex As Exception

            MsgBox(ex.Message, 16, "Hata !")
        End Try

    End Sub

    Private Sub Web_Adres_Text_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Web_Adres_Text.LinkClicked
        System.Diagnostics.Process.Start(Web_Adres_Text.Text)
    End Sub


    Private Sub Sutunları_Cek_Buton_Click(sender As Object, e As EventArgs) Handles Sutunları_Cek_Buton.Click
        If DatabaseBaglan.State = ConnectionState.Closed Then
            DatabaseBaglan.Open()
        End If


        If DatabaseBaglan.State = ConnectionState.Open Then


            Dim TabloAdapter As New SqlDataAdapter("Select TABLE_NAME As Tablolar FROM INFORMATION_SCHEMA.TABLES Order  by TABLE_NAME Asc", DatabaseBaglan)
            TabloAdapter.Fill(TablolarDatatable)
            Tablolar_Datagrid.DataSource = TablolarDatatable
            Tablolar_Datagrid.Columns(0).Width = 240


            Dim TabloOlusturmaKodu As String = ""

            Dim hasan As New StreamWriter("Datatype.txt")

            For A = 0 To Tablolar_Datagrid.RowCount - 1
                Tablolar_Datagrid.ClearSelection()
                Tablolar_Datagrid.Rows(A).Selected = True
                Application.DoEvents()

                System.Threading.Thread.Sleep(25)

                Dim SonKod As String = ""
                Dim Kod As String = ""

                Dim TabloAdı As String = Tablolar_Datagrid.Rows(A).Cells(0).Value.ToString
                Dim Sutunlar As New DataTable
                Dim SutunAdapter As New SqlDataAdapter("Select TABLE_NAME As Tabloadı,COLUMN_NAME As Sutunadı, IS_NULLABLE As Nullolabilir,DATA_TYPE As Datatipi,CHARACTER_MAXIMUM_LENGTH As MaxDeger,NUMERIC_PRECISION As Birincino,NUMERIC_SCALE As ikincino,ORDINAL_POSITION As Sıra from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" & TabloAdı & "'  ORDER BY ORDINAL_POSITION  ASC ", DatabaseBaglan)
                SutunAdapter.Fill(Sutunlar)
                Sutunlar_Datagrid.DataSource = Sutunlar

                TabloOlusturmaKodu = ""

                For i = 0 To Sutunlar_Datagrid.RowCount - 1
                    Application.DoEvents()
                    Sutunlar_Datagrid.ClearSelection()
                    Sutunlar_Datagrid.Rows(i).Selected = True
                    Kod = ""
                    System.Threading.Thread.Sleep(25)

                    If Sutunlar_Datagrid.Rows(i).Cells(2).Value.ToString = "NO" Then
                        Kod = Sutunlar_Datagrid.Rows(i).Cells(1).Value.ToString & " " & Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString & " identity(1,1) Not Null,"
                    Else

                        Dim Tip As String = Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString

                        If Tip = "nvarchar" Then

                            Dim BirinciNo As String = Sutunlar_Datagrid.Rows(i).Cells("Maxdeger").Value.ToString

                            If BirinciNo = "-1" Then
                                Kod = Sutunlar_Datagrid.Rows(i).Cells("Sutunadı").Value.ToString & " " & Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString & "(Max),"
                            Else
                                Kod = Sutunlar_Datagrid.Rows(i).Cells("Sutunadı").Value.ToString & " " & Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString & "(" & Sutunlar_Datagrid.Rows(i).Cells("MaxDeger").Value.ToString & "),"
                            End If

                        ElseIf Tip = "decimal" Then

                            Kod = Sutunlar_Datagrid.Rows(i).Cells("Sutunadı").Value.ToString & " " & Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString & "(" & Sutunlar_Datagrid.Rows(i).Cells("Birincino").Value.ToString & "," & Sutunlar_Datagrid.Rows(i).Cells("ikincino").Value.ToString & "),"

                        Else

                            Kod = Sutunlar_Datagrid.Rows(i).Cells("Sutunadı").Value.ToString & " " & Sutunlar_Datagrid.Rows(i).Cells("Datatipi").Value.ToString & ","

                        End If
                    End If


                    TabloOlusturmaKodu = TabloOlusturmaKodu & " " & Kod



                Next

                TabloOlusturmaKodu = TabloOlusturmaKodu.TrimStart
                TabloOlusturmaKodu = TabloOlusturmaKodu.TrimEnd(",")


                hasan.WriteLine("Sqlkodu = New SqlCommand(" & Chr(34) & "Create Table " & TabloAdı & " (" & TabloOlusturmaKodu & ")" & Chr(34) & ", YeniBaglantı)")
                hasan.WriteLine("Sqlkodu.ExecuteNonQuery()" & vbCrLf)
                hasan.WriteLine(" ")



            Next

            hasan.Close()
            System.Diagnostics.Process.Start("Datatype.txt")

        Else
            MsgBox("Database Bağlantısı Kapalı !", 48, "Uyarı !")
        End If

        'Sqlkodu = New SqlCommand("Create Table TABLOREHBER (ID INT IDENTITY(1,1) NOT NULL,  ADI nvarchar(50),SOYADI nvarchar(50), GSM decimal(11,0),CINSIYET nvarchar(10),BILGIMESAJIISTIYOR bit)", DatabaseBaglan)
        'Sqlkodu.ExecuteNonQuery() '
    End Sub

    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Ayaryaz.Close()
        Ayar_Oku()
        Me.Text = Me.Text & " V.2.0"
    End Sub


End Class
