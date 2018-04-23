Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Lookup_KeyMember
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim categories = New List(Of Category) From { _
                New Category() With {.ID = 0, .Name = "Beverages"}, _
                New Category() With {.ID = 1, .Name = "Grains"}, _
                New Category() With {.ID = 2, .Name = "Seafood"} _
            }

            gridControl1.DataSource = New List(Of Product) From { _
                New Product() With { _
                    .ProductName="Chang", .Category = New Category() With {.ID = 0} _
                }, _
                New Product() With { _
                    .ProductName="Ipoh Coffee", .Category = New Category() With {.ID = 0} _
                }, _
                New Product() With { _
                    .ProductName="Ravioli Angelo", .Category = New Category() With {.ID = 1} _
                }, _
                New Product() With { _
                    .ProductName="Filo Mix", .Category = New Category() With {.ID = 1} _
                }, _
                New Product() With { _
                    .ProductName="Tunnbröd", .Category = New Category() With {.ID = 1} _
                }, _
                New Product() With { _
                    .ProductName="Konbu", .Category = New Category() With {.ID = 2} _
                }, _
                New Product() With { _
                    .ProductName="Boston Crab Meat", .Category = New Category() With {.ID = 2} _
                } _
            }

            Dim riLookUp As New RepositoryItemLookUpEdit()
            riLookUp.KeyMember = "ID"
            riLookUp.DisplayMember = "Name"
            riLookUp.DataSource = categories

            gridView1.Columns("Category").ColumnEdit = riLookUp
        End Sub
    End Class

    Public Class Product
        Public Property Category() As Category
        Public Property ProductName() As String
    End Class

    Public Class Category
        Public Property ID() As Integer
        Public Property Name() As String
    End Class
End Namespace
