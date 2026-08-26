Option Explicit On 

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Imports System.IO.DirectoryInfo
Imports Microsoft.VisualBasic

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents imlClassifications As System.Windows.Forms.ImageList
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tvwFiles As System.Windows.Forms.TreeView
    Friend WithEvents txtHeaders As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubFolders As System.Windows.Forms.CheckBox
    Friend WithEvents txtDrive As System.Windows.Forms.TextBox
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents txtElapsed As System.Windows.Forms.TextBox
    Friend WithEvents lblElapsed As System.Windows.Forms.Label
    Friend WithEvents txtMatched As System.Windows.Forms.TextBox
    Friend WithEvents lblMatched As System.Windows.Forms.Label
    Friend WithEvents txtSearched As System.Windows.Forms.TextBox
    Friend WithEvents lblSearched As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents lblOpening As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblColourKey As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.imlClassifications = New System.Windows.Forms.ImageList(Me.components)
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.chkAuto = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.chkSubFolders = New System.Windows.Forms.CheckBox
        Me.txtDrive = New System.Windows.Forms.TextBox
        Me.lblPath = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblOpening = New System.Windows.Forms.Label
        Me.btnPause = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtElapsed = New System.Windows.Forms.TextBox
        Me.lblElapsed = New System.Windows.Forms.Label
        Me.txtMatched = New System.Windows.Forms.TextBox
        Me.lblMatched = New System.Windows.Forms.Label
        Me.txtSearched = New System.Windows.Forms.TextBox
        Me.lblSearched = New System.Windows.Forms.Label
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.lblSelected = New System.Windows.Forms.Label
        Me.txtHeaders = New System.Windows.Forms.TextBox
        Me.tvwFiles = New System.Windows.Forms.TreeView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblColourKey = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imlClassifications
        '
        Me.imlClassifications.ImageSize = New System.Drawing.Size(16, 16)
        Me.imlClassifications.ImageStream = CType(resources.GetObject("imlClassifications.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlClassifications.TransparentColor = System.Drawing.Color.Transparent
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.TabPage1)
        Me.tabMain.Controls.Add(Me.TabPage2)
        Me.tabMain.Location = New System.Drawing.Point(8, 8)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(808, 344)
        Me.tabMain.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.chkAuto)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.chkSubFolders)
        Me.TabPage1.Controls.Add(Me.txtDrive)
        Me.TabPage1.Controls.Add(Me.lblPath)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(800, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Options"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 56)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "This application will search for all *.doc files under the given path.  For any f" & _
        "iles found, the user can optionally manually display the headers in each file (b" & _
        "y clicking the filenames one at a time), or by selecting the ""Only show CLASSIFI" & _
        "ED..."" checkbox, MS Word will be opened for each file found to check for the ins" & _
        "tance of select words in the header of each section.  This application is not en" & _
        "dorsed in any way by any Authority and does not replace any established procedur" & _
        "es.  The Author takes no responsibility for the outcome arising from the use, mi" & _
        "suse or non-use of this application.  Use at your own risk."
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(336, 64)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 24)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        '
        'chkAuto
        '
        Me.chkAuto.Location = New System.Drawing.Point(8, 104)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(320, 16)
        Me.chkAuto.TabIndex = 21
        Me.chkAuto.Text = "Only show CLASSIFIED documents (VERY time intensive)"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(8, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(136, 16)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Create log (\[date].log)"
        '
        'chkSubFolders
        '
        Me.chkSubFolders.Checked = True
        Me.chkSubFolders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSubFolders.Location = New System.Drawing.Point(248, 64)
        Me.chkSubFolders.Name = "chkSubFolders"
        Me.chkSubFolders.Size = New System.Drawing.Size(88, 16)
        Me.chkSubFolders.TabIndex = 19
        Me.chkSubFolders.Text = "Subfolders"
        '
        'txtDrive
        '
        Me.txtDrive.Location = New System.Drawing.Point(48, 64)
        Me.txtDrive.Name = "txtDrive"
        Me.txtDrive.Size = New System.Drawing.Size(192, 20)
        Me.txtDrive.TabIndex = 18
        Me.txtDrive.Text = "C:"
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(8, 64)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 16)
        Me.lblPath.TabIndex = 17
        Me.lblPath.Text = "Path"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblOpening)
        Me.TabPage2.Controls.Add(Me.btnPause)
        Me.TabPage2.Controls.Add(Me.lblStatus)
        Me.TabPage2.Controls.Add(Me.txtElapsed)
        Me.TabPage2.Controls.Add(Me.lblElapsed)
        Me.TabPage2.Controls.Add(Me.txtMatched)
        Me.TabPage2.Controls.Add(Me.lblMatched)
        Me.TabPage2.Controls.Add(Me.txtSearched)
        Me.TabPage2.Controls.Add(Me.lblSearched)
        Me.TabPage2.Controls.Add(Me.txtFilename)
        Me.TabPage2.Controls.Add(Me.lblSelected)
        Me.TabPage2.Controls.Add(Me.txtHeaders)
        Me.TabPage2.Controls.Add(Me.tvwFiles)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(800, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Results"
        '
        'lblOpening
        '
        Me.lblOpening.Location = New System.Drawing.Point(432, 96)
        Me.lblOpening.Name = "lblOpening"
        Me.lblOpening.Size = New System.Drawing.Size(344, 16)
        Me.lblOpening.TabIndex = 29
        Me.lblOpening.Text = "Opening...."
        Me.lblOpening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOpening.Visible = False
        '
        'btnPause
        '
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.Location = New System.Drawing.Point(728, 248)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(64, 24)
        Me.btnPause.TabIndex = 28
        Me.btnPause.Text = "Pause"
        Me.btnPause.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(424, 288)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(368, 16)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Idle"
        '
        'txtElapsed
        '
        Me.txtElapsed.Location = New System.Drawing.Point(336, 288)
        Me.txtElapsed.Name = "txtElapsed"
        Me.txtElapsed.ReadOnly = True
        Me.txtElapsed.Size = New System.Drawing.Size(80, 20)
        Me.txtElapsed.TabIndex = 26
        Me.txtElapsed.Text = "0"
        Me.txtElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblElapsed
        '
        Me.lblElapsed.Location = New System.Drawing.Point(288, 288)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(48, 16)
        Me.lblElapsed.TabIndex = 25
        Me.lblElapsed.Text = "Elapsed"
        '
        'txtMatched
        '
        Me.txtMatched.Location = New System.Drawing.Point(200, 288)
        Me.txtMatched.Name = "txtMatched"
        Me.txtMatched.ReadOnly = True
        Me.txtMatched.Size = New System.Drawing.Size(80, 20)
        Me.txtMatched.TabIndex = 24
        Me.txtMatched.Text = "0"
        Me.txtMatched.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMatched
        '
        Me.lblMatched.Location = New System.Drawing.Point(152, 288)
        Me.lblMatched.Name = "lblMatched"
        Me.lblMatched.Size = New System.Drawing.Size(48, 16)
        Me.lblMatched.TabIndex = 23
        Me.lblMatched.Text = "Matched"
        '
        'txtSearched
        '
        Me.txtSearched.Location = New System.Drawing.Point(64, 288)
        Me.txtSearched.Name = "txtSearched"
        Me.txtSearched.ReadOnly = True
        Me.txtSearched.Size = New System.Drawing.Size(80, 20)
        Me.txtSearched.TabIndex = 22
        Me.txtSearched.Text = "0"
        Me.txtSearched.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSearched
        '
        Me.lblSearched.Location = New System.Drawing.Point(8, 288)
        Me.lblSearched.Name = "lblSearched"
        Me.lblSearched.Size = New System.Drawing.Size(56, 16)
        Me.lblSearched.TabIndex = 21
        Me.lblSearched.Text = "Searched"
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilename.Location = New System.Drawing.Point(8, 248)
        Me.txtFilename.Multiline = True
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(712, 32)
        Me.txtFilename.TabIndex = 20
        Me.txtFilename.Text = ""
        '
        'lblSelected
        '
        Me.lblSelected.Location = New System.Drawing.Point(8, 232)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(104, 16)
        Me.lblSelected.TabIndex = 19
        Me.lblSelected.Text = "Selected filename:"
        '
        'txtHeaders
        '
        Me.txtHeaders.Location = New System.Drawing.Point(424, 8)
        Me.txtHeaders.Multiline = True
        Me.txtHeaders.Name = "txtHeaders"
        Me.txtHeaders.ReadOnly = True
        Me.txtHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHeaders.Size = New System.Drawing.Size(368, 216)
        Me.txtHeaders.TabIndex = 18
        Me.txtHeaders.Text = ""
        '
        'tvwFiles
        '
        Me.tvwFiles.ImageList = Me.imlClassifications
        Me.tvwFiles.Location = New System.Drawing.Point(8, 8)
        Me.tvwFiles.Name = "tvwFiles"
        Me.tvwFiles.ShowLines = False
        Me.tvwFiles.ShowPlusMinus = False
        Me.tvwFiles.ShowRootLines = False
        Me.tvwFiles.Size = New System.Drawing.Size(408, 216)
        Me.tvwFiles.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lblColourKey
        '
        Me.lblColourKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColourKey.Location = New System.Drawing.Point(8, 8)
        Me.lblColourKey.Name = "lblColourKey"
        Me.lblColourKey.Size = New System.Drawing.Size(160, 16)
        Me.lblColourKey.TabIndex = 25
        Me.lblColourKey.Text = "Key to colours:"
        Me.lblColourKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 104)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(8, 128)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(8, 32)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Unknown\Unclassified"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Restricted"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Confidential"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Secret"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Top Secret"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblColourKey)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(8, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 152)
        Me.Panel1.TabIndex = 35
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 358)
        Me.Controls.Add(Me.tabMain)
        Me.MinimumSize = New System.Drawing.Size(432, 320)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecSearch Personal"
        Me.tabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Constants "

    Private Const vbDot = 46
    Private Const MAX_PATH = 260
    Private Const INVALID_HANDLE_VALUE = -1
    Private Const vbBackslash = "\"
    Private Const ALL_FILES = "*.*"

#End Region

#Region " Structures "

    Private Structure FILETIME
        Dim dwLowDateTime As Integer     ' LONG in VB6
        Dim dwHighDateTime As Integer    ' LONG in VB6
    End Structure

    Private Structure WIN32_FIND_DATA
        Dim dwFileAttributes As Integer  ' LONG in VB6
        Dim ftCreationTime As FILETIME
        Dim ftLastAccessTime As FILETIME
        Dim ftLastWriteTime As FILETIME
        Dim nFileSizeHigh As Integer     ' LONG in VB6
        Dim nFileSizeLow As Integer      ' LONG in VB6
        Dim dwReserved0 As Integer       ' LONG in VB6
        Dim dwReserved1 As Integer       ' LONG in VB6
        <VBFixedString(MAX_PATH), System.Runtime.Interopservices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, sizeconst:=MAX_PATH)> Public cFilename As String
        <VBFixedString(14), System.Runtime.Interopservices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, sizeconst:=14)> Public cAlternate As String
    End Structure

    Private Structure FILE_PARAMS
        Dim bRecurse As Boolean
        Dim nCount As Integer            ' LONG in VB6
        Dim nSearched As Integer         ' LONG in VB6
        Dim sFileNameExt As String
        Dim sFileRoot As String
    End Structure

#End Region

#Region " Declares "

    Private Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Integer) As Integer
    Private Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" _
                                               (ByVal lpFileName As String, _
                                                ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
    Private Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" _
                                              (ByVal hFindFile As Integer, _
                                               ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
    Private Declare Function GetTickCount Lib "kernel32" () As Integer
    Private Declare Function lstrlen Lib "kernel32" Alias "lstrlenW" (ByVal lpString As Long) As Integer
    Private Declare Function PathMatchSpec Lib "shlwapi" Alias "PathMatchSpecW" _
                                               (ByVal pszFileParam As Integer, _
                                                ByVal pszSpec As Long) As Integer

#End Region

#Region " ""Public"" variables "

    Private fp As FILE_PARAMS        ' Holds search parameters
    Private bPause As Boolean        ' Enables us to pause the search
    Private bDoExit As Boolean       ' Quit application
    Private strLogFilename As String
    Private oLogfile As StreamWriter
    Private oWord As Microsoft.Office.Interop.Word.Application

#End Region

#Region " Helper Functions "

    Private Sub SearchForFiles(ByVal sRoot As String)

        Dim WFD As New WIN32_FIND_DATA
        Dim hFile As Integer            ' LONG in VB6
        Dim oNode As TreeNode
        Dim strClassification As String

        hFile = FindFirstFile(sRoot & ALL_FILES, WFD)

        If hFile <> INVALID_HANDLE_VALUE Then

            Do

                'If a folder, and recurse specified, call method again
                If (WFD.dwFileAttributes And vbDirectory) Then
                    If Asc(WFD.cFilename) <> vbDot Then

                        If fp.bRecurse Then
                            SearchForFiles(sRoot & TrimNull(WFD.cFilename) & vbBackslash)
                        End If
                    End If

                Else

                    'Must be a file..
                    If MatchSpec(WFD.cFilename, fp.sFileNameExt) Then
                        If Me.chkAuto.Checked = True Then
                            strClassification = GetClassification(sRoot & TrimNull(WFD.cFilename))
                            If strClassification <> "" Then
                                fp.nCount = fp.nCount + 1
                                oNode = tvwFiles.Nodes.Add(sRoot & TrimNull(WFD.cFilename))
                                WriteToLog("FILE: " & sRoot & TrimNull(WFD.cFilename))
                                Select Case strClassification
                                    Case "RESTRICTED"
                                        oNode.ImageIndex = 1
                                    Case "CONFIDENTIAL"
                                        oNode.ImageIndex = 2
                                    Case "SECRET"
                                        oNode.ImageIndex = 3
                                    Case "TOP SECRET"
                                        oNode.ImageIndex = 4
                                    Case Else
                                        oNode.ImageIndex = 5
                                End Select
                            End If
                            UpdateUser(fp.nCount & " CLASSIFIED files found.")
                        Else
                            fp.nCount = fp.nCount + 1
                            oNode = tvwFiles.Nodes.Add(sRoot & TrimNull(WFD.cFilename))
                            WriteToLog("FILE: " & sRoot & TrimNull(WFD.cFilename))
                            oNode.ImageIndex = 5
                            UpdateUser(fp.nCount & " files found.")
                        End If

                    End If  'If MatchSpec

                End If 'If WFD.dwFileAttributes

                fp.nSearched = fp.nSearched + 1

                Do While bPause  ' user wishes to pause the application.
                    Application.DoEvents()
                Loop

            Loop While FindNextFile(hFile, WFD) And bDoExit = False

        End If 'If hFile

        Call FindClose(hFile)

    End Sub

    Private Function QualifyPath(ByVal sPath As String) As String

        If Microsoft.VisualBasic.Right$(sPath, 1) <> vbBackslash Then
            QualifyPath = sPath & vbBackslash
        Else
            QualifyPath = sPath
        End If

    End Function

    Private Function TrimNull(ByVal startstr As String) As String

        TrimNull = Microsoft.VisualBasic.Left$(startstr, lstrlen(VarPtr(startstr)))

    End Function

    Private Function MatchSpec(ByVal sFile As String, ByVal sSpec As String) As Boolean

        MatchSpec = PathMatchSpec(VarPtr(sFile), VarPtr(sSpec))

    End Function

    Private Function GetHeaderInfo(ByVal strFilename As String) As String
        Dim CharacterCount As Integer
        Dim iCharacters As Integer
        Dim iSectionCount As Integer
        Dim iSections As Integer
        Dim strHeader As String
        Dim oDoc As Microsoft.Office.Interop.Word.Document

        Try
            Me.Cursor = Cursors.WaitCursor

            Try ' Open the document.  If we can't open it, maybe Word has been closed.
                oDoc = oWord.Documents.Open(strFilename, , True, , , , , , , , , False) ' Readonly = True, Visible = False
            Catch ex As Exception
                oWord = CreateObject("Word.Application")
                oDoc = oWord.Documents.Open(strFilename, , True, , , , , , , , , False) ' Readonly = True, Visible = False
            End Try

            iSectionCount = oDoc.Sections.Count

            For iSections = 1 To iSectionCount
                strHeader = strHeader & "[Section " & iSections & "]" & vbCrLf
                CharacterCount = oDoc.Sections.Item(iSections).Headers.Item(1).Range.Characters.Count

                For iCharacters = 1 To CharacterCount
                    strHeader = strHeader & oDoc.Sections.Item(iSections).Headers.Item(1).Range.Characters.Item(iCharacters).Text.ToString
                Next iCharacters

                strHeader = strHeader & vbCrLf
                Application.DoEvents()
            Next iSections

            oDoc.Close(False)
            oWord.Visible = False ' Just in case Word prompted the user with a dialog, we now hide it again.

            oDoc = Nothing

            Me.Cursor = Cursors.Default
            Return strHeader
        Catch ex As Exception
            WriteToLog("Error (" & ex.Message & ").  Filename: " & strFilename)
        End Try

    End Function

    Private Function VarPtr(ByVal o As Object) As Integer ' REPLACES VB6's strptr Function
        Dim GC As GCHandle = GCHandle.Alloc(o, GCHandleType.Pinned)
        Dim ret As Integer = GC.AddrOfPinnedObject.ToInt32

        GC.Free()

        Return ret
    End Function

    Private Function GetClassification(ByVal strFilename As String) As String
        Dim strHeaders As String
        Dim bRestricted As Boolean
        Dim bConfidential As Boolean
        Dim bSecret As Boolean
        Dim bTopSecret As Boolean

        strHeaders = GetHeaderInfo(strFilename)

        txtHeaders.Text = strHeaders
        Me.Refresh()

        If InStr(strHeaders, "RESTRICTED", CompareMethod.Text) <> 0 Then
            SendEmail(strFilename, "RESTRICTED")
            WriteToLog(strHeaders)
            WriteToLog("***** RESTRICTED file found (" & strFilename & ")")
            Return "RESTRICTED"
        End If

        If InStr(strHeaders, "CONFIDENTIAL", CompareMethod.Text) <> 0 Then
            SendEmail(strFilename, "CONFIDENTIAL")
            WriteToLog(strHeaders)
            WriteToLog("***** CONFIDENTIAL file found (" & strFilename & ")")
            Return "CONFIDENTIAL"
        End If

        ' search for "top secret" before "secret"
        If InStr(strHeaders, "TOP SECRET", CompareMethod.Text) <> 0 Then
            SendEmail(strFilename, "TOP SECRET")
            WriteToLog(strHeaders)
            WriteToLog("***** TOP SECRET file found (" & strFilename & ")")
            Return "TOP SECRET"
        End If

        If InStr(strHeaders, "SECRET", CompareMethod.Text) <> 0 Then
            SendEmail(strFilename, "SECRET")
            WriteToLog(strHeaders)
            WriteToLog("***** SECRET file found (" & strFilename & ")")
            Return "SECRET"
        End If

    End Function

    Private Sub UpdateUser(ByVal strStatus As String)
        lblStatus.Text = strStatus
        txtSearched.Text = Format$(fp.nSearched, "###,###,###,##0")
        txtMatched.Text = Format$(fp.nCount, "###,###,###,##0")

        Me.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub SendEmail(ByVal strFilename As String, ByVal strClassification As String)
        Dim objEmail

        Try
            objEmail = CreateObject("CDO.Message")
            objEmail.From = "example@example.com"
            objEmail.To = "example@example.com"
            objEmail.Subject = strClassification & " document found"
            objEmail.Textbody = "SecSearch Personal has found a " & strClassification & " document." & vbCrLf & vbCrLf
            objEmail.Textbody += "Computer: " & Microsoft.VisualBasic.Environ("COMPUTERNAME") & vbCrLf
            objEmail.Textbody += "User: " & Microsoft.VisualBasic.Environ("USERNAME") & vbCrLf
            objEmail.Textbody += "Document filename: " & strFilename & vbCrLf
            objEmail.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            objEmail.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "smtp.example.com"
            objEmail.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
            objEmail.Configuration.Fields.Update()

            objEmail.Send()
        Catch
            ' Don't do anything different
        End Try
    End Sub

    Private Sub OpenLog(ByVal strFilename As String)
        oLogfile = New StreamWriter(strFilename, True)
    End Sub

    Private Sub CloseLog()
        WriteToLog("SecSearch Personal closing.")
        oLogfile.Close()
    End Sub

    Private Sub WriteToLog(ByVal strInfo As String)
        oLogfile.WriteLine(strInfo)
    End Sub

#End Region

#Region " GUI Functions "

    Private Sub tvwFiles_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwFiles.AfterSelect
        Dim strFilename As String
        Dim strClassification As String
        Dim oNode As TreeNode
        Dim iNodeIndex As Integer

        txtHeaders.Text = ""
        lblOpening.Visible = True
        iNodeIndex = tvwFiles.SelectedNode.Index ' Get the index of the selected node, as it is possible for the user to select another node
        '                                          whilst Word is 'doing its thang', thus upsetting the icon updates.
        strFilename = tvwFiles.SelectedNode.Text
        txtFilename.Text = strFilename
        Me.Refresh()
        strClassification = GetClassification(strFilename)

        oNode = tvwFiles.Nodes(iNodeIndex)

        Select Case strClassification
            Case ""
                oNode.ImageIndex = 0
            Case "RESTRICTED"
                oNode.ImageIndex = 1
            Case "CONFIDENTIAL"
                oNode.ImageIndex = 2
            Case "SECRET"
                oNode.ImageIndex = 3
            Case "TOP SECRET"
                oNode.ImageIndex = 4
            Case Else
                oNode.ImageIndex = 5
        End Select

        lblOpening.Visible = False
        Me.Refresh()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim tstart As Single   'timer var for this routine only
        Dim tend As Single     'timer var for this routine only

        txtSearched.Text = ""
        txtMatched.Text = ""
        txtElapsed.Text = ""
        tvwFiles.Nodes.Clear()
        btnSearch.Enabled = False
        btnPause.Visible = True
        tabMain.SelectedTab = tabMain.TabPages.Item(1)
        tvwFiles.Select()
        Me.Cursor = Cursors.WaitCursor
        Me.lblStatus.Text = "Search started..."
        WriteToLog("Search started at " & Now)

        With fp
            .sFileRoot = QualifyPath(txtDrive.Text)      'start path
            .sFileNameExt = "*.doc"                      'file type(s) of interest
            .bRecurse = chkSubFolders.Checked = True     'True = recursive search
            .nCount = 0                                  'results
            .nSearched = 0                               'results
        End With

        tstart = GetTickCount()
        Call SearchForFiles(fp.sFileRoot)
        tend = GetTickCount()
        Me.Cursor = Cursors.Default
        btnSearch.Enabled = True
        btnPause.Visible = False
        WriteToLog("Search complete at " & Now)

        If chkAuto.Checked Then
            UpdateUser("Search complete. " & fp.nCount & " CLASSIFIED files found.")
            WriteToLog("Search complete. " & fp.nCount & " CLASSIFIED files found.")
        Else
            UpdateUser("Search complete. " & fp.nCount & " files found.")
            WriteToLog("Search complete. " & fp.nCount & " files found.")
        End If

        WriteToLog("--------------------------------------------------------------------------------")

        txtElapsed.Text = FormatNumber((tend - tstart) / 1000, 2) & "  s"
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If btnPause.Text = "Pause" Then
            bPause = True
            btnPause.Text = "Resume"
        Else
            bPause = False
            btnPause.Text = "Pause"
        End If

    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        bPause = False
        bDoExit = True
        CloseLog()
        oWord.Quit()
        oWord = Nothing
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strUsername As String
        Dim datDate As Date

        strUsername = Environ("USERNAME")
        datDate = Now
        strLogFilename = Application.StartupPath & "\" & _
                         strUsername & "-" & _
                         DatePart(DateInterval.Year, datDate) & "." & _
                         DatePart(DateInterval.Month, datDate) & "." & _
                         DatePart(DateInterval.Day, datDate) & "." & _
                         DatePart(DateInterval.Hour, datDate) & "." & _
                         DatePart(DateInterval.Minute, datDate) & _
                         ".log"

        OpenLog(strLogFilename)
        WriteToLog("SecSearch personal started.")

        Try
            oWord = CreateObject("Word.Application")
        Catch ex As Exception
            MsgBox("Error creating instance of Word (" & ex.Message & ")")
        End Try
    End Sub

#End Region

End Class
