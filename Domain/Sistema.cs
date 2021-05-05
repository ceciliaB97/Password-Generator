using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sistema
    {
        #region attributes
        public RandomPasswordGenerator PasswordGenerator { get; set; }
        #endregion

        #region constructor
        public Sistema()
        {
            PasswordGenerator = new RandomPasswordGenerator();
        }
        #endregion

        #region methods
        /// <summary>
        /// According to lenght of password generates a new password or gives an error message.
        /// </summary>
        /// <param name="lenght"></param>
        /// <returns></returns>
        public string GeneratePassword(int lenght=10)
        {
            string password = "Lenght must be greater or equals to 10.";

            if (RandomPasswordGenerator.ValidateLenght(lenght))
            {
                password = PasswordGenerator.GeneratePassword(true, true, true, true, lenght);
            }

            return password;
        }
        #endregion

    }
}
