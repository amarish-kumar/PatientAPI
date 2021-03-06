﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        Task<Doctor> FindById(int doctorId);
        Task<List<Doctor>> GetAll();
        Task<Doctor> Update(int doctorId, Doctor doctor);
        Task Delete(int doctorId);
        Task<Doctor> Add(Doctor doctor);
        Task SaveChanges();
        Task<Doctor> GetPatientDoctor(int patientId, int doctorId);
        Task<List<Doctor>> GetPatientDoctors(int patientId);
    }
}
