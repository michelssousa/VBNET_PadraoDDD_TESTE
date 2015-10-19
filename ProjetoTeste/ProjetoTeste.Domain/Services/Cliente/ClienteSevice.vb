Imports ProjetoTeste.Domain.Interfaces.Repositories.Cliente
Imports ProjetoTeste.Domain.Interfaces.Services.Cliente
Imports ProjetoTeste.Domain.Interfaces._0_Base
Imports ProjetoTeste.Domain.Services._0_ServiceBase

Namespace Services.Cliente

  Public Class ClienteSevice
    Inherits SeviceBase(Of Entities.Cliente)
    Implements IClienteSevice

    Private ReadOnly _clienteRepository As IClienteRepository

    Public Sub New(ByVal clienteRepository As IClienteRepository)
      MyBase.New(clienteRepository)
      _clienteRepository = clienteRepository
    End Sub

    Public Function ObterClientesEspeciais(ByVal listaClientes As IEnumerable(Of Entities.Cliente)) As IEnumerable(Of Entities.Cliente) Implements IClienteSevice.ObterClientesEspeciais
      Return listaClientes.Where(Function(c) c.ClienteEspecial(c))
    End Function

  End Class
End Namespace