//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C244Component ecsSchmidC244 { get { return (EcsSchmid.C244Component)GetComponent(GameComponentsLookup.EcsSchmidC244); } }
    public bool hasEcsSchmidC244 { get { return HasComponent(GameComponentsLookup.EcsSchmidC244); } }

    public void AddEcsSchmidC244(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC244;
        var component = CreateComponent<EcsSchmid.C244Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC244(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC244;
        var component = CreateComponent<EcsSchmid.C244Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC244() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC244);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC244;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC244 {
        get {
            if (_matcherEcsSchmidC244 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC244);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC244 = matcher;
            }

            return _matcherEcsSchmidC244;
        }
    }
}