//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C43Component ecsShmidC43 { get { return (EcsShmid.C43Component)GetComponent(GameComponentsLookup.EcsShmidC43); } }
    public bool hasEcsShmidC43 { get { return HasComponent(GameComponentsLookup.EcsShmidC43); } }

    public void AddEcsShmidC43(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC43;
        var component = CreateComponent<EcsShmid.C43Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC43(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC43;
        var component = CreateComponent<EcsShmid.C43Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC43() {
        RemoveComponent(GameComponentsLookup.EcsShmidC43);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC43;

    public static Entitas.IMatcher<GameEntity> EcsShmidC43 {
        get {
            if (_matcherEcsShmidC43 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC43);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC43 = matcher;
            }

            return _matcherEcsShmidC43;
        }
    }
}