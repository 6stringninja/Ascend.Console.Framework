namespace Ascend.Example.Input
{
    public class InputSaleAmount : InputBase<decimal>
    {
        public InputSaleAmount(string prompt, string errorMessage) : base(prompt, errorMessage)
        {
        }

        public override void Validate(ref decimal item, ref bool valid)
        {

        }
    }
}