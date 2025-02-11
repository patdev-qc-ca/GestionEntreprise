using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Liaisoncontact
{
    public int Id { get; set; }

    public int Nocontact { get; set; }

    public int? Noclient { get; set; }

    public int? Nomanufacturier { get; set; }

    public int? Nofournisseur { get; set; }

    public virtual ICollection<ListeDistribution> ListeDistributions { get; set; } = new List<ListeDistribution>();

    public virtual Client? NoclientNavigation { get; set; }

    public virtual Contact NocontactNavigation { get; set; } = null!;

    public virtual Fournisseur? NofournisseurNavigation { get; set; }

    public virtual Manufacturier? NomanufacturierNavigation { get; set; }
}
