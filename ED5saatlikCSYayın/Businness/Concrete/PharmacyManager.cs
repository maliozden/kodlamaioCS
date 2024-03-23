using Businness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        IApplicantService _applicantService;
        public PharmacyManager(IApplicantService applicantService)
        {

            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
            Console.WriteLine("Eczaneden maske verildi");
        }
    }
}
