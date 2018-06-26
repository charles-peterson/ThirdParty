<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpCarrier = New System.Windows.Forms.GroupBox()
        Me.rdoFedEx = New System.Windows.Forms.RadioButton()
        Me.rdoUPS = New System.Windows.Forms.RadioButton()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.dgThirdParty = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtcustnum = New System.Windows.Forms.TextBox()
        Me.txtcompanyname = New System.Windows.Forms.TextBox()
        Me.txtcarrier = New System.Windows.Forms.TextBox()
        Me.txtacctnum = New System.Windows.Forms.TextBox()
        Me.txtaddress1 = New System.Windows.Forms.TextBox()
        Me.txtaddress2 = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.txtzip = New System.Windows.Forms.TextBox()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.lblcustnum = New System.Windows.Forms.Label()
        Me.lblcompanyname = New System.Windows.Forms.Label()
        Me.lblcarrier = New System.Windows.Forms.Label()
        Me.lblacctnum = New System.Windows.Forms.Label()
        Me.lbladdress1 = New System.Windows.Forms.Label()
        Me.lbladdress2 = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblstate = New System.Windows.Forms.Label()
        Me.lblzip = New System.Windows.Forms.Label()
        Me.lblcountry = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.grpDatabase = New System.Windows.Forms.GroupBox()
        Me.rdoRiver = New System.Windows.Forms.RadioButton()
        Me.rdoArdisam = New System.Windows.Forms.RadioButton()
        Me.grpCarrier.SuspendLayout()
        CType(Me.dgThirdParty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCarrier
        '
        Me.grpCarrier.Controls.Add(Me.rdoFedEx)
        Me.grpCarrier.Controls.Add(Me.rdoUPS)
        Me.grpCarrier.Location = New System.Drawing.Point(461, 2)
        Me.grpCarrier.Name = "grpCarrier"
        Me.grpCarrier.Size = New System.Drawing.Size(136, 81)
        Me.grpCarrier.TabIndex = 0
        Me.grpCarrier.TabStop = False
        Me.grpCarrier.Text = "Carrier"
        '
        'rdoFedEx
        '
        Me.rdoFedEx.AutoSize = True
        Me.rdoFedEx.Location = New System.Drawing.Point(22, 44)
        Me.rdoFedEx.Name = "rdoFedEx"
        Me.rdoFedEx.Size = New System.Drawing.Size(55, 17)
        Me.rdoFedEx.TabIndex = 1
        Me.rdoFedEx.TabStop = True
        Me.rdoFedEx.Text = "FedEx"
        Me.rdoFedEx.UseVisualStyleBackColor = True
        '
        'rdoUPS
        '
        Me.rdoUPS.AutoSize = True
        Me.rdoUPS.Location = New System.Drawing.Point(22, 20)
        Me.rdoUPS.Name = "rdoUPS"
        Me.rdoUPS.Size = New System.Drawing.Size(47, 17)
        Me.rdoUPS.TabIndex = 0
        Me.rdoUPS.TabStop = True
        Me.rdoUPS.Text = "UPS"
        Me.rdoUPS.UseVisualStyleBackColor = True
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(94, 12)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustID.TabIndex = 1
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(12, 15)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(39, 13)
        Me.lblCustID.TabIndex = 2
        Me.lblCustID.Text = "CustID"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnGo.Location = New System.Drawing.Point(259, 8)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'dgThirdParty
        '
        Me.dgThirdParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgThirdParty.Location = New System.Drawing.Point(3, 166)
        Me.dgThirdParty.Name = "dgThirdParty"
        Me.dgThirdParty.Size = New System.Drawing.Size(1197, 79)
        Me.dgThirdParty.TabIndex = 4
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEdit.Location = New System.Drawing.Point(824, 9)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSave.Location = New System.Drawing.Point(969, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnNew.Location = New System.Drawing.Point(362, 8)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Visible = False
        '
        'txtcustnum
        '
        Me.txtcustnum.Location = New System.Drawing.Point(3, 50)
        Me.txtcustnum.Name = "txtcustnum"
        Me.txtcustnum.Size = New System.Drawing.Size(100, 20)
        Me.txtcustnum.TabIndex = 8
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Location = New System.Drawing.Point(109, 50)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(100, 20)
        Me.txtcompanyname.TabIndex = 9
        '
        'txtcarrier
        '
        Me.txtcarrier.Location = New System.Drawing.Point(215, 50)
        Me.txtcarrier.Name = "txtcarrier"
        Me.txtcarrier.Size = New System.Drawing.Size(100, 20)
        Me.txtcarrier.TabIndex = 10
        '
        'txtacctnum
        '
        Me.txtacctnum.Location = New System.Drawing.Point(321, 50)
        Me.txtacctnum.Name = "txtacctnum"
        Me.txtacctnum.Size = New System.Drawing.Size(100, 20)
        Me.txtacctnum.TabIndex = 11
        '
        'txtaddress1
        '
        Me.txtaddress1.Location = New System.Drawing.Point(427, 50)
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.Size = New System.Drawing.Size(100, 20)
        Me.txtaddress1.TabIndex = 12
        '
        'txtaddress2
        '
        Me.txtaddress2.Location = New System.Drawing.Point(533, 50)
        Me.txtaddress2.Name = "txtaddress2"
        Me.txtaddress2.Size = New System.Drawing.Size(100, 20)
        Me.txtaddress2.TabIndex = 13
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(639, 50)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(100, 20)
        Me.txtcity.TabIndex = 14
        '
        'txtstate
        '
        Me.txtstate.Location = New System.Drawing.Point(745, 50)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(100, 20)
        Me.txtstate.TabIndex = 15
        '
        'txtzip
        '
        Me.txtzip.Location = New System.Drawing.Point(851, 50)
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(100, 20)
        Me.txtzip.TabIndex = 16
        '
        'txtcountry
        '
        Me.txtcountry.Location = New System.Drawing.Point(960, 50)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(100, 20)
        Me.txtcountry.TabIndex = 17
        '
        'lblcustnum
        '
        Me.lblcustnum.AutoSize = True
        Me.lblcustnum.Location = New System.Drawing.Point(6, 30)
        Me.lblcustnum.Name = "lblcustnum"
        Me.lblcustnum.Size = New System.Drawing.Size(47, 13)
        Me.lblcustnum.TabIndex = 18
        Me.lblcustnum.Text = "custnum"
        '
        'lblcompanyname
        '
        Me.lblcompanyname.AutoSize = True
        Me.lblcompanyname.Location = New System.Drawing.Point(112, 30)
        Me.lblcompanyname.Name = "lblcompanyname"
        Me.lblcompanyname.Size = New System.Drawing.Size(76, 13)
        Me.lblcompanyname.TabIndex = 19
        Me.lblcompanyname.Text = "companyname"
        '
        'lblcarrier
        '
        Me.lblcarrier.AutoSize = True
        Me.lblcarrier.Location = New System.Drawing.Point(218, 30)
        Me.lblcarrier.Name = "lblcarrier"
        Me.lblcarrier.Size = New System.Drawing.Size(36, 13)
        Me.lblcarrier.TabIndex = 20
        Me.lblcarrier.Text = "carrier"
        '
        'lblacctnum
        '
        Me.lblacctnum.AutoSize = True
        Me.lblacctnum.Location = New System.Drawing.Point(324, 30)
        Me.lblacctnum.Name = "lblacctnum"
        Me.lblacctnum.Size = New System.Drawing.Size(48, 13)
        Me.lblacctnum.TabIndex = 21
        Me.lblacctnum.Text = "acctnum"
        '
        'lbladdress1
        '
        Me.lbladdress1.AutoSize = True
        Me.lbladdress1.Location = New System.Drawing.Point(430, 30)
        Me.lbladdress1.Name = "lbladdress1"
        Me.lbladdress1.Size = New System.Drawing.Size(50, 13)
        Me.lbladdress1.TabIndex = 22
        Me.lbladdress1.Text = "address1"
        '
        'lbladdress2
        '
        Me.lbladdress2.AutoSize = True
        Me.lbladdress2.Location = New System.Drawing.Point(536, 30)
        Me.lbladdress2.Name = "lbladdress2"
        Me.lbladdress2.Size = New System.Drawing.Size(50, 13)
        Me.lbladdress2.TabIndex = 23
        Me.lbladdress2.Text = "address2"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(642, 30)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(23, 13)
        Me.lblcity.TabIndex = 24
        Me.lblcity.Text = "city"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.Location = New System.Drawing.Point(748, 30)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.Size = New System.Drawing.Size(30, 13)
        Me.lblstate.TabIndex = 25
        Me.lblstate.Text = "state"
        '
        'lblzip
        '
        Me.lblzip.AutoSize = True
        Me.lblzip.Location = New System.Drawing.Point(854, 30)
        Me.lblzip.Name = "lblzip"
        Me.lblzip.Size = New System.Drawing.Size(20, 13)
        Me.lblzip.TabIndex = 26
        Me.lblzip.Text = "zip"
        '
        'lblcountry
        '
        Me.lblcountry.AutoSize = True
        Me.lblcountry.Location = New System.Drawing.Point(963, 30)
        Me.lblcountry.Name = "lblcountry"
        Me.lblcountry.Size = New System.Drawing.Size(42, 13)
        Me.lblcountry.TabIndex = 27
        Me.lblcountry.Text = "country"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcustnum)
        Me.GroupBox1.Controls.Add(Me.lblcountry)
        Me.GroupBox1.Controls.Add(Me.txtcustnum)
        Me.GroupBox1.Controls.Add(Me.lblzip)
        Me.GroupBox1.Controls.Add(Me.txtcompanyname)
        Me.GroupBox1.Controls.Add(Me.lblstate)
        Me.GroupBox1.Controls.Add(Me.txtcarrier)
        Me.GroupBox1.Controls.Add(Me.lblcity)
        Me.GroupBox1.Controls.Add(Me.txtacctnum)
        Me.GroupBox1.Controls.Add(Me.lbladdress2)
        Me.GroupBox1.Controls.Add(Me.txtaddress1)
        Me.GroupBox1.Controls.Add(Me.lbladdress1)
        Me.GroupBox1.Controls.Add(Me.txtaddress2)
        Me.GroupBox1.Controls.Add(Me.lblacctnum)
        Me.GroupBox1.Controls.Add(Me.txtcity)
        Me.GroupBox1.Controls.Add(Me.lblcarrier)
        Me.GroupBox1.Controls.Add(Me.txtstate)
        Me.GroupBox1.Controls.Add(Me.lblcompanyname)
        Me.GroupBox1.Controls.Add(Me.txtzip)
        Me.GroupBox1.Controls.Add(Me.txtcountry)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1095, 79)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'btnSaveNew
        '
        Me.btnSaveNew.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSaveNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSaveNew.Location = New System.Drawing.Point(969, 38)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNew.TabIndex = 29
        Me.btnSaveNew.Text = "Save"
        Me.btnSaveNew.UseVisualStyleBackColor = False
        Me.btnSaveNew.Visible = False
        '
        'grpDatabase
        '
        Me.grpDatabase.Controls.Add(Me.rdoRiver)
        Me.grpDatabase.Controls.Add(Me.rdoArdisam)
        Me.grpDatabase.Location = New System.Drawing.Point(603, 2)
        Me.grpDatabase.Name = "grpDatabase"
        Me.grpDatabase.Size = New System.Drawing.Size(136, 81)
        Me.grpDatabase.TabIndex = 2
        Me.grpDatabase.TabStop = False
        Me.grpDatabase.Text = "Database"
        '
        'rdoRiver
        '
        Me.rdoRiver.AutoSize = True
        Me.rdoRiver.Location = New System.Drawing.Point(22, 44)
        Me.rdoRiver.Name = "rdoRiver"
        Me.rdoRiver.Size = New System.Drawing.Size(58, 17)
        Me.rdoRiver.TabIndex = 1
        Me.rdoRiver.TabStop = True
        Me.rdoRiver.Text = "RIVER"
        Me.rdoRiver.UseVisualStyleBackColor = True
        '
        'rdoArdisam
        '
        Me.rdoArdisam.AutoSize = True
        Me.rdoArdisam.Checked = True
        Me.rdoArdisam.Location = New System.Drawing.Point(22, 20)
        Me.rdoArdisam.Name = "rdoArdisam"
        Me.rdoArdisam.Size = New System.Drawing.Size(74, 17)
        Me.rdoArdisam.TabIndex = 0
        Me.rdoArdisam.TabStop = True
        Me.rdoArdisam.Text = "ARDISAM"
        Me.rdoArdisam.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 312)
        Me.Controls.Add(Me.grpDatabase)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.grpCarrier)
        Me.Controls.Add(Me.dgThirdParty)
        Me.Name = "Form1"
        Me.Text = "Third Party Setup"
        Me.grpCarrier.ResumeLayout(False)
        Me.grpCarrier.PerformLayout()
        CType(Me.dgThirdParty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDatabase.ResumeLayout(False)
        Me.grpDatabase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCarrier As GroupBox
    Friend WithEvents rdoFedEx As RadioButton
    Friend WithEvents rdoUPS As RadioButton
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents lblCustID As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents dgThirdParty As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtcustnum As TextBox
    Friend WithEvents txtcompanyname As TextBox
    Friend WithEvents txtcarrier As TextBox
    Friend WithEvents txtacctnum As TextBox
    Friend WithEvents txtaddress1 As TextBox
    Friend WithEvents txtaddress2 As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtstate As TextBox
    Friend WithEvents txtzip As TextBox
    Friend WithEvents txtcountry As TextBox
    Friend WithEvents lblcustnum As Label
    Friend WithEvents lblcompanyname As Label
    Friend WithEvents lblcarrier As Label
    Friend WithEvents lblacctnum As Label
    Friend WithEvents lbladdress1 As Label
    Friend WithEvents lbladdress2 As Label
    Friend WithEvents lblcity As Label
    Friend WithEvents lblstate As Label
    Friend WithEvents lblzip As Label
    Friend WithEvents lblcountry As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents grpDatabase As GroupBox
    Friend WithEvents rdoRiver As RadioButton
    Friend WithEvents rdoArdisam As RadioButton
End Class
