//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C217Component ecsSchmidC217 { get { return (EcsSchmid.C217Component)GetComponent(GameComponentsLookup.EcsSchmidC217); } }
    public bool hasEcsSchmidC217 { get { return HasComponent(GameComponentsLookup.EcsSchmidC217); } }

    public void AddEcsSchmidC217(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC217;
        var component = CreateComponent<EcsSchmid.C217Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC217(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC217;
        var component = CreateComponent<EcsSchmid.C217Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC217() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC217);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC217;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC217 {
        get {
            if (_matcherEcsSchmidC217 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC217);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC217 = matcher;
            }

            return _matcherEcsSchmidC217;
        }
    }
}