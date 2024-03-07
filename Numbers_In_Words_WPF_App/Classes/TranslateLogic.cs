using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Numbers_In_Words_WPF_App.Classes
{
    public class TranslateLogic
    {
        public string output;

        // Constructors Start
        public TranslateLogic() { }

        // Constructors END !!

        public string CheckInput(uint input)
        {

            if(input == 1)
            {
                output = "Eins";
            }
            else 
            {
                output = "Bitte etwas eingeben !";
            }

            return output;
        }
    }
}
