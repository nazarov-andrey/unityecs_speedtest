//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C62Component ecsSchmidC62 { get { return (EcsSchmid.C62Component)GetComponent(GameComponentsLookup.EcsSchmidC62); } }
    public bool hasEcsSchmidC62 { get { return HasComponent(GameComponentsLookup.EcsSchmidC62); } }

    public void AddEcsSchmidC62(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC62;
        var component = CreateComponent<EcsSchmid.C62Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC62(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC62;
        var component = CreateComponent<EcsSchmid.C62Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC62() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC62);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC62;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC62 {
        get {
            if (_matcherEcsSchmidC62 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC62);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC62 = matcher;
            }

            return _matcherEcsSchmidC62;
        }
    }
}
