using System;

using R5T.T0141;


namespace R5T.S0084
{
    /// <summary>
    /// .NET target framework moniker (<see cref="T0218.ITargetFrameworkMoniker"/>, example: "net6.0") demonstrations.
    /// </summary>
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_DotnetMajorVersionForTargetFramework()
        {
            /// Inputs.
            var targetFramework =
                Instances.TargetFrameworkMonikers.NET_6
                ;


            /// Run.
            var dotnetMajorVersion = Instances.TargetFrameworkMonikerOperator.Get_DotnetMajorVersion(targetFramework);

            Console.WriteLine($"{targetFramework} => {dotnetMajorVersion}");
        }
    }
}
