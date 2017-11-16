using System.Linq;

namespace Ascend.Example.Input
{
    public class InputYesNo : InputBase<char>
    {
        public InputYesNo(string prompt, string errorMessage) : base(prompt, errorMessage)
        {
        }

        public override void Validate(ref char item, ref bool valid)
        {
            char[] validchars = { 'y', 'Y', 'N', 'n' };

            valid = validchars.Contains(item);
        }
    }
}