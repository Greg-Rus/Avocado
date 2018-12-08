using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class LogHealth : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;

    public LogHealth(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Health);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasHealth;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            Debug.Log("Health: " + e.health.Value);
        }
    }

}
