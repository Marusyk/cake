﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Common.Build;
using Cake.Common.Build.AppVeyor;
using Cake.Common.Build.Bamboo;
using Cake.Common.Build.BitbucketPipelines;
using Cake.Common.Build.Bitrise;
using Cake.Common.Build.ContinuaCI;
using Cake.Common.Build.GitHubActions;
using Cake.Common.Build.GitLabCI;
using Cake.Common.Build.GoCD;
using Cake.Common.Build.Jenkins;
using Cake.Common.Build.MyGet;
using Cake.Common.Build.TeamCity;
using Cake.Common.Build.TFBuild;
using Cake.Common.Build.TravisCI;
using Cake.Common.Tests.Fixtures.Build;
using NSubstitute;
using Xunit;

namespace Cake.Common.Tests.Unit.Build
{
    public sealed class BuildSystemTests
    {
        public sealed class TheConstructor
        {
            [Fact]
            public void Should_Throw_If_AppVeyor_Is_Null()
            {
                // Given
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(null, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "appVeyorProvider");
            }

            [Fact]
            public void Should_Throw_If_TeamCity_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, null, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "teamCityProvider");
            }

            [Fact]
            public void Should_Throw_If_MyGet_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, null, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "myGetProvider");
            }

            [Fact]
            public void Should_Throw_If_Bamboo_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, null, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "bambooProvider");
            }

            [Fact]
            public void Should_Throw_If_ContinuaCI_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, null, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "continuaCIProvider");
            }

            [Fact]
            public void Should_Throw_If_Jenkins_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, null, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "jenkinsProvider");
            }

            [Fact]
            public void Should_Throw_If_Bitrise_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, null, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "bitriseProvider");
            }

            [Fact]
            public void Should_Throw_If_TravisCI_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, null, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "travisCIProvider");
            }

            [Fact]
            public void Should_Throw_If_BitbucketPipelines_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, null, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "bitbucketPipelinesProvider");
            }

            [Fact]
            public void Should_Throw_If_GoCD_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, null, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "goCDProvider");
            }

            [Fact]
            public void Should_Throw_If_GitLabCI_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, null, tfBuildProvider, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "gitLabCIProvider");
            }

            [Fact]
            public void Should_Throw_If_TFBuild_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, null, gitHubActionsProvider));

                // Then
                AssertEx.IsArgumentNullException(result, "tfBuildProvider");
            }

            [Fact]
            public void Should_Throw_If_GitHubActions_Is_Null()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();

                // When
                var result = Record.Exception(() => new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, null));

                // Then
                AssertEx.IsArgumentNullException(result, "gitHubActionsProvider");
            }
        }

        public sealed class TheIsRunningOnAppVeyorProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_AppVeyor()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var appVeyorEnvironment = new AppVeyorInfoFixture().CreateEnvironmentInfo();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                appVeyorProvider.IsRunningOnAppVeyor.Returns(true);
                appVeyorProvider.Environment.Returns(appVeyorEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnAppVeyor);
            }
        }

        public sealed class TheIsRunningOnTeamCityProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_TeamCity()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var teamCityEnvironment = new TeamCityInfoFixture().CreateEnvironmentInfo();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                teamCityProvider.IsRunningOnTeamCity.Returns(true);
                teamCityProvider.Environment.Returns(teamCityEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnTeamCity);
            }
        }

        public sealed class TheIsRunningOnMyGetProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_MyGet()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                myGetProvider.IsRunningOnMyGet.Returns(true);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnMyGet);
            }
        }

        public sealed class TheIsRunningOnBambooProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_Bamboo()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                bambooProvider.IsRunningOnBamboo.Returns(true);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnBamboo);
            }
        }

        public sealed class TheIsRunningOnContinuaCIProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_ContinuaCI()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                continuaCIProvider.IsRunningOnContinuaCI.Returns(true);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnContinuaCI);
            }
        }

        public sealed class TheIsRunningOnJenkinsProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_Jenkins()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                jenkinsProvider.IsRunningOnJenkins.Returns(true);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnJenkins);
            }
        }

        public sealed class TheIsRunningOnBitriseProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_Bitrise()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var bitriseEnvironment = new BitriseInfoFixture().CreateEnvironmentInfo();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                bitriseProvider.IsRunningOnBitrise.Returns(true);
                bitriseProvider.Environment.Returns(bitriseEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnBitrise);
            }
        }

        public sealed class TheIsRunningOnTravisCIProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_TravisCI()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var travisCIEnvironment = new TravisCIInfoFixture().CreateEnvironmentInfo();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                travisCIProvider.IsRunningOnTravisCI.Returns(true);
                travisCIProvider.Environment.Returns(travisCIEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnTravisCI);
            }
        }

        public sealed class TheIsRunningOnBitbucketPipelinesProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_BitbucketPipelines()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var bitbucketPipelinesEnvironment = new BitbucketPipelinesInfoFixture().CreateEnvironmentInfo();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                bitbucketPipelinesProvider.IsRunningOnBitbucketPipelines.Returns(true);
                bitbucketPipelinesProvider.Environment.Returns(bitbucketPipelinesEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnBitbucketPipelines);
            }
        }

        public sealed class TheIsRunningOnGoCDProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_GoCD()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                goCDProvider.IsRunningOnGoCD.Returns(true);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnGoCD);
            }
        }

        public sealed class TheIsRunningOnGitLabCIProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_GitLabCI()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var gitLabCIEnvironment = new GitLabCIInfoFixture().CreateEnvironmentInfo();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                gitLabCIProvider.IsRunningOnGitLabCI.Returns(true);
                gitLabCIProvider.Environment.Returns(gitLabCIEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnGitLabCI);
            }
        }

        public sealed class TheIsRunningOnTFSProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_TFS()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

#pragma warning disable 618
                tfBuildProvider.IsRunningOnTFS.Returns(true);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnTFS);
#pragma warning restore 618
            }
        }

        public sealed class TheIsRunningOnVSTSProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_VSTS()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

#pragma warning disable 618
                tfBuildProvider.IsRunningOnVSTS.Returns(true);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnVSTS);
#pragma warning restore 618
            }
        }

        public sealed class TheIsRunningOnAzurePipelinesProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_AzurePipelines()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                tfBuildProvider.IsRunningOnAzurePipelines.Returns(true);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnAzurePipelines);
            }
        }

        public sealed class TheIsRunningOnAzurePipelinesHostedProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_AzurePipelinesHosted()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();

                tfBuildProvider.IsRunningOnAzurePipelinesHosted.Returns(true);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnAzurePipelinesHosted);
            }
        }

        public sealed class TheIsRunningOnGitHubActionsProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_GitHubActions()
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();
                var gitHubActionsEnvironment = new GitHubActionsInfoFixture().CreateEnvironmentInfo();

                gitHubActionsProvider.IsRunningOnGitHubActions.Returns(true);
                gitHubActionsProvider.Environment.Returns(gitHubActionsEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.True(buildSystem.IsRunningOnGitHubActions);
            }
        }

        public sealed class TheProviderProperty
        {
            [Theory]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.Local)]
            [InlineData(true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.AppVeyor)]
            [InlineData(false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.TeamCity)]
            [InlineData(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.MyGet)]
            [InlineData(false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.Bamboo)]
            [InlineData(false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, BuildProvider.ContinuaCI)]
            [InlineData(false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, BuildProvider.Jenkins)]
            [InlineData(false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, BuildProvider.Bitrise)]
            [InlineData(false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, BuildProvider.TravisCI)]
            [InlineData(false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, BuildProvider.BitbucketPipelines)]
            [InlineData(false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, BuildProvider.GoCD)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, BuildProvider.GitLabCI)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, BuildProvider.AzurePipelines)] // tfs
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, BuildProvider.AzurePipelinesHosted)] // vsts
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, BuildProvider.AzurePipelines)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, false, BuildProvider.AzurePipelinesHosted)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, BuildProvider.GitHubActions)]
            public void Should_Return_Provider_If_Running_On_Provider(bool appVeyor, bool teamCity, bool myGet, bool bamboo, bool continuaCI, bool jenkins, bool bitrise, bool travisCI, bool bitbucketPipelines, bool goCD, bool gitLabCI, bool tfs, bool vsts, bool azurePipelines, bool azurePipelinesHosted, bool gitHubActions, BuildProvider provider)
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var appVeyorEnvironment = new AppVeyorInfoFixture().CreateEnvironmentInfo();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var teamCityEnvironment = new TeamCityInfoFixture().CreateEnvironmentInfo();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var bitriseEnvironment = new BitriseInfoFixture().CreateEnvironmentInfo();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var travisCIEnvironment = new TravisCIInfoFixture().CreateEnvironmentInfo();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var bitbucketPipelinesEnvironment = new BitbucketPipelinesInfoFixture().CreateEnvironmentInfo();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var gitLabCIEnvironment = new GitLabCIInfoFixture().CreateEnvironmentInfo();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();
                var gitHubActionsEnvironment = new GitHubActionsInfoFixture().CreateEnvironmentInfo();

                appVeyorProvider.IsRunningOnAppVeyor.Returns(appVeyor);
                appVeyorProvider.Environment.Returns(appVeyorEnvironment);
                teamCityProvider.IsRunningOnTeamCity.Returns(teamCity);
                teamCityProvider.Environment.Returns(teamCityEnvironment);
                myGetProvider.IsRunningOnMyGet.Returns(myGet);
                bambooProvider.IsRunningOnBamboo.Returns(bamboo);
                continuaCIProvider.IsRunningOnContinuaCI.Returns(continuaCI);
                jenkinsProvider.IsRunningOnJenkins.Returns(jenkins);
                bitriseProvider.IsRunningOnBitrise.Returns(bitrise);
                bitriseProvider.Environment.Returns(bitriseEnvironment);
                travisCIProvider.IsRunningOnTravisCI.Returns(travisCI);
                travisCIProvider.Environment.Returns(travisCIEnvironment);
                bitbucketPipelinesProvider.IsRunningOnBitbucketPipelines.Returns(bitbucketPipelines);
                bitbucketPipelinesProvider.Environment.Returns(bitbucketPipelinesEnvironment);
                goCDProvider.IsRunningOnGoCD.Returns(goCD);
                gitLabCIProvider.IsRunningOnGitLabCI.Returns(gitLabCI);
                gitLabCIProvider.Environment.Returns(gitLabCIEnvironment);
#pragma warning disable 618
                tfBuildProvider.IsRunningOnTFS.Returns(tfs);
                tfBuildProvider.IsRunningOnVSTS.Returns(vsts);
#pragma warning restore 618
                tfBuildProvider.IsRunningOnAzurePipelines.Returns(azurePipelines);
                tfBuildProvider.IsRunningOnAzurePipelinesHosted.Returns(azurePipelinesHosted);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);
                gitHubActionsProvider.IsRunningOnGitHubActions.Returns(gitHubActions);
                gitHubActionsProvider.Environment.Returns(gitHubActionsEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.Equal(provider, buildSystem.Provider);
            }
        }

        public sealed class TheIsLocalBuildProperty
        {
            [Theory]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true)]
            [InlineData(true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, false)] // tfs
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false)] // vsts
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false)]
            public void Should_Return_False_If_Running_On_Provider(bool appVeyor, bool teamCity, bool myGet, bool bamboo, bool continuaCI, bool jenkins, bool bitrise, bool travisCI, bool bitbucketPipelines, bool goCD, bool gitLabCI, bool tfs, bool vsts, bool azurePipelines, bool azurePipelinesHosted, bool gitHubActions, bool isLocalBuild)
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var appVeyorEnvironment = new AppVeyorInfoFixture().CreateEnvironmentInfo();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var teamCityEnvironment = new TeamCityInfoFixture().CreateEnvironmentInfo();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var bitriseEnvironment = new BitriseInfoFixture().CreateEnvironmentInfo();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var travisCIEnvironment = new TravisCIInfoFixture().CreateEnvironmentInfo();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var bitbucketPipelinesEnvironment = new BitbucketPipelinesInfoFixture().CreateEnvironmentInfo();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var gitLabCIEnvironment = new GitLabCIInfoFixture().CreateEnvironmentInfo();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();
                var gitHubActionsEnvironment = new GitHubActionsInfoFixture().CreateEnvironmentInfo();

                appVeyorProvider.IsRunningOnAppVeyor.Returns(appVeyor);
                appVeyorProvider.Environment.Returns(appVeyorEnvironment);
                teamCityProvider.IsRunningOnTeamCity.Returns(teamCity);
                teamCityProvider.Environment.Returns(teamCityEnvironment);
                myGetProvider.IsRunningOnMyGet.Returns(myGet);
                bambooProvider.IsRunningOnBamboo.Returns(bamboo);
                continuaCIProvider.IsRunningOnContinuaCI.Returns(continuaCI);
                jenkinsProvider.IsRunningOnJenkins.Returns(jenkins);
                bitriseProvider.IsRunningOnBitrise.Returns(bitrise);
                bitriseProvider.Environment.Returns(bitriseEnvironment);
                travisCIProvider.IsRunningOnTravisCI.Returns(travisCI);
                travisCIProvider.Environment.Returns(travisCIEnvironment);
                bitbucketPipelinesProvider.IsRunningOnBitbucketPipelines.Returns(bitbucketPipelines);
                bitbucketPipelinesProvider.Environment.Returns(bitbucketPipelinesEnvironment);
                goCDProvider.IsRunningOnGoCD.Returns(goCD);
                gitLabCIProvider.IsRunningOnGitLabCI.Returns(gitLabCI);
                gitLabCIProvider.Environment.Returns(gitLabCIEnvironment);
#pragma warning disable 618
                tfBuildProvider.IsRunningOnTFS.Returns(tfs);
                tfBuildProvider.IsRunningOnVSTS.Returns(vsts);
#pragma warning restore 618
                tfBuildProvider.IsRunningOnAzurePipelines.Returns(azurePipelines);
                tfBuildProvider.IsRunningOnAzurePipelinesHosted.Returns(azurePipelinesHosted);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);
                gitHubActionsProvider.IsRunningOnGitHubActions.Returns(gitHubActions);
                gitHubActionsProvider.Environment.Returns(gitHubActionsEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.Equal(isLocalBuild, buildSystem.IsLocalBuild);
            }
        }

        public sealed class TheIsPullRequestProperty
        {
            [Theory]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true)]
            [InlineData(false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true)]
            [InlineData(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true)]
            [InlineData(false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true)]
            [InlineData(false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true)]
            [InlineData(false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, true)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, true)] // tfs
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, true)] // vsts
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, false, true)]
            [InlineData(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true)]
            public void Should_Return_True_If_Running_On_Supported_Provider(bool appVeyor, bool teamCity, bool myGet, bool bamboo, bool continuaCI, bool jenkins, bool bitrise, bool travisCI, bool bitbucketPipelines, bool goCD, bool gitLabCI, bool tfs, bool vsts, bool azurePipelines, bool azurePipelinesHosted, bool gitHubActions, bool isPullRequest)
            {
                // Given
                var appVeyorProvider = Substitute.For<IAppVeyorProvider>();
                var appVeyorEnvironment = new AppVeyorInfoFixture().CreateEnvironmentInfo();
                var teamCityProvider = Substitute.For<ITeamCityProvider>();
                var teamCityEnvironment = new TeamCityInfoFixture().CreateEnvironmentInfo();
                var myGetProvider = Substitute.For<IMyGetProvider>();
                var bambooProvider = Substitute.For<IBambooProvider>();
                var continuaCIProvider = Substitute.For<IContinuaCIProvider>();
                var jenkinsProvider = Substitute.For<IJenkinsProvider>();
                var bitriseProvider = Substitute.For<IBitriseProvider>();
                var bitriseEnvironment = new BitriseInfoFixture().CreateEnvironmentInfo();
                var travisCIProvider = Substitute.For<ITravisCIProvider>();
                var travisCIEnvironment = new TravisCIInfoFixture().CreateEnvironmentInfo();
                var bitbucketPipelinesProvider = Substitute.For<IBitbucketPipelinesProvider>();
                var bitbucketPipelinesEnvironment = new BitbucketPipelinesInfoFixture().CreateEnvironmentInfo();
                var goCDProvider = Substitute.For<IGoCDProvider>();
                var gitLabCIProvider = Substitute.For<IGitLabCIProvider>();
                var gitLabCIEnvironment = new GitLabCIInfoFixture().CreateEnvironmentInfo();
                var tfBuildProvider = Substitute.For<ITFBuildProvider>();
                var tfBuildEnvironment = new TFBuildInfoFixture().CreateEnvironmentInfo();
                var gitHubActionsProvider = Substitute.For<IGitHubActionsProvider>();
                var gitHubActionsEnvironment = new GitHubActionsInfoFixture().CreateEnvironmentInfo();

                appVeyorProvider.IsRunningOnAppVeyor.Returns(appVeyor);
                appVeyorProvider.Environment.Returns(appVeyorEnvironment);
                teamCityProvider.IsRunningOnTeamCity.Returns(teamCity);
                teamCityProvider.Environment.Returns(teamCityEnvironment);
                myGetProvider.IsRunningOnMyGet.Returns(myGet);
                bambooProvider.IsRunningOnBamboo.Returns(bamboo);
                continuaCIProvider.IsRunningOnContinuaCI.Returns(continuaCI);
                jenkinsProvider.IsRunningOnJenkins.Returns(jenkins);
                bitriseProvider.IsRunningOnBitrise.Returns(bitrise);
                bitriseProvider.Environment.Returns(bitriseEnvironment);
                travisCIProvider.IsRunningOnTravisCI.Returns(travisCI);
                travisCIProvider.Environment.Returns(travisCIEnvironment);
                bitbucketPipelinesProvider.IsRunningOnBitbucketPipelines.Returns(bitbucketPipelines);
                bitbucketPipelinesProvider.Environment.Returns(bitbucketPipelinesEnvironment);
                goCDProvider.IsRunningOnGoCD.Returns(goCD);
                gitLabCIProvider.IsRunningOnGitLabCI.Returns(gitLabCI);
                gitLabCIProvider.Environment.Returns(gitLabCIEnvironment);
#pragma warning disable 618
                tfBuildProvider.IsRunningOnTFS.Returns(tfs);
                tfBuildProvider.IsRunningOnVSTS.Returns(vsts);
#pragma warning restore 618
                tfBuildProvider.IsRunningOnAzurePipelines.Returns(azurePipelines);
                tfBuildProvider.IsRunningOnAzurePipelinesHosted.Returns(azurePipelinesHosted);
                tfBuildProvider.Environment.Returns(tfBuildEnvironment);
                gitHubActionsProvider.IsRunningOnGitHubActions.Returns(gitHubActions);
                gitHubActionsProvider.Environment.Returns(gitHubActionsEnvironment);

                // When
                var buildSystem = new BuildSystem(appVeyorProvider, teamCityProvider, myGetProvider, bambooProvider, continuaCIProvider, jenkinsProvider, bitriseProvider, travisCIProvider, bitbucketPipelinesProvider, goCDProvider, gitLabCIProvider, tfBuildProvider, gitHubActionsProvider);

                // Then
                Assert.Equal(isPullRequest, buildSystem.IsPullRequest);
            }
        }
    }
}