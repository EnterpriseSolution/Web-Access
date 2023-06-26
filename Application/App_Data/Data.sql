UPDATE adfunc SET EXTENSION='STD:Basic:'+'' +EXTENSION
WHERE EXTENSION IS NOT NULL

Debugging a T4 Template
Step 1:
Modify the declaration to enable debugging

<#@ template language=”C#” debug=”true” hostspecific=”true” #>

Step 2:
Add the following line to launch the debugger.

System.Diagnostics.Debugger.Launch();

You can have this line anywhere in template as long as it is between the scripting braces (<#   #>).

After you have added the line, simply re-run your T4 template and you should see a Visual Studio Just-In-Time debugger window pop up asking if you want to debug the error.  Choose a new instance of VS and you should be able to debug the TT file just as you would in a normal debugging session.

After you have finished debugging and are ready to run your T4 template, don’t forget to set debug back to false, as well as remove the call to the debugger.


UPDATE dbo.ADFUNC SET  EXTENSION='STD:Administration:Translation'   WHERE FUNCTION_CODE='SALMLM'

UPDATE dbo.ADFUNC SET  EXTENSION='STD:Administration:ReportDialog'   WHERE FUNCTION_CODE='SAUTRD'


