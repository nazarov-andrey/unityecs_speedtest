//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C70Component ecsSchmidC70 { get { return (EcsSchmid.C70Component)GetComponent(GameComponentsLookup.EcsSchmidC70); } }
    public bool hasEcsSchmidC70 { get { return HasComponent(GameComponentsLookup.EcsSchmidC70); } }

    public void AddEcsSchmidC70(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC70;
        var component = CreateComponent<EcsSchmid.C70Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC70(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC70;
        var component = CreateComponent<EcsSchmid.C70Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC70() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC70);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC70;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC70 {
        get {
            if (_matcherEcsSchmidC70 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC70);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC70 = matcher;
            }

            return _matcherEcsSchmidC70;
        }
    }
}
