using System;
using System.Collections.Generic;

namespace AlmarchivosPT.Models;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public int? NumIdPersona { get; set; }

    public string? Correo { get; set; }

    public string? TipoIdPersona { get; set; }

    public DateTime? FechaCreacionP { get; set; }
}
