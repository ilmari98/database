﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonDBTest.Models
{
    public partial class Phone
    {
        [Column("id")]
        public long Id { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(20)]
        public string Number { get; set; }
        public long? Personid { get; set; }
    }
}