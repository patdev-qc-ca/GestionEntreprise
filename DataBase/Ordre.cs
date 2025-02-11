using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Ordre
{
    public int Id { get; set; }

    public string Famille { get; set; } = null!;
}
