//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C26Component ecsSchmidC26 { get { return (EcsSchmid.C26Component)GetComponent(GameComponentsLookup.EcsSchmidC26); } }
    public bool hasEcsSchmidC26 { get { return HasComponent(GameComponentsLookup.EcsSchmidC26); } }

    public void AddEcsSchmidC26(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC26;
        var component = CreateComponent<EcsSchmid.C26Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC26(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC26;
        var component = CreateComponent<EcsSchmid.C26Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC26() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC26);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC26;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC26 {
        get {
            if (_matcherEcsSchmidC26 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC26);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC26 = matcher;
            }

            return _matcherEcsSchmidC26;
        }
    }
}
