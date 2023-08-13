using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0141;
using R5T.T0198;


namespace R5T.S0101
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public async Task In_New_SampleProjectContext()
        {
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleProjectOperations.In_New_SampleProjectContext(
                    applicationContext.TextOutput,
                    async projectContext =>
                    {
                        await projectContext.Run(
                            Instances.ProjectContextOperations.Create_RazorClassLibrary(
                                projectDescription,
                                repositoryUrl)
                        );

                        Instances.VisualStudioOperator.Open_ProjectFile(
                            projectContext.ProjectFilePath.Value);
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }

        public async Task Create_SampleBlazorClientProject()
        {
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleProjectOperations.In_New_SampleProjectContext(
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_BlazorClient(
                        projectDescription,
                        repositoryUrl
                    ),
                    projectContext =>
                    {
                        Instances.VisualStudioOperator.Open_ProjectFile(
                            projectContext.ProjectFilePath.Value);

                        return Task.CompletedTask;
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }

        public async Task Create_SampleRazorClassLibraryProject()
        {
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleProjectOperations.In_New_SampleProjectContext(
                    applicationContext.TextOutput,
                    Instances.ProjectContextOperations.Create_RazorClassLibrary(
                        projectDescription,
                        repositoryUrl
                    ),
                    projectContext =>
                    {
                        Instances.VisualStudioOperator.Open_ProjectFile(
                            projectContext.ProjectFilePath.Value);

                        return Task.CompletedTask;
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }
    }
}
