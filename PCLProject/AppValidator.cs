using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLProject
{
    public class AppValidator
    {
        IDialog dialog;

        public string Email { get; set; }

        public string Password { get; set; }

        public string Device { get; set; }

        public AppValidator(IDialog dialog)
        {
            this.dialog = dialog;
        }

        public async void Validate()
        {
            var serviceClient = new SALLab04.ServiceClient();
            var svcResult = await serviceClient.ValidateAsync(Email, Password, Device);
            var result = $"{ svcResult.Status}\n{ svcResult.Fullname}\n{svcResult.Token}";
            dialog.Show(result);
        }
    }
}
