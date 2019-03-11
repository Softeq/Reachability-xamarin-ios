using System;
using ObjCRuntime;

namespace ReachabilityBindings
{
    [Native]
    public enum NetworkStatus : long
    {
        NotReachable = 0,
        ReachableViaWiFi = 2,
        ReachableViaWWAN = 1
    }
}
