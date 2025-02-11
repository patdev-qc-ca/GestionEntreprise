using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Transport
{
    public int Id { get; set; }

    public string? Transport1 { get; set; }

    public virtual ICollection<Bonscommande> Bonscommandes { get; set; } = new List<Bonscommande>();

    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();
}
