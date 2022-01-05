using System;


namespace R5T.T0115
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectDescriptionGenerator : IProjectDescriptionGenerator
    {
        #region Static
        
        public static ProjectDescriptionGenerator Instance { get; } = new();

        #endregion
    }
}