//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C76Component ecsSchmidC76 { get { return (EcsSchmid.C76Component)GetComponent(GameComponentsLookup.EcsSchmidC76); } }
    public bool hasEcsSchmidC76 { get { return HasComponent(GameComponentsLookup.EcsSchmidC76); } }

    public void AddEcsSchmidC76(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC76;
        var component = CreateComponent<EcsSchmid.C76Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC76(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC76;
        var component = CreateComponent<EcsSchmid.C76Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC76() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC76);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC76;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC76 {
        get {
            if (_matcherEcsSchmidC76 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC76);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC76 = matcher;
            }

            return _matcherEcsSchmidC76;
        }
    }
}