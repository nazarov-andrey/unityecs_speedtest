//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C401Component ecsSchmidC401 { get { return (EcsSchmid.C401Component)GetComponent(GameComponentsLookup.EcsSchmidC401); } }
    public bool hasEcsSchmidC401 { get { return HasComponent(GameComponentsLookup.EcsSchmidC401); } }

    public void AddEcsSchmidC401(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC401;
        var component = CreateComponent<EcsSchmid.C401Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC401(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC401;
        var component = CreateComponent<EcsSchmid.C401Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC401() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC401);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC401;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC401 {
        get {
            if (_matcherEcsSchmidC401 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC401);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC401 = matcher;
            }

            return _matcherEcsSchmidC401;
        }
    }
}