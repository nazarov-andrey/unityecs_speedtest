//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C414Component ecsSchmidC414 { get { return (EcsSchmid.C414Component)GetComponent(GameComponentsLookup.EcsSchmidC414); } }
    public bool hasEcsSchmidC414 { get { return HasComponent(GameComponentsLookup.EcsSchmidC414); } }

    public void AddEcsSchmidC414(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC414;
        var component = CreateComponent<EcsSchmid.C414Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC414(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC414;
        var component = CreateComponent<EcsSchmid.C414Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC414() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC414);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC414;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC414 {
        get {
            if (_matcherEcsSchmidC414 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC414);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC414 = matcher;
            }

            return _matcherEcsSchmidC414;
        }
    }
}