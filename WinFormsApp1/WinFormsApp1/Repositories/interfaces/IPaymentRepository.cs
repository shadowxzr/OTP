using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface IPaymentRepository
	{
		void Create(Payment payment);
		IEnumerable<Payment> ReadAll();
	}
}