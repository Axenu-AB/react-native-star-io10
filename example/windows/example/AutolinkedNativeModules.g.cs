﻿// AutolinkedNativeModules.g.cs contents generated by "react-native autolink-windows"

using System.Collections.Generic;

// Namespaces from @react-native-community/checkbox
using CheckboxWindows;

// Namespaces from @react-native-picker/picker
using ReactNativePicker;

// Namespaces from react-native-star-io10
using StarMicronics.ReactNative.StarIO10;

// Namespaces from react-native-webview
using ReactNativeWebView;

namespace Microsoft.ReactNative.Managed
{
    internal static class AutolinkedNativeModules
    {
        internal static void RegisterAutolinkedNativeModulePackages(IList<IReactPackageProvider> packageProviders)
        { 
            // IReactPackageProviders from @react-native-community/checkbox
            packageProviders.Add(new CheckboxWindows.ReactPackageProvider());
            // IReactPackageProviders from @react-native-picker/picker
            packageProviders.Add(new ReactNativePicker.ReactPackageProvider());
            // IReactPackageProviders from react-native-star-io10
            packageProviders.Add(new StarMicronics.ReactNative.StarIO10.ReactPackageProvider());
            // IReactPackageProviders from react-native-webview
            packageProviders.Add(new ReactNativeWebView.ReactPackageProvider());
        }
    }
}
