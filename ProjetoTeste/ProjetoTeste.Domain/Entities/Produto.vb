Namespace Entities
  Public Class Produto
    Public Property ProdutoId() As Integer
    Public Property Nome() As String
    Public Property Valor() As Decimal
    Public Property Disponivel() As Boolean
    Public Property ClienteId() As Integer
    Public Overridable Property Cliente() As New Cliente
  End Class
End Namespace