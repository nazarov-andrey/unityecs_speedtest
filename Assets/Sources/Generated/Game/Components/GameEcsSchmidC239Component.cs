//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C239Component ecsSchmidC239 { get { return (EcsSchmid.C239Component)GetComponent(GameComponentsLookup.EcsSchmidC239); } }
    public bool hasEcsSchmidC239 { get { return HasComponent(GameComponentsLookup.EcsSchmidC239); } }

    public void AddEcsSchmidC239(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC239;
        var component = CreateComponent<EcsSchmid.C239Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC239(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC239;
        var component = CreateComponent<EcsSchmid.C239Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC239() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC239);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC239;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC239 {
        get {
            if (_matcherEcsSchmidC239 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC239);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC239 = matcher;
            }

            return _matcherEcsSchmidC239;
        }
    }
}