namespace Organization_of_storage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    class Registration
    {
        [Key]
        public int id_user { get; set; }

        [Required]
        [StringLength(50)]
        public string login_u { get; set; }

        [Required]
        [StringLength(50)]
        public string password_u { get; set; }

        public bool? is_admin { get; set; }

        //public virtual Person Person { get; set; }
    }
}
