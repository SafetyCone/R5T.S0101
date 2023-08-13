using System;


namespace R5T.S0101
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static O0011.IProjectContextOperations ProjectContextOperations => O0011.ProjectContextOperations.Instance;
        public static O0011.O001.ISampleProjectOperations SampleProjectOperations => O0011.O001.SampleProjectOperations.Instance;
        public static IValues Values => S0101.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
    }
}