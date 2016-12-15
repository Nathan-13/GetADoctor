﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetADoctor.Models
{
    public class Waiting : SystemEntity
    {
        public String Name { get; set; }
        public int Serial { get; set; }
        public String Date { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}