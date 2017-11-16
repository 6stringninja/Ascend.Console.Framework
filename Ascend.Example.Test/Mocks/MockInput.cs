using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascend.Example.Test.Mocks
{
    public class MockInput:Input.InputBase<string>
    {
        public MockInput(string prompt, string errorMessage) : base(prompt, errorMessage)
        {
        }

        public override void Validate(ref string item, ref bool valid)
        {
            valid = true;
        }
    }
}
