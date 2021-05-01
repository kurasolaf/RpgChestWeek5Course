using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RpgChest.Helpers
{
    public class InputIntValidation
    {

        public bool InputNumber(string input)
        {
            string isNumeric = input;
            bool result = int.TryParse(isNumeric, out _);

            return result;

        }








    }
}
