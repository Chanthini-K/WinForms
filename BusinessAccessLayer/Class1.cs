using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Logger;

namespace BusinessAccessLayer
{
    public class SecurityCodeBAL
    {
        private SecurityCodeDAL dal = new SecurityCodeDAL();
        private FormsLogger logger = new FormsLogger();
        public void AddSecurityCode(string code, string description)
        {
            dal.AddSecurityCode(code, description);
            logger.Log($"Added security code: {code}");
        }

        public void UpdateSecurityCode(string code, string description)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Code and Description cannot be empty.");
            }
            dal.UpdateSecurityCode(code, description);
            logger.Log($"Updated security code: {code}");
        }

        public List<string> GetAllSecurityCodes()
        {
            return dal.GetAllSecurityCodes();
        }
    }
}

