﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InterfaceTest.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;
//using Xunit;

namespace TypeScriptGenerator.Test
{
    public class InterfaceTest
    {
        //[Test]
        public void LoadType()
        {
            string assemblyFile = @"..\..\..\TypeScriptGenerator.Sample\bin\Debug\TypeScriptGenerator.Sample.dll";
            string rootClass = "TypeScriptGenerator.Sample.Task";


            var scriptInterface = Generator.CreateInterface(assemblyFile, rootClass);
            foreach (var property in scriptInterface.Properties)
            {
                Console.WriteLine(property);
            }
        }

        //[Fact]
        public void IsNullable()
        {
            string assemblyFile = @"..\..\..\TypeScriptGenerator.Sample\bin\Debug\TypeScriptGenerator.Sample.dll";
            string rootClass = "TypeScriptGenerator.Sample.Task";

            var moduleDefinition = ModuleDefinition.ReadModule(assemblyFile);
            var typeDefintion = moduleDefinition.GetType(rootClass);

            foreach (var propertyDefinition in typeDefintion.Properties)
            {
                Console.WriteLine("Name: " + propertyDefinition.Name);
                Console.WriteLine("    " + propertyDefinition.PropertyType.FullName);
                var b = propertyDefinition.PropertyType.GetUnderlyingType();
                Console.WriteLine("    " + b.FullName);
            }
        }

        //[Fact]
        public void LoadTypeInheritance()
        {
            string assemblyFile = @"..\..\..\TypeScriptGenerator.Sample\bin\Debug\TypeScriptGenerator.Sample.dll";
            string rootClass = "TypeScriptGenerator.Sample.Dog";


            var scriptInterface = Generator.CreateInterface(assemblyFile, rootClass);
            foreach (var property in scriptInterface.Properties)
            {
                Console.WriteLine(property);
            }
        }
    }
}
