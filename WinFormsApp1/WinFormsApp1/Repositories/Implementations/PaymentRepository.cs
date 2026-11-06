using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class PaymentRepository : IPaymentRepository
	{
		public void Create(Payment payment) { }
		public IEnumerable<Payment> ReadAll() => new List<Payment>();
	}
}