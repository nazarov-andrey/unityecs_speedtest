//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C357Component ecsSchmidC357 { get { return (EcsSchmid.C357Component)GetComponent(GameComponentsLookup.EcsSchmidC357); } }
    public bool hasEcsSchmidC357 { get { return HasComponent(GameComponentsLookup.EcsSchmidC357); } }

    public void AddEcsSchmidC357(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC357;
        var component = CreateComponent<EcsSchmid.C357Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC357(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC357;
        var component = CreateComponent<EcsSchmid.C357Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC357() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC357);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC357;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC357 {
        get {
            if (_matcherEcsSchmidC357 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC357);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC357 = matcher;
            }

            return _matcherEcsSchmidC357;
        }
    }
}