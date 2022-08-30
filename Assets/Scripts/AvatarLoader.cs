using System;
using UnityEngine;

public class AvatarLoader
{
    /// <summary>
    /// Event called when avatar loaded.
    /// </summary>
    public event Action<GameObject> AvatarLoaded;
    
    /// <summary>
    /// Url for downloading avatar
    /// </summary>
    public string Url;

    // Loading time.
    private float loadTime;

    /// <summary>
    /// Loads avatar.
    /// <br/>Usage:
    /// </summary>
    /// <param name="url">Link to avatar</param>
    /// <example>
    /// This shows how to Load an avatar.
    /// <code>
    /// var avatarLoader = new AvatarLoader();
    /// avatarLoader.url="http://someurl.com";
    /// avatarLoader.AvatarLoaded += avatar => {};  
    /// avatarLoader.Load(url);
    /// </code>
    /// </example>
    public void Load(string url)
    {
    }

    /// <summary>
    /// Unloads avatar.
    /// </summary>
    public void Unload()
    {
    }

    private void DoSomethingWhileLoading()
    {
    }
}
