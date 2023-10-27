using PharmacyManagement.Model;
using PharmacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Services
{
    public class DoctorService
    {
        private readonly DoctorDAL _doctor;
        public DoctorService(DoctorDAL doctor)
        {
            _doctor = doctor;
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctor.AddDoctor(doctor);
        }
    }
}
