using MvvmCross.Platform.Plugins;

namespace Day06.IOS.Bootstrap
{
    public class FilePluginBootstrap
        : MvxLoaderPluginBootstrapAction<MvvmCross.Plugins.File.PluginLoader, MvvmCross.Plugins.File.iOS.Plugin>
    {
    }
    public class DownloadCachePluginBootstrap
        : MvxLoaderPluginBootstrapAction<MvvmCross.Plugins.DownloadCache.PluginLoader, MvvmCross.Plugins.DownloadCache.iOS.Plugin>
    {
    }
}