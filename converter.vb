Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Namespace _0x_Converter
    Public Partial Class Ox_converter
        Inherits Form

        Private pfc As PrivateFontCollection = New PrivateFontCollection()

        Private Sub LoadFont()
            Dim fontLength = Properties.Resources.Monospac821_BT.Length
            Dim fontdata = Properties.Resources.Monospac821_BT
            Dim data = Marshal.AllocCoTaskMem(fontLength)
            Marshal.Copy(fontdata, 0, data, fontLength)
            pfc.AddMemoryFont(data, fontLength)

            converter_title_lbl.Font = New Font(pfc.Families(0), converter_title_lbl.Font.Size, FontStyle.Bold)
            text_grb.Font = New Font(pfc.Families(0), text_grb.Font.Size)
            text_lbl.Font = New Font(pfc.Families(0), text_lbl.Font.Size)
            binary_grb.Font = New Font(pfc.Families(0), binary_grb.Font.Size)
            binary_lbl.Font = New Font(pfc.Families(0), binary_lbl.Font.Size)
            with_spaces_checkbox.Font = New Font(pfc.Families(0), with_spaces_checkbox.Font.Size)
            hex_grb.Font = New Font(pfc.Families(0), hex_grb.Font.Size)
            hex_lbl.Font = New Font(pfc.Families(0), hex_lbl.Font.Size)
            copy_hex_btn.Font = New Font(pfc.Families(0), copy_hex_btn.Font.Size)
            with_dash_hex_checkbox.Font = New Font(pfc.Families(0), with_dash_hex_checkbox.Font.Size)
            ascii_grb.Font = New Font(pfc.Families(0), ascii_grb.Font.Size)
            ascii_lbl.Font = New Font(pfc.Families(0), ascii_lbl.Font.Size)
            with_spaces_ascii_checkbox.Font = New Font(pfc.Families(0), with_spaces_ascii_checkbox.Font.Size)
            base64_grb.Font = New Font(pfc.Families(0), base64_grb.Font.Size)
            base64_lbl.Font = New Font(pfc.Families(0), base64_lbl.Font.Size)
            copy_base64_btn.Font = New Font(pfc.Families(0), copy_base64_btn.Font.Size)
            oct_grb.Font = New Font(pfc.Families(0), oct_grb.Font.Size)
            oct_lbl.Font = New Font(pfc.Families(0), oct_lbl.Font.Size)
            oct_with_spaces_checkbox.Font = New Font(pfc.Families(0), oct_with_spaces_checkbox.Font.Size)
            copied_lbl.Font = New Font(pfc.Families(0), copied_lbl.Font.Size)
            copyright_linklbl.Font = New Font(pfc.Families(0), copyright_linklbl.Font.Size)
        End Sub

        Public Sub New()
            InitializeComponent()
            LoadFont()
        End Sub

        Private Sub Ox_converter_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            pfc.Dispose()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ComboboxStart()
        End Sub

        Public mouseLocation As Point

        Private Sub mouse_down(ByVal sender As Object, ByVal e As MouseEventArgs)
            mouseLocation = New Point(-e.X, -e.Y)
        End Sub

        Private Sub mouse_move(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Dim mousePose = MousePosition
                mousePose.Offset(mouseLocation.X, mouseLocation.Y)
                Location = mousePose
            End If
        End Sub

        Private Sub ComboboxStart()
            If convert_cbx.SelectedIndex = -1 Then
                with_spaces_checkbox.Visible = False
                with_dash_hex_checkbox.Visible = False
                with_spaces_ascii_checkbox.Visible = False
                oct_with_spaces_checkbox.Visible = False
                requirements.Visible = False

                copy_text_btn.Visible = False
                copy_binary_btn.Visible = False
                copy_hex_btn.Visible = False
                copy_ascii_btn.Visible = False
                copy_base64_btn.Visible = False
                copy_oct_btn.Visible = False
                copy_all_btn.Visible = False

                text_lbl.Text = "Please"
                binary_lbl.Text = "select"
                hex_lbl.Text = "a"
                ascii_lbl.Text = "format"
                base64_lbl.Text = "in the"
                oct_lbl.Text = "Combobox"
            End If
        End Sub

        Private Sub convert_cbx_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            convert_text_box.Clear()

            with_spaces_checkbox.Visible = True
            with_dash_hex_checkbox.Visible = True
            with_spaces_ascii_checkbox.Visible = True
            oct_with_spaces_checkbox.Visible = True

            text_lbl.Text = ""
            binary_lbl.Text = ""
            hex_lbl.Text = ""
            ascii_lbl.Text = ""
            base64_lbl.Text = ""
            oct_lbl.Text = ""

            copy_text_btn.Visible = True
            copy_binary_btn.Visible = True
            copy_hex_btn.Visible = True
            copy_ascii_btn.Visible = True
            copy_base64_btn.Visible = True
            copy_oct_btn.Visible = True
            copy_all_btn.Visible = True

            If convert_cbx.SelectedIndex = 0 Then
                text_grb.Visible = False

                requirements.Visible = False
                binary_grb.Visible = True
                hex_grb.Visible = True
                ascii_grb.Visible = True
                base64_grb.Visible = True
                oct_grb.Visible = True

                with_spaces_checkbox.Checked = True
                with_spaces_ascii_checkbox.Checked = True
                oct_with_spaces_checkbox.Checked = True
            ElseIf convert_cbx.SelectedIndex = 1 Then
                binary_grb.Visible = False
                with_dash_hex_checkbox.Visible = False

                base64_grb.Visible = True
                requirements.Visible = False
                text_grb.Visible = True
                hex_grb.Visible = True
                ascii_grb.Visible = True
                oct_grb.Visible = True

                with_spaces_checkbox.Checked = True
                with_spaces_ascii_checkbox.Checked = True
                oct_with_spaces_checkbox.Visible = False
            ElseIf convert_cbx.SelectedIndex = 2 Then
                hex_grb.Visible = False
                with_spaces_checkbox.Visible = False
                oct_with_spaces_checkbox.Visible = False

                requirements.Visible = False
                text_grb.Visible = True
                binary_grb.Visible = True
                ascii_grb.Visible = True
                base64_grb.Visible = True
                oct_grb.Visible = True
            ElseIf convert_cbx.SelectedIndex = 3 Then
                ascii_grb.Visible = False

                requirements.Visible = True
                text_grb.Visible = True
                binary_grb.Visible = True
                hex_grb.Visible = True
                base64_grb.Visible = True
                oct_grb.Visible = True
            ElseIf convert_cbx.SelectedIndex = 4 Then
                base64_grb.Visible = False

                requirements.Visible = False
                text_grb.Visible = True
                binary_grb.Visible = True
                hex_grb.Visible = True
                ascii_grb.Visible = True
                oct_grb.Visible = True
            ElseIf convert_cbx.SelectedIndex = 5 Then
                oct_grb.Visible = False
                with_spaces_checkbox.Visible = False
                with_dash_hex_checkbox.Visible = False
                requirements.Visible = True

                text_grb.Visible = True
                binary_grb.Visible = True
                hex_grb.Visible = True
                ascii_grb.Visible = True
                base64_grb.Visible = True
            End If
        End Sub

        '

        Private Sub ComboboxErr()
            If convert_cbx.SelectedIndex = -1 Then
                '
                If Equals(convert_text_box.Text, "") Then
                Else
                    convert_text_box.Clear()
                    MessageBox.Show("You need to select a format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        '

        Public Shared Function ConvertToByteArray(ByVal str As String, ByVal encoding As Encoding) As Byte()
            Return encoding.GetBytes(str)
        End Function

        Public Shared Function StringToBinary(ByVal data As Byte()) As String
            Try
                Return String.Join(" ", data.Select(Function(byt) Convert.ToString(byt, 2).PadLeft(8, "0"c)))
            Catch
                Return "Can't convert"
            End Try
        End Function

        '

        Public Shared Function BinaryToString(ByVal data As String) As String
            data = data.Replace(" ", "")
            Dim byteList As List(Of Byte) = New List(Of Byte)()

            For i = 0 To data.Length - 1 Step 8
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2))
            Next

            Return Encoding.UTF8.GetString(byteList.ToArray())
        End Function

        '

        Public Shared Function HexToString(ByVal hex As String) As Byte()
            hex = hex.Replace("-", "").Replace(" ", "").Replace("0x", "")
            Dim raw = New Byte(hex.Length / 2 - 1) {}
            For i = 0 To raw.Length - 1
                raw(i) = Convert.ToByte(hex.Substring(i * 2, 2), 16)
            Next
            Return raw
        End Function

        '

        Public Shared Function StringToBase64(ByVal text As String) As String
            Dim plainTextBytes = Encoding.UTF8.GetBytes(text)
            Return Convert.ToBase64String(plainTextBytes)
        End Function

        '

        Public Shared Function Base64ToString(ByVal base64 As String) As String
            Dim data = Convert.FromBase64String(base64)
            Return Encoding.UTF8.GetString(data)
        End Function

        '

        Public Shared Function ConvertFromStringToHex(ByVal inputHex As String) As Byte()
            inputHex = inputHex.Replace("-", "").Replace(" ", "")

            Dim resultantArray = New Byte(inputHex.Length / 2 - 1) {}
            For i = 0 To resultantArray.Length - 1
                resultantArray(i) = Convert.ToByte(inputHex.Substring(i * 2, 2), 16)
            Next
            Return resultantArray
        End Function

        '

        Public Function IsNumeric(ByVal input As String) As Boolean
            Dim test As Integer
            Return Integer.TryParse(input, test)
        End Function

        '

        Public Function DecodeASCII(ByVal str As String) As String 'many thanks to ZioEren for this decoder <3
            If str.Contains(" ") Then
                Dim result = ""
                Dim splitted = str.Split(" "c)

                For Each number In splitted
                    If Not IsNumeric(number) Then
                        Return "Can't convert"
                    End If

                    Dim theNumber = Integer.Parse(number)
                    Dim theChar As Char = Microsoft.VisualBasic.ChrW(theNumber)
                    result += theChar
                Next

                Return result
            ElseIf IsNumeric(str) Then
                Return Microsoft.VisualBasic.ChrW(Integer.Parse(str)).ToString()
            End If

            Return ""
        End Function

        '

        Private Sub BinaryConversions()
            Dim convert = convert_text_box.Text

            If convert_cbx.SelectedIndex = 0 Then
                If with_spaces_checkbox.Checked = False Then
                    Try
                        binary_lbl.Text = StringToBinary(ConvertToByteArray(convert, Encoding.ASCII)).Replace(" ", "")
                    Catch
                        binary_lbl.Text = "Can't convert"
                    End Try
                ElseIf with_spaces_checkbox.Checked = True Then
                    Try
                        binary_lbl.Text = StringToBinary(ConvertToByteArray(convert, Encoding.ASCII))
                    Catch
                        binary_lbl.Text = "Can't convert"
                    End Try
                End If

            ElseIf convert_cbx.SelectedIndex = 3 Then
                Try
                    Dim asciitotext = DecodeASCII(convert)

                    If with_spaces_checkbox.Checked = False Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(asciitotext, Encoding.ASCII)).Replace(" ", "")
                        Catch
                            binary_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_spaces_checkbox.Checked = True Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(asciitotext, Encoding.ASCII))
                        Catch
                            binary_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

            ElseIf convert_cbx.SelectedIndex = 4 Then
                Try
                    Dim conv = Base64ToString(convert)

                    If with_spaces_checkbox.Checked = False Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(conv, Encoding.ASCII)).Replace(" ", "")
                        Catch
                            binary_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_spaces_checkbox.Checked = True Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(conv, Encoding.ASCII))
                        Catch
                            binary_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    binary_lbl.Text = "Can't convert"
                End Try
            End If
        End Sub

        Private Sub HexConversion()
            Dim convert = convert_text_box.Text

            If convert_cbx.SelectedIndex = 0 Then
                If with_dash_hex_checkbox.Checked = False Then
                    Try
                        Dim bytez = Encoding.Default.GetBytes(convert)
                        Dim hex = BitConverter.ToString(bytez)
                        hex = hex.Replace("-", "")
                        hex_lbl.Text = hex
                    Catch
                        hex_lbl.Text = "Can't convert"
                    End Try
                ElseIf with_dash_hex_checkbox.Checked = True Then
                    Try
                        Dim bytez = Encoding.Default.GetBytes(convert)
                        Dim hex = BitConverter.ToString(bytez)
                        hex_lbl.Text = hex
                    Catch
                        hex_lbl.Text = "Can't convert"
                    End Try
                End If

            ElseIf convert_cbx.SelectedIndex = 3 Then
                Try
                    Dim asciitotext = DecodeASCII(convert)

                    If with_dash_hex_checkbox.Checked = False Then
                        Try
                            Dim bytez = Encoding.Default.GetBytes(asciitotext)
                            Dim hex = BitConverter.ToString(bytez)
                            hex = hex.Replace("-", "")
                            hex_lbl.Text = hex
                        Catch
                            hex_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_dash_hex_checkbox.Checked = True Then
                        Try
                            Dim bytez = Encoding.Default.GetBytes(asciitotext)
                            Dim hex = BitConverter.ToString(bytez)
                            hex_lbl.Text = hex
                        Catch
                            hex_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

            ElseIf convert_cbx.SelectedIndex = 4 Then
                Try
                    Dim bytes = System.Convert.FromBase64String(convert)

                    If with_dash_hex_checkbox.Checked = False Then
                        Try
                            hex_lbl.Text = BitConverter.ToString(bytes).Replace("-", "")
                        Catch
                            hex_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_dash_hex_checkbox.Checked = True Then
                        Try
                            hex_lbl.Text = BitConverter.ToString(bytes)
                        Catch
                            hex_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    hex_lbl.Text = "Can't convert"
                End Try
            End If
        End Sub

        Private Sub AsciiConversions()
            Dim convert = convert_text_box.Text

            If convert_cbx.SelectedIndex = 0 Then
                If with_spaces_ascii_checkbox.Checked = False Then
                    Try
                        Dim ascii = Encoding.ASCII.GetBytes(convert)

                        ascii_lbl.Text = String.Join("", ascii.Where(Function(x) x < 127))
                    Catch
                        ascii_lbl.Text = "Can't convert"
                    End Try
                ElseIf with_spaces_ascii_checkbox.Checked = True Then
                    Try
                        Dim ascii = Encoding.ASCII.GetBytes(convert)

                        ascii_lbl.Text = String.Join(" ", ascii.Where(Function(x) x < 127))
                    Catch
                        ascii_lbl.Text = "Can't convert"
                    End Try
                End If
            ElseIf convert_cbx.SelectedIndex = 1 Then
                Try
                    Dim text = BinaryToString(convert)

                    If with_spaces_ascii_checkbox.Checked = False Then
                        Dim ascii = Encoding.ASCII.GetBytes(text)

                        ascii_lbl.Text = String.Join("", ascii.Where(Function(x) x < 127))
                    ElseIf with_spaces_ascii_checkbox.Checked = True Then
                        Dim ascii = Encoding.ASCII.GetBytes(text)

                        ascii_lbl.Text = String.Join(" ", ascii.Where(Function(x) x < 127))
                    End If

                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try
            ElseIf convert_cbx.SelectedIndex = 2 Then
                Try
                    convert = convert.Replace("-", "").Replace("0x", "").Replace(" ", "")
                    Dim bytez = HexToString(convert)
                    Dim hextotext = Encoding.ASCII.GetString(bytez)

                    If with_spaces_ascii_checkbox.Checked = False Then
                        Try
                            Dim ascii = Encoding.ASCII.GetBytes(hextotext)

                            ascii_lbl.Text = String.Join("", ascii.Where(Function(x) x < 127))
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_spaces_ascii_checkbox.Checked = True Then
                        Try
                            Dim ascii = Encoding.ASCII.GetBytes(hextotext)

                            ascii_lbl.Text = String.Join(" ", ascii.Where(Function(x) x < 127))
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try
            ElseIf convert_cbx.SelectedIndex = 3 Then
                Try
                    Dim asciitotext = DecodeASCII(convert)

                    If with_spaces_checkbox.Checked = False Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(asciitotext, Encoding.ASCII)).Replace(" ", "")
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_spaces_checkbox.Checked = True Then
                        Try
                            binary_lbl.Text = StringToBinary(ConvertToByteArray(asciitotext, Encoding.ASCII))
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try
            ElseIf convert_cbx.SelectedIndex = 4 Then
                Try
                    Dim conv = Base64ToString(convert)

                    If with_spaces_ascii_checkbox.Checked = False Then
                        Try
                            Dim ascii = Encoding.ASCII.GetBytes(conv)

                            ascii_lbl.Text = String.Join("", ascii.Where(Function(x) x < 127))
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    ElseIf with_spaces_ascii_checkbox.Checked = True Then
                        Try
                            Dim ascii = Encoding.ASCII.GetBytes(conv)

                            ascii_lbl.Text = String.Join(" ", ascii.Where(Function(x) x < 127))
                        Catch
                            ascii_lbl.Text = "Can't convert"
                        End Try
                    End If

                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try
            End If
        End Sub

        Private Sub OctConversions()
            Dim convert = convert_text_box.Text

            If convert_cbx.SelectedIndex = 0 Then
                If oct_with_spaces_checkbox.Checked = False Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Try
                            Dim s = convert.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                            oct_lbl.Text = s.Replace(" ", "")
                        Catch
                            oct_lbl.Text = "Can't convert"
                        End Try
                    End If
                ElseIf oct_with_spaces_checkbox.Checked = True Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Try
                            Dim s = convert.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                            oct_lbl.Text = s
                        Catch
                            oct_lbl.Text = "Can't convert"
                        End Try
                    End If
                End If

            ElseIf convert_cbx.SelectedIndex = 3 Then
                Dim asciitotext = DecodeASCII(convert)

                If oct_with_spaces_checkbox.Checked = False Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Try
                            Dim s = asciitotext.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                            oct_lbl.Text = s.Replace(" ", "")
                        Catch
                            oct_lbl.Text = "Can't convert"
                        End Try
                    End If
                ElseIf oct_with_spaces_checkbox.Checked = True Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Try
                            Dim s = asciitotext.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                            oct_lbl.Text = s
                        Catch
                            oct_lbl.Text = "Can't convert"
                        End Try
                    End If
                End If

            ElseIf convert_cbx.SelectedIndex = 4 Then
                Dim conv = Base64ToString(convert)

                If oct_with_spaces_checkbox.Checked = False Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Dim s = conv.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                        oct_lbl.Text = s.Replace(" ", "")
                    End If
                ElseIf oct_with_spaces_checkbox.Checked = True Then
                    If Equals(convert_text_box.Text, "") Then
                        oct_lbl.Text = ""
                    Else
                        Dim s = conv.Select(Function(c) System.Convert.ToInt32(c)).Select(Function(v) System.Convert.ToString(v, 8)).Aggregate(Function(v0, v1) $"{v0} {v1}")
                        oct_lbl.Text = s
                    End If
                End If
            End If
        End Sub

        '

        'conversions
        Private Sub textbox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

            ComboboxErr()
            Dim convert As String = convert_text_box.Text

            'text
            If convert_cbx.SelectedIndex = 0 Then
                'to binary
                Try
                    BinaryConversions()
                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

                'to hex
                Try
                    HexConversion()
                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

                'to ascii
                Try
                    AsciiConversions()
                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try

                'to base64
                Try
                    base64_lbl.Text = StringToBase64(convert)
                Catch
                    base64_lbl.Text = "Can't convert"
                End Try

                'to oct
                Try
                    OctConversions()
                Catch
                    oct_lbl.Text = "Can't convert"
                End Try
            End If

            '

            'binary
            If convert_cbx.SelectedIndex = 1 Then

                'to text
                Try
                    text_lbl.Text = BinaryToString(convert)
                Catch
                    text_lbl.Text = "Can't convert"
                End Try

                'to hex
                Try
                    Dim binary As String = convert.Replace(" ", "")
                    Dim result As New StringBuilder(binary.Length \ 8 + 1)

                    Dim mod4Len As Integer = binary.Length Mod 8
                    If mod4Len <> 0 Then
                        ' pad to length multiple of 8
                        binary = binary.PadLeft(((binary.Length \ 8) + 1) * 8, "0"c)
                    End If

                    For i As Integer = 0 To binary.Length - 1 Step 8
                        Dim eightBits As String = binary.Substring(i, 8)
                        result.AppendFormat("{0:X2}", System.Convert.ToByte(eightBits, 2))
                    Next i

                    hex_lbl.Text = result.ToString()
                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

                'to ASCII
                Try
                    AsciiConversions()
                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try

                'to base64
                Try
                    Dim conv As String = BinaryToString(convert)
                    base64_lbl.Text = StringToBase64(conv)
                Catch
                    base64_lbl.Text = "Can't convert"
                End Try

                'oct
                Try
                    convert = convert.Replace(" ", "")
                    Dim binary As Integer = System.Convert.ToInt32(convert, 2)
                    oct_lbl.Text = System.Convert.ToString(binary, 8)
                Catch
                    If convert_text_box.Text = "" Then
                        oct_lbl.Text = ""
                    Else
                        oct_lbl.Text = "Can't convert"
                    End If
                End Try

            End If
            '

            'hex
            If convert_cbx.SelectedIndex = 2 Then
                'to text
                Try
                    Dim bytez() As Byte = HexToString(convert)
                    text_lbl.Text = Encoding.ASCII.GetString(bytez)
                Catch
                    text_lbl.Text = "Can't convert"
                End Try

                'to binary
                Try
                    Dim conv As String = convert.Replace(" ", "").Replace("0x", "").Replace("-", "")
                    Dim binarystring As String = String.Join(String.Empty, conv.Select(Function(c) System.Convert.ToString(System.Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, "0"c)))

                    binary_lbl.Text = binarystring
                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

                'to ASCII
                Try
                    AsciiConversions()
                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try

                'to base64
                Try
                    Dim data() As Byte = ConvertFromStringToHex(convert.Replace(" ", "").Replace("0x", "").Replace("-", ""))
                    base64_lbl.Text = System.Convert.ToBase64String(data)
                Catch
                    base64_lbl.Text = "Can't convert"
                End Try

                'oct
                Try
                    Dim octal As String = ""
                    convert = convert.Replace(" ", "").Replace("-", "").Replace("0x", "")

                    For i As Integer = convert.Length To 1 Step -6
                        Dim threebyte As String
                        If i < 6 Then
                            threebyte = convert.Substring(0, convert.Length Mod 6)
                        Else
                            threebyte = convert.Substring(i - 6, 6)
                        End If

                        octal = System.Convert.ToString(System.Convert.ToInt32(threebyte, 16), 8) & octal
                    Next i

                    oct_lbl.Text = octal
                Catch
                    oct_lbl.Text = "Can't convert"
                End Try
            End If
            '

            'ASCII
            If convert_cbx.SelectedIndex = 3 Then
                'to text
                Try
                    text_lbl.Text = DecodeASCII(convert)
                Catch
                    text_lbl.Text = "Can't convert"
                End Try

                'to binary
                Try
                    AsciiConversions()
                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

                'to hex
                Try
                    HexConversion()
                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

                'to base64
                Try
                    Dim asciitotext As String = DecodeASCII(convert)

                    base64_lbl.Text = StringToBase64(asciitotext)
                Catch
                    base64_lbl.Text = "Can't convert"
                End Try

                'oct
                Try
                    OctConversions()
                Catch
                    oct_lbl.Text = "Can't convert"
                End Try
            End If
            '

            'base64
            If convert_cbx.SelectedIndex = 4 Then
                'to text
                Try
                    text_lbl.Text = Base64ToString(convert)
                Catch
                    text_lbl.Text = "Can't convert"
                End Try

                'to binary
                Try
                    BinaryConversions()
                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

                'to hex
                Try
                    HexConversion()
                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

                'to ASCII
                Try
                    AsciiConversions()
                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try

                'oct
                Try
                    OctConversions()
                Catch
                    oct_lbl.Text = "Can't convert"
                End Try
            End If
            '

            'oct
            If convert_cbx.SelectedIndex = 5 Then
                'to text
                Try
                    Dim bytez() As Byte = convert.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).Select(Function(s) CByte(System.Convert.ToInt32(s, 8))).ToArray()

                    text_lbl.Text = Encoding.UTF8.GetString(bytez)
                Catch
                    text_lbl.Text = "Can't convert"
                End Try

                'to binary
                Try
                    convert = convert.Replace(" ", "")
                    Dim tobinary As Integer = System.Convert.ToInt32(convert, 8)
                    binary_lbl.Text = System.Convert.ToString(tobinary, 2)
                Catch
                    binary_lbl.Text = "Can't convert"
                End Try

                'to hex
                Try
                    convert = convert.Replace(" ", "")
                    Dim tobinary As Integer = System.Convert.ToInt32(convert, 8)
                    Dim binary As String = System.Convert.ToString(tobinary, 2)

                    Dim result As New StringBuilder(binary.Length \ 8 + 1)

                    Dim mod4Len As Integer = binary.Length Mod 8
                    If mod4Len <> 0 Then
                        ' pad to length multiple of 8
                        binary = binary.PadLeft(((binary.Length \ 8) + 1) * 8, "0"c)
                    End If

                    For i As Integer = 0 To binary.Length - 1 Step 8
                        Dim eightBits As String = binary.Substring(i, 8)
                        result.AppendFormat("{0:X2}", System.Convert.ToByte(eightBits, 2))
                    Next i

                    hex_lbl.Text = result.ToString()
                Catch
                    hex_lbl.Text = "Can't convert"
                End Try

                'to ASCII
                Try
                    AsciiConversions()
                Catch
                    ascii_lbl.Text = "Can't convert"
                End Try

                'to base64
                Try
                    convert = convert_text_box.Text
                    Dim bytezz() As Byte = convert.Split({" "}, StringSplitOptions.RemoveEmptyEntries).Select(Function(ss) CByte(System.Convert.ToInt32(ss, 8))).ToArray()

                    base64_lbl.Text = StringToBase64(Encoding.UTF8.GetString(bytezz))
                Catch
                    base64_lbl.Text = "Can't convert"
                End Try
            End If
        End Sub


        '

        Private Sub with_spaces_checkbox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            BinaryConversions()
        End Sub

        Private Sub with_dash_hex_checkbox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            HexConversion()
        End Sub

        Private Sub with_spaces_ascii_checkbox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            AsciiConversions()
        End Sub

        Private Sub oct_with_spaces_checkbox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            OctConversions()
        End Sub

        Private Sub copy_text_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(text_lbl.Text, "") Then
            Else
                Clipboard.SetText(text_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_binary_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(binary_lbl.Text, "") Then
            Else
                Clipboard.SetText(binary_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_hex_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(hex_lbl.Text, "") Then
            Else
                Clipboard.SetText(hex_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_ascii_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(ascii_lbl.Text, "") Then
            Else
                Clipboard.SetText(ascii_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_base64_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(base64_lbl.Text, "") Then
            Else
                Clipboard.SetText(base64_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_oct_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            '
            If Equals(oct_lbl.Text, "") Then
            Else
                Clipboard.SetText(oct_lbl.Text)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub copy_all_btn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If convert_cbx.SelectedIndex = 0 Then
                Dim copyall = $"Text: {convert_text_box.Text}
Binary: {binary_lbl.Text}
Hex: {hex_lbl.Text}
ASCII: {ascii_lbl.Text}
Base64: {base64_lbl.Text}
Octal: {oct_lbl.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            ElseIf convert_cbx.SelectedIndex = 1 Then
                Dim copyall = $"Text: {text_lbl.Text}
Binary: {convert_text_box.Text}
Hex: {hex_lbl.Text}
ASCII: {ascii_lbl.Text}
Base64: {base64_lbl.Text}
Octal: {oct_lbl.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            ElseIf convert_cbx.SelectedIndex = 2 Then
                Dim copyall = $"Text: {text_lbl.Text}
Binary: {binary_lbl.Text}
Hex: {convert_text_box.Text}
ASCII: {ascii_lbl.Text}
Base64: {base64_lbl.Text}
Octal: {oct_lbl.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            ElseIf convert_cbx.SelectedIndex = 3 Then
                Dim copyall = $"Text: {text_lbl.Text}
Binary: {binary_lbl.Text}
Hex: {hex_lbl.Text}
ASCII: {convert_text_box.Text}
Base64: {base64_lbl.Text}
Octal: {oct_lbl.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            ElseIf convert_cbx.SelectedIndex = 4 Then
                Dim copyall = $"Text: {text_lbl.Text}
Binary: {binary_lbl.Text}
Hex: {hex_lbl.Text}
ASCII: {ascii_lbl.Text}
Base64: {convert_text_box.Text}
Octal: {oct_lbl.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            ElseIf convert_cbx.SelectedIndex = 5 Then
                Dim copyall = $"Text: {text_lbl.Text}
Binary: {binary_lbl.Text}
Hex: {hex_lbl.Text}
ASCII: {ascii_lbl.Text}
Base64: {base64_lbl.Text}
Octal: {convert_text_box.Text}"

                Clipboard.SetText(copyall)
                copied_lbl.Text = "Copied text!"

                Dim t = New Timer()
                t.Interval = 1200
                AddHandler t.Tick, Sub(s, en)
                                       copied_lbl.Text = ""
                                       t.Stop()
                                   End Sub
                t.Start()
            End If
        End Sub

        Private Sub guna2ControlBox2_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub guna2ControlBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("https://github.com/riccio333/0x-Converter")
        End Sub
    End Class
End Namespace
