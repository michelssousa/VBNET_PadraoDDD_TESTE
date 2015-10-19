Imports ProjetoTeste.Domain.Interfaces._0_Base

Namespace Interfaces.Produto
  Public Interface IProdutoRepository
    Inherits IRepositoryBase(Of Entities.Produto)

    Function BuscarPorNome(nome As String) As IEnumerable(Of Entities.Produto)

  End Interface
End Namespace