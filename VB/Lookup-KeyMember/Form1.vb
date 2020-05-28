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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim categories = New List(Of Category) From {
				New Category() With {
					.ID = 0,
					.Name = "Beverages"
				},
				New Category() With {
					.ID = 1,
					.Name = "Grains"
				},
				New Category() With {
					.ID = 2,
					.Name = "Seafood"
				}
			}

			gridControl1.DataSource = New List(Of Product) From {
				New Product() With {
					.ProductName="Chang",
					.Category = New Category() With {.ID = 0}
				},
				New Product() With {
					.ProductName="Ipoh Coffee",
					.Category = New Category() With {.ID = 0}
				},
				New Product() With {
					.ProductName="Ravioli Angelo",
					.Category = New Category() With {.ID = 1}
				},
				New Product() With {
					.ProductName="Filo Mix",
					.Category = New Category() With {.ID = 1}
				},
				New Product() With {
					.ProductName="Tunnbröd",
					.Category = New Category() With {.ID = 1}
				},
				New Product() With {
					.ProductName="Konbu",
					.Category = New Category() With {.ID = 2}
				},
				New Product() With {
					.ProductName="Boston Crab Meat",
					.Category = New Category() With {.ID = 2}
				}
			}

			Dim riLookUp As New RepositoryItemLookUpEdit()
			riLookUp.KeyMember = "ID"
			riLookUp.DisplayMember = "Name"
			riLookUp.DataSource = categories

			gridControl1.RepositoryItems.Add(riLookUp)
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
