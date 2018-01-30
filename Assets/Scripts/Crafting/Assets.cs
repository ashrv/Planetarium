using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

internal static class Assets
{
    static ICollection<GameObject> _prefabs;
    internal static ICollection<GameObject> prefabs
    {
        get
        {
            if (_prefabs == null)
                _prefabs = new Collection<GameObject>("Assets/Prefabs/Characters");
            return _prefabs;
        }
    }
    static ICollection<AudioClip> _sounds;
    internal static ICollection<AudioClip> sounds
    {
        get
        {
            if (_sounds == null)
                _sounds = new Collection<AudioClip>("Assets/Sounds","*.mp3");
            return _sounds;
        }
    }
    static ICollection<Texture2D> _textures;
    internal static ICollection<Texture2D> textures
    {
        get
        {
            if (_textures == null)
                _textures = new Collection<Texture2D>("Assets/Textures", "*.png");
            return _textures;
        }
    }
    static ICollection<Texture2D> _symbols;
    internal static ICollection<Texture2D> symbols
    {
        get
        {
            if (_symbols == null)
                _symbols = new Collection<Texture2D>("Assets/Symbols", "*.png");
            return _symbols;
        }
    }

    internal interface ICollection<T> where T : Object
    {
        T Get(string name);
    }

    class Collection<T>:ICollection<T> where T:Object
    {
        List<T> data;

        public Collection(string path, string format = "*.prefab")
        {
            data = new List<T>(Load(path, format));
        }

        public T Get(string name)
        {
            return data.SingleOrDefault(z => z.name.Equals(name));
        }

        List<T> Load(string path, string format, SearchOption searchOption = SearchOption.AllDirectories)
        {
            List<T> loaded = new List<T>();

#if UNITY_EDITOR

            if (path != "")
                if (path.EndsWith("/"))
                    path = path.TrimEnd('/');

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] fileInf = dirInfo.GetFiles(format, searchOption);

            foreach (FileInfo fileInfo in fileInf)
            {
                string fullPath = fileInfo.FullName.Replace(@"\", "/");
                string assetPath = "Assets" + fullPath.Replace(Application.dataPath, "");
                T prefab = UnityEditor.AssetDatabase.LoadAssetAtPath(assetPath, typeof(T)) as T;
                if (prefab)
                    loaded.Add(prefab);
            }

#endif

            return loaded;
        }
    }
}
