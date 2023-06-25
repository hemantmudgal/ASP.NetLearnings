using Dummy.Models;

namespace Dummy.ViewModel
{
	public class CustomerFormViewModel
	{
		public IEnumerable<MembershipType> MembershipTypes { get; set; }
		public Customers Customer { get; set; }
	}
}
