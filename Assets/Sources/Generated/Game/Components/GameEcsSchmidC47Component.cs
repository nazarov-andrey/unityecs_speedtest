//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C47Component ecsSchmidC47 { get { return (EcsSchmid.C47Component)GetComponent(GameComponentsLookup.EcsSchmidC47); } }
    public bool hasEcsSchmidC47 { get { return HasComponent(GameComponentsLookup.EcsSchmidC47); } }

    public void AddEcsSchmidC47(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC47;
        var component = CreateComponent<EcsSchmid.C47Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC47(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC47;
        var component = CreateComponent<EcsSchmid.C47Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC47() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC47);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC47;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC47 {
        get {
            if (_matcherEcsSchmidC47 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC47);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC47 = matcher;
            }

            return _matcherEcsSchmidC47;
        }
    }
}