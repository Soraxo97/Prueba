using System;
using System.Collections.Generic;

namespace Prueba.Models;

public partial class Perfil
{
    public int IdPerfil { get; set; }

    public string? NombrePerfil { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
