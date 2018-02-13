//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C13Component ecsShmidC13 { get { return (EcsShmid.C13Component)GetComponent(GameComponentsLookup.EcsShmidC13); } }
    public bool hasEcsShmidC13 { get { return HasComponent(GameComponentsLookup.EcsShmidC13); } }

    public void AddEcsShmidC13(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC13;
        var component = CreateComponent<EcsShmid.C13Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC13(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC13;
        var component = CreateComponent<EcsShmid.C13Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC13() {
        RemoveComponent(GameComponentsLookup.EcsShmidC13);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC13;

    public static Entitas.IMatcher<GameEntity> EcsShmidC13 {
        get {
            if (_matcherEcsShmidC13 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC13);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC13 = matcher;
            }

            return _matcherEcsShmidC13;
        }
    }
}