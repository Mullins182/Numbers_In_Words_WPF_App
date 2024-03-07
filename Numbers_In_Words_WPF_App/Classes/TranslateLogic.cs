﻿using System;
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

        public List<string> words = new List<string>()
        {   "Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Eleven","Twelfe","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen",
            "Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety","Hundred","Thousand","Tenthousand","Hundredthousand","Million"};

        // Constructors Start
        public TranslateLogic() { }

        // Constructors END !!

        public string CheckInput(string input)
        {

            if (input == "1")
            {
                output = words[1];
            }
            else if (input == "2")
            {
                output = words[2];
            }
            else if (input == "3")
            {
                output = words[3];
            }
            else if (input == "4")
            {
                output = words[4];
            }
            else if (input == "5")
            {
                output = words[5];
            }
            else if (input == "6")
            {
                output = words[6];
            }
            else if (input == "7")
            {
                output = words[7];
            }
            else if (input == "8")
            {
                output = words[8];
            }
            else if (input == "9")
            {
                output = words[9];
            }
            else if (input == "0")
            {
                output = words[0];
            }
            else if (input == "10")
            {
                output = words[10];
            }
            else if (input == "11")
            {
                output = words[11];
            }
            else if (input == "12")
            {
                output = words[12];
            }
            else if (input == "13")
            {
                output = words[13];
            }
            else if (input == "14")
            {
                output = words[14];
            }
            else if (input == "15")
            {
                output = words[15];
            }
            else if (input == "16")
            {
                output = words[16];
            }
            else if (input == "17")
            {
                output = words[17];
            }
            else if (input == "18")
            {
                output = words[18];
            }
            else if (input == "19")
            {
                output = words[19];
            }
            else if (input == "20")
            {
                output = words[20];
            }
            else if (input.Count() == 2)
            {
                output = words[Convert.ToInt32(input.ElementAt(0)) - 30] + words[Convert.ToInt32(input.ElementAt(1)) - 48];
            }
            else
            {
                output = "Type in a valid value PLS ;D";
            }

            return output;
        }
    }
}
