using System;

using R5T.T0115;


namespace System
{
    public static class IProjectDescriptionGeneratorExtensions
    {
        public static string GetProjectDescription(this IProjectDescriptionGenerator _,
            string libraryDescription)
        {
            // The default description is just the library description.
            var output = libraryDescription;
            return output;
        }
    }
}