using System;
// Worked LATE with Paul to complete this file for the assignment due 9am 15May2020
namespace AspNetCoreTodo.Models
{
    public class CarErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
