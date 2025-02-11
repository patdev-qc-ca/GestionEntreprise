using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class ListeDistribution
{
    public int Id { get; set; }

    public int NoContact { get; set; }

    public string NomCompagnie { get; set; } = null!;

    public bool IsContact { get; set; }

    public bool IsClient { get; set; }

    public bool IsFournisseur { get; set; }

    public bool IsChefEntreprise { get; set; }

    public virtual Fournisseur NoContact1 { get; set; } = null!;

    public virtual Liaisoncontact NoContact2 { get; set; } = null!;

    public virtual Contact NoContactNavigation { get; set; } = null!;
}
