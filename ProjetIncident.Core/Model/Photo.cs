using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetIncident.Core.Model
{
    public class Photo
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PhotoBase64 { get; set; }
        public int IncidentId { get; set; }

        [ForeignKey(nameof(IncidentId))]
        public Incident Incident { get; set; }

        public Photo()
        {
        }
    }
}