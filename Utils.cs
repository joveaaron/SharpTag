using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTag
{
    internal class Utils
    {
        public string MinecraftRootDir;
        public string APIMetaFile;
        public string ServersDatFile;
        public string VersionsDir;
        public string TempDir;
        public string LauncherlogsTxtFile;
        public string LibrariesDir;
        public string MojangNettyDir;
        public string NettyBootstrapDir;
        public string NettyBootstrapClassFile;
        public string MojangPatchyDir;
        public string PatchyBootstrapClassFile;
        public string VersionManifestJsonFile;
        public string LauncherProfilesJsonFile;
        public string AssetsRootDir;
        public string AssetsIndexesDir;
        public string AssetsObjectsDir;
        public string ArgsDiv;
        public string AssetsVirtualDir;
        public string AssetsVirtualLegacyDir;
        public Utils()
        {
            switch(Environment.OSVersion.Platform)
            {
                //if WINDOWS
                case PlatformID.Win32NT:
                    ArgsDiv = ";";
                    MinecraftRootDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
                    break;
                //if UNIX-based
                case PlatformID.Unix:
                    //ArgsDiv = ":";
                    //MinecraftRootDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/.minecraft";
                    //break;
                //if OSX
                case PlatformID.MacOSX:
                    //ArgsDiv = ":";
                default:
                    throw new PlatformNotSupportedException("This platform is not supported. Visit https://github.com/joveaaron/SharpTag for further information.");
            }
            APIMetaFile = MinecraftRootDir + "/api_meta";
            ServersDatFile = MinecraftRootDir + "/servers.dat";
            VersionsDir = MinecraftRootDir + "/versions";
            TempDir = MinecraftRootDir + "/tmp";
            LauncherlogsTxtFile = MinecraftRootDir + "/Launcherlogs.txt";
            LibrariesDir = MinecraftRootDir + "/libraries";
            MojangNettyDir = LibrariesDir + "/com/mojang/netty";
            NettyBootstrapDir = TempDir + "/io/netty/bootstrap";
            NettyBootstrapClassFile = NettyBootstrapDir + "/Bootstrap.class";
            MojangPatchyDir = LibrariesDir + "/com/mojang/patchy";
            PatchyBootstrapClassFile = NettyBootstrapDir + "/Bootstrap.class"; //??? name makes no sense
            VersionManifestJsonFile = MinecraftRootDir + "/version_manifest.json";
            LauncherProfilesJsonFile = MinecraftRootDir + "/launcher_profiles.json";
            AssetsRootDir = MinecraftRootDir + "/assets";
            AssetsIndexesDir = AssetsRootDir + "/indexes";
            AssetsObjectsDir = AssetsRootDir + "/objects";
            AssetsVirtualDir = AssetsRootDir + "/virtual";
            AssetsVirtualLegacyDir = AssetsVirtualDir + "/legacy";
        }
        public string GetVersionJsonFile(string version)
        {
            return VersionsDir + "/" + version + "/" + version + ".json";
        }
        public string GetVersionJarFile(string version)
        {
            return VersionsDir + "/" + version + "/" + version + ".jar";
        }
        public string GetVersionNativesDir(string version)
        {
            return VersionsDir + "/" + version + "/natives";
        }
        public string GetAssetsIndexes_X_json(string version)
        {
            return AssetsIndexesDir + "/" + version + ".json";
        }
        public string getMineCraft_X_json(string username)
        {
            return MinecraftRootDir + "/" + username + ".json";
        }
        //two methods that are the same and do weird new Utils in java wtff
        public string setMineCraft_Versions_X_NativesLocation(string _path)
        {
            return LibrariesDir + "/" + _path;
        }
        public string setMineCraft_librariesLocation(string _path)
        {
            return LibrariesDir + "/" + _path;
        }
    }
}