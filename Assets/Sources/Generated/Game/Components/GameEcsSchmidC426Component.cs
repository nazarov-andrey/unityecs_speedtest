//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C426Component ecsSchmidC426 { get { return (EcsSchmid.C426Component)GetComponent(GameComponentsLookup.EcsSchmidC426); } }
    public bool hasEcsSchmidC426 { get { return HasComponent(GameComponentsLookup.EcsSchmidC426); } }

    public void AddEcsSchmidC426(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC426;
        var component = CreateComponent<EcsSchmid.C426Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC426(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC426;
        var component = CreateComponent<EcsSchmid.C426Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC426() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC426);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC426;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC426 {
        get {
            if (_matcherEcsSchmidC426 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC426);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC426 = matcher;
            }

            return _matcherEcsSchmidC426;
        }
    }
}