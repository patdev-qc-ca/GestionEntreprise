using System;
using System.Collections.Generic;

namespace GestionEntreprise.DataBase;

public partial class Piecesparprojet
{
    public int Id { get; set; }

    public int Idprojet { get; set; }

    public int? Piece { get; set; }

    public double? Qte { get; set; }

    public int Manufact { get; set; }

    public int? Fournisseur { get; set; }

    public string? Type { get; set; }

    public bool Commande { get; set; }

    public bool Recu { get; set; }

    public bool Retour { get; set; }

    public string? Noretour { get; set; }

    public bool Commandeannulee { get; set; }

    public DateOnly? Reception { get; set; }

    public int Quantiterecue { get; set; }

    public DateTime? Commandele { get; set; }

    public DateTime Requisele { get; set; }

    public string? Titrecommande { get; set; }

    public string? Commentaire { get; set; }

    public DateTime? Retournee { get; set; }
}
