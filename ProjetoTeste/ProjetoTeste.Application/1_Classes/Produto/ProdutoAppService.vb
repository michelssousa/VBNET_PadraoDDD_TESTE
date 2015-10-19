Imports ProjetoTeste.Application._0_Interface.Produto
Imports ProjetoTeste.Application._1_Classes.Base
Imports ProjetoTeste.Domain.Interfaces.Produto
Imports ProjetoTeste.Domain.Interfaces.Services.Produto
Imports ProjetoTeste.Domain

Namespace _1_Classes.Produto
  Public Class ProdutoAppService
    Inherits AppServiceBase(Of Entities.Produto)
    Implements IProdutoAppService

    Private ReadOnly _produtoRepository As IProdutoService

    Public Sub New(ByVal produtoRepository As IProdutoService)
      MyBase.New(produtoRepository)
      _produtoRepository = produtoRepository
    End Sub

    Public Function BuscarPorNome(ByVal nome As String) As IEnumerable(Of Entities.Produto) Implements IProdutoAppService.BuscarPorNome
      Return _produtoRepository.BuscarPorNome(nome:=nome)
    End Function

  End Class
End Namespace