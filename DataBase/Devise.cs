using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Devise
{
    public int Id { get; set; }

    public string Desciption { get; set; } = null!;

    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
