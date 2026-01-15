namespace TRK_TARpe24EN.Models;
using System.ComponentModel.DataAnnotations;

public enum Violations
{
    Assault, Theft, Vandalism, Skipping, Bullying
}
public class Delinquents
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public bool isStudent { get; set; }
    public string PunishmentType { get; set; }
    public int PunishmentLength { get; set; }
    public string Description { get; set; }

}
