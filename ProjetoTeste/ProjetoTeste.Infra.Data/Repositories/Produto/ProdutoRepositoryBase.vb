
Imports ProjetoTeste.Domain.Interfaces.Produto
Imports ProjetoTeste.Infra.Data.Repositories._0_Base

Namespace Repositories.Produto
  Public Class ProdutoRepositoryBase
    Inherits RepositoryBase(Of Domain.Entities.Produto)
    Implements IProdutoRepository

    Public Function BuscarPorNome(ByVal nome As String) As IEnumerable(Of Domain.Entities.Produto) Implements IProdutoRepository.BuscarPorNome
      Return _contexto.Set(Of Domain.Entities.Produto)().Where(Function(p) p.Nome = nome)
    End Function
  End Class
End Namespace