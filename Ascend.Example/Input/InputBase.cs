using System;
using System.Text.RegularExpressions;

namespace Ascend.Example.Input
{
    public abstract class InputBase<T>
    {
        protected InputBase(string prompt, string errorMessage)
        {
            Prompt = prompt;
            ErrorMessage = errorMessage;
        }
        public string Prompt { get; set; }
        public string ErrorMessage { get; set; }
        public T ValidValue { get; set; }
        public object EnteredValue { get; set; }
        public abstract void Validate(ref T item, ref bool valid);
        public T GetValidEntry()
        {
            bool valid = false;
            while (valid == false)
            {
                Application.AppBase.UI.WriteLine(Prompt);
                if (typeof(T) != typeof(char))
                    EnteredValue = Application.AppBase.UI.ReadLine("");
                else
                    EnteredValue = Application.AppBase.UI.ReadKey(Char.MinValue);
                try
                {

                    if (typeof(T) == typeof(decimal))
                    {
                        object test = Decimal.Parse(EnteredValue.ToString());
                        ValidValue = (T)test;
                    }

                    else ValidValue = (T)EnteredValue;


                    T valueEntered = ValidValue;
                    valid = true;
                    Validate(ref valueEntered, ref valid);
                }
                catch
                {
                    Application.AppBase.UI.WriteLine(ErrorMessage);

                }
            }
            return ValidValue;
        }

        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }
    }
}
