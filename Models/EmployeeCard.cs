﻿using Newtonsoft.Json;
using PSP.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSP.Models
{
    [Table("EmployeeCard")]
    public class EmployeeCard
    {
        [Key]
        [JsonProperty("employeeCardId")]
        public Guid EmployeeCardId { get; set; }

        [JsonProperty("locationId")]
        public Guid LocationId { get; set; }
        internal virtual Location location { get; set; }

        [JsonProperty("employeeId")]
        public Guid EmployeeId { get; set; }
        internal virtual Employee employee { get; set; }

        [JsonProperty("status")]
        public CardStatus Status { get; set; }
    }
}
