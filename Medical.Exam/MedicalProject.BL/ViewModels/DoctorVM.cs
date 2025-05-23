using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject.BL.ViewModels
{
    public class DoctorVM
    {
        public IFormFile File { get; set; }
        public string DoctorName { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
