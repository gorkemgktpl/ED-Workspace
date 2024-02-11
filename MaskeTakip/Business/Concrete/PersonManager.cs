using System;
using Business.Abstract;
using Entities.Concrete;
using ServiceReference;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
	public void ApplyForMask(Person person)
	{

	}

	public List<Person> GetList()
	{
		return null;
	}

	public bool CheckPerson(Person person)
	{
        //mernis kontrolü yapılacak
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(person.NationalID,person.FirstName,person.LastName,person.DateOfBirth).Result.Body.TCKimlikNoDogrulaResult;
    }
}

