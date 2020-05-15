// Worked LATE with Paul to complete this file for the assignment due 9am 15May2020
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCar.Models
{
    public class CarItem
    {
        public Guid Id { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public int CarYear { get; set; }
    }
}
/* This class defines what the database will need to store for each to-do
item: an ID, a title or name, whether the item is complete, and what the
due date is. Each line defines a property of the class: */