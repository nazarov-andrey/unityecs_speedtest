//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C30Component ecsShmidC30 { get { return (EcsShmid.C30Component)GetComponent(GameComponentsLookup.EcsShmidC30); } }
    public bool hasEcsShmidC30 { get { return HasComponent(GameComponentsLookup.EcsShmidC30); } }

    public void AddEcsShmidC30(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC30;
        var component = CreateComponent<EcsShmid.C30Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC30(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC30;
        var component = CreateComponent<EcsShmid.C30Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC30() {
        RemoveComponent(GameComponentsLookup.EcsShmidC30);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC30;

    public static Entitas.IMatcher<GameEntity> EcsShmidC30 {
        get {
            if (_matcherEcsShmidC30 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC30);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC30 = matcher;
            }

            return _matcherEcsShmidC30;
        }
    }
}