'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Statuses
    Public Property Id As Integer
    Public Property ServiceCall_Id As Integer
    Public Property ProviderID As Integer
    Public Property TimeOf As Date
    Public Property Status1 As String
    Public Property Comments As String

    Public Overridable Property Provider As Providers
    Public Overridable Property ServiceCall As ServiceCalls

End Class