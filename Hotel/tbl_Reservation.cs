namespace Hotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Reservation
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string IDNumber { get; set; }

        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeRoom { get; set; }

        public DateTime CheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckOut { get; set; }

        [Required]
        [StringLength(50)]
        public string LengthStay { get; set; }
    }
}
