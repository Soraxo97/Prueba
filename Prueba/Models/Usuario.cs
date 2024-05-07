using System;
using System.Collections.Generic;

namespace Prueba.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? IdPerfil { get; set; }

    public int? Activo { get; set; }

    public virtual Perfil? IdPerfilNavigation { get; set; }
}
