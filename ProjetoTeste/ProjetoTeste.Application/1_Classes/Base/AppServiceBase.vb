Imports ProjetoTeste.Domain.Interfaces.Services

Namespace _1_Classes.Base

  Public Class AppServiceBase(Of T As Class)
    Implements IAppServiceBase(Of T)

    Private ReadOnly _serviceBase As IServiceBase(Of T) 'Camada de Aplicaco conversa com a camada de servico.


    Public Sub New(ByVal repository As IServiceBase(Of T))
      _serviceBase = repository
    End Sub

    Public Sub Add(obj As T) Implements IAppServiceBase(Of T).Add
      _serviceBase.Add(obj)
    End Sub

    Public Function GetAll() As IEnumerable(Of T) Implements IAppServiceBase(Of T).GetAll
      Return _serviceBase.GetAll
    End Function

    Public Function GetById(int As Integer) As T Implements IAppServiceBase(Of T).GetById
      Return _serviceBase.GetById(int)
    End Function

    Public Sub Remove(obj As T) Implements IAppServiceBase(Of T).Remove
      _serviceBase.Remove(obj)
    End Sub

    Public Sub Update(obj As T) Implements IAppServiceBase(Of T).Update
      _serviceBase.Update(obj)
    End Sub

    Public Sub Dispose() Implements IAppServiceBase(Of T).Dispose
      _serviceBase.Dispose()
    End Sub

  End Class
End Namespace