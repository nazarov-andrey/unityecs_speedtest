//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C265Component ecsSchmidC265 { get { return (EcsSchmid.C265Component)GetComponent(GameComponentsLookup.EcsSchmidC265); } }
    public bool hasEcsSchmidC265 { get { return HasComponent(GameComponentsLookup.EcsSchmidC265); } }

    public void AddEcsSchmidC265(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC265;
        var component = CreateComponent<EcsSchmid.C265Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC265(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC265;
        var component = CreateComponent<EcsSchmid.C265Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC265() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC265);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC265;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC265 {
        get {
            if (_matcherEcsSchmidC265 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC265);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC265 = matcher;
            }

            return _matcherEcsSchmidC265;
        }
    }
}