using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft:MonoBehaviour {
    public Inventory inventory;
    public BuildTree tree;
    public Player player;

    private void OnValidate()
    {
        inventory = FindObjectOfType<Inventory>();
        tree = FindObjectOfType<BuildTree>();
        player = FindObjectOfType<Player>();

        Initialize();
    }

    private void Initialize()
    {
        var wood = new Item("wood", "You got wood");
        var twig = new Item("twig", "It's a twig");
        var stone = new Item("stone", "I did not cast the first stone");
        var tools = new Category("tools", "Wish it was all tooth and claw");
        var axe = new Tool("axe", "Murder trees. Mass murder in case of a forest", tools,
            new Ingredient(twig, 2),
            new Ingredient(stone, 1));
        var light = new Category("light", "Let there be light");
        var firepit = new Structure("firepit", "Everything burns", light, new Ingredient(stone, 5));
        firepit.Function(0, () =>
        {
            //firepit stuff
        }, wood, twig);
        var bush = new Resource("bush", "The bushiest of them all", twig);
        var rock = new Resource("rock", "Harder than anything else. That's what she said", stone);
        var tree = new Resource("tree", "Once there was a tree, and she loved a little boy",wood);
        tree.Requires(axe);
    }

    internal void Make(Craftable craftable)
    {
        Instantiate(craftable.model, player.transform.position, new Quaternion(), player.transform.parent);
        tree.Update(craftable);
    }
}
