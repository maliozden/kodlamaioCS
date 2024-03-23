using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businness.Abstract;
using Entities.Concrete;

namespace Businness.Concrete;

public  class PttManager : ISupplierService
{

    //kodu daha bağımsız kılmak için dependecy injection dediğim yöntem kullanılır.
    //personManager yerine interface sınıfı bir nesne tanımlanarak işlemler gerçekleştirilir.
    private IApplicantService _applicantService;
   

    public PttManager(IApplicantService applicantService)
    {
        _applicantService=applicantService; 
    }

   

    public void GiveMask(Person person)
    {
        if(_applicantService.CheckPerson(person)) { Console.WriteLine($"{person.Name} için maske PTT'den verildi"); } else
        {
            Console.WriteLine("Maske Verilemedi");
        }


       /* Bu kullanım senaryosu kodu personManager a bağımlı hale getirir.
        * 
        * PersonManager personManager = new PersonManager();
        if (personManager.CheckPerson(person))
        {
            Console.WriteLine($"{person.Name} için maske verildi");

        }*/
    }

}
