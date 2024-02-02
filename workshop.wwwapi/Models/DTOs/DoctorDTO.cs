﻿namespace workshop.wwwapi.Models.DTOs
{
    public class DoctorDTO
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public List<AppointmentDoctorDTO> Appointments { get; set; } = new List<AppointmentDoctorDTO>();
    }
}
