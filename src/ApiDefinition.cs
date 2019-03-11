using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using SystemConfiguration;

namespace ReachabilityBindings
{
    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const kReachabilityChangedNotification;
    //    [Field("kReachabilityChangedNotification", "__Internal")]
    //    NSString kReachabilityChangedNotification { get; }
    //}

    // typedef void (^NetworkReachable)(Reachability *);
    delegate void NetworkReachable(Reachability arg0);

    // typedef void (^NetworkUnreachable)(Reachability *);
    delegate void NetworkUnreachable(Reachability arg0);

    // @interface Reachability : NSObject
    [BaseType(typeof(NSObject))]
    interface Reachability
    {
        // @property (copy, nonatomic) NetworkReachable reachableBlock;
        [Export("reachableBlock", ArgumentSemantic.Copy)]
        NetworkReachable ReachableBlock { get; set; }

        // @property (copy, nonatomic) NetworkUnreachable unreachableBlock;
        [Export("unreachableBlock", ArgumentSemantic.Copy)]
        NetworkUnreachable UnreachableBlock { get; set; }

        // @property (assign, nonatomic) BOOL reachableOnWWAN;
        [Export("reachableOnWWAN")]
        bool ReachableOnWWAN { get; set; }

        // +(Reachability *)reachabilityWithHostname:(NSString *)hostname;
        [Static]
        [Export("reachabilityWithHostname:")]
        Reachability ReachabilityWithHostname(string hostname);

        // +(Reachability *)reachabilityWithHostName:(NSString *)hostname;
        [Static]
        [Export("reachabilityWithHostName:")]
        Reachability ReachabilityWithHostName(string hostname);

        // +(Reachability *)reachabilityForInternetConnection;
        [Static]
        [Export("reachabilityForInternetConnection")]
        Reachability ReachabilityForInternetConnection { get; }

        //// +(Reachability *)reachabilityWithAddress:(void *)hostAddress;
        //[Static]
        //[Export("reachabilityWithAddress:")]
        //unsafe Reachability ReachabilityWithAddress(void* hostAddress);

        // +(Reachability *)reachabilityForLocalWiFi;
        [Static]
        [Export("reachabilityForLocalWiFi")]
        Reachability ReachabilityForLocalWiFi { get; }

        //// -(Reachability *)initWithReachabilityRef:(SCNetworkReachabilityRef)ref;
        //[Export("initWithReachabilityRef:")]
        //unsafe IntPtr Constructor(SCNetworkReachabilityRef* @ref);

        // -(BOOL)startNotifier;
        [Export("startNotifier")]
        bool StartNotifier();

        // -(void)stopNotifier;
        [Export("stopNotifier")]
        void StopNotifier();

        // -(BOOL)isReachable;
        [Export("isReachable")]
        bool IsReachable { get; }

        // -(BOOL)isReachableViaWWAN;
        [Export("isReachableViaWWAN")]
        bool IsReachableViaWWAN { get; }

        // -(BOOL)isReachableViaWiFi;
        [Export("isReachableViaWiFi")]
        bool IsReachableViaWiFi { get; }

        // -(BOOL)isConnectionRequired;
        [Export("isConnectionRequired")]
        bool IsConnectionRequired { get; }

        // -(BOOL)connectionRequired;
        [Export("connectionRequired")]
        bool ConnectionRequired { get; }

        // -(BOOL)isConnectionOnDemand;
        [Export("isConnectionOnDemand")]
        bool IsConnectionOnDemand { get; }

        // -(BOOL)isInterventionRequired;
        [Export("isInterventionRequired")]
        bool IsInterventionRequired { get; }

        // -(NetworkStatus)currentReachabilityStatus;
        [Export("currentReachabilityStatus")]
        NetworkStatus CurrentReachabilityStatus { get; }

        // -(SCNetworkReachabilityFlags)reachabilityFlags;
        [Export("reachabilityFlags")]
        NetworkReachabilityFlags ReachabilityFlags { get; }

        // -(NSString *)currentReachabilityString;
        [Export("currentReachabilityString")]
        string CurrentReachabilityString { get; }

        // -(NSString *)currentReachabilityFlags;
        [Export("currentReachabilityFlags")]
        string CurrentReachabilityFlags { get; }
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern double ReachabilityVersionNumber;
    //    [Field("ReachabilityVersionNumber", "__Internal")]
    //    double ReachabilityVersionNumber { get; }

    //    // extern const unsigned char [] ReachabilityVersionString;
    //    [Field("ReachabilityVersionString", "__Internal")]
    //    byte[] ReachabilityVersionString { get; }
    //}
}
