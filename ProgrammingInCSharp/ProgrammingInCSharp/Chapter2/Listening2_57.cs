﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

/// <summary>
/// 
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_57
    {
        public static void Listening2_57Main()
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();

            // Create a namespace to hold the types we are going to create.
            CodeNamespace personelNamespace = new CodeNamespace("Personel");

            // Inport the System namespace.
            personelNamespace.Imports.Add(new CodeNamespaceImport("System"));

            // Create a Person class.
            CodeTypeDeclaration personClass = new CodeTypeDeclaration("Person");
            personClass.IsClass = true;
            personClass.TypeAttributes = System.Reflection.TypeAttributes.Public;

            // Add the person class to personelNamespace.
            personelNamespace.Types.Add(personClass);

            // Create a field to hold name of person.
            CodeMemberField nameField = new CodeMemberField("String", "name");
            nameField.Attributes = MemberAttributes.Private;

            // Add the name field to the Person class.
            personClass.Members.Add(nameField);

            // Add the namespace to the document.
            compileUnit.Namespaces.Add(personelNamespace);

            /*
            // 
            // Now we need to send our document somewhere
            // Create a provider to parse the document
            // 
            */
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");

            // Give the provider somewhere to send the parsed output.
            StringWriter stringWriter = new StringWriter();

            // Set some options for the parse - we can use the defaults/.
            CodeGeneratorOptions options = new CodeGeneratorOptions();

            // Generate the C# source from the CodeDOM.
            provider.GenerateCodeFromCompileUnit(compileUnit, stringWriter, options);

            // Close the output stream.
            stringWriter.Close();

            // Print the C# output.
            Console.WriteLine(stringWriter.ToString());
            Console.ReadKey();
        }
    }
}
