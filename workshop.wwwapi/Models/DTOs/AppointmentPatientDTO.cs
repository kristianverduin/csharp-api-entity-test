﻿namespace workshop.wwwapi.Models.DTOs
{
    public class AppointmentPatientDTO
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTime Booking { get; set; }
    }
}
