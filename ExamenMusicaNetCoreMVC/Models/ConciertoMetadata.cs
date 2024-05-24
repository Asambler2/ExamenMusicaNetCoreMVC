using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExamenMusicaNetCoreMVC.Models
{
    [ModelMetadataType(typeof(ConciertoMetadata))]
    public partial class Concierto { }
    public class ConciertoMetadata
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("([0-9]{2})([/])([0-9]{2})([/])([0-9]{4})", ErrorMessage = "Fecha invalida")]
        public DateTime? Fecha { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string? Genero { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string? Lugar { get; set; }

    }
}
