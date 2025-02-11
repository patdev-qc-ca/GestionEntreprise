using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Punch
{
    public int Id { get; set; }

    public int? Employe { get; set; }

    public int Noprojet { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly Debut { get; set; }

    public TimeOnly? Fin { get; set; }

    public string? Commentaire { get; set; }

    public bool Facture { get; set; }

    public string? Nofacture { get; set; }

    public string? Noclient { get; set; }

    public bool Km { get; set; }

    public string? Nbrekm { get; set; }

    public int Section { get; set; }

    public string? Duree { get; set; }
}
