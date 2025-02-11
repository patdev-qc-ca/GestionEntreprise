using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Type
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();

    public virtual ICollection<Alarme> Alarmes { get; set; } = new List<Alarme>();
}
