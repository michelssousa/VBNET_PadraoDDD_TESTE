Imports System.Data.Entity.ModelConfiguration
Imports ProjetoTeste.Domain.Entities

Namespace EntityConfig
  Public Class ProdutoConfiguration
    Inherits EntityTypeConfiguration(Of Produto)
    Sub New()
      HasKey(Function(p) p.ProdutoId)
      [Property](Function(p) p.Nome).IsRequired().HasMaxLength(250)
      [Property](Function(p) p.Valor).IsRequired()
      HasRequired(Function(p) p.Cliente).WithMany().HasForeignKey(Function(p) p.ClienteId)
    End Sub
  End Class
End Namespace