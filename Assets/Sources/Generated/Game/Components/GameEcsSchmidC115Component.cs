//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C115Component ecsSchmidC115 { get { return (EcsSchmid.C115Component)GetComponent(GameComponentsLookup.EcsSchmidC115); } }
    public bool hasEcsSchmidC115 { get { return HasComponent(GameComponentsLookup.EcsSchmidC115); } }

    public void AddEcsSchmidC115(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC115;
        var component = CreateComponent<EcsSchmid.C115Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC115(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC115;
        var component = CreateComponent<EcsSchmid.C115Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC115() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC115);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC115;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC115 {
        get {
            if (_matcherEcsSchmidC115 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC115);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC115 = matcher;
            }

            return _matcherEcsSchmidC115;
        }
    }
}