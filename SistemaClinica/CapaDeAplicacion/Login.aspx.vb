Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Response.Redirect("PanelGeneral.aspx")
    End Sub
End Class

