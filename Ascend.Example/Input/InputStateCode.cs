namespace Ascend.Example.Input
{
    public class InputStateCode : InputBase<string>
    {
        public InputStateCode(string prompt, string errorMessage) : base(prompt, errorMessage)
        {
        }

        public override void Validate(ref string item, ref bool valid)
        {
            item = item.Trim();
            if (item.Length != 2)
            {
                valid = false;
                return;
            }
            valid = IsAlpha(item);
            if (valid) item = item.ToUpper();
        }
    }
}