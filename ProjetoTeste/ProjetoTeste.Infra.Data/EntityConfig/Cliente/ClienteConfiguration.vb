Imports System.Data.Entity.ModelConfiguration
Imports ProjetoTeste.Domain.Entities

Namespace EntityConfig
  Public Class ClienteConfiguration
    Inherits EntityTypeConfiguration(Of Cliente)

    Sub New()
      HasKey(Function(c) c.ClienteId)
      [Property](Function(c) c.Nome).IsRequired().HasMaxLength(150)
      [Property](Function(c) c.SobreNome).IsRequired().HasMaxLength(150)
      [Property](Function(c) c.SobreNome).IsRequired()
    End Sub
  End Class
End Namespace