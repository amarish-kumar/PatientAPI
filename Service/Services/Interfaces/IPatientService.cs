﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Repository.Dto;

namespace Service.Services.Interfaces
{
    public interface IPatientService
    {
        Task<List<PatientDto>> Get();
        Task<PatientDto> Get(int patientId);
        Task<PatientDto> Post(PatientDto patientDto);
        Task<PatientDto> Put(int patientId, PatientDto patientDto);
        Task Delete(int patientId);
    }
}
