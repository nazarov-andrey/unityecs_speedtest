//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C72Component ecsSchmidC72 { get { return (EcsSchmid.C72Component)GetComponent(GameComponentsLookup.EcsSchmidC72); } }
    public bool hasEcsSchmidC72 { get { return HasComponent(GameComponentsLookup.EcsSchmidC72); } }

    public void AddEcsSchmidC72(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC72;
        var component = CreateComponent<EcsSchmid.C72Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC72(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC72;
        var component = CreateComponent<EcsSchmid.C72Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC72() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC72);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC72;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC72 {
        get {
            if (_matcherEcsSchmidC72 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC72);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC72 = matcher;
            }

            return _matcherEcsSchmidC72;
        }
    }
}