//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C350Component ecsSchmidC350 { get { return (EcsSchmid.C350Component)GetComponent(GameComponentsLookup.EcsSchmidC350); } }
    public bool hasEcsSchmidC350 { get { return HasComponent(GameComponentsLookup.EcsSchmidC350); } }

    public void AddEcsSchmidC350(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC350;
        var component = CreateComponent<EcsSchmid.C350Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC350(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC350;
        var component = CreateComponent<EcsSchmid.C350Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC350() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC350);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC350;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC350 {
        get {
            if (_matcherEcsSchmidC350 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC350);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC350 = matcher;
            }

            return _matcherEcsSchmidC350;
        }
    }
}