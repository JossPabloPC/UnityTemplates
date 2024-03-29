using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPaths
{
    public static readonly string PERSISTENT_DATA       = Application.persistentDataPath;
    public static readonly string PATH_RESOURCE_SFX     = "Audio/SFX/";
    public static readonly string PATH_RESOURCE_MUSIC   = "Audio/Music/";
}

public class AppPlayerPrefKeys
{
    public static readonly string MUSIC_VOLUME = "MUSIC_VOLUME";
    public static readonly string SFX_VOLUME = "SFX _VOLUME ";
}
