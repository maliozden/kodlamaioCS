using Businness.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete;

public  class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }
    public List<Person> GetList() 
    {
        
            return null;
    }
    public  bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(54937226682,"Muhammed Ali","Özden",2001))).Result.Body.TCKimlikNoDogrulaResult;
    }



}









