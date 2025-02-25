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

        public Utils()
        {
            switch(Environment.OSVersion.Platform)
            {
                //if WINDOWS
                case PlatformID.Win32NT:
                    MinecraftRootDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
                    break;
                //if UNIX-based
                case PlatformID.Unix:
                    MinecraftRootDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/.minecraft";
                    break;
                //if OSX
                case PlatformID.MacOSX:
                    MinecraftRootDir = ;
                    break;
                default:
                    throw new PlatformNotSupportedException("This platform is not supported. Visit https://github.com/joveaaron/TagAPI-Sharp for further information.");
            }
        }
    }
}