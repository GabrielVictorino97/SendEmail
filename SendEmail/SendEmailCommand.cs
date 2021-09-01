using System;

namespace ConsoleApp1
{
    public class SendEmailCommand
    {
        public Guid Key { get; set; }
        public string FullName { get; set; }
        public int EmployeeNumber { get; set; }
        public string Email { get; set; }
        public DateTime AcceptanceDate { get; set; }
        public string AcceptanceTerm { get; set; }
        public string Version { get; set; }
        public string DeviceModel { get; set; }
        public string Senha { get; set; }

    }
}
