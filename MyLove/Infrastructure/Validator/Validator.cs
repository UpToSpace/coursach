using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLove.Infrastructure.Validator
{
    static class Validator
    {
        public static bool Validate(dynamic obj)
        {
            ValidationContext contex = new ValidationContext(obj, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(obj, contex, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
