using System;
using System.Threading.Tasks;


namespace R5T.S0101
{
    class Program
    {
        static async Task Main()
        {
            //await Demonstrations.Instance.In_New_SampleProjectContext();
            //await Demonstrations.Instance.Create_SampleRazorClassLibraryProject();
            await Demonstrations.Instance.Create_SampleBlazorClientProject();
        }
    }
}