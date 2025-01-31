using Godot;
using GodotSharp.BuildingBlocks.TestRunner;
using GodotTests.TestScenes;
using GodotTests.TestScenes.SeparateScriptNamespace;

namespace GodotTests
{
    [SceneTree]
    public abstract partial class Run : Control
    {
        private static IEnumerable<Func<ITest>> Tests
        {
            get
            {
                yield return ITest.GetTest<AmbiguousTypeWithImplicitUsings>;
                yield return ITest.GetTest<CachedNodes>;
                yield return ITest.GetTest<EditableChildrenTest>;
                yield return ITest.GetTest<EditableChildrenWithTraversalTest>;
                yield return ITest.GetTest<EmptyScene>;
                yield return ITest.GetTest<EmptySceneWithNoNamespace>;
                yield return ITest.GetTest<GenericRootTest>;
                yield return ITest.GetTest<GodotNotifyTests>;
                yield return ITest.GetTest<GodotOverrideInheritanceTest>;
                yield return ITest.GetTest<GodotOverrideTest>;
                yield return ITest.GetTest<InheritedScene>;
                yield return ITest.GetTest<InheritedSceneWithBaseChanges1>;
                yield return ITest.GetTest<InheritedSceneWithBaseChanges2>;
                yield return ITest.GetTest<InheritedSceneWithInstancedScene>;
                yield return ITest.GetTest<InheritingSceneWithoutScript>;
                yield return ITest.GetTest<InstancedScene>;
                yield return ITest.GetTest<InstancedSceneFromDifferentNamespace>;
                yield return ITest.GetTest<InstancingSceneWithoutScript>;
                yield return ITest.GetTest<LoadAsPlaceholderTest>;
                yield return ITest.GetTest<RootScene>;
                yield return ITest.GetTest<RootSceneWithNoNamespace>;
                yield return ITest.GetTest<SameNameTest>;
                yield return ITest.GetTest<ScriptForSceneWithDifferentName>;
                yield return ITest.GetTest<ScriptForSceneWithDifferentPath>;
                yield return ITest.GetTest<TraverseInstancedScene>;
                yield return ITest.GetTest<UniqueSceneNameAccessTest>;
            }
        }

        [GodotOverride]
        public void OnReady()
            => _.TestRunner.Initialise(Tests);
    }
}
