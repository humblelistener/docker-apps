using Microsoft.AspNet.Mvc;

namespace aspApp
{
	public class HomeController: Controller
	{
		public User User()
        {
            User user = new User()
            {
                Name = "My name",
                Address = "My address"
            };

            return user;
        }
	}

	public class User
	{
		public string Name {get; set;}
		public string Address {get; set;}
	}
}