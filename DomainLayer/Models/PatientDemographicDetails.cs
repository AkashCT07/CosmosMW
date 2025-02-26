﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class PatientDemographicDetails
    {
        public Guid PatientDemographicId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; } //enum
        public string Race { get; set; }
        public string Ethinicity { get; set; }
        public string Address { get; set; }
        public string PreviousAllergies { get; set; }
        public Boolean IsFatal { get; set; }

        [ForeignKey("PatientRelativeDetails")]
        public Guid PatientRelativeId { get; set; }
        public PatientRelativeDetails PatientRelativeDetails { get; set; }
        //public string EmergencyContactFN { get; set; }
        //public string EmergencyContactLN { get; set; }
        //public string EmergencyContactAddress { get; set; }
        //public string EmergencyContactRelation { get; set; }
        //public double EmergencyContactPhone { get; set; }

    }
}
