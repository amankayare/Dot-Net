using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAndSharedAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
 - Steps To Make Shared Assembly

    ** Install the assembly into the GAC (Global Assembly Cache)
    ** Not all assembly are allowed to install on GAC
    ** To Put assembly in GAC , give the assembly "strong name"-> used in cryptography  so that we can uniquely identify the assembly
    ** To give the strong name ,sign the assembly with "Key Pair"
    ** Generate a key pair
    
          i) Generate a key pair 
                > sn -k file1.snk
            ii) Sign the assembly with "Key Pair"
                   Assembly properties -> signning  -> check the sighnin the assembly -> browse our key value file
            iii)To give the strong name
                   Build your assembly -> building will assign a strong name
            iv) Install the assembly into the GAC
                
                 * our assembly is present in AssemblyName/bin/Debug/----.Dll
                 * go to the debug folder and run the below command
                
                    > gacutil /i Asm1.Dll   -> to install
                
                 * if you want to unistall then use below command

                    > gacutil /u Asm1   -> to uninstall from GAC



   - Before .Net version 4 All inbuild Shared and custom shared assembly of GAC is stored at: -> c:\windows\assembly
   - .Net version 4 onwards All inbuild Shared and custom shared assembly of GAC is stored at: -> c:\windows\Microsoft.Net\assembly\gac_msil


todo -> remove local copy , created by vs  from vs UI



*/
