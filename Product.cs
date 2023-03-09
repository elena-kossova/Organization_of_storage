namespace Organization_of_storage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        public int Year { get; set; }

        public int ID_Place { get; set; }

        public int ID_Component { get; set; }

        public int ID_Container { get; set; }

        public int ID_Type { get; set; }

        public int Count { get; set; }

        [StringLength(150)]
        public string Recipe { get; set; }

        public virtual Container Container { get; set; }

        public virtual Ingredients Ingredients { get; set; }

        public virtual Location Location { get; set; }

        public virtual Type_of_conservation Type_of_conservation { get; set; }
    }
}
