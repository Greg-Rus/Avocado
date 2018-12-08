using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreatePlayerSystem : IInitializeSystem {
    private Contexts _context;

    public CreatePlayerSystem(Contexts context)
    {
        _context = context;
    }

    // Use this for initialization
    void Start () {
		
	}
	

    public void Initialize()
    {
        var e = _context.game.CreateEntity();
        e.AddHealth(100);
    }
}
