#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;
    /*
        I regularly encounter this issue in VS 2015 and VS 2013. My solution is not a pretty one, but it works for me...

        Close Visual Studio
        Go to your scripts folder, delete all JavaScript files that have corresponding TypeScript files (only necessary to do this for TypeScript files that you have created for your project)
        Open Visual Studio, clean, and build
        If this doesn't work, open each TypeScript file, change one character, Save, re-build... hopefully the file will re-compile.

        If this still doesn't work, open a Node.JS command prompt, change directory to the scripts directory, run;

        tsc "yourfile.ts"
        If this doesn't work, you've got bigger problems.


        Create a file named tsconfig.json in your project root and include following lines in it:

{
    "compilerOptions": {
        "emitDecoratorMetadata": true,
        "module": "commonjs",
        "target": "ES5",
        "outDir": "ts-built",
        "rootDir": "src"
    }
}  
Please note that outDir should be the path of the directory to receive compiled JS files, and rootDir should be the path of the directory containing your source (.ts) files.

Open a terminal and run tsc -w, it'll compile any .ts file in src directory into .js and store them in ts-built directory.

shareimprove this answer

        */


    [RoutePrefix("Administration/Translation"), Route("{action=index}")]
    public class TranslationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Administration/Translation/TranslationIndex.cshtml");
        }
    }
}