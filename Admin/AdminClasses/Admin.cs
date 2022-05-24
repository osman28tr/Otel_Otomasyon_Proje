namespace Otel_Rezervasyon.Admin.AdminClasses
{
    internal class Admin
    {

        public bool Login(string Username, string Password)
        {
            return Username=="admin"&& Password == "admin";
        }
    }
}
