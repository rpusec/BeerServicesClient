using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Validation
{
    /// <summary>
    /// This class is used for input validation purposes. 
    /// </summary>
    public abstract class InputValidation
    {
        /// <summary>
        /// Validates the number length
        /// </summary>
        /// <param name="lengthFrom">From what character should the input's length be validated. </param>
        /// <param name="lengthTo">To what character should the input's length be validated. </param>
        /// <param name="input">input</param>
        /// <returns>True if length is appropriate, false otherwise. </returns>
        public static Boolean ValidateLength(int lengthFrom, int lengthTo, String input)
        {
            if (input.Length >= lengthFrom && input.Length <= lengthTo)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates the number's length. 
        /// </summary>
        /// <param name="input">input </param>
        /// <param name="maxLength">maximum length</param>
        /// <returns>True if length is appropriate, false otherwise. </returns>
        public static Boolean ValidateNumberLength(double input, int maxLength)
        {
            try
            {
                int inputInt = (int)input; //removing the decimal part of the number
                String inputStr = "" + inputInt; //parsing the input into a string to find the length

                if (inputStr.Length > maxLength)
                    return false;
                else
                    return true;
            }
            catch (FormatException) 
            {
                //returns false if a FormatException occured
                return false;
            }
        }

        /// <summary>
        /// Validates the format
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>True if format is correct, false otherwise. </returns>
        public static Boolean ValidateNumberFormat(String input)
        {
            try
            {
                //tests if it is a number
                double num = double.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                //returns false if a FormatException occured
                return false;
            }
        }
    }
}
