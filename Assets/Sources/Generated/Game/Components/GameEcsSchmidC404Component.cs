//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C404Component ecsSchmidC404 { get { return (EcsSchmid.C404Component)GetComponent(GameComponentsLookup.EcsSchmidC404); } }
    public bool hasEcsSchmidC404 { get { return HasComponent(GameComponentsLookup.EcsSchmidC404); } }

    public void AddEcsSchmidC404(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC404;
        var component = CreateComponent<EcsSchmid.C404Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC404(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC404;
        var component = CreateComponent<EcsSchmid.C404Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC404() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC404);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC404;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC404 {
        get {
            if (_matcherEcsSchmidC404 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC404);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC404 = matcher;
            }

            return _matcherEcsSchmidC404;
        }
    }
}