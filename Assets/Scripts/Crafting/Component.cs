using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Component {
    public string name { get; private set; }
    public string description { get; private set; }

    protected Craft craft
    {
        get
        {
            return GameObject.FindObjectOfType<Craft>();
        }
    }
    public AudioClip sound
    {
        get
        {
            return Assets.sounds.Get(name);
        }
    }
    public Texture2D symbol
    {
        get
        {
            return Assets.symbols.Get(name);
        }
    }
    public Texture2D icon
    {
        get
        {
            return Assets.textures.Get(name);
        }
    }
    public GameObject model
    {
        get
        {
            return Assets.prefabs.Get(name);
        }
    }
    public GameObject gameObject { get; set; }

    public Component(string name, string description)
    {
        this.name = name;
        this.description = description;
        gameObject = GameObject.Instantiate(model);
    }

    public override bool Equals(object obj)
    {
        return name.Equals((Component)obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
