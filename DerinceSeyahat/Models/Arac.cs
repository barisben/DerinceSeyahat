using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.Models
{
    public class Arac
    {
        [Key]
        public int AracId { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        [Display(Name = "Araç Markası")]
        public string AracMarka { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        [Display(Name = "Araç Modeli")]
        public string AracModel { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        [Display(Name = "Araç Kapasitesi")]
        public int AracKapasite { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        [Display(Name = "Araç Adedi")]
        public int AracAdet { get; set; }
        [Display(Name = "Araç Fotoğrafı")]
        public string AracImage { get; set; }

    }
}
