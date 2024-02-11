using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager: ISupplierService
{
	private IApplicantService _applicantService;

	public PttManager(IApplicantService applicantService)
	{
		_applicantService = applicantService;
		

    }


	public void GiveMask(Person person)
	{
		PersonManager personManager = new PersonManager();
		if (_applicantService.CheckPerson(person))
		{
			Console.WriteLine(person.FirstName + " için maske verildi");
		}
		else
		{
			Console.WriteLine(person.FirstName + " için maske verilemedi");
		}
	}
}

