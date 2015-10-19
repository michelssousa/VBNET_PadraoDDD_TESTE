Namespace Interfaces.Services.Produto
  Public Interface IProdutoService
    Inherits IServiceBase(Of Entities.Produto)
    Function BuscarPorNome(nome As String) As IEnumerable(Of Entities.Produto)

  End Interface
End Namespace