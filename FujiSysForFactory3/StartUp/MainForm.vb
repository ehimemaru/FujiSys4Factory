Public Class MainForm

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim StrMsg As String = "システムを終了します。" & System.Environment.NewLine & "よろしいですか？"
        Dim DResult As DialogResult = MessageBox.Show(StrMsg, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DResult = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim FrmLogin As New LogInForm
        My.Forms.LogInForm.MdiParent = Me
        My.Forms.LogInForm.Show()

    End Sub


End Class