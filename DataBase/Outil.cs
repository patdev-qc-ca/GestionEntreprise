using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Outil
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int Secteur { get; set; }

    public decimal Prix { get; set; }

    public string? TypeEtiquette { get; set; }

    public string? DateAchat { get; set; }

    public string? DateHorsFonction { get; set; }

    public string? Commentaire { get; set; }
}
