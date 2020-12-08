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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.tbLast = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.tbFirst = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.clmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSAM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEmpID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.gbTelephone = New System.Windows.Forms.GroupBox()
        Me.tbAcctExpiry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbIPPhone = New System.Windows.Forms.TextBox()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.tbMobile = New System.Windows.Forms.TextBox()
        Me.tbPager = New System.Windows.Forms.TextBox()
        Me.tbHome = New System.Windows.Forms.TextBox()
        Me.lblIPPhone = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblPager = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.clmType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblUserDN = New System.Windows.Forms.Label()
        Me.gbDescription = New System.Windows.Forms.GroupBox()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.lblConjunction = New System.Windows.Forms.Label()
        Me.lblLocked = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.lblIAE = New System.Windows.Forms.Label()
        Me.lblHMB = New System.Windows.Forms.Label()
        Me.lblEMB = New System.Windows.Forms.Label()
        Me.lblCDepartment = New System.Windows.Forms.Label()
        Me.lblCurrentDepl = New System.Windows.Forms.Label()
        Me.lblCRole = New System.Windows.Forms.Label()
        Me.lblCurrentRole = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.tbManager = New System.Windows.Forms.TextBox()
        Me.lblMgr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.pbUserImg = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMailNickName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbTelephone.SuspendLayout()
        Me.gbDescription.SuspendLayout()
        CType(Me.pbUserImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.tbUserID)
        Me.GroupBox1.Controls.Add(Me.lblUserID)
        Me.GroupBox1.Controls.Add(Me.tbLast)
        Me.GroupBox1.Controls.Add(Me.lblLName)
        Me.GroupBox1.Controls.Add(Me.tbFirst)
        Me.GroupBox1.Controls.Add(Me.lblFName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 98)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'btnSearch
        '
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSearch.Location = New System.Drawing.Point(410, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbUserID
        '
        Me.tbUserID.Location = New System.Drawing.Point(124, 63)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(280, 20)
        Me.tbUserID.TabIndex = 3
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(9, 64)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(118, 13)
        Me.lblUserID.TabIndex = 7
        Me.lblUserID.Text = "User ID / Logon Name:"
        '
        'tbLast
        '
        Me.tbLast.Location = New System.Drawing.Point(272, 21)
        Me.tbLast.Name = "tbLast"
        Me.tbLast.Size = New System.Drawing.Size(223, 20)
        Me.tbLast.TabIndex = 2
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(236, 22)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(30, 13)
        Me.lblLName.TabIndex = 6
        Me.lblLName.Text = "Last:"
        '
        'tbFirst
        '
        Me.tbFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbFirst.Location = New System.Drawing.Point(41, 21)
        Me.tbFirst.Name = "tbFirst"
        Me.tbFirst.Size = New System.Drawing.Size(189, 20)
        Me.tbFirst.TabIndex = 1
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(6, 23)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(29, 13)
        Me.lblFName.TabIndex = 4
        Me.lblFName.Text = "First:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmName, Me.chType, Me.chSAM})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 149)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(507, 172)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'clmName
        '
        Me.clmName.Text = "Name"
        Me.clmName.Width = 94
        '
        'chType
        '
        Me.chType.Text = "Object Type"
        Me.chType.Width = 158
        '
        'chSAM
        '
        Me.chSAM.Text = "User Name"
        Me.chSAM.Width = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select a name on this list to view the data."
        '
        'tbEmpID
        '
        Me.tbEmpID.Location = New System.Drawing.Point(100, 395)
        Me.tbEmpID.Name = "tbEmpID"
        Me.tbEmpID.Size = New System.Drawing.Size(118, 20)
        Me.tbEmpID.TabIndex = 14
        Me.tbEmpID.Text = " "
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(12, 397)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.lblEmpID.TabIndex = 13
        Me.lblEmpID.Text = "Employee ID:"
        '
        'gbTelephone
        '
        Me.gbTelephone.Controls.Add(Me.tbAcctExpiry)
        Me.gbTelephone.Controls.Add(Me.Label6)
        Me.gbTelephone.Controls.Add(Me.tbIPPhone)
        Me.gbTelephone.Controls.Add(Me.tbFax)
        Me.gbTelephone.Controls.Add(Me.tbMobile)
        Me.gbTelephone.Controls.Add(Me.tbPager)
        Me.gbTelephone.Controls.Add(Me.tbHome)
        Me.gbTelephone.Controls.Add(Me.lblIPPhone)
        Me.gbTelephone.Controls.Add(Me.lblFax)
        Me.gbTelephone.Controls.Add(Me.lblMobile)
        Me.gbTelephone.Controls.Add(Me.lblPager)
        Me.gbTelephone.Controls.Add(Me.lblHome)
        Me.gbTelephone.Location = New System.Drawing.Point(15, 419)
        Me.gbTelephone.Name = "gbTelephone"
        Me.gbTelephone.Size = New System.Drawing.Size(214, 196)
        Me.gbTelephone.TabIndex = 17
        Me.gbTelephone.TabStop = False
        Me.gbTelephone.Text = "Account Information"
        '
        'tbAcctExpiry
        '
        Me.tbAcctExpiry.Location = New System.Drawing.Point(106, 143)
        Me.tbAcctExpiry.Name = "tbAcctExpiry"
        Me.tbAcctExpiry.Size = New System.Drawing.Size(97, 20)
        Me.tbAcctExpiry.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Account Expiration:"
        '
        'tbIPPhone
        '
        Me.tbIPPhone.Location = New System.Drawing.Point(82, 115)
        Me.tbIPPhone.Name = "tbIPPhone"
        Me.tbIPPhone.Size = New System.Drawing.Size(121, 20)
        Me.tbIPPhone.TabIndex = 9
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(82, 90)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(121, 20)
        Me.tbFax.TabIndex = 8
        '
        'tbMobile
        '
        Me.tbMobile.Location = New System.Drawing.Point(82, 65)
        Me.tbMobile.Name = "tbMobile"
        Me.tbMobile.Size = New System.Drawing.Size(121, 20)
        Me.tbMobile.TabIndex = 7
        '
        'tbPager
        '
        Me.tbPager.Location = New System.Drawing.Point(82, 40)
        Me.tbPager.Name = "tbPager"
        Me.tbPager.Size = New System.Drawing.Size(121, 20)
        Me.tbPager.TabIndex = 6
        '
        'tbHome
        '
        Me.tbHome.Location = New System.Drawing.Point(82, 15)
        Me.tbHome.Name = "tbHome"
        Me.tbHome.Size = New System.Drawing.Size(121, 20)
        Me.tbHome.TabIndex = 5
        '
        'lblIPPhone
        '
        Me.lblIPPhone.AutoSize = True
        Me.lblIPPhone.Location = New System.Drawing.Point(6, 117)
        Me.lblIPPhone.Name = "lblIPPhone"
        Me.lblIPPhone.Size = New System.Drawing.Size(79, 13)
        Me.lblIPPhone.TabIndex = 4
        Me.lblIPPhone.Text = "When Created:"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(6, 92)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(58, 13)
        Me.lblFax.TabIndex = 3
        Me.lblFax.Text = "Username:"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(6, 67)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(46, 13)
        Me.lblMobile.TabIndex = 2
        Me.lblMobile.Text = "Country:"
        '
        'lblPager
        '
        Me.lblPager.AutoSize = True
        Me.lblPager.Location = New System.Drawing.Point(6, 42)
        Me.lblPager.Name = "lblPager"
        Me.lblPager.Size = New System.Drawing.Size(76, 13)
        Me.lblPager.TabIndex = 1
        Me.lblPager.Text = "Email Address:"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(6, 17)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(72, 13)
        Me.lblHome.TabIndex = 0
        Me.lblHome.Text = "DisplayName:"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmType, Me.clmEMail})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(240, 416)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(564, 166)
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView2.TabIndex = 20
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'clmType
        '
        Me.clmType.Text = "Type"
        Me.clmType.Width = 53
        '
        'clmEMail
        '
        Me.clmEMail.Text = "E-Mail"
        Me.clmEMail.Width = 410
        '
        'lblUserDN
        '
        Me.lblUserDN.AutoSize = True
        Me.lblUserDN.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDN.ForeColor = System.Drawing.Color.Blue
        Me.lblUserDN.Location = New System.Drawing.Point(106, 327)
        Me.lblUserDN.Name = "lblUserDN"
        Me.lblUserDN.Size = New System.Drawing.Size(70, 14)
        Me.lblUserDN.TabIndex = 21
        Me.lblUserDN.Text = "         "
        '
        'gbDescription
        '
        Me.gbDescription.Controls.Add(Me.rtbDescription)
        Me.gbDescription.ForeColor = System.Drawing.Color.Black
        Me.gbDescription.Location = New System.Drawing.Point(11, 340)
        Me.gbDescription.Name = "gbDescription"
        Me.gbDescription.Size = New System.Drawing.Size(790, 50)
        Me.gbDescription.TabIndex = 23
        Me.gbDescription.TabStop = False
        Me.gbDescription.Text = "Description"
        '
        'rtbDescription
        '
        Me.rtbDescription.Location = New System.Drawing.Point(9, 19)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(775, 22)
        Me.rtbDescription.TabIndex = 10
        Me.rtbDescription.Text = ""
        '
        'lblConjunction
        '
        Me.lblConjunction.AutoSize = True
        Me.lblConjunction.Location = New System.Drawing.Point(735, 65)
        Me.lblConjunction.Name = "lblConjunction"
        Me.lblConjunction.Size = New System.Drawing.Size(19, 13)
        Me.lblConjunction.TabIndex = 52
        Me.lblConjunction.Text = "    "
        '
        'lblLocked
        '
        Me.lblLocked.AutoSize = True
        Me.lblLocked.Location = New System.Drawing.Point(756, 65)
        Me.lblLocked.Name = "lblLocked"
        Me.lblLocked.Size = New System.Drawing.Size(43, 13)
        Me.lblLocked.TabIndex = 51
        Me.lblLocked.Text = "            "
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Location = New System.Drawing.Point(689, 65)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(28, 13)
        Me.lblAccountStatus.TabIndex = 50
        Me.lblAccountStatus.Text = "       "
        '
        'lblIAE
        '
        Me.lblIAE.AutoSize = True
        Me.lblIAE.ForeColor = System.Drawing.Color.Navy
        Me.lblIAE.Location = New System.Drawing.Point(631, 65)
        Me.lblIAE.Name = "lblIAE"
        Me.lblIAE.Size = New System.Drawing.Size(60, 13)
        Me.lblIAE.TabIndex = 49
        Me.lblIAE.Text = "Account is:"
        '
        'lblHMB
        '
        Me.lblHMB.AutoSize = True
        Me.lblHMB.Location = New System.Drawing.Point(668, 51)
        Me.lblHMB.Name = "lblHMB"
        Me.lblHMB.Size = New System.Drawing.Size(70, 13)
        Me.lblHMB.TabIndex = 48
        Me.lblHMB.Text = "                     "
        '
        'lblEMB
        '
        Me.lblEMB.AutoSize = True
        Me.lblEMB.BackColor = System.Drawing.SystemColors.Control
        Me.lblEMB.ForeColor = System.Drawing.Color.Navy
        Me.lblEMB.Location = New System.Drawing.Point(631, 50)
        Me.lblEMB.Name = "lblEMB"
        Me.lblEMB.Size = New System.Drawing.Size(34, 13)
        Me.lblEMB.TabIndex = 47
        Me.lblEMB.Text = "Type:"
        '
        'lblCDepartment
        '
        Me.lblCDepartment.AutoSize = True
        Me.lblCDepartment.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCDepartment.Location = New System.Drawing.Point(662, 34)
        Me.lblCDepartment.Name = "lblCDepartment"
        Me.lblCDepartment.Size = New System.Drawing.Size(88, 13)
        Me.lblCDepartment.TabIndex = 46
        Me.lblCDepartment.Text = "                           "
        '
        'lblCurrentDepl
        '
        Me.lblCurrentDepl.AutoSize = True
        Me.lblCurrentDepl.ForeColor = System.Drawing.Color.Navy
        Me.lblCurrentDepl.Location = New System.Drawing.Point(631, 33)
        Me.lblCurrentDepl.Name = "lblCurrentDepl"
        Me.lblCurrentDepl.Size = New System.Drawing.Size(33, 13)
        Me.lblCurrentDepl.TabIndex = 45
        Me.lblCurrentDepl.Text = "Dept:"
        '
        'lblCRole
        '
        Me.lblCRole.AutoSize = True
        Me.lblCRole.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCRole.Location = New System.Drawing.Point(665, 17)
        Me.lblCRole.Name = "lblCRole"
        Me.lblCRole.Size = New System.Drawing.Size(88, 13)
        Me.lblCRole.TabIndex = 44
        Me.lblCRole.Text = "                           "
        '
        'lblCurrentRole
        '
        Me.lblCurrentRole.AutoSize = True
        Me.lblCurrentRole.ForeColor = System.Drawing.Color.Navy
        Me.lblCurrentRole.Location = New System.Drawing.Point(630, 16)
        Me.lblCurrentRole.Name = "lblCurrentRole"
        Me.lblCurrentRole.Size = New System.Drawing.Size(30, 13)
        Me.lblCurrentRole.TabIndex = 43
        Me.lblCurrentRole.Text = "Title:"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(523, 133)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 13)
        Me.lblNotes.TabIndex = 23
        Me.lblNotes.Text = "Notes:"
        '
        'rtbNotes
        '
        Me.rtbNotes.Location = New System.Drawing.Point(525, 149)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(276, 172)
        Me.rtbNotes.TabIndex = 22
        Me.rtbNotes.Text = ""
        '
        'tbManager
        '
        Me.tbManager.Enabled = False
        Me.tbManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbManager.ForeColor = System.Drawing.Color.Black
        Me.tbManager.Location = New System.Drawing.Point(576, 114)
        Me.tbManager.Name = "tbManager"
        Me.tbManager.Size = New System.Drawing.Size(219, 20)
        Me.tbManager.TabIndex = 21
        '
        'lblMgr
        '
        Me.lblMgr.AutoSize = True
        Me.lblMgr.Location = New System.Drawing.Point(524, 116)
        Me.lblMgr.Name = "lblMgr"
        Me.lblMgr.Size = New System.Drawing.Size(52, 13)
        Me.lblMgr.TabIndex = 20
        Me.lblMgr.Text = "Manager:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(630, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "UPN:"
        '
        'lblExpiry
        '
        Me.lblExpiry.AutoSize = True
        Me.lblExpiry.Location = New System.Drawing.Point(665, 83)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(28, 13)
        Me.lblExpiry.TabIndex = 54
        Me.lblExpiry.Text = "       "
        '
        'pbUserImg
        '
        Me.pbUserImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUserImg.Location = New System.Drawing.Point(529, 15)
        Me.pbUserImg.MaximumSize = New System.Drawing.Size(96, 96)
        Me.pbUserImg.Name = "pbUserImg"
        Me.pbUserImg.Size = New System.Drawing.Size(96, 96)
        Me.pbUserImg.TabIndex = 22
        Me.pbUserImg.TabStop = False
        Me.pbUserImg.Tag = "NoPhoto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Exchange Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "OU:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(630, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "MailNickName:"
        '
        'lblMailNickName
        '
        Me.lblMailNickName.AutoSize = True
        Me.lblMailNickName.Location = New System.Drawing.Point(715, 98)
        Me.lblMailNickName.Name = "lblMailNickName"
        Me.lblMailNickName.Size = New System.Drawing.Size(28, 13)
        Me.lblMailNickName.TabIndex = 58
        Me.lblMailNickName.Text = "       "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 627)
        Me.Controls.Add(Me.lblMailNickName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblExpiry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblConjunction)
        Me.Controls.Add(Me.rtbNotes)
        Me.Controls.Add(Me.lblLocked)
        Me.Controls.Add(Me.lblMgr)
        Me.Controls.Add(Me.tbManager)
        Me.Controls.Add(Me.lblAccountStatus)
        Me.Controls.Add(Me.lblIAE)
        Me.Controls.Add(Me.lblHMB)
        Me.Controls.Add(Me.lblEMB)
        Me.Controls.Add(Me.lblCDepartment)
        Me.Controls.Add(Me.lblCurrentDepl)
        Me.Controls.Add(Me.lblCRole)
        Me.Controls.Add(Me.lblCurrentRole)
        Me.Controls.Add(Me.gbDescription)
        Me.Controls.Add(Me.pbUserImg)
        Me.Controls.Add(Me.lblUserDN)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.gbTelephone)
        Me.Controls.Add(Me.tbEmpID)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Corporate AD Quick View"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTelephone.ResumeLayout(False)
        Me.gbTelephone.PerformLayout()
        Me.gbDescription.ResumeLayout(False)
        CType(Me.pbUserImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents tbLast As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents tbFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents clmName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chType As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSAM As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbEmpID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents gbTelephone As System.Windows.Forms.GroupBox
    Friend WithEvents tbIPPhone As System.Windows.Forms.TextBox
    Friend WithEvents tbFax As System.Windows.Forms.TextBox
    Friend WithEvents tbMobile As System.Windows.Forms.TextBox
    Friend WithEvents tbPager As System.Windows.Forms.TextBox
    Friend WithEvents tbHome As System.Windows.Forms.TextBox
    Friend WithEvents lblIPPhone As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblPager As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents clmType As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmEMail As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblUserDN As System.Windows.Forms.Label
    Friend WithEvents gbDescription As System.Windows.Forms.GroupBox
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents lblConjunction As System.Windows.Forms.Label
    Friend WithEvents lblLocked As System.Windows.Forms.Label
    Friend WithEvents lblAccountStatus As System.Windows.Forms.Label
    Friend WithEvents lblIAE As System.Windows.Forms.Label
    Friend WithEvents lblHMB As System.Windows.Forms.Label
    Friend WithEvents lblEMB As System.Windows.Forms.Label
    Friend WithEvents lblCDepartment As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDepl As System.Windows.Forms.Label
    Friend WithEvents lblCRole As System.Windows.Forms.Label
    Friend WithEvents lblCurrentRole As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents tbManager As System.Windows.Forms.TextBox
    Friend WithEvents lblMgr As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExpiry As Label
    Friend WithEvents pbUserImg As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMailNickName As Label
    Friend WithEvents tbAcctExpiry As TextBox
    Friend WithEvents Label6 As Label
End Class
