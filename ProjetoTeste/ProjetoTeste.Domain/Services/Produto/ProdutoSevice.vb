Imports ProjetoTeste.Domain.Interfaces.Produto
Imports ProjetoTeste.Domain.Interfaces.Services.Produto
Imports ProjetoTeste.Domain.Interfaces._0_Base
Imports ProjetoTeste.Domain.Services._0_ServiceBase

Namespace Services.Produto
  Public Class ProdutoSevice
    Inherits SeviceBase(Of Entities.Produto)
    Implements IProdutoService

    Private ReadOnly _produtoRepository As IProdutoRepository

    Public Sub New(ByVal produtoRepository As IProdutoRepository)
      MyBase.New(produtoRepository)
      _produtoRepository = produtoRepository
    End Sub

    Public Function BuscarPorNome(ByVal nome As String) As IEnumerable(Of Entities.Produto) Implements IProdutoService.BuscarPorNome
      Return _produtoRepository.BuscarPorNome(nome:=nome)
    End Function

  End Class
End Namespace