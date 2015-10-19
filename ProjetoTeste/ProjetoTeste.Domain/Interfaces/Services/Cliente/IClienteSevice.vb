
Namespace Interfaces.Services.Cliente
  Public Interface IClienteSevice
    Inherits IServiceBase(Of Entities.Cliente)

    Function ObterClientesEspeciais(listaClientes As IEnumerable(Of Entities.Cliente)) As IEnumerable(Of Entities.Cliente) 'Servico especial para recuperar todos os clientes especiais presentes na entidade cliente.

  End Interface
End Namespace