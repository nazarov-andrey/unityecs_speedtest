//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C275Component ecsSchmidC275 { get { return (EcsSchmid.C275Component)GetComponent(GameComponentsLookup.EcsSchmidC275); } }
    public bool hasEcsSchmidC275 { get { return HasComponent(GameComponentsLookup.EcsSchmidC275); } }

    public void AddEcsSchmidC275(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC275;
        var component = CreateComponent<EcsSchmid.C275Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC275(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC275;
        var component = CreateComponent<EcsSchmid.C275Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC275() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC275);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC275;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC275 {
        get {
            if (_matcherEcsSchmidC275 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC275);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC275 = matcher;
            }

            return _matcherEcsSchmidC275;
        }
    }
}