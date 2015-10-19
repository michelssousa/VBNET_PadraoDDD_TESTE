Imports ProjetoTeste.Domain
Imports ProjetoTeste.Domain.Entities

Namespace _0_Interface.Produto

  Public Interface IProdutoAppService
    Inherits IAppServiceBase(Of Entities.Produto)
    Function BuscarPorNome(nome As String) As IEnumerable(Of Entities.Produto)
  End Interface
End Namespace