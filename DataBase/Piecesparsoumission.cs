using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Piecesparsoumission
{
    public int Id { get; set; }

    public int Idsoumission { get; set; }

    public int Piece { get; set; }

    public double Qte { get; set; }

    public double Temps { get; set; }

    public double Dureetotale { get; set; }

    public decimal Prixtotal { get; set; }

    public decimal Prixorigine { get; set; }

    public bool Commande { get; set; }

    public bool Recu { get; set; }

    public bool Retour { get; set; }

    public bool Commandeannulee { get; set; }

    public string? Commentaire { get; set; }

    public virtual Soumission IdsoumissionNavigation { get; set; } = null!;

    public virtual Piece PieceNavigation { get; set; } = null!;
}
