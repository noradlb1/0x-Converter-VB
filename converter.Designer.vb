Imports System
Namespace _0x_Converter
    Partial Class Ox_converter
        ''' <summary>
        ''' Variabile di progettazione necessaria.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Pulire le risorse in uso.
        ''' </summary>
        ''' <paramname="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Codice generato da Progettazione Windows Form"

        ''' <summary>
        ''' Metodo necessario per il supporto della finestra di progettazione. Non modificare
        ''' il contenuto del metodo con l'editor di codice.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Ox_converter))
            guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
            guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
            panel1 = New Windows.Forms.Panel()
            converter_title_lbl = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            copied_lbl = New Windows.Forms.Label()
            text_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            text_lbl = New Windows.Forms.Label()
            copy_text_btn = New Guna.UI2.WinForms.Guna2TileButton()
            requirements = New Windows.Forms.Label()
            oct_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            oct_with_spaces_checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
            oct_lbl = New Windows.Forms.Label()
            copy_oct_btn = New Guna.UI2.WinForms.Guna2TileButton()
            ascii_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            with_spaces_ascii_checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
            ascii_lbl = New Windows.Forms.Label()
            copy_ascii_btn = New Guna.UI2.WinForms.Guna2TileButton()
            hex_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            with_dash_hex_checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
            hex_lbl = New Windows.Forms.Label()
            copy_hex_btn = New Guna.UI2.WinForms.Guna2TileButton()
            base64_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            base64_lbl = New Windows.Forms.Label()
            copy_base64_btn = New Guna.UI2.WinForms.Guna2TileButton()
            binary_grb = New Guna.UI2.WinForms.Guna2GroupBox()
            with_spaces_checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
            binary_lbl = New Windows.Forms.Label()
            copy_binary_btn = New Guna.UI2.WinForms.Guna2TileButton()
            convert_text_box = New Windows.Forms.TextBox()
            convert_cbx = New Windows.Forms.ComboBox()
            copy_all_btn = New Siticone.Desktop.UI.Winforms.SiticoneRoundedButton()
            copyright_linklbl = New Windows.Forms.LinkLabel()
            panel1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            text_grb.SuspendLayout()
            oct_grb.SuspendLayout()
            ascii_grb.SuspendLayout()
            hex_grb.SuspendLayout()
            base64_grb.SuspendLayout()
            binary_grb.SuspendLayout()
            SuspendLayout()
            ' 
            ' guna2ControlBox2
            ' 
            guna2ControlBox2.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
            guna2ControlBox2.FillColor = Drawing.Color.FromArgb(20, 20, 20)
            guna2ControlBox2.IconColor = Drawing.Color.FromArgb(0, 255, 65)
            guna2ControlBox2.Location = New Drawing.Point(708, 3)
            guna2ControlBox2.Name = "guna2ControlBox2"
            guna2ControlBox2.Size = New Drawing.Size(45, 35)
            guna2ControlBox2.TabIndex = 27
            AddHandler guna2ControlBox2.Click, New EventHandler(AddressOf guna2ControlBox2_Click)
            ' 
            ' guna2ControlBox1
            ' 
            guna2ControlBox1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
            guna2ControlBox1.FillColor = Drawing.Color.FromArgb(20, 20, 20)
            guna2ControlBox1.ForeColor = Drawing.Color.Black
            guna2ControlBox1.IconColor = Drawing.Color.Red
            guna2ControlBox1.Location = New Drawing.Point(749, 3)
            guna2ControlBox1.Name = "guna2ControlBox1"
            guna2ControlBox1.Size = New Drawing.Size(51, 33)
            guna2ControlBox1.TabIndex = 28
            AddHandler guna2ControlBox1.Click, New EventHandler(AddressOf guna2ControlBox1_Click)
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.FromArgb(20, 20, 20)
            panel1.Controls.Add(guna2ControlBox2)
            panel1.Controls.Add(converter_title_lbl)
            panel1.Controls.Add(guna2ControlBox1)
            panel1.Controls.Add(pictureBox1)
            panel1.Dock = Windows.Forms.DockStyle.Top
            panel1.ForeColor = Drawing.Color.Black
            panel1.Location = New Drawing.Point(0, 0)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(800, 33)
            panel1.TabIndex = 27
            AddHandler panel1.MouseDown, New Windows.Forms.MouseEventHandler(AddressOf mouse_down)
            AddHandler panel1.MouseMove, New Windows.Forms.MouseEventHandler(AddressOf mouse_move)
            ' 
            ' converter_title_lbl
            ' 
            converter_title_lbl.AutoSize = True
            converter_title_lbl.Font = New Drawing.Font("Monospac821 BT", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            converter_title_lbl.ForeColor = Drawing.Color.FromArgb(0, 255, 65)
            converter_title_lbl.Location = New Drawing.Point(34, 10)
            converter_title_lbl.Name = "converter_title_lbl"
            converter_title_lbl.Size = New Drawing.Size(77, 21)
            converter_title_lbl.TabIndex = 24
            converter_title_lbl.Text = "Converter"
            converter_title_lbl.UseCompatibleTextRendering = True
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global._0x_Converter.Properties.Resources._0x
            pictureBox1.Location = New Drawing.Point(3, 4)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(32, 25)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 24
            pictureBox1.TabStop = False
            ' 
            ' copied_lbl
            ' 
            copied_lbl.Font = New Drawing.Font("Monospac821 BT", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            copied_lbl.ForeColor = Drawing.Color.FromArgb(0, 255, 65)
            copied_lbl.Location = New Drawing.Point(3, 532)
            copied_lbl.Name = "copied_lbl"
            copied_lbl.Size = New Drawing.Size(797, 26)
            copied_lbl.TabIndex = 37
            copied_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            copied_lbl.UseCompatibleTextRendering = True
            ' 
            ' text_grb
            ' 
            text_grb.BackColor = Drawing.Color.Transparent
            text_grb.BorderColor = Drawing.Color.FromArgb(4, 127, 210)
            text_grb.Controls.Add(text_lbl)
            text_grb.Controls.Add(copy_text_btn)
            text_grb.CustomBorderColor = Drawing.Color.FromArgb(4, 127, 210)
            text_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            text_grb.FillColor = Drawing.Color.Transparent
            text_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            text_grb.ForeColor = Drawing.Color.FromArgb(4, 127, 210)
            text_grb.Location = New Drawing.Point(94, 136)
            text_grb.Name = "text_grb"
            text_grb.Size = New Drawing.Size(194, 155)
            text_grb.TabIndex = 35
            text_grb.Text = "Text"
            text_grb.TextOffset = New Drawing.Point(-5, -5)
            text_grb.UseTransparentBackground = True
            ' 
            ' text_lbl
            ' 
            text_lbl.ForeColor = Drawing.Color.White
            text_lbl.Location = New Drawing.Point(3, 63)
            text_lbl.Name = "text_lbl"
            text_lbl.Size = New Drawing.Size(188, 19)
            text_lbl.TabIndex = 19
            text_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            text_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_text_btn
            ' 
            copy_text_btn.Animated = True
            copy_text_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_text_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_text_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_text_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_text_btn.FillColor = Drawing.Color.FromArgb(4, 127, 210)
            copy_text_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_text_btn.ForeColor = Drawing.Color.Black
            copy_text_btn.Location = New Drawing.Point(64, 110)
            copy_text_btn.Name = "copy_text_btn"
            copy_text_btn.Size = New Drawing.Size(64, 23)
            copy_text_btn.TabIndex = 14
            copy_text_btn.Text = "copy"
            AddHandler copy_text_btn.Click, New EventHandler(AddressOf copy_text_btn_Click)
            ' 
            ' requirements
            ' 
            requirements.Font = New Drawing.Font("Monospac821 BT", 7.5F)
            requirements.ForeColor = Drawing.Color.White
            requirements.Location = New Drawing.Point(3, 112)
            requirements.Name = "requirements"
            requirements.Size = New Drawing.Size(797, 15)
            requirements.TabIndex = 20
            requirements.Text = "requires spaces between values"
            requirements.TextAlign = Drawing.ContentAlignment.MiddleCenter
            requirements.UseCompatibleTextRendering = True
            ' 
            ' oct_grb
            ' 
            oct_grb.BackColor = Drawing.Color.Transparent
            oct_grb.BorderColor = Drawing.Color.FromArgb(148, 82, 165)
            oct_grb.Controls.Add(oct_with_spaces_checkbox)
            oct_grb.Controls.Add(oct_lbl)
            oct_grb.Controls.Add(copy_oct_btn)
            oct_grb.CustomBorderColor = Drawing.Color.FromArgb(148, 82, 165)
            oct_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            oct_grb.FillColor = Drawing.Color.Transparent
            oct_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            oct_grb.ForeColor = Drawing.Color.FromArgb(148, 82, 165)
            oct_grb.Location = New Drawing.Point(515, 324)
            oct_grb.Name = "oct_grb"
            oct_grb.Size = New Drawing.Size(194, 155)
            oct_grb.TabIndex = 34
            oct_grb.Text = "Octal code"
            oct_grb.TextOffset = New Drawing.Point(-5, -5)
            oct_grb.UseTransparentBackground = True
            ' 
            ' oct_with_spaces_checkbox
            ' 
            oct_with_spaces_checkbox.AutoSize = True
            oct_with_spaces_checkbox.CheckedState.BorderColor = Drawing.Color.FromArgb(148, 82, 165)
            oct_with_spaces_checkbox.CheckedState.BorderRadius = 0
            oct_with_spaces_checkbox.CheckedState.BorderThickness = 0
            oct_with_spaces_checkbox.CheckedState.FillColor = Drawing.Color.FromArgb(148, 82, 165)
            oct_with_spaces_checkbox.CheckMarkColor = Drawing.Color.Black
            oct_with_spaces_checkbox.Font = New Drawing.Font("Monospac821 BT", 9.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            oct_with_spaces_checkbox.ForeColor = Drawing.Color.White
            oct_with_spaces_checkbox.Location = New Drawing.Point(45, 84)
            oct_with_spaces_checkbox.Name = "oct_with_spaces_checkbox"
            oct_with_spaces_checkbox.Size = New Drawing.Size(105, 20)
            oct_with_spaces_checkbox.TabIndex = 28
            oct_with_spaces_checkbox.Text = "with spaces"
            oct_with_spaces_checkbox.UncheckedState.BorderColor = Drawing.Color.FromArgb(50, 50, 50)
            oct_with_spaces_checkbox.UncheckedState.BorderRadius = 0
            oct_with_spaces_checkbox.UncheckedState.BorderThickness = 0
            oct_with_spaces_checkbox.UncheckedState.FillColor = Drawing.Color.FromArgb(50, 50, 50)
            oct_with_spaces_checkbox.UseCompatibleTextRendering = True
            AddHandler oct_with_spaces_checkbox.CheckedChanged, New EventHandler(AddressOf oct_with_spaces_checkbox_CheckedChanged)
            ' 
            ' oct_lbl
            ' 
            oct_lbl.ForeColor = Drawing.Color.White
            oct_lbl.Location = New Drawing.Point(3, 63)
            oct_lbl.Name = "oct_lbl"
            oct_lbl.Size = New Drawing.Size(185, 19)
            oct_lbl.TabIndex = 19
            oct_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            oct_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_oct_btn
            ' 
            copy_oct_btn.Animated = True
            copy_oct_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_oct_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_oct_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_oct_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_oct_btn.FillColor = Drawing.Color.FromArgb(148, 82, 165)
            copy_oct_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_oct_btn.ForeColor = Drawing.Color.Black
            copy_oct_btn.Location = New Drawing.Point(64, 110)
            copy_oct_btn.Name = "copy_oct_btn"
            copy_oct_btn.Size = New Drawing.Size(64, 23)
            copy_oct_btn.TabIndex = 14
            copy_oct_btn.Text = "copy"
            AddHandler copy_oct_btn.Click, New EventHandler(AddressOf copy_oct_btn_Click)
            ' 
            ' ascii_grb
            ' 
            ascii_grb.BackColor = Drawing.Color.Transparent
            ascii_grb.BorderColor = Drawing.Color.FromArgb(253, 3, 0)
            ascii_grb.Controls.Add(with_spaces_ascii_checkbox)
            ascii_grb.Controls.Add(ascii_lbl)
            ascii_grb.Controls.Add(copy_ascii_btn)
            ascii_grb.CustomBorderColor = Drawing.Color.FromArgb(253, 3, 0)
            ascii_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            ascii_grb.FillColor = Drawing.Color.Transparent
            ascii_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            ascii_grb.ForeColor = Drawing.Color.FromArgb(253, 3, 0)
            ascii_grb.Location = New Drawing.Point(94, 324)
            ascii_grb.Name = "ascii_grb"
            ascii_grb.Size = New Drawing.Size(194, 155)
            ascii_grb.TabIndex = 33
            ascii_grb.Text = "ASCII code"
            ascii_grb.TextOffset = New Drawing.Point(-5, -5)
            ascii_grb.UseTransparentBackground = True
            ' 
            ' with_spaces_ascii_checkbox
            ' 
            with_spaces_ascii_checkbox.AutoSize = True
            with_spaces_ascii_checkbox.CheckedState.BorderColor = Drawing.Color.FromArgb(253, 3, 0)
            with_spaces_ascii_checkbox.CheckedState.BorderRadius = 0
            with_spaces_ascii_checkbox.CheckedState.BorderThickness = 0
            with_spaces_ascii_checkbox.CheckedState.FillColor = Drawing.Color.FromArgb(253, 3, 0)
            with_spaces_ascii_checkbox.CheckMarkColor = Drawing.Color.Black
            with_spaces_ascii_checkbox.Font = New Drawing.Font("Monospac821 BT", 9.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            with_spaces_ascii_checkbox.ForeColor = Drawing.Color.White
            with_spaces_ascii_checkbox.Location = New Drawing.Point(45, 84)
            with_spaces_ascii_checkbox.Name = "with_spaces_ascii_checkbox"
            with_spaces_ascii_checkbox.Size = New Drawing.Size(105, 20)
            with_spaces_ascii_checkbox.TabIndex = 27
            with_spaces_ascii_checkbox.Text = "with spaces"
            with_spaces_ascii_checkbox.UncheckedState.BorderColor = Drawing.Color.FromArgb(50, 50, 50)
            with_spaces_ascii_checkbox.UncheckedState.BorderRadius = 0
            with_spaces_ascii_checkbox.UncheckedState.BorderThickness = 0
            with_spaces_ascii_checkbox.UncheckedState.FillColor = Drawing.Color.FromArgb(50, 50, 50)
            with_spaces_ascii_checkbox.UseCompatibleTextRendering = True
            AddHandler with_spaces_ascii_checkbox.CheckedChanged, New EventHandler(AddressOf with_spaces_ascii_checkbox_CheckedChanged)
            ' 
            ' ascii_lbl
            ' 
            ascii_lbl.BackColor = Drawing.Color.Transparent
            ascii_lbl.ForeColor = Drawing.Color.White
            ascii_lbl.Location = New Drawing.Point(3, 63)
            ascii_lbl.Name = "ascii_lbl"
            ascii_lbl.Size = New Drawing.Size(188, 19)
            ascii_lbl.TabIndex = 19
            ascii_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ascii_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_ascii_btn
            ' 
            copy_ascii_btn.Animated = True
            copy_ascii_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_ascii_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_ascii_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_ascii_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_ascii_btn.FillColor = Drawing.Color.FromArgb(253, 3, 0)
            copy_ascii_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_ascii_btn.ForeColor = Drawing.Color.White
            copy_ascii_btn.Location = New Drawing.Point(64, 110)
            copy_ascii_btn.Name = "copy_ascii_btn"
            copy_ascii_btn.Size = New Drawing.Size(64, 23)
            copy_ascii_btn.TabIndex = 14
            copy_ascii_btn.Text = "copy"
            AddHandler copy_ascii_btn.Click, New EventHandler(AddressOf copy_ascii_btn_Click)
            ' 
            ' hex_grb
            ' 
            hex_grb.BackColor = Drawing.Color.Transparent
            hex_grb.BorderColor = Drawing.Color.FromArgb(0, 255, 65)
            hex_grb.Controls.Add(with_dash_hex_checkbox)
            hex_grb.Controls.Add(hex_lbl)
            hex_grb.Controls.Add(copy_hex_btn)
            hex_grb.CustomBorderColor = Drawing.Color.FromArgb(0, 255, 65)
            hex_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            hex_grb.FillColor = Drawing.Color.Transparent
            hex_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            hex_grb.ForeColor = Drawing.Color.FromArgb(0, 255, 65)
            hex_grb.Location = New Drawing.Point(515, 136)
            hex_grb.Name = "hex_grb"
            hex_grb.Size = New Drawing.Size(194, 155)
            hex_grb.TabIndex = 32
            hex_grb.Text = "Hex code"
            hex_grb.TextOffset = New Drawing.Point(-5, -5)
            hex_grb.UseTransparentBackground = True
            ' 
            ' with_dash_hex_checkbox
            ' 
            with_dash_hex_checkbox.AutoSize = True
            with_dash_hex_checkbox.CheckedState.BorderColor = Drawing.Color.FromArgb(0, 255, 65)
            with_dash_hex_checkbox.CheckedState.BorderRadius = 0
            with_dash_hex_checkbox.CheckedState.BorderThickness = 0
            with_dash_hex_checkbox.CheckedState.FillColor = Drawing.Color.FromArgb(0, 255, 65)
            with_dash_hex_checkbox.CheckMarkColor = Drawing.Color.Black
            with_dash_hex_checkbox.Font = New Drawing.Font("Monospac821 BT", 9.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            with_dash_hex_checkbox.ForeColor = Drawing.Color.White
            with_dash_hex_checkbox.Location = New Drawing.Point(45, 84)
            with_dash_hex_checkbox.Name = "with_dash_hex_checkbox"
            with_dash_hex_checkbox.Size = New Drawing.Size(105, 20)
            with_dash_hex_checkbox.TabIndex = 25
            with_dash_hex_checkbox.Text = "with dashes"
            with_dash_hex_checkbox.UncheckedState.BorderColor = Drawing.Color.FromArgb(50, 50, 50)
            with_dash_hex_checkbox.UncheckedState.BorderRadius = 0
            with_dash_hex_checkbox.UncheckedState.BorderThickness = 0
            with_dash_hex_checkbox.UncheckedState.FillColor = Drawing.Color.FromArgb(50, 50, 50)
            with_dash_hex_checkbox.UseCompatibleTextRendering = True
            AddHandler with_dash_hex_checkbox.CheckedChanged, New EventHandler(AddressOf with_dash_hex_checkbox_CheckedChanged)
            ' 
            ' hex_lbl
            ' 
            hex_lbl.ForeColor = Drawing.Color.White
            hex_lbl.Location = New Drawing.Point(3, 63)
            hex_lbl.Name = "hex_lbl"
            hex_lbl.Size = New Drawing.Size(188, 19)
            hex_lbl.TabIndex = 19
            hex_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            hex_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_hex_btn
            ' 
            copy_hex_btn.Animated = True
            copy_hex_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_hex_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_hex_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_hex_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_hex_btn.FillColor = Drawing.Color.FromArgb(0, 255, 65)
            copy_hex_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_hex_btn.ForeColor = Drawing.Color.Black
            copy_hex_btn.Location = New Drawing.Point(64, 110)
            copy_hex_btn.Name = "copy_hex_btn"
            copy_hex_btn.Size = New Drawing.Size(64, 23)
            copy_hex_btn.TabIndex = 14
            copy_hex_btn.Text = "copy"
            AddHandler copy_hex_btn.Click, New EventHandler(AddressOf copy_hex_btn_Click)
            ' 
            ' base64_grb
            ' 
            base64_grb.BackColor = Drawing.Color.Transparent
            base64_grb.BorderColor = Drawing.Color.Yellow
            base64_grb.Controls.Add(base64_lbl)
            base64_grb.Controls.Add(copy_base64_btn)
            base64_grb.CustomBorderColor = Drawing.Color.Yellow
            base64_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            base64_grb.FillColor = Drawing.Color.Transparent
            base64_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            base64_grb.ForeColor = Drawing.Color.Yellow
            base64_grb.Location = New Drawing.Point(305, 324)
            base64_grb.Name = "base64_grb"
            base64_grb.Size = New Drawing.Size(194, 155)
            base64_grb.TabIndex = 31
            base64_grb.Text = "Base64"
            base64_grb.TextOffset = New Drawing.Point(-5, -5)
            base64_grb.UseTransparentBackground = True
            ' 
            ' base64_lbl
            ' 
            base64_lbl.ForeColor = Drawing.Color.White
            base64_lbl.Location = New Drawing.Point(3, 63)
            base64_lbl.Name = "base64_lbl"
            base64_lbl.Size = New Drawing.Size(188, 19)
            base64_lbl.TabIndex = 19
            base64_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            base64_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_base64_btn
            ' 
            copy_base64_btn.Animated = True
            copy_base64_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_base64_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_base64_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_base64_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_base64_btn.FillColor = Drawing.Color.Yellow
            copy_base64_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_base64_btn.ForeColor = Drawing.Color.Black
            copy_base64_btn.Location = New Drawing.Point(64, 110)
            copy_base64_btn.Name = "copy_base64_btn"
            copy_base64_btn.Size = New Drawing.Size(64, 23)
            copy_base64_btn.TabIndex = 14
            copy_base64_btn.Text = "copy"
            AddHandler copy_base64_btn.Click, New EventHandler(AddressOf copy_base64_btn_Click)
            ' 
            ' binary_grb
            ' 
            binary_grb.BackColor = Drawing.Color.Transparent
            binary_grb.BorderColor = Drawing.Color.White
            binary_grb.Controls.Add(with_spaces_checkbox)
            binary_grb.Controls.Add(binary_lbl)
            binary_grb.Controls.Add(copy_binary_btn)
            binary_grb.CustomBorderColor = Drawing.Color.White
            binary_grb.CustomBorderThickness = New Windows.Forms.Padding(0, 1, 0, 0)
            binary_grb.FillColor = Drawing.Color.Transparent
            binary_grb.Font = New Drawing.Font("Monospac821 BT", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            binary_grb.ForeColor = Drawing.Color.White
            binary_grb.Location = New Drawing.Point(305, 136)
            binary_grb.Name = "binary_grb"
            binary_grb.Size = New Drawing.Size(194, 155)
            binary_grb.TabIndex = 30
            binary_grb.Text = "Binary code"
            binary_grb.TextOffset = New Drawing.Point(-5, -5)
            binary_grb.UseTransparentBackground = True
            ' 
            ' with_spaces_checkbox
            ' 
            with_spaces_checkbox.AutoSize = True
            with_spaces_checkbox.CheckedState.BorderColor = Drawing.Color.White
            with_spaces_checkbox.CheckedState.BorderRadius = 0
            with_spaces_checkbox.CheckedState.BorderThickness = 0
            with_spaces_checkbox.CheckedState.FillColor = Drawing.Color.White
            with_spaces_checkbox.CheckMarkColor = Drawing.Color.Black
            with_spaces_checkbox.Font = New Drawing.Font("Monospac821 BT", 9.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            with_spaces_checkbox.ForeColor = Drawing.Color.White
            with_spaces_checkbox.Location = New Drawing.Point(45, 84)
            with_spaces_checkbox.Name = "with_spaces_checkbox"
            with_spaces_checkbox.Size = New Drawing.Size(105, 20)
            with_spaces_checkbox.TabIndex = 26
            with_spaces_checkbox.Text = "with spaces"
            with_spaces_checkbox.UncheckedState.BorderColor = Drawing.Color.FromArgb(50, 50, 50)
            with_spaces_checkbox.UncheckedState.BorderRadius = 0
            with_spaces_checkbox.UncheckedState.BorderThickness = 0
            with_spaces_checkbox.UncheckedState.FillColor = Drawing.Color.FromArgb(50, 50, 50)
            with_spaces_checkbox.UseCompatibleTextRendering = True
            AddHandler with_spaces_checkbox.CheckedChanged, New EventHandler(AddressOf with_spaces_checkbox_CheckedChanged)
            ' 
            ' binary_lbl
            ' 
            binary_lbl.ForeColor = Drawing.Color.White
            binary_lbl.Location = New Drawing.Point(3, 63)
            binary_lbl.Name = "binary_lbl"
            binary_lbl.Size = New Drawing.Size(188, 19)
            binary_lbl.TabIndex = 19
            binary_lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
            binary_lbl.UseCompatibleTextRendering = True
            ' 
            ' copy_binary_btn
            ' 
            copy_binary_btn.Animated = True
            copy_binary_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_binary_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_binary_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_binary_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_binary_btn.FillColor = Drawing.Color.White
            copy_binary_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_binary_btn.ForeColor = Drawing.Color.Black
            copy_binary_btn.Location = New Drawing.Point(64, 110)
            copy_binary_btn.Name = "copy_binary_btn"
            copy_binary_btn.Size = New Drawing.Size(64, 23)
            copy_binary_btn.TabIndex = 14
            copy_binary_btn.Text = "copy"
            AddHandler copy_binary_btn.Click, New EventHandler(AddressOf copy_binary_btn_Click)
            ' 
            ' convert_text_box
            ' 
            convert_text_box.Font = New Drawing.Font("Open Sans Semibold", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            convert_text_box.Location = New Drawing.Point(268, 77)
            convert_text_box.Name = "convert_text_box"
            convert_text_box.Size = New Drawing.Size(105, 25)
            convert_text_box.TabIndex = 29
            AddHandler convert_text_box.TextChanged, New EventHandler(AddressOf textbox_TextChanged)
            ' 
            ' convert_cbx
            ' 
            convert_cbx.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            convert_cbx.Font = New Drawing.Font("Open Sans Semibold", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            convert_cbx.FormattingEnabled = True
            convert_cbx.Items.AddRange(New Object() {"Text", "Binary", "Hex", "ASCII", "Base64", "Octal"})
            convert_cbx.Location = New Drawing.Point(419, 77)
            convert_cbx.Name = "convert_cbx"
            convert_cbx.Size = New Drawing.Size(105, 26)
            convert_cbx.TabIndex = 28
            AddHandler convert_cbx.SelectedIndexChanged, New EventHandler(AddressOf convert_cbx_SelectedIndexChanged)
            ' 
            ' copy_all_btn
            ' 
            copy_all_btn.Animated = True
            copy_all_btn.BorderRadius = 15
            copy_all_btn.CheckedState.Parent = copy_all_btn
            copy_all_btn.CustomImages.Parent = copy_all_btn
            copy_all_btn.DisabledState.BorderColor = Drawing.Color.DarkGray
            copy_all_btn.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            copy_all_btn.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            copy_all_btn.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            copy_all_btn.DisabledState.Parent = copy_all_btn
            copy_all_btn.FillColor = Drawing.Color.FromArgb(0, 255, 65)
            copy_all_btn.Font = New Drawing.Font("Open Sans", 9.0F)
            copy_all_btn.ForeColor = Drawing.Color.Black
            copy_all_btn.HoverState.Parent = copy_all_btn
            copy_all_btn.Location = New Drawing.Point(357, 494)
            copy_all_btn.Name = "copy_all_btn"
            copy_all_btn.ShadowDecoration.Parent = copy_all_btn
            copy_all_btn.Size = New Drawing.Size(96, 32)
            copy_all_btn.TabIndex = 38
            copy_all_btn.Text = "copy all"
            AddHandler copy_all_btn.Click, New EventHandler(AddressOf copy_all_btn_Click)
            ' 
            ' copyright_linklbl
            ' 
            copyright_linklbl.ActiveLinkColor = Drawing.Color.FromArgb(0, 128, 33)
            copyright_linklbl.AutoSize = True
            copyright_linklbl.Font = New Drawing.Font("Monospac821 BT", 9.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            copyright_linklbl.LinkColor = Drawing.Color.FromArgb(0, 128, 33)
            copyright_linklbl.LinkVisited = True
            copyright_linklbl.Location = New Drawing.Point(0, 563)
            copyright_linklbl.Name = "copyright_linklbl"
            copyright_linklbl.Size = New Drawing.Size(222, 21)
            copyright_linklbl.TabIndex = 39
            copyright_linklbl.TabStop = True
            copyright_linklbl.Text = "Copyright © 2022, riccio333"
            copyright_linklbl.UseCompatibleTextRendering = True
            copyright_linklbl.VisitedLinkColor = Drawing.Color.FromArgb(0, 255, 65)
            AddHandler copyright_linklbl.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' Ox_converter
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Black
            ClientSize = New Drawing.Size(800, 579)
            Controls.Add(requirements)
            Controls.Add(copyright_linklbl)
            Controls.Add(copy_all_btn)
            Controls.Add(copied_lbl)
            Controls.Add(text_grb)
            Controls.Add(oct_grb)
            Controls.Add(ascii_grb)
            Controls.Add(hex_grb)
            Controls.Add(base64_grb)
            Controls.Add(binary_grb)
            Controls.Add(convert_text_box)
            Controls.Add(convert_cbx)
            Controls.Add(panel1)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            MaximizeBox = False
            Name = "Ox_converter"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "0x Converter"
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Ox_converter_FormClosing)
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            text_grb.ResumeLayout(False)
            oct_grb.ResumeLayout(False)
            oct_grb.PerformLayout()
            ascii_grb.ResumeLayout(False)
            ascii_grb.PerformLayout()
            hex_grb.ResumeLayout(False)
            hex_grb.PerformLayout()
            base64_grb.ResumeLayout(False)
            binary_grb.ResumeLayout(False)
            binary_grb.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
        Private panel1 As Windows.Forms.Panel
        Private converter_title_lbl As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private copied_lbl As Windows.Forms.Label
        Private text_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private requirements As Windows.Forms.Label
        Private text_lbl As Windows.Forms.Label
        Private copy_text_btn As Guna.UI2.WinForms.Guna2TileButton
        Private oct_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private oct_with_spaces_checkbox As Guna.UI2.WinForms.Guna2CheckBox
        Private oct_lbl As Windows.Forms.Label
        Private copy_oct_btn As Guna.UI2.WinForms.Guna2TileButton
        Private ascii_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private with_spaces_ascii_checkbox As Guna.UI2.WinForms.Guna2CheckBox
        Private ascii_lbl As Windows.Forms.Label
        Private copy_ascii_btn As Guna.UI2.WinForms.Guna2TileButton
        Private hex_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private with_dash_hex_checkbox As Guna.UI2.WinForms.Guna2CheckBox
        Private hex_lbl As Windows.Forms.Label
        Private copy_hex_btn As Guna.UI2.WinForms.Guna2TileButton
        Private base64_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private base64_lbl As Windows.Forms.Label
        Private copy_base64_btn As Guna.UI2.WinForms.Guna2TileButton
        Private binary_grb As Guna.UI2.WinForms.Guna2GroupBox
        Private with_spaces_checkbox As Guna.UI2.WinForms.Guna2CheckBox
        Private binary_lbl As Windows.Forms.Label
        Private copy_binary_btn As Guna.UI2.WinForms.Guna2TileButton
        Private convert_text_box As Windows.Forms.TextBox
        Private convert_cbx As Windows.Forms.ComboBox
        Private copy_all_btn As Siticone.Desktop.UI.Winforms.SiticoneRoundedButton
        Private copyright_linklbl As Windows.Forms.LinkLabel
    End Class
End Namespace
