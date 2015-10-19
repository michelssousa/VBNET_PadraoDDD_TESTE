Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports ProjetoTeste.Domain.Entities
Imports ProjetoTeste.Infra.Data.EntityConfig

Namespace Contexto
  Public Class ProjetoTesteContexto
    Inherits DbContext

    Sub New()
      MyBase.New("WebServiceVbnetBD")
    End Sub
    Public Property Clientes() As DbSet(Of Cliente)
    Public Property Produtos() As DbSet(Of Produto)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
      modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
      modelBuilder.Conventions.Remove(Of OneToManyCascadeDeleteConvention)()
      modelBuilder.Conventions.Remove(Of ManyToManyCascadeDeleteConvention)()

      modelBuilder.Properties().Where(Function(p) p.Name = p.ReflectedType.Name & "Id").Configure(Function(p) p.IsKey())
      modelBuilder.Properties().Where(Function(p) p.PropertyType = GetType(String)).Configure(Function(p) p.HasColumnType("varchar"))
      modelBuilder.Properties().Where(Function(p) p.PropertyType = GetType(String)).Configure(Function(p) p.HasMaxLength(100))

      modelBuilder.Configurations.Add(New ClienteConfiguration)
      modelBuilder.Configurations.Add(New ProdutoConfiguration)


    End Sub

    Public Overrides Function SaveChanges() As Integer
      For Each entry As dbentityentry In Me.ChangeTracker.Entries().Where(Function(e) e.GetType().GetProperty("DataCadastro") <> Nothing)
        If entry.State = EntityState.Added Then
          entry.Property("DataCadastro").CurrentValue = DateTime.Now
        End If

        If entry.State = EntityState.Modified Then
          entry.Property("DataCadastro").IsModified = False
        End If
      Next
      Return MyBase.SaveChanges()
    End Function

  End Class
End Namespace