Imports ProjetoTeste.Application._0_Interface.Cliente
Imports ProjetoTeste.Application._1_Classes.Base
Imports ProjetoTeste.Domain.Entities
Imports ProjetoTeste.Domain.Interfaces.Services.Cliente

Namespace _1_Classes.Cliente

  Public Class ClienteAppService
    Inherits AppServiceBase(Of ProjetoTeste.Domain.Entities.Cliente)
    Implements IClienteAppService

    Private ReadOnly _clienteService As IClienteSevice

    Public Sub New(ByVal clienteService As IClienteSevice)
      MyBase.New(clienteService)
      _clienteService = clienteService
    End Sub

    Public Function ObterClientesEspeciais() As IEnumerable(Of ProjetoTeste.Domain.Entities.Cliente) Implements IClienteAppService.ObterClientesEspeciais
      Return _clienteService.ObterClientesEspeciais(_clienteService.GetAll())
    End Function
  End Class

End Namespace