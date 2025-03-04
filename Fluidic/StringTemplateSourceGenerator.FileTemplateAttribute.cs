namespace Fluidic;

public sealed partial class StringTemplateSourceGenerator
{
    private const string FileTemplateAttributeSourceCode = """
        #if !FLUIDIC_EXCLUDE_ATTRIBUTES

        // <auto-generated/>
        #nullable enable

        using System;

        namespace Fluidic;

        /// <summary>
        /// Marks a method as a string template generator, this method will be implemented to write
        /// into a string builder like object, based on a provided liquid template
        /// </summary>
        [AttributeUsage(AttributeTargets.Method)]
        internal sealed class FileTemplateAttribute : Attribute
        {
            /// <summary>
            /// The relative path to the template file to use for generating the builder code
            /// </summary>
            public string? Path { get; set; }
            
            /// <summary>
            /// Initializes a new instance of the <see cref="FileTemplateAttribute"/> class
            /// </summary>
            public FileTemplateAttribute(string path)
            {
                Path = path;
            }
            
            /// <summary>
            /// Initializes a new instance of the <see cref="FileTemplateAttribute"/> class
            /// </summary>
            public FileTemplateAttribute()
            {
            }
        }
        #endif
        """;
}
