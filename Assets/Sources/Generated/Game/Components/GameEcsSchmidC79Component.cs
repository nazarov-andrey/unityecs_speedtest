//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C79Component ecsSchmidC79 { get { return (EcsSchmid.C79Component)GetComponent(GameComponentsLookup.EcsSchmidC79); } }
    public bool hasEcsSchmidC79 { get { return HasComponent(GameComponentsLookup.EcsSchmidC79); } }

    public void AddEcsSchmidC79(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC79;
        var component = CreateComponent<EcsSchmid.C79Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC79(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC79;
        var component = CreateComponent<EcsSchmid.C79Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC79() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC79);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC79;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC79 {
        get {
            if (_matcherEcsSchmidC79 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC79);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC79 = matcher;
            }

            return _matcherEcsSchmidC79;
        }
    }
}
