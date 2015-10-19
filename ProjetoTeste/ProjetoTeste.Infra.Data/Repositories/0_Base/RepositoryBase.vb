Imports System.Data.Entity
Imports ProjetoTeste.Domain.Interfaces._0_Base

Namespace Repositories._0_Base
  Public Class RepositoryBase(Of T As Class)
    Implements IRepositoryBase(Of T)

    Protected _contexto As DbContext

    Protected Sub New()

    End Sub

    Protected Sub New(contexto As DbContext)
      _contexto = contexto
    End Sub

    Public Sub Add(obj As T) Implements IRepositoryBase(Of T).Add
      _contexto.Set(Of T).Add(obj)
    End Sub

    Public Function GetAll() As IEnumerable(Of T) Implements IRepositoryBase(Of T).GetAll
      Return _contexto.Set(Of T).ToList()
    End Function

    Public Function GetById(int As Integer) As T Implements IRepositoryBase(Of T).GetById
      Return _contexto.Set(Of T).Find(int)
    End Function

    Public Sub Remove(obj As T) Implements IRepositoryBase(Of T).Remove
      _contexto.Set(Of T).Remove(obj)
    End Sub

    Public Sub Update(obj As T) Implements IRepositoryBase(Of T).Update
      _contexto.Entry(obj).State = EntityState.Modified
      _contexto.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IRepositoryBase(Of T).Dispose
      _contexto.Dispose()
    End Sub

  End Class
End Namespace