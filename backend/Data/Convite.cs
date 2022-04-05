using System.ComponentModel.DataAnnotations;

namespace Parceria.Data
{
    public class Convite
    {
        [Key]
        public int ConviteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailDestinatario { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string WalletRemetente { get; set; }

        public string Link { get; set; } = string.Empty;

    }
}
