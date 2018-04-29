using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Course
{
    public class PositiveDoubleRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo ci)
        {
            double Val = 0;

            try
            {
                Val = Double.Parse((string)value);
            }
            catch
            {
                return new ValidationResult(false, "Недопустимые символы.");
            }

            if (Val < 0)
            {
                return new ValidationResult(false,
                  "Может быть введено только положительное число");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
