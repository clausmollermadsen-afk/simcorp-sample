using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.Sample.Entities.Extensions
{
    /// <summary>
    /// Extensions for double
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Ensure value greater than zero
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="name">Name of the value</param>
        /// <param name="errorMessage">Error message if not greater than zero</param>
        /// <returns>Returns true if greater than zero</returns>
        public static bool EnsureGreaterThanZero(this double value, string name, [NotNullWhen(false)] out string? errorMessage)
        {
            errorMessage = null;
            if (value <= 0 || double.IsNaN(value))
            {
                errorMessage = $"{name}: {value} is less or equal to zero or is Nan";
                return false;
            }

            return true;
        }
    }
}
