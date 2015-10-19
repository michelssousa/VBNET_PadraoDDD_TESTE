Namespace Interfaces._0_Base
  Public Interface IRepositoryBase(Of T As Class)
    Sub Add(obj As T)
    Function GetById(int As Integer) As T
    Function GetAll() As IEnumerable(Of T)
    Sub Update(obj As T)
    Sub Remove(obj As T)
    Sub Dispose()
  End Interface
End Namespace