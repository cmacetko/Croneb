Imports System.ComponentModel
Imports System.Threading
Imports System.Net
Imports System.IO

Public Class Principal

    Private GemThread As Thread()
    Private Delegate Sub TreathAddLog(ByVal CodLinha As Integer, ByVal Mensagem As String)

    Private Sub CarregarListaLinks()

        Try

            Dim xmlFile = XDocument.Load(Application.StartupPath & "\Config.xml")

            For Each conexao In xmlFile.Descendants("site")

                DtgListaLinks.Rows.Add(ListaImagens.Images(2), conexao.Element("Nome").Value, conexao.Element("Link").Value, conexao.Element("AbrirCada").Value, 0, conexao.Element("Timeout").Value, 0)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub AddLog(ByVal CodLinha As Integer, ByVal Mensagem As String)

        Try

            LsbLog.SelectedIndex = LsbLog.Items.Add(DtgListaLinks.Rows(CodLinha).Cells("Nome").Value & " -> " & Mensagem)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub IniciaListaExecucao()

        Try

            For Each Linha As DataGridViewRow In DtgListaLinks.Rows

                ReDim Preserve GemThread(Linha.Index)

                GemThread(Linha.Index) = New Thread(AddressOf ExecutacaoExecutar)
                GemThread(Linha.Index).Name = Linha.Index
                GemThread(Linha.Index).IsBackground = True

                GemThread(Linha.Index).Start()

                Me.Invoke(New TreathAddLog(AddressOf Me.AddLog), Linha.Index, "Iniciado Thread")

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ExecutacaoExecutar()

        Try

            If Thread.CurrentThread.IsAlive = True Then

                Dim CodLinha As Integer = Thread.CurrentThread.Name
                Dim RLink As String = DtgListaLinks.Rows(CodLinha).Cells("Link").Value
                Dim RAbrirCada As String = DtgListaLinks.Rows(CodLinha).Cells("AbrirCada").Value
                Dim RTimeout As String = DtgListaLinks.Rows(CodLinha).Cells("Timeout").Value

                Dim DataInicio As DateTime

                Dim request As HttpWebRequest
                Dim response As HttpWebResponse

                While (True)

                    DataInicio = Date.Now

                    Try

                        request = HttpWebRequest.Create(RLink)
                        request.Timeout = RTimeout

                        response = request.GetResponse()

                        If response.StatusCode = HttpStatusCode.OK Then

                            DtgListaLinks.Rows(CodLinha).Cells("Status").Value = ListaImagens.Images(1)

                        Else

                            Me.Invoke(New TreathAddLog(AddressOf Me.AddLog), CodLinha, "ERRO: Http Status Code " & response.StatusCode)
                            DtgListaLinks.Rows(CodLinha).Cells("Status").Value = ListaImagens.Images(0)

                        End If

                        response.Close()

                    Catch ex As Exception

                        DtgListaLinks.Rows(CodLinha).Cells("Status").Value = ListaImagens.Images(0)

                    End Try

                    Dim DataFim As DateTime = Date.Now
                    Dim DataDiff = (DataFim - DataInicio).TotalSeconds

                    DtgListaLinks.Rows(CodLinha).Cells("QtdAberturas").Value = DtgListaLinks.Rows(CodLinha).Cells("QtdAberturas").Value + 1
                    DtgListaLinks.Rows(CodLinha).Cells("Duracao").Value = DataDiff & " seg"
                    Console.WriteLine(Thread.CurrentThread.ThreadState)

                    Thread.Sleep(RAbrirCada)

                End While

            End If

        Catch ex As Exception

            '

        End Try

    End Sub

    Private Sub TimIsThread_Tick(sender As System.Object, e As System.EventArgs) Handles TimIsThread.Tick

        Try

            For Each Thr As Thread In GemThread

                If Thr.IsAlive = False Then

                    Dim CodLinhas As Integer = CInt(Thr.Name)

                    Me.Invoke(New TreathAddLog(AddressOf Me.AddLog), CodLinhas, "ERRO: Thread esta instável - " & Thr.ThreadState.ToString)

                    GemThread(CodLinhas) = New Thread(AddressOf ExecutacaoExecutar)
                    GemThread(CodLinhas).Name = CodLinhas
                    GemThread(CodLinhas).IsBackground = True

                    GemThread(CodLinhas).Start()

                    Me.Invoke(New TreathAddLog(AddressOf Me.AddLog), CodLinhas, "Reiniciado Thread")

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            CarregarListaLinks()

            If DtgListaLinks.Rows.Count > 0 Then

                IniciaListaExecucao()

                TimIsThread.Enabled = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub NtfGeral_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NtfGeral.MouseClick

        Try

            If Me.WindowState = FormWindowState.Minimized Then

                Me.Show()
                Me.WindowState = FormWindowState.Normal
                Me.ShowInTaskbar = True

            Else

                Me.WindowState = FormWindowState.Minimized
                Me.Hide()
                Me.ShowInTaskbar = False

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Principal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            TimIsThread.Stop()

            For Each Thr As Thread In GemThread

                If Thr.IsAlive = True Then

                    Thr.Abort()

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Sobre.ShowDialog()

    End Sub

    Private Sub Principal_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize

        Try

            If Me.WindowState = FormWindowState.Minimized Then

                Me.ShowInTaskbar = False
                Me.WindowState = FormWindowState.Minimized
                Me.Hide()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
