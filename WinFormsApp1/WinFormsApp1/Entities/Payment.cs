using System;

namespace DrivingSchool.Entities
{
	public class Payment
	{
		public int Id { get; private set; }
		public int StudentId { get; private set; }
		public decimal Amount { get; private set; }
		public DateTime PaymentDate { get; private set; }

		public static Payment CreateEntity(int id, int studentId, decimal amount, DateTime paymentDate)
		{
			return new Payment
			{
				Id = id,
				StudentId = studentId,
				Amount = amount,
				PaymentDate = paymentDate
			};
		}
	}
}