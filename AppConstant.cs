using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppScenes
{
    public static readonly string Main_Scene = "Menu";
    public static readonly string LOADING_SCENE = "Loading";
    public static readonly string GAME_SCENE = "Menu";
}
public class AppPlayerPrefKeys
{
    public static readonly string MUSIC_VOLUME = "MusicVolume";
    public static readonly string SFX_VOLUME = "SfxVolume";
}

public class AppPaths
{
    public static readonly string PERSISTENT_DATA = Application.persistentDataPath;
    public static readonly string PATH_RESOURCE_SFX = "Audio/Sfx/";
    public static readonly string PATH_RESOURCEMUSIC = "Audio/Music/";
}