Imports ProjetoTeste.Domain
Imports ProjetoTeste.Domain.Entities

Namespace _0_Interface.Cliente

  Public Interface IClienteAppService
    Inherits IAppServiceBase(Of Entities.Cliente)
    Function ObterClientesEspeciais() As IEnumerable(Of Entities.Cliente)
  End Interface
End Namespace