//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C383Component ecsSchmidC383 { get { return (EcsSchmid.C383Component)GetComponent(GameComponentsLookup.EcsSchmidC383); } }
    public bool hasEcsSchmidC383 { get { return HasComponent(GameComponentsLookup.EcsSchmidC383); } }

    public void AddEcsSchmidC383(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC383;
        var component = CreateComponent<EcsSchmid.C383Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC383(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC383;
        var component = CreateComponent<EcsSchmid.C383Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC383() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC383);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC383;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC383 {
        get {
            if (_matcherEcsSchmidC383 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC383);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC383 = matcher;
            }

            return _matcherEcsSchmidC383;
        }
    }
}