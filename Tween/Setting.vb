﻿' Tween - Client of Twitter
' Copyright (c) 2007-2009 kiri_feather (@kiri_feather) <kiri_feather@gmail.com>
'           (c) 2008-2009 Moz (@syo68k) <http://iddy.jp/profile/moz/>
'           (c) 2008-2009 takeshik (@takeshik) <http://www.takeshik.org/>
' All rights reserved.
' 
' This file is part of Tween.
' 
' This program is free software; you can redistribute it and/or modify it
' under the terms of the GNU General Public License as published by the Free
' Software Foundation; either version 3 of the License, or (at your option)
' any later version.
' 
' This program is distributed in the hope that it will be useful, but
' WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
' or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License
' for more details. 
' 
' You should have received a copy of the GNU General Public License along
' with this program. If not, see <http://www.gnu.org/licenses/>, or write to
' the Free Software Foundation, Inc., 51 Franklin Street - Fifth Floor,
' Boston, MA 02110-1301, USA.

Public Class Setting
    Private _MyuserID As String
    Private _Mypassword As String
    Private _MytimelinePeriod As Integer
    Private _MyDMPeriod As Integer
    Private _MyPubSearchPeriod As Integer
    Private _MynextThreshold As Integer
    Private _MyNextPages As Integer
    Private _MyLogDays As Integer
    Private _MyLogUnit As LogUnitEnum
    Private _MyReadPages As Integer
    Private _MyReadPagesReply As Integer
    Private _MyReadPagesDM As Integer
    Private _MyReaded As Boolean
    Private _MyIconSize As IconSizes
    Private _MyStatusText As String
    Private _MyRecommendStatusText As String
    Private _MyUnreadManage As Boolean
    Private _MyPlaySound As Boolean
    Private _MyOneWayLove As Boolean
    Private _fntUnread As Font
    Private _clUnread As Color
    Private _fntReaded As Font
    Private _clReaded As Color
    Private _clFav As Color
    Private _clOWL As Color
    Private _clRetweet As Color
    Private _fntDetail As Font
    Private _clSelf As Color
    Private _clAtSelf As Color
    Private _clTarget As Color
    Private _clAtTarget As Color
    Private _clAtFromTarget As Color
    Private _clAtTo As Color
    Private _clInputBackcolor As Color
    Private _clInputFont As Color
    Private _fntInputFont As Font
    Private _clListBackcolor As Color
    Private _clDetailBackcolor As Color
    Private _clDetail As Color
    Private _clDetailLink As Color
    Private _MyNameBalloon As NameBalloonEnum
    Private _MyPostCtrlEnter As Boolean
    Private _useAPI As Boolean
    Private _usePostMethod As Boolean
    Private _countApi As Integer
    Private _countApiReply As Integer
    Private _hubServer As String
    Private _browserpath As String
    Private _MyCheckReply As Boolean
    Private _MyUseRecommendStatus As Boolean
    Private _MyDispUsername As Boolean
    Private _MyDispLatestPost As DispTitleEnum
    Private _MySortOrderLock As Boolean
    Private _MyMinimizeToTray As Boolean
    Private _MyCloseToExit As Boolean
    Private _MyTinyUrlResolve As Boolean
    Private _MyProxyType As ProxyType
    Private _MyProxyAddress As String
    Private _MyProxyPort As Integer
    Private _MyProxyUser As String
    Private _MyProxyPassword As String
    Private _MyMaxPostNum As Integer
    Private _MyPeriodAdjust As Boolean
    Private _MyStartupVersion As Boolean
    Private _MyStartupKey As Boolean
    Private _MyStartupFollowers As Boolean
    Private _MyStartupAPImodeNoWarning As Boolean
    Private _MyRestrictFavCheck As Boolean
    Private _MyAlwaysTop As Boolean
    Private _MyUrlConvertAuto As Boolean
    Private _MyOutputz As Boolean
    Private _MyOutputzKey As String
    Private _MyOutputzUrlmode As OutputzUrlmode
    Private _MyUnreadStyle As Boolean
    Private _MyDateTimeFormat As String
    Private _MyDefaultTimeOut As Integer
    Private _MyProtectNotInclude As Boolean
    Private _MyLimitBalloon As Boolean
    Private _MyPostAndGet As Boolean
    Private _MyReplyPeriod As Integer
    Private _MyAutoShortUrlFirst As UrlConverter
    Private _MyTabIconDisp As Boolean
    Private _MyReplyIconState As REPLY_ICONSTATE
    Private _MyReadOwnPost As Boolean
    Private _MyGetFav As Boolean
    Private _MyMonoSpace As Boolean
    Private _MyReadOldPosts As Boolean
    Private _MyUseSsl As Boolean
    Private _MyBitlyId As String
    Private _MyBitlyPw As String
    Private _MyShowGrid As Boolean
    Private _MyUseAtIdSupplement As Boolean
    Private _MyLanguage As String

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            _MyuserID = Username.Text.Trim()
            _Mypassword = Password.Text.Trim()
            _MytimelinePeriod = CType(TimelinePeriod.Text, Integer)
            _MyDMPeriod = CType(DMPeriod.Text, Integer)
            _MyPubSearchPeriod = CType(PubSearchPeriod.Text, Integer)
            _MyReplyPeriod = CType(ReplyPeriod.Text, Integer)
            _MynextThreshold = CType(NextThreshold.Text, Integer)
            _MyNextPages = CType(NextPages.Text, Integer)
            _MyMaxPostNum = 125

            _MyReadPages = CType(StartupReadPages.Text, Integer)
            _MyReadPagesReply = CType(StartupReadReply.Text, Integer)
            _MyReadPagesDM = CType(StartupReadDM.Text, Integer)
            _MyReaded = StartupReaded.Checked
            Select Case IconSize.SelectedIndex
                Case 0
                    _MyIconSize = IconSizes.IconNone
                Case 1
                    _MyIconSize = IconSizes.Icon16
                Case 2
                    _MyIconSize = IconSizes.Icon24
                Case 3
                    _MyIconSize = IconSizes.Icon48
                Case 4
                    _MyIconSize = IconSizes.Icon48_2
            End Select
            _MyStatusText = StatusText.Text
            _MyPlaySound = PlaySnd.Checked
            'TweenMain.PlaySoundMenuItem.Checked = _MyPlaySound  'これは勘弁
            _MyUnreadManage = UReadMng.Checked
            _MyOneWayLove = OneWayLv.Checked

            _fntUnread = lblUnread.Font     '未使用
            _clUnread = lblUnread.ForeColor
            _fntReaded = lblListFont.Font     'リストフォントとして使用
            _clReaded = lblListFont.ForeColor
            _clFav = lblFav.ForeColor
            _clOWL = lblOWL.ForeColor
            _clRetweet = lblRetweet.ForeColor
            _fntDetail = lblDetail.Font
            _clSelf = lblSelf.BackColor
            _clAtSelf = lblAtSelf.BackColor
            _clTarget = lblTarget.BackColor
            _clAtTarget = lblAtTarget.BackColor
            _clAtFromTarget = lblAtFromTarget.BackColor
            _clAtTo = lblAtTo.BackColor
            _clInputBackcolor = lblInputBackcolor.BackColor
            _clInputFont = lblInputFont.ForeColor
            _clListBackcolor = lblListBackcolor.BackColor
            _clDetailBackcolor = lblDetailBackcolor.BackColor
            _clDetail = lblDetail.ForeColor
            _clDetailLink = lblDetailLink.ForeColor
            _fntInputFont = lblInputFont.Font
            Select Case cmbNameBalloon.SelectedIndex
                Case 0
                    _MyNameBalloon = NameBalloonEnum.None
                Case 1
                    _MyNameBalloon = NameBalloonEnum.UserID
                Case 2
                    _MyNameBalloon = NameBalloonEnum.NickName
            End Select
            _MyPostCtrlEnter = CheckPostCtrlEnter.Checked
            _useAPI = CheckUseApi.Checked
            _usePostMethod = False
            _countApi = CType(TextCountApi.Text, Integer)
            _countApiReply = CType(TextCountApiReply.Text, Integer)
            _hubServer = "twitter.com"
            _browserpath = BrowserPathText.Text.Trim
            _MyCheckReply = CheckboxReply.Checked
            _MyPostAndGet = CheckPostAndGet.Checked
            _MyUseRecommendStatus = CheckUseRecommendStatus.Checked
            _MyDispUsername = CheckDispUsername.Checked
            _MyCloseToExit = CheckCloseToExit.Checked
            _MyMinimizeToTray = CheckMinimizeToTray.Checked
            Select Case ComboDispTitle.SelectedIndex
                Case 0  'None
                    _MyDispLatestPost = DispTitleEnum.None
                Case 1  'Ver
                    _MyDispLatestPost = DispTitleEnum.Ver
                Case 2  'Post
                    _MyDispLatestPost = DispTitleEnum.Post
                Case 3  'RepCount
                    _MyDispLatestPost = DispTitleEnum.UnreadRepCount
                Case 4  'AllCount
                    _MyDispLatestPost = DispTitleEnum.UnreadAllCount
                Case 5  'Rep+All
                    _MyDispLatestPost = DispTitleEnum.UnreadAllRepCount
                Case 6  'Unread/All
                    _MyDispLatestPost = DispTitleEnum.UnreadCountAllCount
            End Select
            _MySortOrderLock = CheckSortOrderLock.Checked
            _MyTinyUrlResolve = CheckTinyURL.Checked
            If RadioProxyNone.Checked Then
                _MyProxyType = ProxyType.None
            ElseIf RadioProxyIE.Checked Then
                _MyProxyType = ProxyType.IE
            Else
                _MyProxyType = ProxyType.Specified
            End If
            _MyProxyAddress = TextProxyAddress.Text.Trim()
            _MyProxyPort = Integer.Parse(TextProxyPort.Text.Trim())
            _MyProxyUser = TextProxyUser.Text.Trim()
            _MyProxyPassword = TextProxyPassword.Text.Trim()
            _MyPeriodAdjust = CheckPeriodAdjust.Checked
            _MyStartupVersion = CheckStartupVersion.Checked
            _MyStartupKey = CheckStartupKey.Checked
            _MyStartupAPImodeNoWarning = CheckStartupAPImodeNoWarning.Checked
            _MyStartupFollowers = CheckStartupFollowers.Checked
            _MyRestrictFavCheck = CheckFavRestrict.Checked
            _MyAlwaysTop = CheckAlwaysTop.Checked
            _MyUrlConvertAuto = CheckAutoConvertUrl.Checked
            _MyOutputz = CheckOutputz.Checked
            Outputz.Enabled = _MyOutputz
            _MyOutputzKey = TextBoxOutputzKey.Text.Trim()
            Outputz.key = _MyOutputzKey

            Select Case ComboBoxOutputzUrlmode.SelectedIndex
                Case 0
                    _MyOutputzUrlmode = OutputzUrlmode.twittercom
                    Outputz.url = "http://twitter.com/"
                Case 1
                    _MyOutputzUrlmode = OutputzUrlmode.twittercomWithUsername
                    Outputz.url = "http://twitter.com/" + _MyuserID
            End Select

            _MyUnreadStyle = chkUnreadStyle.Checked
            _MyDateTimeFormat = CmbDateTimeFormat.Text
            _MyDefaultTimeOut = CType(ConnectionTimeOut.Text, Integer)      ' 0の場合はGetWebResponse()側でTimeOut.Infiniteへ読み替える
            _MyProtectNotInclude = CheckProtectNotInclude.Checked
            _MyLimitBalloon = CheckBalloonLimit.Checked
            _MyAutoShortUrlFirst = CType(ComboBoxAutoShortUrlFirst.SelectedIndex, UrlConverter)
            _MyTabIconDisp = chkTabIconDisp.Checked
            _MyReadOwnPost = chkReadOwnPost.Checked
            _MyGetFav = chkGetFav.Checked
            _MyMonoSpace = CheckMonospace.Checked
            _MyReadOldPosts = CheckReadOldPosts.Checked
            _MyUseSsl = CheckUseSsl.Checked
            _MyBitlyId = TextBitlyId.Text
            _MyBitlyPw = TextBitlyPw.Text
            _MyShowGrid = CheckShowGrid.Checked
            _MyUseAtIdSupplement = CheckAtIdSupple.Checked
            Select Case ReplyIconStateCombo.SelectedIndex
                Case 0
                    _MyReplyIconState = REPLY_ICONSTATE.None
                Case 1
                    _MyReplyIconState = REPLY_ICONSTATE.StaticIcon
                Case 2
                    _MyReplyIconState = REPLY_ICONSTATE.BlinkIcon
            End Select
            Select Case LanguageCombo.SelectedIndex
                Case 0
                    _MyLanguage = "OS"
                Case 1
                    _MyLanguage = "ja"
                Case Else
                    _MyLanguage = "en"
            End Select
        Catch ex As Exception
            MessageBox.Show(My.Resources.Save_ClickText3)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End Try
    End Sub

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Text = _MyuserID
        Password.Text = _Mypassword
        TimelinePeriod.Text = _MytimelinePeriod.ToString()
        ReplyPeriod.Text = _MyReplyPeriod.ToString()
        DMPeriod.Text = _MyDMPeriod.ToString()
        PubSearchPeriod.Text = _MyPubSearchPeriod.ToString()
        NextThreshold.Text = _MynextThreshold.ToString()
        NextPages.Text = _MyNextPages.ToString()
        'MaxPost.Text = _MyMaxPostNum.ToString()
        'ReadLogDays.Text = _MyLogDays.ToString()
        'Select Case _MyLogUnit
        '    Case LogUnitEnum.Minute
        '        ReadLogUnit.SelectedIndex = 0
        '    Case LogUnitEnum.Hour
        '        ReadLogUnit.SelectedIndex = 1
        '    Case LogUnitEnum.Day
        '        ReadLogUnit.SelectedIndex = 2
        'End Select
        StartupReadPages.Text = _MyReadPages.ToString()
        StartupReadReply.Text = _MyReadPagesReply.ToString()
        StartupReadDM.Text = _MyReadPagesDM.ToString()
        StartupReaded.Checked = _MyReaded
        Select Case _MyIconSize
            Case IconSizes.IconNone
                IconSize.SelectedIndex = 0
            Case IconSizes.Icon16
                IconSize.SelectedIndex = 1
            Case IconSizes.Icon24
                IconSize.SelectedIndex = 2
            Case IconSizes.Icon48
                IconSize.SelectedIndex = 3
            Case IconSizes.Icon48_2
                IconSize.SelectedIndex = 4
        End Select
        StatusText.Text = _MyStatusText
        UReadMng.Checked = _MyUnreadManage
        If _MyUnreadManage = False Then
            StartupReaded.Enabled = False
        Else
            StartupReaded.Enabled = True
        End If
        PlaySnd.Checked = _MyPlaySound
        'TweenMain.PlaySoundMenuItem.Checked = _MyPlaySound
        OneWayLv.Checked = _MyOneWayLove

        lblListFont.Font = _fntReaded
        lblUnread.Font = _fntUnread
        lblUnread.ForeColor = _clUnread
        'lblReaded.Font = _fntReaded
        'lblReaded.ForeColor = _clReaded
        lblListFont.ForeColor = _clReaded
        lblFav.ForeColor = _clFav
        lblOWL.ForeColor = _clOWL
        lblRetweet.ForeColor = _clRetweet
        lblDetail.Font = _fntDetail
        lblSelf.BackColor = _clSelf
        lblAtSelf.BackColor = _clAtSelf
        lblTarget.BackColor = _clTarget
        lblAtTarget.BackColor = _clAtTarget
        lblAtFromTarget.BackColor = _clAtFromTarget
        lblAtTo.BackColor = _clAtTo
        lblInputBackcolor.BackColor = _clInputBackcolor
        lblInputFont.ForeColor = _clInputFont
        lblInputFont.Font = _fntInputFont
        lblListBackcolor.BackColor = _clListBackcolor
        lblDetailBackcolor.BackColor = _clDetailBackcolor
        lblDetail.ForeColor = _clDetail
        lblDetailLink.ForeColor = _clDetailLink

        Select Case _MyNameBalloon
            Case NameBalloonEnum.None
                cmbNameBalloon.SelectedIndex = 0
            Case NameBalloonEnum.UserID
                cmbNameBalloon.SelectedIndex = 1
            Case NameBalloonEnum.NickName
                cmbNameBalloon.SelectedIndex = 2
        End Select

        CheckPostCtrlEnter.Checked = _MyPostCtrlEnter
        CheckUseApi.Checked = _useAPI
        'Enable切り替え
        CheckboxReply.Enabled = Not CheckUseApi.Checked
        CheckPeriodAdjust.Enabled = Not CheckUseApi.Checked
        NextThreshold.Enabled = Not CheckUseApi.Checked
        NextPages.Enabled = Not CheckUseApi.Checked
        StartupReadPages.Enabled = Not CheckUseApi.Checked
        StartupReadReply.Enabled = Not CheckUseApi.Checked
        StartupReadDM.Enabled = Not CheckUseApi.Checked
        CheckPostMethod.Enabled = False
        TextCountApi.Enabled = CheckUseApi.Checked
        TextCountApiReply.Enabled = CheckUseApi.Checked

        CheckPostMethod.Checked = False
        TextCountApi.Text = _countApi.ToString
        TextCountApiReply.Text = _countApiReply.ToString
        'HubServerDomain.Text = _hubServer
        BrowserPathText.Text = _browserpath
        CheckboxReply.Checked = _MyCheckReply
        CheckPostAndGet.Checked = _MyPostAndGet
        CheckUseRecommendStatus.Checked = _MyUseRecommendStatus
        CheckDispUsername.Checked = _MyDispUsername
        CheckCloseToExit.Checked = _MyCloseToExit
        CheckMinimizeToTray.Checked = _MyMinimizeToTray
        Select Case _MyDispLatestPost
            Case DispTitleEnum.None
                ComboDispTitle.SelectedIndex = 0
            Case DispTitleEnum.Ver
                ComboDispTitle.SelectedIndex = 1
            Case DispTitleEnum.Post
                ComboDispTitle.SelectedIndex = 2
            Case DispTitleEnum.UnreadRepCount
                ComboDispTitle.SelectedIndex = 3
            Case DispTitleEnum.UnreadAllCount
                ComboDispTitle.SelectedIndex = 4
            Case DispTitleEnum.UnreadAllRepCount
                ComboDispTitle.SelectedIndex = 5
            Case DispTitleEnum.UnreadCountAllCount
                ComboDispTitle.SelectedIndex = 6
        End Select
        CheckSortOrderLock.Checked = _MySortOrderLock
        CheckTinyURL.Checked = _MyTinyUrlResolve
        Select Case _MyProxyType
            Case ProxyType.None
                RadioProxyNone.Checked = True
            Case ProxyType.IE
                RadioProxyIE.Checked = True
            Case Else
                RadioProxySpecified.Checked = True
        End Select
        Dim chk As Boolean = RadioProxySpecified.Checked
        LabelProxyAddress.Enabled = chk
        TextProxyAddress.Enabled = chk
        LabelProxyPort.Enabled = chk
        TextProxyPort.Enabled = chk
        LabelProxyUser.Enabled = chk
        TextProxyUser.Enabled = chk
        LabelProxyPassword.Enabled = chk
        TextProxyPassword.Enabled = chk

        TextProxyAddress.Text = _MyProxyAddress
        TextProxyPort.Text = _MyProxyPort.ToString
        TextProxyUser.Text = _MyProxyUser
        TextProxyPassword.Text = _MyProxyPassword

        CheckPeriodAdjust.Checked = _MyPeriodAdjust
        CheckStartupVersion.Checked = _MyStartupVersion
        CheckStartupKey.Checked = _MyStartupKey
        CheckStartupFollowers.Checked = _MyStartupFollowers
        CheckStartupAPImodeNoWarning.Checked = _MyStartupAPImodeNoWarning
        CheckFavRestrict.Checked = _MyRestrictFavCheck
        CheckAlwaysTop.Checked = _MyAlwaysTop
        CheckAutoConvertUrl.Checked = _MyUrlConvertAuto
        CheckOutputz.Checked = _MyOutputz
        Outputz.Enabled = _MyOutputz
        TextBoxOutputzKey.Text = _MyOutputzKey
        Outputz.key = _MyOutputzKey

        Select Case _MyOutputzUrlmode
            Case OutputzUrlmode.twittercom
                ComboBoxOutputzUrlmode.SelectedIndex = 0
            Case OutputzUrlmode.twittercomWithUsername
                ComboBoxOutputzUrlmode.SelectedIndex = 1
        End Select

        chkUnreadStyle.Checked = _MyUnreadStyle
        CmbDateTimeFormat.Text = _MyDateTimeFormat
        ConnectionTimeOut.Text = _MyDefaultTimeOut.ToString
        CheckProtectNotInclude.Checked = _MyProtectNotInclude
        CheckBalloonLimit.Checked = _MyLimitBalloon
        ComboBoxAutoShortUrlFirst.SelectedIndex = _MyAutoShortUrlFirst
        chkTabIconDisp.Checked = _MyTabIconDisp
        chkReadOwnPost.Checked = _MyReadOwnPost
        chkGetFav.Checked = _MyGetFav
        CheckMonospace.Checked = _MyMonoSpace
        CheckReadOldPosts.Checked = _MyReadOldPosts
        CheckUseSsl.Checked = _MyUseSsl
        TextBitlyId.Text = _MyBitlyId
        TextBitlyPw.Text = _MyBitlyPw
        CheckShowGrid.Checked = _MyShowGrid
        CheckAtIdSupple.Checked = _MyUseAtIdSupplement
        Select Case _MyReplyIconState
            Case REPLY_ICONSTATE.None
                ReplyIconStateCombo.SelectedIndex = 0
            Case REPLY_ICONSTATE.StaticIcon
                ReplyIconStateCombo.SelectedIndex = 1
            Case REPLY_ICONSTATE.BlinkIcon
                ReplyIconStateCombo.SelectedIndex = 2
        End Select
        Select Case _MyLanguage
            Case "OS"
                LanguageCombo.SelectedIndex = 0
            Case "ja"
                LanguageCombo.SelectedIndex = 1
            Case Else
                LanguageCombo.SelectedIndex = 2
        End Select

        TabControl1.SelectedIndex = 0
        ActiveControl = Username

        CheckOutputz_CheckedChanged(sender, e)
    End Sub

    Private Sub TimelinePeriod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TimelinePeriod.Validating
        Dim prd As Integer
        Try
            prd = CType(TimelinePeriod.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.TimelinePeriod_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If prd <> 0 And (prd < 30 Or prd > 6000) Then
            MessageBox.Show(My.Resources.TimelinePeriod_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub ReplyPeriod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReplyPeriod.Validating
        Dim prd As Integer
        Try
            prd = CType(ReplyPeriod.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.TimelinePeriod_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If prd <> 0 And (prd < 30 Or prd > 6000) Then
            MessageBox.Show(My.Resources.TimelinePeriod_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub NextThreshold_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NextThreshold.Validating
        Dim thr As Integer
        Try
            thr = CType(NextThreshold.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.NextThreshold_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If thr < 1 Or thr > 20 Then
            MessageBox.Show(My.Resources.NextThreshold_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub NextPages_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NextPages.Validating
        Dim thr As Integer
        Try
            thr = CType(NextPages.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.NextPages_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If thr < 1 Or thr > 20 Then
            MessageBox.Show(My.Resources.NextPages_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub DMPeriod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DMPeriod.Validating
        Dim prd As Integer
        Try
            prd = CType(DMPeriod.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.DMPeriod_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If prd <> 0 And (prd < 30 Or prd > 6000) Then
            MessageBox.Show(My.Resources.DMPeriod_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub PubSearchPeriod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PubSearchPeriod.Validating
        Dim prd As Integer
        Try
            prd = CType(PubSearchPeriod.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.DMPeriod_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If prd <> 0 And (prd < 30 Or prd > 6000) Then
            MessageBox.Show(My.Resources.DMPeriod_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub ReadLogDays_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'Dim days As Integer
        'Try
        '    days = CType(ReadLogDays.Text, Integer)
        'Catch ex As Exception
        '    MessageBox.Show("読み込み日数には数値（0～7）を指定してください。")
        '    e.Cancel = True
        '    Exit Sub
        'End Try

        'If days < 0 Or days > 7 Then
        '    MessageBox.Show("読み込み日数には数値（0～7）を指定してください。")
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub StartupReadPages_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StartupReadPages.Validating
        Dim pages As Integer
        Try
            pages = CType(StartupReadPages.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.StartupReadPages_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If pages < 1 Or pages > 999 Then
            MessageBox.Show(My.Resources.StartupReadPages_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub StartupReadReply_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StartupReadReply.Validating
        Dim pages As Integer
        Try
            pages = CType(StartupReadReply.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.StartupReadReply_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If pages < 0 Or pages > 999 Then
            MessageBox.Show(My.Resources.StartupReadReply_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub StartupReadDM_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StartupReadDM.Validating
        Dim pages As Integer
        Try
            pages = CType(StartupReadDM.Text, Integer)
        Catch ex As Exception
            MessageBox.Show(My.Resources.StartupReadDM_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If pages < 1 Or pages > 999 Then
            MessageBox.Show(My.Resources.StartupReadDM_ValidatingText2)
            e.Cancel = True
        End If
    End Sub

    Private Sub UReadMng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If UReadMng.Checked = True Then
            StartupReaded.Enabled = True
        Else
            StartupReaded.Enabled = False
        End If
    End Sub

    Private Sub btnFontAndColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click, btnListFont.Click, btnUnread.Click, btnInputFont.Click
        Dim Btn As Button = CType(sender, Button)
        Dim rtn As DialogResult

        FontDialog1.AllowVerticalFonts = False
        FontDialog1.AllowScriptChange = True
        FontDialog1.AllowSimulations = True
        FontDialog1.AllowVectorFonts = True
        FontDialog1.FixedPitchOnly = False
        FontDialog1.FontMustExist = True
        FontDialog1.ScriptsOnly = False
        FontDialog1.ShowApply = False
        FontDialog1.ShowEffects = True
        FontDialog1.ShowColor = True

        Select Case Btn.Name
            Case "btnUnread"
                FontDialog1.Color = lblUnread.ForeColor
                FontDialog1.Font = lblUnread.Font
                'Case "btnReaded"
                '    FontDialog1.Color = lblReaded.ForeColor
                '    FontDialog1.Font = lblReaded.Font
            Case "btnDetail"
                FontDialog1.Color = lblDetail.ForeColor
                FontDialog1.Font = lblDetail.Font
                'FontDialog1.ShowEffects = False
                'FontDialog1.ShowColor = False
            Case "btnListFont"
                FontDialog1.Color = lblListFont.ForeColor
                FontDialog1.Font = lblListFont.Font
            Case "btnInputFont"
                FontDialog1.Color = lblInputFont.ForeColor
                FontDialog1.Font = lblInputFont.Font
        End Select

        Try
            rtn = FontDialog1.ShowDialog
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        If rtn = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Select Case Btn.Name
            Case "btnUnread"
                lblUnread.ForeColor = FontDialog1.Color
                lblUnread.Font = FontDialog1.Font
                'Case "btnReaded"
                '    lblReaded.ForeColor = FontDialog1.Color
                '    lblReaded.Font = FontDialog1.Font
            Case "btnDetail"
                lblDetail.ForeColor = FontDialog1.Color
                lblDetail.Font = FontDialog1.Font
            Case "btnListFont"
                lblListFont.ForeColor = FontDialog1.Color
                lblListFont.Font = FontDialog1.Font
            Case "btnInputFont"
                lblInputFont.ForeColor = FontDialog1.Color
                lblInputFont.Font = FontDialog1.Font
        End Select

    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelf.Click, btnAtSelf.Click, btnTarget.Click, btnAtTarget.Click, btnAtFromTarget.Click, btnFav.Click, btnOWL.Click, btnInputBackcolor.Click, btnAtTo.Click, btnListBack.Click, btnDetailBack.Click, btnDetailLink.Click, btnRetweet.Click
        Dim Btn As Button = CType(sender, Button)
        Dim rtn As DialogResult

        ColorDialog1.AllowFullOpen = True
        ColorDialog1.AnyColor = True
        ColorDialog1.FullOpen = False
        ColorDialog1.SolidColorOnly = False

        Select Case Btn.Name
            Case "btnSelf"
                ColorDialog1.Color = lblSelf.BackColor
            Case "btnAtSelf"
                ColorDialog1.Color = lblAtSelf.BackColor
            Case "btnTarget"
                ColorDialog1.Color = lblTarget.BackColor
            Case "btnAtTarget"
                ColorDialog1.Color = lblAtTarget.BackColor
            Case "btnAtFromTarget"
                ColorDialog1.Color = lblAtFromTarget.BackColor
            Case "btnFav"
                ColorDialog1.Color = lblFav.ForeColor
            Case "btnOWL"
                ColorDialog1.Color = lblOWL.ForeColor
            Case "btnRetweet"
                ColorDialog1.Color = lblRetweet.ForeColor
                'Case "btnUnread"
                '    'ColorDialog1.Color = lblUnRead.ForeColor
                'Case "btnReaded"
                '    'ColorDialog1.Color = lblReaded.ForeColor
            Case "btnInputBackcolor"
                ColorDialog1.Color = lblInputBackcolor.BackColor
            Case "btnAtTo"
                ColorDialog1.Color = lblAtTo.BackColor
            Case "btnListBack"
                ColorDialog1.Color = lblListBackcolor.BackColor
            Case "btnDetailBack"
                ColorDialog1.Color = lblDetailBackcolor.BackColor
            Case "btnDetailLink"
                ColorDialog1.Color = lblDetailLink.ForeColor
        End Select

        rtn = ColorDialog1.ShowDialog

        If rtn = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Select Case Btn.Name
            Case "btnSelf"
                lblSelf.BackColor = ColorDialog1.Color
            Case "btnAtSelf"
                lblAtSelf.BackColor = ColorDialog1.Color
            Case "btnTarget"
                lblTarget.BackColor = ColorDialog1.Color
            Case "btnAtTarget"
                lblAtTarget.BackColor = ColorDialog1.Color
            Case "btnAtFromTarget"
                lblAtFromTarget.BackColor = ColorDialog1.Color
            Case "btnFav"
                lblFav.ForeColor = ColorDialog1.Color
            Case "btnOWL"
                lblOWL.ForeColor = ColorDialog1.Color
            Case "btnRetweet"
                lblRetweet.ForeColor = ColorDialog1.Color
                'Case "btnUnread"
                '    'lblUnRead.ForeColor = ColorDialog1.Color
                'Case "btnReaded"
                '    'lblReaded.ForeColor = ColorDialog1.Color
            Case "btnInputBackcolor"
                lblInputBackcolor.BackColor = ColorDialog1.Color
            Case "btnAtTo"
                lblAtTo.BackColor = ColorDialog1.Color
            Case "btnListBack"
                lblListBackcolor.BackColor = ColorDialog1.Color
            Case "btnDetailBack"
                lblDetailBackcolor.BackColor = ColorDialog1.Color
            Case "btnDetailLink"
                lblDetailLink.ForeColor = ColorDialog1.Color
        End Select
    End Sub

    Public Property UserID() As String
        Get
            Return _MyuserID
        End Get
        Set(ByVal value As String)
            _MyuserID = value
        End Set
    End Property

    Public Property PasswordStr() As String
        Get
            Return _Mypassword
        End Get
        Set(ByVal value As String)
            _Mypassword = value
        End Set
    End Property

    Public Property TimelinePeriodInt() As Integer
        Get
            Return _MytimelinePeriod
        End Get
        Set(ByVal value As Integer)
            _MytimelinePeriod = value
        End Set
    End Property

    Public Property ReplyPeriodInt() As Integer
        Get
            Return _MyReplyPeriod
        End Get
        Set(ByVal value As Integer)
            _MyReplyPeriod = value
        End Set
    End Property

    Public Property DMPeriodInt() As Integer
        Get
            Return _MyDMPeriod
        End Get
        Set(ByVal value As Integer)
            _MyDMPeriod = value
        End Set
    End Property

    Public Property PubSearchPeriodInt() As Integer
        Get
            Return _MyPubSearchPeriod
        End Get
        Set(ByVal value As Integer)
            _MyPubSearchPeriod = value
        End Set
    End Property

    Public Property NextPageThreshold() As Integer
        Get
            Return _MynextThreshold
        End Get
        Set(ByVal value As Integer)
            _MynextThreshold = value
        End Set
    End Property

    Public Property MaxPostNum() As Integer
        Get
            Return _MyMaxPostNum
        End Get
        Set(ByVal value As Integer)
            _MyMaxPostNum = value
        End Set
    End Property

    Public Property NextPagesInt() As Integer
        Get
            Return _MyNextPages
        End Get
        Set(ByVal value As Integer)
            _MyNextPages = value
        End Set
    End Property

    Public Property LogDays() As Integer
        Get
            Return _MyLogDays
        End Get
        Set(ByVal value As Integer)
            _MyLogDays = value
        End Set
    End Property

    Public Property LogUnit() As LogUnitEnum
        Get
            Return _MyLogUnit
        End Get
        Set(ByVal value As LogUnitEnum)
            _MyLogUnit = value
        End Set
    End Property

    Public Property ReadPages() As Integer
        Get
            Return _MyReadPages
        End Get
        Set(ByVal value As Integer)
            _MyReadPages = value
        End Set
    End Property

    Public Property ReadPagesReply() As Integer
        Get
            Return _MyReadPagesReply
        End Get
        Set(ByVal value As Integer)
            _MyReadPagesReply = value
        End Set
    End Property

    Public Property ReadPagesDM() As Integer
        Get
            Return _MyReadPagesDM
        End Get
        Set(ByVal value As Integer)
            _MyReadPagesDM = value
        End Set
    End Property

    Public Property Readed() As Boolean
        Get
            Return _MyReaded
        End Get
        Set(ByVal value As Boolean)
            _MyReaded = value
        End Set
    End Property

    Public Property IconSz() As IconSizes
        Get
            Return _MyIconSize
        End Get
        Set(ByVal value As IconSizes)
            _MyIconSize = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return _MyStatusText
        End Get
        Set(ByVal value As String)
            _MyStatusText = value
        End Set
    End Property

    Public Property UnreadManage() As Boolean
        Get
            Return _MyUnreadManage
        End Get
        Set(ByVal value As Boolean)
            _MyUnreadManage = value
        End Set
    End Property

    Public Property PlaySound() As Boolean
        Get
            Return _MyPlaySound
        End Get
        Set(ByVal value As Boolean)
            _MyPlaySound = value
        End Set
    End Property

    Public Property OneWayLove() As Boolean
        Get
            Return _MyOneWayLove
        End Get
        Set(ByVal value As Boolean)
            _MyOneWayLove = value
        End Set
    End Property

    '''''未使用
    Public Property FontUnread() As Font
        Get
            Return _fntUnread
        End Get
        Set(ByVal value As Font)
            _fntUnread = value
            '無視
        End Set
    End Property

    Public Property ColorUnread() As Color
        Get
            Return _clUnread
        End Get
        Set(ByVal value As Color)
            _clUnread = value
        End Set
    End Property

    '''''リストフォントとして使用
    Public Property FontReaded() As Font
        Get
            Return _fntReaded
        End Get
        Set(ByVal value As Font)
            _fntReaded = value
        End Set
    End Property

    Public Property ColorReaded() As Color
        Get
            Return _clReaded
        End Get
        Set(ByVal value As Color)
            _clReaded = value
        End Set
    End Property

    Public Property ColorFav() As Color
        Get
            Return _clFav
        End Get
        Set(ByVal value As Color)
            _clFav = value
        End Set
    End Property

    Public Property ColorOWL() As Color
        Get
            Return _clOWL
        End Get
        Set(ByVal value As Color)
            _clOWL = value
        End Set
    End Property

    Public Property ColorRetweet() As Color
        Get
            Return _clRetweet
        End Get
        Set(ByVal value As Color)
            _clRetweet = value
        End Set
    End Property

    Public Property FontDetail() As Font
        Get
            Return _fntDetail
        End Get
        Set(ByVal value As Font)
            _fntDetail = value
        End Set
    End Property

    Public Property ColorDetail() As Color
        Get
            Return _clDetail
        End Get
        Set(ByVal value As Color)
            _clDetail = value
        End Set
    End Property

    Public Property ColorDetailLink() As Color
        Get
            Return _clDetailLink
        End Get
        Set(ByVal value As Color)
            _clDetailLink = value
        End Set
    End Property

    Public Property ColorSelf() As Color
        Get
            Return _clSelf
        End Get
        Set(ByVal value As Color)
            _clSelf = value
        End Set
    End Property

    Public Property ColorAtSelf() As Color
        Get
            Return _clAtSelf
        End Get
        Set(ByVal value As Color)
            _clAtSelf = value
        End Set
    End Property

    Public Property ColorTarget() As Color
        Get
            Return _clTarget
        End Get
        Set(ByVal value As Color)
            _clTarget = value
        End Set
    End Property

    Public Property ColorAtTarget() As Color
        Get
            Return _clAtTarget
        End Get
        Set(ByVal value As Color)
            _clAtTarget = value
        End Set
    End Property

    Public Property ColorAtFromTarget() As Color
        Get
            Return _clAtFromTarget
        End Get
        Set(ByVal value As Color)
            _clAtFromTarget = value
        End Set
    End Property

    Public Property ColorAtTo() As Color
        Get
            Return _clAtTo
        End Get
        Set(ByVal value As Color)
            _clAtTo = value
        End Set
    End Property

    Public Property ColorInputBackcolor() As Color
        Get
            Return _clInputBackcolor
        End Get
        Set(ByVal value As Color)
            _clInputBackcolor = value
        End Set
    End Property

    Public Property ColorInputFont() As Color
        Get
            Return _clInputFont
        End Get
        Set(ByVal value As Color)
            _clInputFont = value
        End Set
    End Property

    Public Property FontInputFont() As Font
        Get
            Return _fntInputFont
        End Get
        Set(ByVal value As Font)
            _fntInputFont = value
        End Set
    End Property

    Public Property ColorListBackcolor() As Color
        Get
            Return _clListBackcolor
        End Get
        Set(ByVal value As Color)
            _clListBackcolor = value
        End Set
    End Property

    Public Property ColorDetailBackcolor() As Color
        Get
            Return _clDetailBackcolor
        End Get
        Set(ByVal value As Color)
            _clDetailBackcolor = value
        End Set
    End Property

    Public Property NameBalloon() As NameBalloonEnum
        Get
            Return _MyNameBalloon
        End Get
        Set(ByVal value As NameBalloonEnum)
            _MyNameBalloon = value
        End Set
    End Property

    Public Property PostCtrlEnter() As Boolean
        Get
            Return _MyPostCtrlEnter
        End Get
        Set(ByVal value As Boolean)
            _MyPostCtrlEnter = value
        End Set
    End Property

    Public Property UseAPI() As Boolean
        Get
            Return _useAPI
        End Get
        Set(ByVal value As Boolean)
            _useAPI = value
        End Set
    End Property

    Public Property UsePostMethod() As Boolean
        Get
            Return _usePostMethod
        End Get
        Set(ByVal value As Boolean)
            _usePostMethod = False
        End Set
    End Property

    Public Property CountApi() As Integer
        Get
            Return _countApi
        End Get
        Set(ByVal value As Integer)
            _countApi = value
        End Set
    End Property

    Public Property CountApiReply() As Integer
        Get
            Return _countApiReply
        End Get
        Set(ByVal value As Integer)
            _countApiReply = value
        End Set
    End Property

    Public Property CheckReply() As Boolean
        Get
            Return _MyCheckReply
        End Get
        Set(ByVal value As Boolean)
            _MyCheckReply = value
        End Set
    End Property

    Public Property PostAndGet() As Boolean
        Get
            Return _MyPostAndGet
        End Get
        Set(ByVal value As Boolean)
            _MyPostAndGet = value
        End Set
    End Property

    Public Property UseRecommendStatus() As Boolean
        Get
            Return _MyUseRecommendStatus
        End Get
        Set(ByVal value As Boolean)
            _MyUseRecommendStatus = value
        End Set
    End Property

    Public Property RecommendStatusText() As String
        Get
            Return _MyRecommendStatusText
        End Get
        Set(ByVal value As String)
            _MyRecommendStatusText = value
        End Set
    End Property

    Public Property DispUsername() As Boolean
        Get
            Return _MyDispUsername
        End Get
        Set(ByVal value As Boolean)
            _MyDispUsername = value
        End Set
    End Property

    Public Property CloseToExit() As Boolean
        Get
            Return _MyCloseToExit
        End Get
        Set(ByVal value As Boolean)
            _MyCloseToExit = value
        End Set
    End Property

    Public Property MinimizeToTray() As Boolean
        Get
            Return _MyMinimizeToTray
        End Get
        Set(ByVal value As Boolean)
            _MyMinimizeToTray = value
        End Set
    End Property

    Public Property DispLatestPost() As DispTitleEnum
        Get
            Return _MyDispLatestPost
        End Get
        Set(ByVal value As DispTitleEnum)
            _MyDispLatestPost = value
        End Set
    End Property

    Public Property HubServer() As String
        Get
            Return _hubServer
        End Get
        Set(ByVal value As String)
            _hubServer = value
        End Set
    End Property

    Public Property BrowserPath() As String
        Get
            Return _browserpath
        End Get
        Set(ByVal value As String)
            _browserpath = value
        End Set
    End Property

    Public Property TinyUrlResolve() As Boolean
        Get
            Return _MyTinyUrlResolve
        End Get
        Set(ByVal value As Boolean)
            _MyTinyUrlResolve = value
        End Set
    End Property

    Private Sub CheckUseRecommendStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckUseRecommendStatus.CheckedChanged
        If CheckUseRecommendStatus.Checked = True Then
            StatusText.Enabled = False
        Else
            StatusText.Enabled = True
        End If
    End Sub

    Public Property SortOrderLock() As Boolean
        Get
            Return _MySortOrderLock
        End Get
        Set(ByVal value As Boolean)
            _MySortOrderLock = value
        End Set
    End Property

    Public Property SelectedProxyType() As ProxyType
        Get
            Return _MyProxyType
        End Get
        Set(ByVal value As ProxyType)
            _MyProxyType = value
        End Set
    End Property

    Public Property ProxyAddress() As String
        Get
            Return _MyProxyAddress
        End Get
        Set(ByVal value As String)
            _MyProxyAddress = value
        End Set
    End Property

    Public Property ProxyPort() As Integer
        Get
            Return _MyProxyPort
        End Get
        Set(ByVal value As Integer)
            _MyProxyPort = value
        End Set
    End Property

    Public Property ProxyUser() As String
        Get
            Return _MyProxyUser
        End Get
        Set(ByVal value As String)
            _MyProxyUser = value
        End Set
    End Property

    Public Property ProxyPassword() As String
        Get
            Return _MyProxyPassword
        End Get
        Set(ByVal value As String)
            _MyProxyPassword = value
        End Set
    End Property

    Public Property PeriodAdjust() As Boolean
        Get
            Return _MyPeriodAdjust
        End Get
        Set(ByVal value As Boolean)
            _MyPeriodAdjust = value
        End Set
    End Property

    Public Property StartupVersion() As Boolean
        Get
            Return _MyStartupVersion
        End Get
        Set(ByVal value As Boolean)
            _MyStartupVersion = value
        End Set
    End Property

    Public Property StartupKey() As Boolean
        Get
            Return _MyStartupKey
        End Get
        Set(ByVal value As Boolean)
            _MyStartupKey = value
        End Set
    End Property

    Public Property StartupFollowers() As Boolean
        Get
            Return _MyStartupFollowers
        End Get
        Set(ByVal value As Boolean)
            _MyStartupFollowers = value
        End Set
    End Property

    Public Property StartupAPImodeNoWarning() As Boolean
        Get
            Return _MyStartupAPImodeNoWarning
        End Get
        Set(ByVal value As Boolean)
            _MyStartupAPImodeNoWarning = value
        End Set
    End Property

    Public Property RestrictFavCheck() As Boolean
        Get
            Return _MyRestrictFavCheck
        End Get
        Set(ByVal value As Boolean)
            _MyRestrictFavCheck = value
        End Set
    End Property

    Public Property AlwaysTop() As Boolean
        Get
            Return _MyAlwaysTop
        End Get
        Set(ByVal value As Boolean)
            _MyAlwaysTop = value
        End Set
    End Property

    Public Property UrlConvertAuto() As Boolean
        Get
            Return _MyUrlConvertAuto
        End Get
        Set(ByVal value As Boolean)
            _MyUrlConvertAuto = value
        End Set
    End Property
    Public Property OutputzEnabled() As Boolean
        Get
            Return _MyOutputz
        End Get
        Set(ByVal value As Boolean)
            _MyOutputz = value
        End Set
    End Property
    Public Property OutputzKey() As String
        Get
            Return _MyOutputzKey
        End Get
        Set(ByVal value As String)
            _MyOutputzKey = value
        End Set
    End Property
    Public Property OutputzUrlmode() As OutputzUrlmode
        Get
            Return _MyOutputzUrlmode
        End Get
        Set(ByVal value As OutputzUrlmode)
            _MyOutputzUrlmode = value
        End Set
    End Property

    Public Property AutoShortUrlFirst() As UrlConverter
        Get
            Return _MyAutoShortUrlFirst
        End Get
        Set(ByVal value As UrlConverter)
            _MyAutoShortUrlFirst = value
        End Set
    End Property

    Public Property UseUnreadStyle() As Boolean
        Get
            Return _MyUnreadStyle
        End Get
        Set(ByVal value As Boolean)
            _MyUnreadStyle = value
        End Set
    End Property

    Public Property DateTimeFormat() As String
        Get
            Return _MyDateTimeFormat
        End Get
        Set(ByVal value As String)
            _MyDateTimeFormat = value
        End Set
    End Property

    Public Property DefaultTimeOut() As Integer
        Get
            Return _MyDefaultTimeOut
        End Get
        Set(ByVal value As Integer)
            _MyDefaultTimeOut = value
        End Set
    End Property

    Public Property ProtectNotInclude() As Boolean
        Get
            Return _MyProtectNotInclude
        End Get
        Set(ByVal value As Boolean)
            _MyProtectNotInclude = value
        End Set
    End Property

    Public Property TabIconDisp() As Boolean
        Get
            Return _MyTabIconDisp
        End Get
        Set(ByVal value As Boolean)
            _MyTabIconDisp = value
        End Set
    End Property

    Public Property ReplyIconState() As REPLY_ICONSTATE
        Get
            Return _MyReplyIconState
        End Get
        Set(ByVal value As REPLY_ICONSTATE)
            _MyReplyIconState = value
        End Set
    End Property

    Public Property ReadOwnPost() As Boolean
        Get
            Return _MyReadOwnPost
        End Get
        Set(ByVal value As Boolean)
            _MyReadOwnPost = value
        End Set
    End Property

    Public Property GetFav() As Boolean
        Get
            Return _MyGetFav
        End Get
        Set(ByVal value As Boolean)
            _MyGetFav = value
        End Set
    End Property

    Public Property IsMonospace() As Boolean
        Get
            Return _MyMonoSpace
        End Get
        Set(ByVal value As Boolean)
            _MyMonoSpace = value
        End Set
    End Property

    Public Property ReadOldPosts() As Boolean
        Get
            Return _MyReadOldPosts
        End Get
        Set(ByVal value As Boolean)
            _MyReadOldPosts = value
        End Set
    End Property

    Public Property UseSsl() As Boolean
        Get
            Return _MyUseSsl
        End Get
        Set(ByVal value As Boolean)
            _MyUseSsl = value
        End Set
    End Property

    Public Property BitlyUser() As String
        Get
            Return _MyBitlyId
        End Get
        Set(ByVal value As String)
            _MyBitlyId = value
        End Set
    End Property

    Public Property BitlyPwd() As String
        Get
            Return _MyBitlyPw
        End Get
        Set(ByVal value As String)
            _MyBitlyPw = value
        End Set
    End Property

    Public Property ShowGrid() As Boolean
        Get
            Return _MyShowGrid
        End Get
        Set(ByVal value As Boolean)
            _MyShowGrid = value
        End Set
    End Property

    Public Property UseAtIdSupplement() As Boolean
        Get
            Return _MyUseAtIdSupplement
        End Get
        Set(ByVal value As Boolean)
            _MyUseAtIdSupplement = value
        End Set
    End Property

    Public Property Language() As String
        Get
            Return _MyLanguage
        End Get
        Set(ByVal value As String)
            _MyLanguage = value
        End Set
    End Property

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim filedlg As New OpenFileDialog()

        filedlg.Filter = My.Resources.Button3_ClickText1
        filedlg.FilterIndex = 1
        filedlg.Title = My.Resources.Button3_ClickText2
        filedlg.RestoreDirectory = True

        If filedlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BrowserPathText.Text = filedlg.FileName

        End If
    End Sub

    Private Sub RadioProxySpecified_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioProxySpecified.CheckedChanged
        Dim chk As Boolean = RadioProxySpecified.Checked
        LabelProxyAddress.Enabled = chk
        TextProxyAddress.Enabled = chk
        LabelProxyPort.Enabled = chk
        TextProxyPort.Enabled = chk
        LabelProxyUser.Enabled = chk
        TextProxyUser.Enabled = chk
        LabelProxyPassword.Enabled = chk
        TextProxyPassword.Enabled = chk
    End Sub

    Private Sub TextProxyPort_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextProxyPort.Validating
        Dim port As Integer
        If TextProxyPort.Text.Trim() = "" Then TextProxyPort.Text = "0"
        If Integer.TryParse(TextProxyPort.Text.Trim(), port) = False Then
            MessageBox.Show(My.Resources.TextProxyPort_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End If
        If port < 0 Or port > 65535 Then
            MessageBox.Show(My.Resources.TextProxyPort_ValidatingText2)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub CheckOutputz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutputz.CheckedChanged
        If CheckOutputz.Checked = True Then
            Label59.Enabled = True
            Label60.Enabled = True
            TextBoxOutputzKey.Enabled = True
            ComboBoxOutputzUrlmode.Enabled = True
        Else
            Label59.Enabled = False
            Label60.Enabled = False
            TextBoxOutputzKey.Enabled = False
            ComboBoxOutputzUrlmode.Enabled = False
        End If
    End Sub

    Private Sub TextBoxOutputzKey_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBoxOutputzKey.Validating
        If CheckOutputz.Checked Then
            TextBoxOutputzKey.Text = Trim(TextBoxOutputzKey.Text)
            If TextBoxOutputzKey.Text.Length = 0 Then
                MessageBox.Show(My.Resources.TextBoxOutputzKey_Validating)
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Function CreateDateTimeFormatSample() As Boolean
        Try
            LabelDateTimeFormatApplied.Text = DateTime.Now.ToString(CmbDateTimeFormat.Text)
        Catch ex As FormatException
            LabelDateTimeFormatApplied.Text = My.Resources.CreateDateTimeFormatSampleText1
            Return False
        End Try
        Return True
    End Function

    Private Sub CmbDateTimeFormat_TextUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDateTimeFormat.TextUpdate
        CreateDateTimeFormatSample()
    End Sub

    Private Sub CmbDateTimeFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDateTimeFormat.SelectedIndexChanged
        CreateDateTimeFormatSample()
    End Sub

    Private Sub CmbDateTimeFormat_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CmbDateTimeFormat.Validating
        If Not CreateDateTimeFormatSample() Then
            MessageBox.Show(My.Resources.CmbDateTimeFormat_Validating)
            e.Cancel = True
        End If
    End Sub

    Private Sub ConnectionTimeOut_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ConnectionTimeOut.Validating
        Dim tm As Integer
        Try
            tm = CInt(ConnectionTimeOut.Text)
        Catch ex As Exception
            MessageBox.Show(My.Resources.ConnectionTimeOut_ValidatingText1)
            e.Cancel = True
            Exit Sub
        End Try

        If tm < HttpTimeOut.MinValue OrElse tm > HttpTimeOut.MaxValue Then
            MessageBox.Show(My.Resources.ConnectionTimeOut_ValidatingText1)
            e.Cancel = True
        End If
    End Sub

    Private Sub LabelDateTimeFormatApplied_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelDateTimeFormatApplied.VisibleChanged
        CreateDateTimeFormatSample()
    End Sub

    Private Sub CheckUseApi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckUseApi.CheckedChanged
        CheckboxReply.Enabled = Not CheckUseApi.Checked
        CheckPeriodAdjust.Enabled = Not CheckUseApi.Checked
        NextThreshold.Enabled = Not CheckUseApi.Checked
        NextPages.Enabled = Not CheckUseApi.Checked
        StartupReadPages.Enabled = Not CheckUseApi.Checked
        StartupReadReply.Enabled = Not CheckUseApi.Checked
        StartupReadDM.Enabled = Not CheckUseApi.Checked
        CheckPostMethod.Enabled = False
        TextCountApi.Enabled = CheckUseApi.Checked
        TextCountApiReply.Enabled = CheckUseApi.Checked
    End Sub

    Private Sub TextCountApi_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextCountApi.Validating
        Dim cnt As Integer
        Try
            cnt = Integer.Parse(TextCountApi.Text)
        Catch ex As Exception
            MessageBox.Show(My.Resources.TextCountApi_Validating1)
            e.Cancel = True
            Exit Sub
        End Try

        If cnt < 20 OrElse cnt > 200 Then
            MessageBox.Show(My.Resources.TextCountApi_Validating1)
            e.Cancel = True
        End If
    End Sub

    Private Sub TextCountApiReply_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextCountApiReply.Validating
        Dim cnt As Integer
        Try
            cnt = Integer.Parse(TextCountApiReply.Text)
        Catch ex As Exception
            MessageBox.Show(My.Resources.TextCountApi_Validating1)
            e.Cancel = True
            Exit Sub
        End Try

        If cnt < 20 OrElse cnt > 200 Then
            MessageBox.Show(My.Resources.TextCountApi_Validating1)
            e.Cancel = True
        End If
    End Sub

    Public Property LimitBalloon() As Boolean
        Get
            Return _MyLimitBalloon
        End Get
        Set(ByVal value As Boolean)
            _MyLimitBalloon = value
        End Set
    End Property

    Private Sub Username_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Username.Validating
        If Username.Text.Trim = "" Then
            MessageBox.Show(My.Resources.Save_ClickText1)
            e.Cancel = True
            Exit Sub
        End If
        If Username.Text.Contains("@") Then
            MessageBox.Show(My.Resources.Save_ClickText2)
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub Password_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Password.Validating
        If Password.Text.Trim = "" Then
            MessageBox.Show(My.Resources.Save_ClickText1)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub ComboBoxAutoShortUrlFirst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAutoShortUrlFirst.SelectedIndexChanged
        If ComboBoxAutoShortUrlFirst.SelectedIndex = UrlConverter.Bitly OrElse _
           ComboBoxAutoShortUrlFirst.SelectedIndex = UrlConverter.Jmp Then
            TextBitlyId.Enabled = True
            TextBitlyPw.Enabled = True
        Else
            TextBitlyId.Enabled = False
            TextBitlyPw.Enabled = False
        End If
    End Sub

    Private Sub ButtonBackToDefaultFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackToDefaultFontColor.Click
        lblUnread.ForeColor = System.Drawing.SystemColors.ControlText
        lblUnread.Font = New Font(SystemFonts.DefaultFont, FontStyle.Bold Or FontStyle.Underline)

        lblListFont.ForeColor = System.Drawing.SystemColors.ControlText
        lblListFont.Font = System.Drawing.SystemFonts.DefaultFont

        lblDetail.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.ControlText)
        lblDetail.Font = System.Drawing.SystemFonts.DefaultFont

        lblInputFont.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.ControlText)
        lblInputFont.Font = System.Drawing.SystemFonts.DefaultFont

        lblSelf.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.AliceBlue)

        lblAtSelf.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.AntiqueWhite)

        lblTarget.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.LemonChiffon)

        lblAtTarget.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.LavenderBlush)

        lblAtFromTarget.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.Honeydew)

        lblFav.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.Red)

        lblOWL.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.Blue)

        lblInputBackcolor.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.LemonChiffon)

        lblAtTo.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.Pink)

        lblListBackcolor.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.Window)

        lblDetailBackcolor.BackColor = Color.FromKnownColor(System.Drawing.KnownColor.Window)

        lblDetailLink.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.Blue)

        lblRetweet.ForeColor = Color.FromKnownColor(System.Drawing.KnownColor.Green)
    End Sub
End Class
