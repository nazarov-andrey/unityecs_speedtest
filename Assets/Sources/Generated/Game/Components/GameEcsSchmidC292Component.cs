//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C292Component ecsSchmidC292 { get { return (EcsSchmid.C292Component)GetComponent(GameComponentsLookup.EcsSchmidC292); } }
    public bool hasEcsSchmidC292 { get { return HasComponent(GameComponentsLookup.EcsSchmidC292); } }

    public void AddEcsSchmidC292(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC292;
        var component = CreateComponent<EcsSchmid.C292Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC292(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC292;
        var component = CreateComponent<EcsSchmid.C292Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC292() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC292);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC292;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC292 {
        get {
            if (_matcherEcsSchmidC292 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC292);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC292 = matcher;
            }

            return _matcherEcsSchmidC292;
        }
    }
}