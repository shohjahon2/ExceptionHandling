using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            int response = 0;
            string trimmedString = stringValue.Replace(" ","");
            trimmedString = trimmedString.Replace("+","");

            if (!trimmedString.StartsWith('-'))
            {
                foreach (char c in trimmedString)
                {
                    response *= 10;
                    response += c - '0';
                }
            }
            else
            {
                trimmedString = trimmedString.Replace("-","");
                foreach (char c in trimmedString)
                {
                    response *= 10;
                    response += c - '0';
                }
                response = -response;

            }
            return response;
        }
    }
}