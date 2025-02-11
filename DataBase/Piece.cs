using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Piece
{
    public int Id { get; set; }

    public int Idpiece { get; set; }

    public int? Qte { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public int? Idmanufacturier { get; set; }

    public decimal Prixliste { get; set; }

    public double? Escompte { get; set; }

    public decimal PrixNet { get; set; }

    public int Idfournisseur { get; set; }

    public decimal PrixTotal { get; set; }

    public int Type { get; set; }

    public bool Commande { get; set; }

    public bool Retour { get; set; }

    public string? Noretour { get; set; }

    public bool Recu { get; set; }

    public DateOnly? Datereception { get; set; }

    public int? Quantiterecue { get; set; }

    public DateOnly? Datecommande { get; set; }

    public DateOnly Daterequise { get; set; }

    public bool Commandeannulee { get; set; }

    public DateOnly? Dateretour { get; set; }

    public string? Prixorigine { get; set; }

    public int? Devise { get; set; }

    public virtual ICollection<Catalogue> Catalogues { get; set; } = new List<Catalogue>();

    public virtual Devise? DeviseNavigation { get; set; }

    public virtual Manufacturier? IdmanufacturierNavigation { get; set; }

    public virtual ICollection<Piecesparsoumission> Piecesparsoumissions { get; set; } = new List<Piecesparsoumission>();
}
