using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private LogHealth _logHealthSystem;
    private Contexts _context;
    private CreatePlayerSystem _createPlayerSystem;
    void Start ()
	{

	    _context = Contexts.sharedInstance;
	    _logHealthSystem = new LogHealth(_context);
        _createPlayerSystem = new CreatePlayerSystem(_context);
	    _createPlayerSystem.Initialize();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _logHealthSystem.Execute();
        }
    }
	

}
