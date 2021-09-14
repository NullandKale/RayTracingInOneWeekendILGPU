using System;
using ILGPU;
using ILGPU.Runtime;

namespace RayTracingInOneWeekendILGPU
{
    class Program
    {
        static bool DEBUG = false;
        static void Main(string[] args)
        {
            //Initialize ILGPU
            Context context = Context.Create(builder => builder.Default().EnableAlgorithms());
            Accelerator device = context.GetPreferredDevice(preferCPU: DEBUG)
                                      .CreateAccelerator(context);

            device.PrintInformation();
        }
    }
}
