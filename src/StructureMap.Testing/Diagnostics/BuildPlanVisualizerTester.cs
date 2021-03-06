﻿using System.Xml;
using NUnit.Framework;
using StructureMap.Diagnostics;

namespace StructureMap.Testing.Diagnostics
{
    [TestFixture]
    public class BuildPlanVisualizerTester
    {
        [Test]
        public void create_deep()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty(), deep: true)
                .MaxLevels.ShouldEqual(int.MaxValue);
        }

        [Test]
        public void create_default_is_0_levels()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty())
                .MaxLevels.ShouldEqual(0);
        }

        [Test]
        public void create_with_explicit_levels()
        {
            new BuildPlanVisualizer(PipelineGraph.BuildEmpty(), levels:2)
                .MaxLevels.ShouldEqual(2);
        }
    }
}