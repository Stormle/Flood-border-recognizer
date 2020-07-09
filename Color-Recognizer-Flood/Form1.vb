Public Class Form1
    Public screenGrab As Bitmap
    Public gra As Graphics
    Public objectedges(0) As Point
    Public npcedges(0) As Point
    Public bmp As Bitmap
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Function findobject(ByVal r As Integer, g As Integer, b As Integer, r2 As Integer, g2 As Integer, b2 As Integer, bmp2 As Bitmap)
        Try
            screenGrab.Dispose()
        Catch ex As Exception
        End Try
        Dim ts As DateTime = DateTime.Now
        Dim screenSize As Size = New Size(bmp2.Width, bmp2.Height)


        screenGrab = New Bitmap(bmp2)
        'THE MAIN OFFSET NUMBER HERE, MUST BE !!!ODD!!!
        Dim originaloffset As Integer = 8


        Dim changingoffset As Integer = originaloffset
        Dim pc As Color
        'GET REAL BMP RESOLUTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!@@@@@@@@@@@
        Dim totalheight As Integer = bmp2.Height / 2
        Dim totalwidth As Integer = bmp2.Width / originaloffset
        Dim r1offset As Integer = (r / 255 * 40) + 30
        Dim r2offset As Integer = (r2 / 255 * 40) + 30
        Dim g1offset As Integer = (g / 255 * 40) + 30
        Dim g2offset As Integer = (g2 / 255 * 40) + 30
        Dim b1offset As Integer = (b / 255 * 40) + 30
        Dim b2offset As Integer = (b2 / 255 * 40) + 30
        Dim R1bigfloodhelper As Integer = 0
        Dim R2bigfloodhelper As Integer = 0
        Dim B1bigfloodhelper As Integer = 0
        Dim B2bigfloodhelper As Integer = 0
        Dim G1bigfloodhelper As Integer = 0
        Dim G2bigfloodhelper As Integer = 0
        For iheight = 1 To totalheight

            For iwidth = 1 To totalwidth
                Dim currentpixelwidth As Integer = iwidth * originaloffset - changingoffset
                Dim currentpixelheight As Integer = iheight * 2 - 1
                Try
                    pc = screenGrab.GetPixel(currentpixelwidth, currentpixelheight)
                Catch ex As Exception
                    Console.WriteLine(currentpixelheight.ToString + currentpixelwidth.ToString)
                    Continue For
                End Try

                If Not pc = Color.Red Then
                    screenGrab.SetPixel(currentpixelwidth, currentpixelheight, Color.Purple)
                End If
                'Console.WriteLine(pc.R.ToString + " " + pc.G.ToString + " " + pc.B.ToString)
                'Handle Pixel color data here
                'Dim asasd As String = pc.R.ToString + "  " + r.ToString + " " + pc.G.ToString + "  " + g.ToString + "     " + g1offset.ToString + "  " + pc.B.ToString + "  " + b.ToString + "  " + b1offset.ToString
                'Console.WriteLine(asasd)
                If Math.Abs(pc.R - r) <= r1offset And Math.Abs(pc.G - g) <= g1offset And Math.Abs(pc.B - b) <= b1offset Then
                    'Console.WriteLine("found")
                    screenGrab.SetPixel(currentpixelwidth, currentpixelheight, Color.Red)
                    GoTo FLOOD
                ElseIf Math.Abs(pc.R - 0) <= 30 And Math.Abs(pc.G - 255) <= 70 And Math.Abs(pc.B - 0) <= 30 Then
                    screenGrab.SetPixel(currentpixelwidth, currentpixelheight, Color.Red)
                    GoTo FLOOD
                End If

                GoTo notamatch

FLOOD:
                Dim secondchance As Boolean = False
                Dim skipne As Boolean = False
                Dim skipse As Boolean = False
                Dim skipsw As Boolean = False
                Dim skipnw As Boolean = False
                Dim skipn As Boolean = False
                Dim skipe As Boolean = False
                Dim skips As Boolean = False
                Dim skipw As Boolean = False


                'Match was found, time to flood this bitch
                Dim startpoint As New Point(currentpixelwidth, currentpixelheight)
                Dim currentpoint As New Point(currentpixelwidth, currentpixelheight)
                'PictureBox1.Image = screenGrab
                'Delay(0.01)
                'Triboolean's explanation: (0 = searching, try the next one), (1 = found one, but we're not done with the flood), (2 = done with the flood)
                Dim triboolean As Integer = 0


                Dim allpoints As ArrayList = New ArrayList
                Dim lilfloodhelper As Integer = 0
                Dim bigfloodhelper As Integer = 0
                Dim templength As Integer = 0
                For do8times = 1 To 8
                    currentpoint = startpoint
                    'Console.WriteLine(do8times.ToString)
                    Do Until triboolean = 2
                        'Reset for each loop
                        triboolean = 0
renewloop:
                        If bigfloodhelper = 19 Then
                            bigfloodhelper += 1
                            r1offset = r / 255 * 20
                            r2offset = r / 255 * 20
                            b1offset = r / 255 * 20
                            b2offset = r / 255 * 20
                            g1offset = r / 255 * 20
                            g2offset = r / 255 * 20
                        ElseIf bigfloodhelper = 20 Then
                            bigfloodhelper = 0
                            r1offset = 0
                            r2offset = 0
                            b1offset = 0
                            b2offset = 0
                            g1offset = 0
                            g2offset = 0
                        End If
                        'PictureBox1.Image = screenGrab

                        Do Until triboolean = 1


                            'N-E
                            Try
                                If skipne = False Or secondchance = True Then


                                    Dim nepoint As New Point(currentpoint.X + 1, currentpoint.Y - 1)
                                    'This determins the offset of the flood's direction
                                    pc = screenGrab.GetPixel(nepoint.X, nepoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(nepoint.X, nepoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X + 1
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(nepoint.ToString)
                                        skipe = False
                                        skipn = False
                                        skipne = False
                                        skipnw = False
                                        skipse = False
                                        skips = True
                                        skipw = True
                                        skipsw = True
                                        secondchance = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = nepoint


                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(nepoint.X, nepoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X + 1
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(nepoint.ToString)
                                        skipe = False
                                        skipn = False
                                        skipne = False
                                        skipnw = False
                                        skipse = False
                                        skips = True
                                        skipw = True
                                        skipsw = True
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = nepoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception

                            End Try

                            'S-E

                            Try
                                If skipse = False Or secondchance = True Then
                                    Dim sepoint As New Point(currentpoint.X + 1, currentpoint.Y + 1)

                                    'This determins the offset of the flood's direction
                                    pc = screenGrab.GetPixel(sepoint.X, sepoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(sepoint.X, sepoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X + 1
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(sepoint.ToString)
                                        skipn = True
                                        skipw = True
                                        skipnw = True
                                        skipe = False
                                        skips = False
                                        skipne = False
                                        skipsw = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = sepoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(sepoint.X, sepoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X + 1
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(sepoint.ToString)
                                        skipn = True
                                        skipw = True
                                        skipnw = True
                                        skipe = False
                                        skips = False
                                        skipne = False
                                        skipsw = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = sepoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            'S-W
                            Try
                                If skipsw = False Or secondchance = True Then
                                    Dim swpoint As New Point(currentpoint.X - 1, currentpoint.Y + 1)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(swpoint.X, swpoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(swpoint.X, swpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(swpoint.ToString)
                                        skipn = True
                                        skipe = True
                                        skipne = True
                                        skipw = False
                                        skipnw = False
                                        skips = False
                                        skipsw = False
                                        secondchance = False
                                        skipse = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = swpoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(swpoint.X, swpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(swpoint.ToString)
                                        skipn = True
                                        skipe = True
                                        skipne = True
                                        skipw = False
                                        skipnw = False
                                        skips = False
                                        skipsw = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = swpoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            'N-W
                            Try
                                If skipnw = False Or secondchance = True Then
                                    Dim nwpoint As New Point(currentpoint.X - 1, currentpoint.Y - 1)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(nwpoint.X, nwpoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(nwpoint.ToString)
                                        skips = True
                                        skipe = True
                                        skipse = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skipne = False
                                        secondchance = False
                                        skipsw = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = nwpoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(nwpoint.ToString)
                                        skips = True
                                        skipe = True
                                        skipse = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skipne = False
                                        skipsw = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = nwpoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            'N
                            Try
                                If skipn = False Or secondchance = True Then
                                    Dim npoint As New Point(currentpoint.X, currentpoint.Y - 1)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(npoint.X, npoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(npoint.X, npoint.Y, Color.Red)
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(npoint.ToString)

                                        skips = True
                                        skipse = True
                                        skipsw = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skipe = False
                                        secondchance = False
                                        skipne = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = npoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(npoint.X, npoint.Y, Color.Red)
                                        currentpoint.Y = currentpoint.Y - 1
                                        allpoints.Add(npoint.ToString)

                                        skips = True
                                        skipse = True
                                        skipsw = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skipe = False
                                        skipne = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = npoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            'E oikeasti
                            Try
                                If skipe = False Or secondchance = True Then
                                    Dim npoint As New Point(currentpoint.X + 1, currentpoint.Y)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(npoint.X, npoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(npoint.X, npoint.Y, Color.White)
                                        currentpoint.X = currentpoint.X + 1
                                        allpoints.Add(npoint.ToString)

                                        skipw = True
                                        skipsw = True
                                        skipnw = True
                                        skipw = False
                                        skipe = False
                                        skips = False
                                        skipsw = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = npoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(npoint.X, npoint.Y, Color.White)
                                        currentpoint.X = currentpoint.X + 1
                                        allpoints.Add(npoint.ToString)

                                        skipw = True
                                        skipsw = True
                                        skipnw = True
                                        skipw = False
                                        skipe = False
                                        skips = False
                                        skipsw = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = npoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            's oikeasti
                            Try
                                If skips = False Or secondchance = True Then
                                    Dim nwpoint As New Point(currentpoint.X, currentpoint.Y + 1)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(nwpoint.X, nwpoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(nwpoint.ToString)
                                        skipn = True
                                        skipne = True
                                        skipnw = True
                                        skipn = False
                                        skipe = False
                                        skips = False
                                        skipne = False
                                        secondchance = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = nwpoint

                                        skipse = False
                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.Y = currentpoint.Y + 1
                                        allpoints.Add(nwpoint.ToString)
                                        skipn = True
                                        skipne = True
                                        skipnw = True
                                        skipn = False
                                        skipe = False
                                        skips = False
                                        skipne = False
                                        skipne = False
                                        skipse = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = nwpoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            'W
                            Try
                                If skipw = False Or secondchance = True Then
                                    Dim nwpoint As New Point(currentpoint.X - 1, currentpoint.Y)
                                    'This determins the offset of the flood's direction

                                    pc = screenGrab.GetPixel(nwpoint.X, nwpoint.Y)
                                    If Math.Abs(pc.R - r - R1bigfloodhelper) <= r1offset And Math.Abs(pc.G - g - G1bigfloodhelper) <= g1offset And Math.Abs(pc.B - b - B1bigfloodhelper) <= b1offset Then
                                        'Console.WriteLine("found")
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        allpoints.Add(nwpoint.ToString)
                                        skipne = True
                                        skipe = True
                                        skipse = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skips = False
                                        secondchance = False
                                        skipsw = False

                                        'Add to points list
                                        templength = objectedges.Length
                                        If objectedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve objectedges(templength)
                                            templength = objectedges.Length
                                        End If
                                        objectedges(templength - 1) = nwpoint

                                        GoTo renewloop
                                    ElseIf Math.Abs(pc.R - r2 - R2bigfloodhelper) <= r2offset And Math.Abs(pc.G - g2 - G2bigfloodhelper) <= g2offset And Math.Abs(pc.B - b2 - B2bigfloodhelper) <= b2offset Then
                                        screenGrab.SetPixel(nwpoint.X, nwpoint.Y, Color.Red)
                                        currentpoint.X = currentpoint.X - 1
                                        allpoints.Add(nwpoint.ToString)
                                        skipne = True
                                        skipe = True
                                        skipse = True
                                        skipn = False
                                        skipw = False
                                        skipnw = False
                                        skips = False
                                        skipsw = False
                                        secondchance = False

                                        'Add to points list
                                        templength = npcedges.Length
                                        If npcedges(0) = New Point(0, 0) Then
                                            'First loop. Using else because I'm not sure how VB will handle size differentiations in a 2D space
                                        Else
                                            ReDim Preserve npcedges(templength)
                                            templength = npcedges.Length
                                        End If
                                        npcedges(templength - 1) = nwpoint

                                        GoTo renewloop
                                    End If
                                End If
                            Catch ex As Exception
                            End Try

                            If secondchance = False Then
                                secondchance = True
                                GoTo renewloop
                            Else
                                skipne = False
                                skipe = False
                                skipse = False
                                skipn = False
                                skipw = False
                                skipnw = False
                                skips = False
                                skipsw = False
                                secondchance = False
                                bigfloodhelper = 19
                                screenGrab.SetPixel(currentpoint.X, currentpoint.Y, Color.Cyan)
                                allpoints.Clear()
                                GoTo nextloop
                            End If
                            'It got through without triggering anything, opening both loops

                        Loop
                    Loop
nextloop:
                Next do8times
                GoTo notamatch






notamatch:
            Next iwidth
            If changingoffset <> 1 Then
                changingoffset -= 1
            Else
                changingoffset = originaloffset
            End If
        Next iheight
        PictureBox1.Image = screenGrab

        Dim ts2 As TimeSpan = DateTime.Now.Subtract(ts)
        Console.WriteLine("Raking and flooding a full HD picture took " + ts2.TotalMilliseconds.ToString + " milliseconds!")
        Label6.Text = "Raking And flooding the picture took: " + ts2.TotalMilliseconds.ToString + " milliseconds"
        Return (npcedges, objectedges)
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            r2.Visible = True
            g2.Visible = True
            b2.Visible = True
        Else
            r2.Visible = False
            g2.Visible = False
            b2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures + "\testpictures"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        TextBox1.Text = OpenFileDialog1.FileName.ToString()


        If Not (strm Is Nothing) Then
            bmp = New Bitmap(TextBox1.Text)
            PictureBox1.Image = bmp
            'insert code to read the file data


            strm.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            findobject(r1.Text, g1.Text, b1.Text, r2.Text, g2.Text, b2.Text, bmp)
        Else
            findobject(r1.Text, g1.Text, b1.Text, 0, 0, 0, bmp)
        End If
    End Sub
End Class
