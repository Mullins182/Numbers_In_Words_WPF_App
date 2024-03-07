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
        public string input;

        // Constructors Start
        public TranslateLogic() { }

        public TranslateLogic(string input)
        {
            this.input = input;
        }

        // Constructors END !!

        public void CheckInput()
        {
            if (input == null) 
            {
                MessageBox.Show("Da ist was schief gelaufen !");
            }
        }

    }





}
