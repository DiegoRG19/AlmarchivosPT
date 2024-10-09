using System;
using System.Collections.Generic;

namespace AlmarchivosPT.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contrasenia { get; set; }

    public DateTime? FechaCreacionU { get; set; }
}
