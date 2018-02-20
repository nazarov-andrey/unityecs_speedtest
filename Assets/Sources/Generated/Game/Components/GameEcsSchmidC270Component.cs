//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C270Component ecsSchmidC270 { get { return (EcsSchmid.C270Component)GetComponent(GameComponentsLookup.EcsSchmidC270); } }
    public bool hasEcsSchmidC270 { get { return HasComponent(GameComponentsLookup.EcsSchmidC270); } }

    public void AddEcsSchmidC270(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC270;
        var component = CreateComponent<EcsSchmid.C270Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC270(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC270;
        var component = CreateComponent<EcsSchmid.C270Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC270() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC270);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC270;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC270 {
        get {
            if (_matcherEcsSchmidC270 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC270);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC270 = matcher;
            }

            return _matcherEcsSchmidC270;
        }
    }
}