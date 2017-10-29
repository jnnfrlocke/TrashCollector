﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class GetZip
    {
        [Key]
        public int Id { get; set; }

        public string ZipCode { get; set; }
    }
}